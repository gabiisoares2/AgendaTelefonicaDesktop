namespace AgendaTelefonica
{
    partial class FrmDetalhe
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
            this.txtDataAniversario = new System.Windows.Forms.MaskedTextBox();
            this.txtTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.txtCasa = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluirTrab = new System.Windows.Forms.PictureBox();
            this.btnExcluirCel = new System.Windows.Forms.PictureBox();
            this.btnExcluirCasa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirTrab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirCel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirCasa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataAniversario
            // 
            this.txtDataAniversario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataAniversario.Location = new System.Drawing.Point(51, 189);
            this.txtDataAniversario.Mask = "00/00/0000";
            this.txtDataAniversario.Name = "txtDataAniversario";
            this.txtDataAniversario.Size = new System.Drawing.Size(97, 19);
            this.txtDataAniversario.TabIndex = 23;
            this.txtDataAniversario.ValidatingType = typeof(System.DateTime);
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTrabalho.Location = new System.Drawing.Point(52, 373);
            this.txtTrabalho.Mask = "(00) 0000-0000";
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(120, 19);
            this.txtTrabalho.TabIndex = 26;
            // 
            // txtCasa
            // 
            this.txtCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCasa.Location = new System.Drawing.Point(50, 307);
            this.txtCasa.Mask = "(00) 0000-0000";
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(122, 19);
            this.txtCasa.TabIndex = 25;
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCelular.Location = new System.Drawing.Point(50, 243);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(136, 19);
            this.txtCelular.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(52, 83);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(349, 23);
            this.txtNome.TabIndex = 33;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(52, 126);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(349, 23);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(46, 165);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "Data Nascimento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(46, 221);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Celular";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(46, 285);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(149, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "Telefone Residencial";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(43, 346);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(152, 19);
            this.materialLabel4.TabIndex = 38;
            this.materialLabel4.Text = "Telefone do Trabalho";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(137, 419);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(84, 33);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Location = new System.Drawing.Point(241, 419);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(84, 33);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExcluirTrab
            // 
            this.btnExcluirTrab.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirTrab.Image = global::AgendaTelefonica.Properties.Resources.icon_delet;
            this.btnExcluirTrab.Location = new System.Drawing.Point(178, 374);
            this.btnExcluirTrab.Name = "btnExcluirTrab";
            this.btnExcluirTrab.Size = new System.Drawing.Size(20, 20);
            this.btnExcluirTrab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcluirTrab.TabIndex = 43;
            this.btnExcluirTrab.TabStop = false;
            this.btnExcluirTrab.Click += new System.EventHandler(this.btnExcluirTrab_Click);
            // 
            // btnExcluirCel
            // 
            this.btnExcluirCel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirCel.Image = global::AgendaTelefonica.Properties.Resources.icon_delet;
            this.btnExcluirCel.Location = new System.Drawing.Point(178, 244);
            this.btnExcluirCel.Name = "btnExcluirCel";
            this.btnExcluirCel.Size = new System.Drawing.Size(20, 20);
            this.btnExcluirCel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcluirCel.TabIndex = 44;
            this.btnExcluirCel.TabStop = false;
            this.btnExcluirCel.Click += new System.EventHandler(this.btnExcluirCel_Click);
            // 
            // btnExcluirCasa
            // 
            this.btnExcluirCasa.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirCasa.Image = global::AgendaTelefonica.Properties.Resources.icon_delet;
            this.btnExcluirCasa.Location = new System.Drawing.Point(178, 307);
            this.btnExcluirCasa.Name = "btnExcluirCasa";
            this.btnExcluirCasa.Size = new System.Drawing.Size(20, 20);
            this.btnExcluirCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcluirCasa.TabIndex = 45;
            this.btnExcluirCasa.TabStop = false;
            this.btnExcluirCasa.Click += new System.EventHandler(this.btnExcluirCasa_Click);
            // 
            // FrmDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 467);
            this.Controls.Add(this.btnExcluirCasa);
            this.Controls.Add(this.btnExcluirCel);
            this.Controls.Add(this.btnExcluirTrab);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtCasa);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDataAniversario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.FrmDetalhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirTrab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirCel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirCasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtDataAniversario;
        private System.Windows.Forms.MaskedTextBox txtTrabalho;
        private System.Windows.Forms.MaskedTextBox txtCasa;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
        private System.Windows.Forms.PictureBox btnExcluirTrab;
        private System.Windows.Forms.PictureBox btnExcluirCel;
        private System.Windows.Forms.PictureBox btnExcluirCasa;
    }
}