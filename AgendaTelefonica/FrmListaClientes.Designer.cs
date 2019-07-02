namespace AgendaTelefonica
{
    partial class FrmListaClientes
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
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCasa = new System.Windows.Forms.MaskedTextBox();
            this.txtTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGravar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.txtPesquisar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSincronizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataAniversario
            // 
            this.txtDataAniversario.BackColor = System.Drawing.Color.White;
            this.txtDataAniversario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataAniversario.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataAniversario.Location = new System.Drawing.Point(12, 207);
            this.txtDataAniversario.Mask = "00/00/0000";
            this.txtDataAniversario.Name = "txtDataAniversario";
            this.txtDataAniversario.Size = new System.Drawing.Size(107, 19);
            this.txtDataAniversario.TabIndex = 7;
            this.txtDataAniversario.ValidatingType = typeof(System.DateTime);
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCliente.Location = new System.Drawing.Point(315, 109);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListaCliente.Size = new System.Drawing.Size(670, 320);
            this.dgvListaCliente.TabIndex = 16;
            this.dgvListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCliente_CellClick);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCelular.ForeColor = System.Drawing.Color.DimGray;
            this.txtCelular.Location = new System.Drawing.Point(14, 268);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(130, 19);
            this.txtCelular.TabIndex = 18;
            // 
            // txtCasa
            // 
            this.txtCasa.BackColor = System.Drawing.Color.White;
            this.txtCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCasa.ForeColor = System.Drawing.Color.DimGray;
            this.txtCasa.Location = new System.Drawing.Point(15, 331);
            this.txtCasa.Mask = "(00) 0000-0000";
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(129, 19);
            this.txtCasa.TabIndex = 19;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.BackColor = System.Drawing.Color.White;
            this.txtTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalho.ForeColor = System.Drawing.Color.DimGray;
            this.txtTrabalho.Location = new System.Drawing.Point(16, 389);
            this.txtTrabalho.Margin = new System.Windows.Forms.Padding(5);
            this.txtTrabalho.Mask = "(00) 0000-0000";
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(117, 19);
            this.txtTrabalho.TabIndex = 20;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(312, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "* Clique em cima do cliente desejado para ver os detalhes sobre ele.";
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(12, 95);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(275, 23);
            this.txtNome.TabIndex = 26;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(12, 145);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(275, 23);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Depth = 0;
            this.btnGravar.Location = new System.Drawing.Point(99, 443);
            this.btnGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Primary = true;
            this.btnGravar.Size = new System.Drawing.Size(95, 37);
            this.btnGravar.TabIndex = 28;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 182);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Data Nascimento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 365);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 30;
            this.materialLabel2.Text = "Telefone do Trabalho";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(10, 307);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(149, 19);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Telefone Residencial";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 246);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 19);
            this.materialLabel4.TabIndex = 32;
            this.materialLabel4.Text = "Celular";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(293, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 494);
            this.materialDivider1.TabIndex = 33;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-4, 435);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(297, 2);
            this.materialDivider2.TabIndex = 35;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Depth = 0;
            this.txtPesquisar.Hint = "Pesquisar Cliente";
            this.txtPesquisar.Location = new System.Drawing.Point(436, 77);
            this.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(370, 23);
            this.txtPesquisar.TabIndex = 37;
            this.txtPesquisar.UseSystemPasswordChar = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(826, 71);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = true;
            this.btnPesquisar.Size = new System.Drawing.Size(85, 32);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Depth = 0;
            this.btnSincronizar.Location = new System.Drawing.Point(885, 441);
            this.btnSincronizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Primary = true;
            this.btnSincronizar.Size = new System.Drawing.Size(100, 35);
            this.btnSincronizar.TabIndex = 39;
            this.btnSincronizar.Text = "Sincronizar";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(567, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Lista de Clientes";
            // 
            // FrmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSincronizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtCasa);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.dgvListaCliente);
            this.Controls.Add(this.txtDataAniversario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtDataAniversario;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCasa;
        private System.Windows.Forms.MaskedTextBox txtTrabalho;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialRaisedButton btnGravar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisar;
        private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSincronizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

