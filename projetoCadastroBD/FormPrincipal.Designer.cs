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
            tabPageConsulta = new TabPage();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit3 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit4 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit5 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit6 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            materialMaskedTextBox1 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            listView1 = new ListView();
            materialTabControl1.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
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
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(materialMaskedTextBox1);
            tabPageCadastro.Controls.Add(materialComboBox1);
            tabPageCadastro.Controls.Add(materialTextBoxEdit6);
            tabPageCadastro.Controls.Add(materialTextBoxEdit5);
            tabPageCadastro.Controls.Add(materialTextBoxEdit4);
            tabPageCadastro.Controls.Add(materialTextBoxEdit3);
            tabPageCadastro.Controls.Add(materialTextBoxEdit2);
            tabPageCadastro.Controls.Add(materialTextBoxEdit1);
            tabPageCadastro.ImageKey = "c-sharp.png";
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(710, 335);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(listView1);
            tabPageConsulta.ImageKey = "pesquisa-de-dados.png";
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(710, 335);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.Hint = "Matricula";
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(6, 6);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(384, 48);
            materialTextBoxEdit1.TabIndex = 0;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit2
            // 
            materialTextBoxEdit2.AnimateReadOnly = false;
            materialTextBoxEdit2.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit2.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit2.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit2.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit2.Depth = 0;
            materialTextBoxEdit2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit2.HideSelection = true;
            materialTextBoxEdit2.Hint = "Nome";
            materialTextBoxEdit2.LeadingIcon = null;
            materialTextBoxEdit2.Location = new Point(6, 60);
            materialTextBoxEdit2.MaxLength = 32767;
            materialTextBoxEdit2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit2.Name = "materialTextBoxEdit2";
            materialTextBoxEdit2.PasswordChar = '\0';
            materialTextBoxEdit2.PrefixSuffixText = null;
            materialTextBoxEdit2.ReadOnly = false;
            materialTextBoxEdit2.RightToLeft = RightToLeft.No;
            materialTextBoxEdit2.SelectedText = "";
            materialTextBoxEdit2.SelectionLength = 0;
            materialTextBoxEdit2.SelectionStart = 0;
            materialTextBoxEdit2.ShortcutsEnabled = true;
            materialTextBoxEdit2.Size = new Size(640, 48);
            materialTextBoxEdit2.TabIndex = 1;
            materialTextBoxEdit2.TabStop = false;
            materialTextBoxEdit2.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit2.TrailingIcon = null;
            materialTextBoxEdit2.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit3
            // 
            materialTextBoxEdit3.AnimateReadOnly = false;
            materialTextBoxEdit3.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit3.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit3.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit3.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit3.Depth = 0;
            materialTextBoxEdit3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit3.HideSelection = true;
            materialTextBoxEdit3.Hint = "Endereço";
            materialTextBoxEdit3.LeadingIcon = null;
            materialTextBoxEdit3.Location = new Point(6, 114);
            materialTextBoxEdit3.MaxLength = 32767;
            materialTextBoxEdit3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit3.Name = "materialTextBoxEdit3";
            materialTextBoxEdit3.PasswordChar = '\0';
            materialTextBoxEdit3.PrefixSuffixText = null;
            materialTextBoxEdit3.ReadOnly = false;
            materialTextBoxEdit3.RightToLeft = RightToLeft.No;
            materialTextBoxEdit3.SelectedText = "";
            materialTextBoxEdit3.SelectionLength = 0;
            materialTextBoxEdit3.SelectionStart = 0;
            materialTextBoxEdit3.ShortcutsEnabled = true;
            materialTextBoxEdit3.Size = new Size(640, 48);
            materialTextBoxEdit3.TabIndex = 2;
            materialTextBoxEdit3.TabStop = false;
            materialTextBoxEdit3.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit3.TrailingIcon = null;
            materialTextBoxEdit3.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit4
            // 
            materialTextBoxEdit4.AnimateReadOnly = false;
            materialTextBoxEdit4.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit4.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit4.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit4.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit4.Depth = 0;
            materialTextBoxEdit4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit4.HideSelection = true;
            materialTextBoxEdit4.Hint = "Bairro";
            materialTextBoxEdit4.LeadingIcon = null;
            materialTextBoxEdit4.Location = new Point(6, 168);
            materialTextBoxEdit4.MaxLength = 32767;
            materialTextBoxEdit4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit4.Name = "materialTextBoxEdit4";
            materialTextBoxEdit4.PasswordChar = '\0';
            materialTextBoxEdit4.PrefixSuffixText = null;
            materialTextBoxEdit4.ReadOnly = false;
            materialTextBoxEdit4.RightToLeft = RightToLeft.No;
            materialTextBoxEdit4.SelectedText = "";
            materialTextBoxEdit4.SelectionLength = 0;
            materialTextBoxEdit4.SelectionStart = 0;
            materialTextBoxEdit4.ShortcutsEnabled = true;
            materialTextBoxEdit4.Size = new Size(374, 48);
            materialTextBoxEdit4.TabIndex = 3;
            materialTextBoxEdit4.TabStop = false;
            materialTextBoxEdit4.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit4.TrailingIcon = null;
            materialTextBoxEdit4.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit5
            // 
            materialTextBoxEdit5.AnimateReadOnly = false;
            materialTextBoxEdit5.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit5.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit5.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit5.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit5.Depth = 0;
            materialTextBoxEdit5.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit5.HideSelection = true;
            materialTextBoxEdit5.Hint = "Cidade";
            materialTextBoxEdit5.LeadingIcon = null;
            materialTextBoxEdit5.Location = new Point(6, 222);
            materialTextBoxEdit5.MaxLength = 32767;
            materialTextBoxEdit5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit5.Name = "materialTextBoxEdit5";
            materialTextBoxEdit5.PasswordChar = '\0';
            materialTextBoxEdit5.PrefixSuffixText = null;
            materialTextBoxEdit5.ReadOnly = false;
            materialTextBoxEdit5.RightToLeft = RightToLeft.No;
            materialTextBoxEdit5.SelectedText = "";
            materialTextBoxEdit5.SelectionLength = 0;
            materialTextBoxEdit5.SelectionStart = 0;
            materialTextBoxEdit5.ShortcutsEnabled = true;
            materialTextBoxEdit5.Size = new Size(640, 48);
            materialTextBoxEdit5.TabIndex = 4;
            materialTextBoxEdit5.TabStop = false;
            materialTextBoxEdit5.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit5.TrailingIcon = null;
            materialTextBoxEdit5.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit6
            // 
            materialTextBoxEdit6.AnimateReadOnly = false;
            materialTextBoxEdit6.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit6.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit6.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit6.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit6.Depth = 0;
            materialTextBoxEdit6.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit6.HideSelection = true;
            materialTextBoxEdit6.Hint = "Senha";
            materialTextBoxEdit6.LeadingIcon = null;
            materialTextBoxEdit6.Location = new Point(6, 276);
            materialTextBoxEdit6.MaxLength = 32767;
            materialTextBoxEdit6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit6.Name = "materialTextBoxEdit6";
            materialTextBoxEdit6.PasswordChar = '\0';
            materialTextBoxEdit6.PrefixSuffixText = null;
            materialTextBoxEdit6.ReadOnly = false;
            materialTextBoxEdit6.RightToLeft = RightToLeft.No;
            materialTextBoxEdit6.SelectedText = "";
            materialTextBoxEdit6.SelectionLength = 0;
            materialTextBoxEdit6.SelectionStart = 0;
            materialTextBoxEdit6.ShortcutsEnabled = true;
            materialTextBoxEdit6.Size = new Size(441, 48);
            materialTextBoxEdit6.TabIndex = 5;
            materialTextBoxEdit6.TabStop = false;
            materialTextBoxEdit6.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit6.TrailingIcon = null;
            materialTextBoxEdit6.UseSystemPasswordChar = false;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Estado";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(396, 167);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(250, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 6;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Data de Nascimento";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(396, 6);
            materialMaskedTextBox1.Mask = "99/99/9999";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(250, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 7;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Text = "  /  /";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
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
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(655, 261);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "FormPrincipal";
            Text = "Cadastro de Aluno";
            materialTabControl1.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ListView listView1;
    }
}
