
namespace ProjetoAcesso
{
    partial class Form4
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.btnSeguir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeletar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(172, 258);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(79, 24);
            this.btnDeletar.TabIndex = 68;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(257, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 24);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(65, 258);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 24);
            this.btnEditar.TabIndex = 66;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.Color.White;
            this.txtEnd.Location = new System.Drawing.Point(110, 127);
            this.txtEnd.Multiline = true;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(390, 19);
            this.txtEnd.TabIndex = 57;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(75, 91);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(425, 19);
            this.txtNome.TabIndex = 56;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkGray;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 15);
            this.lblNome.TabIndex = 54;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.BackColor = System.Drawing.Color.DarkGray;
            this.lblend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblend.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(16, 129);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(90, 15);
            this.lblend.TabIndex = 53;
            this.lblend.Text = "ENDEREÇO:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoAcesso.Properties.Resources.Gingham_Check_in_Succulent_Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblpesquisa);
            this.panel1.Location = new System.Drawing.Point(16, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 59);
            this.panel1.TabIndex = 52;
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblpesquisa.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesquisa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblpesquisa.Location = new System.Drawing.Point(114, 10);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(264, 40);
            this.lblpesquisa.TabIndex = 1;
            this.lblpesquisa.Text = "C A D A S T R O";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.DarkGray;
            this.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBairro.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(16, 168);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(72, 15);
            this.lblBairro.TabIndex = 70;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(94, 166);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(151, 19);
            this.txtBairro.TabIndex = 71;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.DarkGray;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(284, 168);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 15);
            this.lblEstado.TabIndex = 72;
            this.lblEstado.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre\tAC\tRio Branco",
            "Alagoas\tAL\tMaceió",
            "Amapá\tAP\tMacapá",
            "Amazonas\tAM\tManaus",
            "Bahia\tBA\tSalvador",
            "Ceará\tCE\tFortaleza",
            "Espírito Santo\tES\tVitória",
            "Goiás\tGO\tGoiânia",
            "Maranhão\tMA\tSão Luís",
            "Mato Grosso\tMT\tCuiabá",
            "Mato Grosso do Sul\tMS\tCampo Grande",
            "Minas Gerais\tMG\tBelo Horizonte",
            "Pará\tPA\tBelém",
            "Paraíba\tPB\tJoão Pessoa",
            "Paraná\tPR\tCuritiba",
            "Pernambuco\tPE\tRecife",
            "Piauí\tPI\tTeresina",
            "Rio de Janeiro\tRJ\tRio de Janeiro",
            "Rio Grande do Norte\tRN\tNatal",
            "Rio Grande do Sul\tRS\tPorto Alegre",
            "Rondônia\tRO\tPorto Velho",
            "Roraima\tRR\tBoa Vista",
            "Santa Catarina\tSC\tFlorianópolis",
            "São Paulo\tSP\tSão Paulo",
            "Sergipe\tSE\tAracaju",
            "Tocantins\tTO\tPalmas"});
            this.cmbEstado.Location = new System.Drawing.Point(362, 164);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(138, 21);
            this.cmbEstado.TabIndex = 73;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.DarkGray;
            this.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCep.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(16, 201);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(45, 15);
            this.lblCep.TabIndex = 74;
            this.lblCep.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.Color.White;
            this.txtcep.Location = new System.Drawing.Point(65, 200);
            this.txtcep.Multiline = true;
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(181, 19);
            this.txtcep.TabIndex = 75;
            // 
            // btnSeguir
            // 
            this.btnSeguir.BackColor = System.Drawing.Color.DarkGray;
            this.btnSeguir.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguir.Location = new System.Drawing.Point(373, 258);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(127, 24);
            this.btnSeguir.TabIndex = 76;
            this.btnSeguir.Text = "PROSSEGUIR ->";
            this.btnSeguir.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 294);
            this.Controls.Add(this.btnSeguir);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Continuação Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Button btnSeguir;
    }
}