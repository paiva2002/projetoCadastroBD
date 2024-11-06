namespace projetoCadastroBD
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPageCadastroCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            txtButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            txtButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            txtPeriodoCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNivelCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAreaCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDuracaoSemestre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodigoCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            dataGridViewCurso = new DataGridView();
            txtButtonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            txtButtonEditar = new ReaLTaiizor.Controls.MaterialButton();
            txtButtonNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabPageCadastroCurso.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastroCurso
            // 
            tabPageCadastroCurso.Controls.Add(tabPage1);
            tabPageCadastroCurso.Controls.Add(tabPage2);
            tabPageCadastroCurso.Depth = 0;
            tabPageCadastroCurso.ImageList = imageList1;
            tabPageCadastroCurso.Location = new Point(6, 80);
            tabPageCadastroCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabPageCadastroCurso.Multiline = true;
            tabPageCadastroCurso.Name = "tabPageCadastroCurso";
            tabPageCadastroCurso.SelectedIndex = 0;
            tabPageCadastroCurso.Size = new Size(778, 337);
            tabPageCadastroCurso.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtButtonCancelar);
            tabPage1.Controls.Add(txtButtonSalvar);
            tabPage1.Controls.Add(txtPeriodoCurso);
            tabPage1.Controls.Add(txtNivelCurso);
            tabPage1.Controls.Add(txtNomeCurso);
            tabPage1.Controls.Add(txtAreaCurso);
            tabPage1.Controls.Add(txtDuracaoSemestre);
            tabPage1.Controls.Add(txtCodigoCurso);
            tabPage1.ImageKey = "register.png";
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(770, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtButtonCancelar
            // 
            txtButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtButtonCancelar.Depth = 0;
            txtButtonCancelar.HighEmphasis = true;
            txtButtonCancelar.Icon = null;
            txtButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtButtonCancelar.Location = new Point(640, 288);
            txtButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            txtButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtButtonCancelar.Name = "txtButtonCancelar";
            txtButtonCancelar.NoAccentTextColor = Color.Empty;
            txtButtonCancelar.Size = new Size(96, 36);
            txtButtonCancelar.TabIndex = 7;
            txtButtonCancelar.Text = "Cancelar";
            txtButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtButtonCancelar.UseAccentColor = false;
            txtButtonCancelar.UseVisualStyleBackColor = true;
            txtButtonCancelar.Click += txtButtonCancelar_Click;
            // 
            // txtButtonSalvar
            // 
            txtButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtButtonSalvar.Depth = 0;
            txtButtonSalvar.HighEmphasis = true;
            txtButtonSalvar.Icon = null;
            txtButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtButtonSalvar.Location = new Point(660, 225);
            txtButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            txtButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtButtonSalvar.Name = "txtButtonSalvar";
            txtButtonSalvar.NoAccentTextColor = Color.Empty;
            txtButtonSalvar.Size = new Size(76, 36);
            txtButtonSalvar.TabIndex = 6;
            txtButtonSalvar.Text = "Salvar";
            txtButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtButtonSalvar.UseAccentColor = false;
            txtButtonSalvar.UseVisualStyleBackColor = true;
            txtButtonSalvar.Click += txtButtonSalvar_Click;
            // 
            // txtPeriodoCurso
            // 
            txtPeriodoCurso.AnimateReadOnly = false;
            txtPeriodoCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtPeriodoCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtPeriodoCurso.BackgroundImageLayout = ImageLayout.None;
            txtPeriodoCurso.CharacterCasing = CharacterCasing.Normal;
            txtPeriodoCurso.Depth = 0;
            txtPeriodoCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeriodoCurso.HideSelection = true;
            txtPeriodoCurso.Hint = "Periodo do curso";
            txtPeriodoCurso.LeadingIcon = null;
            txtPeriodoCurso.Location = new Point(6, 222);
            txtPeriodoCurso.MaxLength = 32767;
            txtPeriodoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeriodoCurso.Name = "txtPeriodoCurso";
            txtPeriodoCurso.PasswordChar = '\0';
            txtPeriodoCurso.PrefixSuffixText = null;
            txtPeriodoCurso.ReadOnly = false;
            txtPeriodoCurso.RightToLeft = RightToLeft.No;
            txtPeriodoCurso.SelectedText = "";
            txtPeriodoCurso.SelectionLength = 0;
            txtPeriodoCurso.SelectionStart = 0;
            txtPeriodoCurso.ShortcutsEnabled = true;
            txtPeriodoCurso.Size = new Size(647, 48);
            txtPeriodoCurso.TabIndex = 5;
            txtPeriodoCurso.TabStop = false;
            txtPeriodoCurso.TextAlign = HorizontalAlignment.Left;
            txtPeriodoCurso.TrailingIcon = null;
            txtPeriodoCurso.UseSystemPasswordChar = false;
            // 
            // txtNivelCurso
            // 
            txtNivelCurso.AnimateReadOnly = false;
            txtNivelCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNivelCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNivelCurso.BackgroundImageLayout = ImageLayout.None;
            txtNivelCurso.CharacterCasing = CharacterCasing.Normal;
            txtNivelCurso.Depth = 0;
            txtNivelCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNivelCurso.HideSelection = true;
            txtNivelCurso.Hint = "Nivel do curso";
            txtNivelCurso.LeadingIcon = null;
            txtNivelCurso.Location = new Point(3, 114);
            txtNivelCurso.MaxLength = 32767;
            txtNivelCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNivelCurso.Name = "txtNivelCurso";
            txtNivelCurso.PasswordChar = '\0';
            txtNivelCurso.PrefixSuffixText = null;
            txtNivelCurso.ReadOnly = false;
            txtNivelCurso.RightToLeft = RightToLeft.No;
            txtNivelCurso.SelectedText = "";
            txtNivelCurso.SelectionLength = 0;
            txtNivelCurso.SelectionStart = 0;
            txtNivelCurso.ShortcutsEnabled = true;
            txtNivelCurso.Size = new Size(761, 48);
            txtNivelCurso.TabIndex = 4;
            txtNivelCurso.TabStop = false;
            txtNivelCurso.TextAlign = HorizontalAlignment.Left;
            txtNivelCurso.TrailingIcon = null;
            txtNivelCurso.UseSystemPasswordChar = false;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.AnimateReadOnly = false;
            txtNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCurso.BackgroundImageLayout = ImageLayout.None;
            txtNomeCurso.CharacterCasing = CharacterCasing.Normal;
            txtNomeCurso.Depth = 0;
            txtNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCurso.HideSelection = true;
            txtNomeCurso.Hint = "Nome do curso";
            txtNomeCurso.LeadingIcon = null;
            txtNomeCurso.Location = new Point(6, 60);
            txtNomeCurso.MaxLength = 32767;
            txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.PasswordChar = '\0';
            txtNomeCurso.PrefixSuffixText = null;
            txtNomeCurso.ReadOnly = false;
            txtNomeCurso.RightToLeft = RightToLeft.No;
            txtNomeCurso.SelectedText = "";
            txtNomeCurso.SelectionLength = 0;
            txtNomeCurso.SelectionStart = 0;
            txtNomeCurso.ShortcutsEnabled = true;
            txtNomeCurso.Size = new Size(758, 48);
            txtNomeCurso.TabIndex = 3;
            txtNomeCurso.TabStop = false;
            txtNomeCurso.TextAlign = HorizontalAlignment.Left;
            txtNomeCurso.TrailingIcon = null;
            txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // txtAreaCurso
            // 
            txtAreaCurso.AnimateReadOnly = false;
            txtAreaCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtAreaCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtAreaCurso.BackgroundImageLayout = ImageLayout.None;
            txtAreaCurso.CharacterCasing = CharacterCasing.Normal;
            txtAreaCurso.Depth = 0;
            txtAreaCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAreaCurso.HideSelection = true;
            txtAreaCurso.Hint = "Área do curso";
            txtAreaCurso.LeadingIcon = null;
            txtAreaCurso.Location = new Point(6, 276);
            txtAreaCurso.MaxLength = 32767;
            txtAreaCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAreaCurso.Name = "txtAreaCurso";
            txtAreaCurso.PasswordChar = '\0';
            txtAreaCurso.PrefixSuffixText = null;
            txtAreaCurso.ReadOnly = false;
            txtAreaCurso.RightToLeft = RightToLeft.No;
            txtAreaCurso.SelectedText = "";
            txtAreaCurso.SelectionLength = 0;
            txtAreaCurso.SelectionStart = 0;
            txtAreaCurso.ShortcutsEnabled = true;
            txtAreaCurso.Size = new Size(615, 48);
            txtAreaCurso.TabIndex = 2;
            txtAreaCurso.TabStop = false;
            txtAreaCurso.TextAlign = HorizontalAlignment.Left;
            txtAreaCurso.TrailingIcon = null;
            txtAreaCurso.UseSystemPasswordChar = false;
            // 
            // txtDuracaoSemestre
            // 
            txtDuracaoSemestre.AnimateReadOnly = false;
            txtDuracaoSemestre.AutoCompleteMode = AutoCompleteMode.None;
            txtDuracaoSemestre.AutoCompleteSource = AutoCompleteSource.None;
            txtDuracaoSemestre.BackgroundImageLayout = ImageLayout.None;
            txtDuracaoSemestre.CharacterCasing = CharacterCasing.Normal;
            txtDuracaoSemestre.Depth = 0;
            txtDuracaoSemestre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracaoSemestre.HideSelection = true;
            txtDuracaoSemestre.Hint = "Duração do semestre";
            txtDuracaoSemestre.LeadingIcon = null;
            txtDuracaoSemestre.Location = new Point(3, 168);
            txtDuracaoSemestre.MaxLength = 32767;
            txtDuracaoSemestre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracaoSemestre.Name = "txtDuracaoSemestre";
            txtDuracaoSemestre.PasswordChar = '\0';
            txtDuracaoSemestre.PrefixSuffixText = null;
            txtDuracaoSemestre.ReadOnly = false;
            txtDuracaoSemestre.RightToLeft = RightToLeft.No;
            txtDuracaoSemestre.SelectedText = "";
            txtDuracaoSemestre.SelectionLength = 0;
            txtDuracaoSemestre.SelectionStart = 0;
            txtDuracaoSemestre.ShortcutsEnabled = true;
            txtDuracaoSemestre.Size = new Size(761, 48);
            txtDuracaoSemestre.TabIndex = 1;
            txtDuracaoSemestre.TabStop = false;
            txtDuracaoSemestre.TextAlign = HorizontalAlignment.Left;
            txtDuracaoSemestre.TrailingIcon = null;
            txtDuracaoSemestre.UseSystemPasswordChar = false;
            // 
            // txtCodigoCurso
            // 
            txtCodigoCurso.AnimateReadOnly = false;
            txtCodigoCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigoCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigoCurso.BackgroundImageLayout = ImageLayout.None;
            txtCodigoCurso.CharacterCasing = CharacterCasing.Normal;
            txtCodigoCurso.Depth = 0;
            txtCodigoCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoCurso.HideSelection = true;
            txtCodigoCurso.Hint = "Código do curso";
            txtCodigoCurso.LeadingIcon = null;
            txtCodigoCurso.Location = new Point(6, 6);
            txtCodigoCurso.MaxLength = 32767;
            txtCodigoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigoCurso.Name = "txtCodigoCurso";
            txtCodigoCurso.PasswordChar = '\0';
            txtCodigoCurso.PrefixSuffixText = null;
            txtCodigoCurso.ReadOnly = false;
            txtCodigoCurso.RightToLeft = RightToLeft.No;
            txtCodigoCurso.SelectedText = "";
            txtCodigoCurso.SelectionLength = 0;
            txtCodigoCurso.SelectionStart = 0;
            txtCodigoCurso.ShortcutsEnabled = true;
            txtCodigoCurso.Size = new Size(758, 48);
            txtCodigoCurso.TabIndex = 0;
            txtCodigoCurso.TabStop = false;
            txtCodigoCurso.TextAlign = HorizontalAlignment.Left;
            txtCodigoCurso.TrailingIcon = null;
            txtCodigoCurso.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewCurso);
            tabPage2.Controls.Add(txtButtonExcluir);
            tabPage2.Controls.Add(txtButtonEditar);
            tabPage2.Controls.Add(txtButtonNovo);
            tabPage2.ImageKey = "file.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(770, 309);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCurso
            // 
            dataGridViewCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurso.Location = new Point(6, 6);
            dataGridViewCurso.Name = "dataGridViewCurso";
            dataGridViewCurso.Size = new Size(758, 238);
            dataGridViewCurso.TabIndex = 4;
            dataGridViewCurso.CellDoubleClick += dataGridViewCurso_CellDoubleClick;
            // 
            // txtButtonExcluir
            // 
            txtButtonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtButtonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtButtonExcluir.Depth = 0;
            txtButtonExcluir.HighEmphasis = true;
            txtButtonExcluir.Icon = null;
            txtButtonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtButtonExcluir.Location = new Point(520, 253);
            txtButtonExcluir.Margin = new Padding(4, 6, 4, 6);
            txtButtonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtButtonExcluir.Name = "txtButtonExcluir";
            txtButtonExcluir.NoAccentTextColor = Color.Empty;
            txtButtonExcluir.Size = new Size(80, 36);
            txtButtonExcluir.TabIndex = 3;
            txtButtonExcluir.Text = "Excluir";
            txtButtonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtButtonExcluir.UseAccentColor = false;
            txtButtonExcluir.UseVisualStyleBackColor = true;
            txtButtonExcluir.Click += txtButtonExcluir_Click;
            // 
            // txtButtonEditar
            // 
            txtButtonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtButtonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtButtonEditar.Depth = 0;
            txtButtonEditar.HighEmphasis = true;
            txtButtonEditar.Icon = null;
            txtButtonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtButtonEditar.Location = new Point(296, 253);
            txtButtonEditar.Margin = new Padding(4, 6, 4, 6);
            txtButtonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtButtonEditar.Name = "txtButtonEditar";
            txtButtonEditar.NoAccentTextColor = Color.Empty;
            txtButtonEditar.Size = new Size(71, 36);
            txtButtonEditar.TabIndex = 2;
            txtButtonEditar.Text = "Editar";
            txtButtonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtButtonEditar.UseAccentColor = false;
            txtButtonEditar.UseVisualStyleBackColor = true;
            txtButtonEditar.Click += txtButtonEditar_Click;
            // 
            // txtButtonNovo
            // 
            txtButtonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtButtonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtButtonNovo.Depth = 0;
            txtButtonNovo.HighEmphasis = true;
            txtButtonNovo.Icon = null;
            txtButtonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtButtonNovo.Location = new Point(34, 253);
            txtButtonNovo.Margin = new Padding(4, 6, 4, 6);
            txtButtonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtButtonNovo.Name = "txtButtonNovo";
            txtButtonNovo.NoAccentTextColor = Color.Empty;
            txtButtonNovo.Size = new Size(64, 36);
            txtButtonNovo.TabIndex = 1;
            txtButtonNovo.Text = "Novo";
            txtButtonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtButtonNovo.UseAccentColor = false;
            txtButtonNovo.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(1, "logo.png");
            imageList1.Images.SetKeyName(2, "register.png");
            imageList1.Images.SetKeyName(3, "file.png");
            imageList1.Images.SetKeyName(4, "search.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabPageCadastroCurso);
            Name = "Form1";
            Text = "Cadastro de Curso";
            tabPageCadastroCurso.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabPageCadastroCurso;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigoCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracaoSemestre;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeriodoCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNivelCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAreaCurso;
        private ReaLTaiizor.Controls.MaterialButton txtButtonCancelar;
        private ReaLTaiizor.Controls.MaterialButton txtButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton txtButtonExcluir;
        private ReaLTaiizor.Controls.MaterialButton txtButtonEditar;
        private ReaLTaiizor.Controls.MaterialButton txtButtonNovo;
        private DataGridView dataGridViewCurso;
    }
}