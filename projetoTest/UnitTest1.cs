using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace projetoTest
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
               "uid=root;" + "pwd=kjhg456bta;" +
               "database=academico";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnect()
        {
            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void TestInsert()
        {
            string sql = " INSERT INTO aluno " +
                " (mstricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@mstricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";
            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@mstricula", "BI3008371");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2002, 10, 13));
            cmd.Parameters.AddWithValue("@nome", "lucas paiva");
            cmd.Parameters.AddWithValue("@endereco", "rua afonso pena 928");
            cmd.Parameters.AddWithValue("@bairro", "centro");
            cmd.Parameters.AddWithValue("@cidade", "Buritama");
            cmd.Parameters.AddWithValue("@estado", "sp");
            cmd.Parameters.AddWithValue("@senha", "12345678");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestSelect()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * from aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.Write(dr["mstricula"] + " ");
                Debug.Write(dr["nome"] + " ");
                Debug.Write(dr["dt_nascimento"] + " ");
                Debug.Write(dr["endereco"] + " ");
                Debug.Write(dr["bairro"] + " ");
                Debug.Write(dr["cidade"] + " ");
                Debug.Write(dr["estado"] + " ");
                Debug.Write(dr["senha"] + " ");
                Debug.WriteLine(" ");

            }
            con.Close();
        }
    }
}