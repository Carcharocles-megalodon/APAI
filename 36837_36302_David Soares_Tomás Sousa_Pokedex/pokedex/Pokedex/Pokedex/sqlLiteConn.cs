using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Pokedex
{
    class sqlLiteConn
    {
        public static void RunIDbType(string name, string type1, string type2)
        {
            using (IDbConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = "Data Source=PokedexDb.db;";
                conn.Open();
                IDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Pokemon(nome,type,type2) VALUES(" + name + " ," + type1 + " ," + type2 + ");";
                cmd.ExecuteNonQuery();
            }
    }
        public static void SelectDb(int nro, string nome)
        {
            using (IDbConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = "Data Source=PokedexDb.db;";
                conn.Open();
                IDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * from Pokemon WHERE id like " + nro + " or nome like " + nome;
                cmd.ExecuteNonQuery();
                IDbCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "SELECT * from Stats WHERE pokemon_id like " + nro;
                cmd2.ExecuteNonQuery();
            }
        }
    }
}
