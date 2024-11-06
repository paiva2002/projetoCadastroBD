using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastroBD
{
    public partial class Form1 : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
            "uid=root;" + "pwd=kjhg456bta;" + "database=academico";
        public Form1()
        {
            InitializeComponent();
        }
        private void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";
            if (isAlteracao)
            {
                sql = "UPDATE aluno SET " +
                    " (mstricula = @mstricula, " +
                    " dt_nascimento = @dt_nascimento, " +
                    " nome = @nome, " +
                    " endereco = @endereco, " +
                    " bairro = @bairro, " +
                    "cidade = @cidade, " +
                    " estado = @estado, " +
                    " senha = @senha " +
                    " WHERE id = @id";
            }
            else
            {
                sql = " INSERT INTO aluno " +
                " (mstricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@mstricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mstricula", txtMatricula.Text);
            DateTime.TryParse(txtDataNascimento.Text, out DateTime dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", txtCidade.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
        }
    }
}
