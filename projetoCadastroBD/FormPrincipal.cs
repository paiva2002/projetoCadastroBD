using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace projetoCadastroBD
{
    public partial class FormPrincipal : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
            "uid=root;" + "pwd=kjhg456bta;" + "database=academico";
        public FormPrincipal()
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
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("matricula obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime date))
            {
                MessageBox.Show("Data obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("nome obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("endereço obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("bairro obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("cidade obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("senha obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboEstado.Text))
            {
                MessageBox.Show("estado obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstado.Focus();
                return false;
            }

            return true;
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
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
            dataGridViewAluno.DataSource = dt;
            con.Close();
        }

        private void dataGridViewAluno_Enter(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void Editar()
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewAluno.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["mstricula"].Value.ToString();
                txtDataNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                cboEstado.Text = linha.Cells["estado"].Value.ToString();
                txtSenha.Text = linha.Cells["senha"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;//conferir
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnExlcuir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewAluno.SelectedRows[0].Cells["id"].Value;
                    Excluir(id);
                    carregaGrid();
                }
            }
            else
            {
                MessageBox.Show("selecione algum aluno!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Atençao: informações não salvas serão perdidasa", "IFSP",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl1.SelectedIndex = 1;
            }
        }
    }
}
