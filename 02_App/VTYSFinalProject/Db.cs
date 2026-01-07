using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using MySqlConnector;

public static class Db
{
    private static readonly string CS =
        ConfigurationManager.ConnectionStrings["KutuphaneDb"]?.ConnectionString
        ?? throw new InvalidOperationException("App.config içinde 'KutuphaneDb' connection string bulunamadı.");

    public static async Task<DataTable> QueryAsync(string sql, params (string name, object value)[] p)
    {
        if (string.IsNullOrWhiteSpace(sql))
            throw new ArgumentException("SQL boş olamaz.", nameof(sql));

        await using var con = new MySqlConnection(CS);
        await con.OpenAsync();

        await using var cmd = new MySqlCommand(sql, con)
        {
            CommandType = CommandType.Text
        };

        foreach (var (name, value) in p)
            cmd.Parameters.AddWithValue(name, value ?? DBNull.Value);

        await using var reader = await cmd.ExecuteReaderAsync();
        var dt = new DataTable();
        dt.Load(reader);
        return dt;
    }

    public static async Task<int> ExecAsync(string sql, params (string name, object value)[] p)
    {
        if (string.IsNullOrWhiteSpace(sql))
            throw new ArgumentException("SQL boş olamaz.", nameof(sql));

        await using var con = new MySqlConnection(CS);
        await con.OpenAsync();

        await using var cmd = new MySqlCommand(sql, con)
        {
            CommandType = CommandType.Text
        };

        foreach (var (name, value) in p)
            cmd.Parameters.AddWithValue(name, value ?? DBNull.Value);

        return await cmd.ExecuteNonQueryAsync();
    }

    public static async Task<object?> ScalarAsync(string sql, params (string name, object value)[] p)
    {
        if (string.IsNullOrWhiteSpace(sql))
            throw new ArgumentException("SQL boş olamaz.", nameof(sql));

        await using var con = new MySqlConnection(CS);
        await con.OpenAsync();

        await using var cmd = new MySqlCommand(sql, con)
        {
            CommandType = CommandType.Text
        };

        foreach (var (name, value) in p)
            cmd.Parameters.AddWithValue(name, value ?? DBNull.Value);

        return await cmd.ExecuteScalarAsync();
    }

    public static async Task<(bool ok, int kullaniciId, int rolId)> LoginAsync(string kullaniciAdi, string sifre)
    {
        var dt = await QueryAsync(@"
            SELECT KullaniciID, RolID
            FROM kullanici
            WHERE KullaniciAdi = @u AND SifreHash = @p AND AktifMi = 1
            LIMIT 1;",
            ("@u", kullaniciAdi),
            ("@p", sifre));

        if (dt.Rows.Count == 0) return (false, 0, 0);

        int kid = Convert.ToInt32(dt.Rows[0]["KullaniciID"]);
        int rid = Convert.ToInt32(dt.Rows[0]["RolID"]);
        return (true, kid, rid);
    }
}
