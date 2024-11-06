using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
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
                sql = "UPDATE curso SET " +
                    " (codigo_curso = @codigo_curso, " +
                    " nome_curso = @nome_curso, " +
                    " nivel_curso = @nivel_curso, " +
                    " duracao_semestre = @duracao_semestre, " +
                    " periodo_curso = @periodo_curso, " +
                    "area_curso = @area_curso, " +
                    " WHERE id = @id";
            }
            else
            {
                sql = " INSERT INTO aluno " +
                " (codigo_curso, nome_curso, nivel_curso, duracao_semestre, " +
                " periodo_curso, area_curso) " +
                " VALUES " +
                " (@codigo_curso, @nome_curso, @nivel_curso, @duracao_semestre, " +
                " @periodo_curso, @area_curso) ";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo_curso", txtCodigoCurso.Text);
            cmd.Parameters.AddWithValue("@nome_curso", txtNomeCurso);
            cmd.Parameters.AddWithValue("@nivel_curso", txtNivelCurso.Text);
            cmd.Parameters.AddWithValue("@duracao_semestre", txtDuracaoSemestre.Text);
            cmd.Parameters.AddWithValue("@periodo_curso", txtPeriodoCurso.Text);
            cmd.Parameters.AddWithValue("@area_curso", txtAreaCurso.Text);
        }
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodigoCurso.Text))
            {
                MessageBox.Show("codigo do curso obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoCurso.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtNomeCurso.Text, out DateTime date))
            {
                MessageBox.Show("Nome do curso obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNivelCurso.Text))
            {
                MessageBox.Show("nivel do curso obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNivelCurso.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDuracaoSemestre.Text))
            {
                MessageBox.Show("Duracao semestre obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuracaoSemestre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPeriodoCurso.Text))
            {
                MessageBox.Show("periodo do curso obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPeriodoCurso.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAreaCurso.Text))
            {
                MessageBox.Show("area do curso obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAreaCurso.Focus();
                return false;
            }

            return true;
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastroCurso.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void txtButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabPageCadastroCurso.SelectedIndex = 1;
            }
        }
        private void carregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }
        private void dataGridViewCurso_Enter(object sender, EventArgs e)
        {
            carregaGrid();
        }
        private void Editar()
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewCurso.SelectedRows[0];
                //txtId.Text = linha.Cells["id"].Value.ToString();
                txtCodigoCurso.Text = linha.Cells["codigo_curso"].Value.ToString();
                txtNomeCurso.Text = linha.Cells["nome_curso"].Value.ToString();
                txtNivelCurso.Text = linha.Cells["nivel_curso"].Value.ToString();
                txtDuracaoSemestre.Text = linha.Cells["duracao_semestre"].Value.ToString();
                txtPeriodoCurso.Text = linha.Cells["periodo_curso"].Value.ToString();
                txtAreaCurso.Text = linha.Cells["area_curso"].Value.ToString();
                tabPageCadastroCurso.SelectedIndex = 0;//conferir
                txtCodigoCurso.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void txtButtonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void dataGridViewCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM aluno WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txtButtonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewCurso.SelectedRows[0].Cells["id"].Value;
                    Excluir(id);
                    carregaGrid();
                }
            }
            else
            {
                MessageBox.Show("selecione algum curso!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atençao: informações não salvas serão perdidasa", "IFSP", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabPageCadastroCurso.SelectedIndex = 1;
            }
        }
    }
}
