-- DB
CREATE DATABASE IF NOT EXISTS KutuphaneVTYS
  CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci;
USE KutuphaneVTYS;

-- Temizle (varsa)
SET FOREIGN_KEY_CHECKS=0;
DROP TABLE IF EXISTS LOG_ISLEM;
DROP TABLE IF EXISTS CEZA;
DROP TABLE IF EXISTS ODUNC;
DROP TABLE IF EXISTS KITAP;
DROP TABLE IF EXISTS KATEGORI;
DROP TABLE IF EXISTS UYE;
DROP TABLE IF EXISTS KULLANICI;
DROP TABLE IF EXISTS ROL;
SET FOREIGN_KEY_CHECKS=1;

-- Tablolar
CREATE TABLE ROL (
  RolID INT AUTO_INCREMENT PRIMARY KEY,
  RolAdi VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB;

CREATE TABLE KULLANICI (
  KullaniciID INT AUTO_INCREMENT PRIMARY KEY,
  KullaniciAdi VARCHAR(50) NOT NULL UNIQUE,
  SifreHash VARCHAR(256) NOT NULL,
  RolID INT NOT NULL,
  AktifMi TINYINT(1) NOT NULL DEFAULT 1,
  OlusturmaZamani DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT FK_KULLANICI_ROL FOREIGN KEY (RolID) REFERENCES ROL(RolID)
) ENGINE=InnoDB;

CREATE TABLE UYE (
  UyeID INT AUTO_INCREMENT PRIMARY KEY,
  Ad VARCHAR(60) NOT NULL,
  Soyad VARCHAR(60) NOT NULL,
  Telefon VARCHAR(30) NOT NULL,
  Email VARCHAR(120) NOT NULL UNIQUE,
  ToplamBorc DECIMAL(12,2) NOT NULL DEFAULT 0,
  KayitTarihi DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

CREATE TABLE KATEGORI (
  KategoriID INT AUTO_INCREMENT PRIMARY KEY,
  KategoriAdi VARCHAR(80) NOT NULL UNIQUE
) ENGINE=InnoDB;

CREATE TABLE KITAP (
  KitapID INT AUTO_INCREMENT PRIMARY KEY,
  KitapAdi VARCHAR(200) NOT NULL,
  Yazar VARCHAR(150) NOT NULL,
  KategoriID INT NOT NULL,
  Yayinevi VARCHAR(150) NOT NULL,
  BasimYili INT NOT NULL,
  ToplamAdet INT NOT NULL,
  MevcutAdet INT NOT NULL,
  EklenmeZamani DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT FK_KITAP_KATEGORI FOREIGN KEY (KategoriID) REFERENCES KATEGORI(KategoriID),
  CONSTRAINT UK_KITAP UNIQUE (KitapAdi, Yazar, Yayinevi, BasimYili)
) ENGINE=InnoDB;

CREATE TABLE ODUNC (
  OduncID INT AUTO_INCREMENT PRIMARY KEY,
  UyeID INT NOT NULL,
  KitapID INT NOT NULL,
  IslemYapanKullaniciID INT NOT NULL,
  OduncTarihi DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  SonTeslimTarihi DATE NOT NULL,
  TeslimTarihi DATETIME NULL,
  CONSTRAINT FK_ODUNC_UYE FOREIGN KEY (UyeID) REFERENCES UYE(UyeID),
  CONSTRAINT FK_ODUNC_KITAP FOREIGN KEY (KitapID) REFERENCES KITAP(KitapID),
  CONSTRAINT FK_ODUNC_KULLANICI FOREIGN KEY (IslemYapanKullaniciID) REFERENCES KULLANICI(KullaniciID)
) ENGINE=InnoDB;

CREATE TABLE CEZA (
  CezaID INT AUTO_INCREMENT PRIMARY KEY,
  OduncID INT NOT NULL,
  UyeID INT NOT NULL,
  Tutar DECIMAL(12,2) NOT NULL,
  CezaTarihi DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  Aciklama VARCHAR(250) NULL,
  IslemYapanKullaniciID INT NULL,
  CONSTRAINT FK_CEZA_ODUNC FOREIGN KEY (OduncID) REFERENCES ODUNC(OduncID),
  CONSTRAINT FK_CEZA_UYE FOREIGN KEY (UyeID) REFERENCES UYE(UyeID),
  CONSTRAINT FK_CEZA_KULLANICI FOREIGN KEY (IslemYapanKullaniciID) REFERENCES KULLANICI(KullaniciID)
) ENGINE=InnoDB;

CREATE TABLE LOG_ISLEM (
  LogID BIGINT AUTO_INCREMENT PRIMARY KEY,
  TabloAdi VARCHAR(50) NOT NULL,
  IslemTipi VARCHAR(20) NOT NULL,
  IslemZamani DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  Aciklama VARCHAR(400) NULL,
  KullaniciID INT NULL,
  IlgiliID INT NULL
) ENGINE=InnoDB;

-- Index
CREATE INDEX IX_ODUNC_Uye_Aktif ON ODUNC (UyeID, TeslimTarihi);
CREATE INDEX IX_ODUNC_Geciken ON ODUNC (SonTeslimTarihi, TeslimTarihi);
CREATE INDEX IX_CEZA_Uye_Tarih ON CEZA (UyeID, CezaTarihi);
CREATE INDEX IX_KITAP_Kategori ON KITAP (KategoriID);
CREATE INDEX IX_KITAP_KitapAdi ON KITAP (KitapAdi);
CREATE INDEX IX_KITAP_Yazar ON KITAP (Yazar);

-- Seed
INSERT INTO ROL (RolAdi) VALUES ('Admin'), ('Gorevli');
INSERT INTO KULLANICI (KullaniciAdi, SifreHash, RolID) VALUES
('admin','admin123',1), ('gorevli','1234',2);

INSERT INTO KATEGORI (KategoriAdi) VALUES ('Roman'), ('Bilim'), ('Tarih');

INSERT INTO KITAP (KitapAdi, Yazar, KategoriID, Yayinevi, BasimYili, ToplamAdet, MevcutAdet)
VALUES
('Suc ve Ceza','Dostoyevski',1,'X Yayinlari',2019,3,3),
('Kisa Tarih','Hawking',2,'Y Yayinlari',2015,2,2);

INSERT INTO UYE (Ad, Soyad, Telefon, Email)
VALUES ('Ali','Yilmaz','5551112233','ali@uni.edu'),
       ('Ayse','Kaya','5559998877','ayse@uni.edu');

-- =========================
--  STORED PROCEDURE + TRIGGER
-- =========================
DELIMITER $$

DROP PROCEDURE IF EXISTS sp_YeniOduncVer $$
CREATE PROCEDURE sp_YeniOduncVer(
  IN pUyeID INT,
  IN pKitapID INT,
  IN pIslemYapanKullaniciID INT,
  IN pOduncLimit INT
)
BEGIN
  DECLARE vAktif INT DEFAULT 0;
  DECLARE vMevcut INT DEFAULT 0;
  DECLARE vOduncTarihi DATETIME;
  DECLARE vSonTeslim DATE;

  DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    ROLLBACK;
    RESIGNAL;
  END;

  START TRANSACTION;

  SELECT COUNT(*) INTO vAktif
  FROM ODUNC
  WHERE UyeID = pUyeID AND TeslimTarihi IS NULL
  FOR UPDATE;

  IF vAktif >= pOduncLimit THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Odunc limiti asildi';
  END IF;

  SELECT MevcutAdet INTO vMevcut
  FROM KITAP
  WHERE KitapID = pKitapID
  FOR UPDATE;

  IF vMevcut IS NULL THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Kitap bulunamadi';
  END IF;

  IF vMevcut <= 0 THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Stok yok';
  END IF;

  SET vOduncTarihi = NOW();
  SET vSonTeslim = DATE_ADD(DATE(vOduncTarihi), INTERVAL 15 DAY);

  INSERT INTO ODUNC (UyeID, KitapID, IslemYapanKullaniciID, OduncTarihi, SonTeslimTarihi, TeslimTarihi)
  VALUES (pUyeID, pKitapID, pIslemYapanKullaniciID, vOduncTarihi, vSonTeslim, NULL);

  COMMIT;
END $$

DROP PROCEDURE IF EXISTS sp_KitapTeslimAl $$
CREATE PROCEDURE sp_KitapTeslimAl(
  IN pOduncID INT,
  IN pTeslimTarihi DATETIME
)
BEGIN
  DECLARE vUyeID INT;
  DECLARE vKitapID INT;
  DECLARE vSonTeslim DATE;
  DECLARE vEskiTeslim DATETIME;
  DECLARE vIslemYapan INT;

  DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    ROLLBACK;
    RESIGNAL;
  END;

  START TRANSACTION;

  SELECT UyeID, KitapID, SonTeslimTarihi, TeslimTarihi, IslemYapanKullaniciID
    INTO vUyeID, vKitapID, vSonTeslim, vEskiTeslim, vIslemYapan
  FROM ODUNC
  WHERE OduncID = pOduncID
  FOR UPDATE;

  IF vUyeID IS NULL THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Odunc kaydi bulunamadi';
  END IF;

  IF vEskiTeslim IS NOT NULL THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Bu odunc zaten teslim edilmis';
  END IF;

  UPDATE ODUNC
  SET TeslimTarihi = pTeslimTarihi
  WHERE OduncID = pOduncID;

  IF DATE(pTeslimTarihi) > vSonTeslim THEN
    -- gun basi 5 TL
    INSERT INTO CEZA (OduncID, UyeID, Tutar, Aciklama, IslemYapanKullaniciID)
    VALUES (pOduncID, vUyeID, DATEDIFF(DATE(pTeslimTarihi), vSonTeslim) * 5.00,
            CONCAT(DATEDIFF(DATE(pTeslimTarihi), vSonTeslim), ' gun gecikme'),
            vIslemYapan);
  END IF;

  COMMIT;
END $$

DROP PROCEDURE IF EXISTS sp_UyeOzetRapor $$
CREATE PROCEDURE sp_UyeOzetRapor(IN pUyeID INT)
BEGIN
  SELECT
    u.UyeID, u.Ad, u.Soyad, u.Email, u.ToplamBorc,
    (SELECT COUNT(*) FROM ODUNC o WHERE o.UyeID=u.UyeID) AS ToplamAldigiKitap,
    (SELECT COUNT(*) FROM ODUNC o WHERE o.UyeID=u.UyeID AND o.TeslimTarihi IS NULL) AS AktifOduncSayisi,
    (SELECT IFNULL(SUM(c.Tutar),0) FROM CEZA c WHERE c.UyeID=u.UyeID) AS ToplamCezaTutari
  FROM UYE u
  WHERE u.UyeID = pUyeID;
END $$

-- Trigger: ODUNC insert -> stok azalt + log
DROP TRIGGER IF EXISTS TR_ODUNC_INSERT $$
CREATE TRIGGER TR_ODUNC_INSERT
AFTER INSERT ON ODUNC
FOR EACH ROW
BEGIN
  UPDATE KITAP
  SET MevcutAdet = MevcutAdet - 1
  WHERE KitapID = NEW.KitapID;

  IF (SELECT MevcutAdet FROM KITAP WHERE KitapID = NEW.KitapID) < 0 THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Stok yetersiz (negatif olamaz)';
  END IF;

  INSERT INTO LOG_ISLEM(TabloAdi, IslemTipi, Aciklama, KullaniciID, IlgiliID)
  VALUES ('ODUNC','INSERT', CONCAT('ODUNC eklendi. UyeID=',NEW.UyeID,', KitapID=',NEW.KitapID),
          NEW.IslemYapanKullaniciID, NEW.OduncID);
END $$

-- Trigger: ODUNC update (teslim) -> stok artir + log
DROP TRIGGER IF EXISTS TR_ODUNC_UPDATE_TESLIM $$
CREATE TRIGGER TR_ODUNC_UPDATE_TESLIM
AFTER UPDATE ON ODUNC
FOR EACH ROW
BEGIN
  IF OLD.TeslimTarihi IS NULL AND NEW.TeslimTarihi IS NOT NULL THEN
    UPDATE KITAP
    SET MevcutAdet = MevcutAdet + 1
    WHERE KitapID = NEW.KitapID;

    INSERT INTO LOG_ISLEM(TabloAdi, IslemTipi, Aciklama, KullaniciID, IlgiliID)
    VALUES ('ODUNC','UPDATE', CONCAT('Teslim alindi. KitapID=',NEW.KitapID),
            NEW.IslemYapanKullaniciID, NEW.OduncID);
  END IF;
END $$

-- Trigger: CEZA insert -> borc ekle + log
DROP TRIGGER IF EXISTS TR_CEZA_INSERT $$
CREATE TRIGGER TR_CEZA_INSERT
AFTER INSERT ON CEZA
FOR EACH ROW
BEGIN
  UPDATE UYE
  SET ToplamBorc = ToplamBorc + NEW.Tutar
  WHERE UyeID = NEW.UyeID;

  INSERT INTO LOG_ISLEM(TabloAdi, IslemTipi, Aciklama, KullaniciID, IlgiliID)
  VALUES ('CEZA','INSERT', CONCAT('Ceza eklendi. UyeID=',NEW.UyeID,', Tutar=',NEW.Tutar),
          NEW.IslemYapanKullaniciID, NEW.CezaID);
END $$

-- Trigger: UYE delete engelle (aktif odunc veya borc varsa)
DROP TRIGGER IF EXISTS TR_UYE_DELETE_BLOCK $$
CREATE TRIGGER TR_UYE_DELETE_BLOCK
BEFORE DELETE ON UYE
FOR EACH ROW
BEGIN
  IF OLD.ToplamBorc > 0 OR EXISTS(SELECT 1 FROM ODUNC o WHERE o.UyeID=OLD.UyeID AND o.TeslimTarihi IS NULL) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Uye silinemez: aktif odunc veya borc var';
  END IF;
END $$

DELIMITER ;
