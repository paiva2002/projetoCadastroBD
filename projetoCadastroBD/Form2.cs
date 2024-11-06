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
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal formAluno = new FormPrincipal();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formCurso = new Form1();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
