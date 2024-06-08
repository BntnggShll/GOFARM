using GoFarm.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFarm.DAL
{
    public class SapiDAL
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public List<SapiModels> GetAll()
        {
            List<SapiModels> lstSapi = new List<SapiModels>();
            using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
            {
                string strSql = @"select * from sapi order by nama_sapi asc";
                MySqlCommand cmd = new MySqlCommand(strSql, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lstSapi.Add(new SapiModels
                            {
                                Id_Sapi = dr["id_sapi"].ToString(),
                                Nama_Sapi = dr["nama_sapi"].ToString(),
                                Warna = dr["warna"].ToString(),
                                Keturunan = dr["keturunan"].ToString(),
                                Kandang = dr["kandang"].ToString(),
                                Berat_Lahir = Convert.ToDecimal(dr["berat_lahir"]),
                                Umur = Convert.ToInt32(dr["umur"]),
                                Tanggal_Lahir = Convert.ToDateTime(dr["tanggal_lahir"])
                            });
                        }
                    }
                    dr.Close();
                    return lstSapi;
                }
                catch (MySqlException sqlEx)
                {
                    throw new Exception($"Kesalahan: {sqlEx.Message}");
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }

            }
        }

        public int Insert(SapiModels sapi)
        {
            int hasil = 0;
            using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
            {
                string strSql = @"insert into sapi(id_sapi,nama_sapi,warna,keturunan,kandang,berat_lahir,umur,tanggal_lahir)
                values(@id_sapi,@nama_sapi,@warna,@keturunan,@kandang,@berat_lahir,@umur,@tanggal_lahir)";
                MySqlCommand cmd = new MySqlCommand(strSql, conn);
                cmd.Parameters.AddWithValue("@id_sapi", sapi.Id_Sapi);
                cmd.Parameters.AddWithValue("@nama_sapi", sapi.Nama_Sapi);
                cmd.Parameters.AddWithValue("@warna", sapi.Warna);
                cmd.Parameters.AddWithValue("@keturunan", sapi.Keturunan);
                cmd.Parameters.AddWithValue("@kandang", sapi.Kandang);
                cmd.Parameters.AddWithValue("@berat_lahir", sapi.Berat_Lahir);
                cmd.Parameters.AddWithValue("@umur", sapi.Umur);
                cmd.Parameters.AddWithValue("@tanggal_lahir", sapi.Tanggal_Lahir);
                try
                {
                    conn.Open();
                    hasil = cmd.ExecuteNonQuery();
                    if (hasil != 1)
                        throw new Exception("Gagal menambahkan data");

                    return hasil;
                }
                catch (MySqlException sqlEx)
                {
                    throw new Exception($"Kesalahan: {sqlEx.Message}");
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        public int Update(SapiModels sapi)
        {
            int hasil = 0;
            using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
            {
                string strSql = @"update sapi set nama_sapi=@nama_sapi,warna=@warna,
                keturunan=@keturunan,kandang=@kandang,berat_lahir=@berat_lahir,umur=@umur,
                tanggal_lahir=@tanggal_lahir where id_sapi=@id_sapi";
                MySqlCommand cmd = new MySqlCommand(strSql, conn);
                cmd.Parameters.AddWithValue("@nama_sapi", sapi.Nama_Sapi);
                cmd.Parameters.AddWithValue("@warna", sapi.Warna);
                cmd.Parameters.AddWithValue("@keturunan", sapi.Keturunan);
                cmd.Parameters.AddWithValue("@kandang", sapi.Kandang);
                cmd.Parameters.AddWithValue("@berat_lahir", sapi.Berat_Lahir);
                cmd.Parameters.AddWithValue("@umur", sapi.Umur);
                cmd.Parameters.AddWithValue("@tanggal_lahir", sapi.Tanggal_Lahir);
                try
                {
                    conn.Open();
                    hasil = cmd.ExecuteNonQuery();
                    if (hasil != 1)
                        throw new Exception("Gagal menambahkan data");

                    return hasil;
                }
                catch (MySqlException sqlEx)
                {
                    throw new Exception($"Kesalahan: {sqlEx.Message}");
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }

            }
        }

        public int Delete(string idSapi)
{
    int hasil = 0;
    using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
    {
        string strSql = @"delete from sapi where id_sapi=@id_sapi";
        MySqlCommand cmd = new MySqlCommand(strSql, conn);
        cmd.Parameters.AddWithValue("@id_sapi", idSapi);
        try
        {
            conn.Open();
            hasil = cmd.ExecuteNonQuery();
            if (hasil != 1)
                throw new Exception("Gagal menghapus data");

            return hasil;
        }
        catch (MySqlException sqlEx)
        {
            throw new Exception($"Kesalahan: {sqlEx.Message}");
        }
        finally
        {
            cmd.Dispose();
            conn.Close();
        }
    }
}

    }
}
