namespace projetoCadastroBD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroAlunoToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            cursoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroAlunoToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            cadastroAlunoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, cursoToolStripMenuItem });
            cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            cadastroAlunoToolStripMenuItem.Size = new Size(66, 20);
            cadastroAlunoToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(106, 22);
            alunoToolStripMenuItem.Text = "Aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // cursoToolStripMenuItem
            // 
            cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            cursoToolStripMenuItem.Size = new Size(106, 22);
            cursoToolStripMenuItem.Text = "Curso";
            cursoToolStripMenuItem.Click += cursoToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFSP - Sistema de Gerenciamneto Academico Com Banco";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form2_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem cursoToolStripMenuItem;
    }
}