public static class Session
{
    public static int KullaniciID { get; set; }
    public static int RolID { get; set; }
    public static string KullaniciAdi { get; set; } = string.Empty;

    public static void Clear()
    {
        KullaniciID = 0;
        RolID = 0;
        KullaniciAdi = string.Empty;
    }
}
