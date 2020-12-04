using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteThomasGreg.Model;

namespace TesteThomasGreg.Persistence
{
    class Persist
    {

        public  void CreateTable(SQLiteConnection conn)
        {
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(id INTEGER PRIMARY KEY AUTOINCREMENT" +
                        ", DATA_VOO DATETIME, CUSTO NUMERIC(10,2), DISTANCIA INTEGER, CAPTURA CHARACTER(1), NIVEL_DOR INTEGER)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  DataTable GetVoos(SQLiteConnection conn)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id AS ID, DATA_VOO AS DATA, CAPTURA AS CAPTURA, NIVEL_DOR AS 'NIVEL DOR' FROM TB_VOO";
                    da = new SQLiteDataAdapter(cmd.CommandText, conn);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public  DataTable GetById(string id, SQLiteConnection conn)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id , DATA_VOO , CUSTO , DISTANCIA , CAPTURA , NIVEL_DOR FROM TB_VOO Where Id = " + id;

                    da = new SQLiteDataAdapter(cmd.CommandText, conn);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public  void Add(Voo voo, SQLiteConnection conn)
        {
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TB_VOO(DATA_VOO , CUSTO , DISTANCIA , CAPTURA , NIVEL_DOR ) " +
                        "values (@DATA_VOO, @CUSTO, @DISTANCIA , @CAPTURA, @NIVEL_DOR)";

                    cmd.Parameters.AddWithValue("@NIVEL_DOR", voo.NIVEL_DOR);
                    cmd.Parameters.AddWithValue("@CAPTURA", voo.CAPTURA);
                    cmd.Parameters.AddWithValue("@CUSTO", voo.CUSTO);
                    cmd.Parameters.AddWithValue("@DATA_VOO", voo.DATA_VOO);
                    cmd.Parameters.AddWithValue("@DISTANCIA", voo.DISTANCIA);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public  void Update(Voo voo, SQLiteConnection conn)
        {
            try
            {
                using (var cmd = new SQLiteCommand(conn))
                {
                    if (voo.Id != null)
                    {
                        cmd.CommandText = "UPDATE TB_VOO SET NIVEL_DOR=@NIVEL_DOR, CAPTURA=@CAPTURA , CUSTO=@CUSTO, DATA_VOO=@DATA_VOO" +
                            ", DISTANCIA=@DISTANCIA WHERE Id=@Id";

                        cmd.Parameters.AddWithValue("@NIVEL_DOR", voo.NIVEL_DOR);
                        cmd.Parameters.AddWithValue("@CAPTURA", voo.CAPTURA);
                        cmd.Parameters.AddWithValue("@CUSTO", voo.CUSTO);
                        cmd.Parameters.AddWithValue("@DATA_VOO", voo.DATA_VOO);
                        cmd.Parameters.AddWithValue("@DISTANCIA", voo.DISTANCIA);
                        cmd.Parameters.AddWithValue("@Id", voo.Id);

                        cmd.ExecuteNonQuery();
                    }
                };
        }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public  void Delete(string Id, SQLiteConnection conn)
        {
            try
            {
                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM TB_VOO Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
