namespace projetoCadastroBD
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            imageList1 = new ImageList(components);
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnExlcuir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewAluno = new DataGridView();
            materialTabControl1.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAluno).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pesquisa-de-dados.png");
            imageList1.Images.SetKeyName(1, "c-sharp.png");
            imageList1.Images.SetKeyName(2, "pesquisa-de-dados.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPageCadastro);
            materialTabControl1.Controls.Add(tabPageConsulta);
            materialTabControl1.Depth = 0;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(6, 67);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(718, 363);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(txtDataNascimento);
            tabPageCadastro.Controls.Add(cboEstado);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "c-sharp.png";
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(710, 335);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(202, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(164, 48);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(550, 276);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(466, 276);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AllowPromptAsInput = true;
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AsciiOnly = false;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.BeepOnError = false;
            txtDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HidePromptOnLeave = false;
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.Hint = "Data de Nascimento";
            txtDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(396, 6);
            txtDataNascimento.Mask = "99/99/9999";
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.PromptChar = '_';
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RejectInputOnFirstFailure = false;
            txtDataNascimento.ResetOnPrompt = true;
            txtDataNascimento.ResetOnSpace = true;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(250, 48);
            txtDataNascimento.SkipLiterals = true;
            txtDataNascimento.TabIndex = 7;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.Text = "  /  /";
            txtDataNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            txtDataNascimento.ValidatingType = null;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "SP" });
            cboEstado.Location = new Point(396, 167);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(250, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(6, 276);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '\0';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(441, 48);
            txtSenha.TabIndex = 5;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(6, 222);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(640, 48);
            txtCidade.TabIndex = 4;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(6, 168);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(374, 48);
            txtBairro.TabIndex = 3;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(6, 114);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(640, 48);
            txtEndereco.TabIndex = 2;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 60);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(640, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matricula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(6, 6);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(190, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnExlcuir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(dataGridViewAluno);
            tabPageConsulta.ImageKey = "pesquisa-de-dados.png";
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(710, 335);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(216, 279);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExlcuir
            // 
            btnExlcuir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExlcuir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExlcuir.Depth = 0;
            btnExlcuir.HighEmphasis = true;
            btnExlcuir.Icon = null;
            btnExlcuir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExlcuir.Location = new Point(477, 279);
            btnExlcuir.Margin = new Padding(4, 6, 4, 6);
            btnExlcuir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExlcuir.Name = "btnExlcuir";
            btnExlcuir.NoAccentTextColor = Color.Empty;
            btnExlcuir.Size = new Size(80, 36);
            btnExlcuir.TabIndex = 2;
            btnExlcuir.Text = "Excluir";
            btnExlcuir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExlcuir.UseAccentColor = false;
            btnExlcuir.UseVisualStyleBackColor = true;
            btnExlcuir.Click += btnExlcuir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(382, 279);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridViewAluno
            // 
            dataGridViewAluno.AllowUserToAddRows = false;
            dataGridViewAluno.AllowUserToDeleteRows = false;
            dataGridViewAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAluno.Dock = DockStyle.Top;
            dataGridViewAluno.Location = new Point(3, 3);
            dataGridViewAluno.Name = "dataGridViewAluno";
            dataGridViewAluno.ReadOnly = true;
            dataGridViewAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAluno.Size = new Size(704, 247);
            dataGridViewAluno.TabIndex = 0;
            dataGridViewAluno.CellDoubleClick += dataGridViewAluno_CellDoubleClick;
            dataGridViewAluno.Enter += dataGridViewAluno_Enter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 451);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "FormPrincipal";
            Text = "Cadastro de Aluno";
            materialTabControl1.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAluno).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNascimento;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private DataGridView dataGridViewAluno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExlcuir;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
    }
}
