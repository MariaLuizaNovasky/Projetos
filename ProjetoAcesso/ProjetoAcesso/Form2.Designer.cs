
namespace ProjetoAcesso
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblava = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.rdbExc = new System.Windows.Forms.RadioButton();
            this.rdbBom = new System.Windows.Forms.RadioButton();
            this.rdbRegular = new System.Windows.Forms.RadioButton();
            this.rdbRuim = new System.Windows.Forms.RadioButton();
            this.lblsecao = new System.Windows.Forms.Label();
            this.lbloutra = new System.Windows.Forms.Label();
            this.txtoutra = new System.Windows.Forms.TextBox();
            this.lblcomen = new System.Windows.Forms.Label();
            this.cmbSecao = new System.Windows.Forms.ComboBox();
            this.txtComen = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(140, 335);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 24);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.DarkGray;
            this.btnfechar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(230, 335);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(82, 24);
            this.btnfechar.TabIndex = 20;
            this.btnfechar.Text = "FECHAR";
            this.btnfechar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(33, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 24);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblava
            // 
            this.lblava.AutoSize = true;
            this.lblava.BackColor = System.Drawing.Color.DarkGray;
            this.lblava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblava.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblava.Location = new System.Drawing.Point(158, 85);
            this.lblava.Name = "lblava";
            this.lblava.Size = new System.Drawing.Size(234, 15);
            this.lblava.TabIndex = 12;
            this.lblava.Text = "O QUE VOCE ACHOU DO SITE?";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoAcesso.Properties.Resources.Gingham_Check_in_Succulent_Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblpesquisa);
            this.panel1.Location = new System.Drawing.Point(33, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 59);
            this.panel1.TabIndex = 11;
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblpesquisa.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesquisa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblpesquisa.Location = new System.Drawing.Point(117, 10);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(251, 40);
            this.lblpesquisa.TabIndex = 1;
            this.lblpesquisa.Text = "P E S Q U I S A";
            this.lblpesquisa.Click += new System.EventHandler(this.lblacesso_Click);
            // 
            // rdbExc
            // 
            this.rdbExc.AutoSize = true;
            this.rdbExc.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExc.Location = new System.Drawing.Point(140, 107);
            this.rdbExc.Name = "rdbExc";
            this.rdbExc.Size = new System.Drawing.Size(86, 15);
            this.rdbExc.TabIndex = 22;
            this.rdbExc.TabStop = true;
            this.rdbExc.Text = "Excelente";
            this.rdbExc.UseVisualStyleBackColor = true;
            // 
            // rdbBom
            // 
            this.rdbBom.AutoSize = true;
            this.rdbBom.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBom.Location = new System.Drawing.Point(232, 107);
            this.rdbBom.Name = "rdbBom";
            this.rdbBom.Size = new System.Drawing.Size(44, 15);
            this.rdbBom.TabIndex = 23;
            this.rdbBom.TabStop = true;
            this.rdbBom.Text = "Bom";
            this.rdbBom.UseVisualStyleBackColor = true;
            // 
            // rdbRegular
            // 
            this.rdbRegular.AutoSize = true;
            this.rdbRegular.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRegular.Location = new System.Drawing.Point(282, 107);
            this.rdbRegular.Name = "rdbRegular";
            this.rdbRegular.Size = new System.Drawing.Size(72, 15);
            this.rdbRegular.TabIndex = 24;
            this.rdbRegular.TabStop = true;
            this.rdbRegular.Text = "Regular";
            this.rdbRegular.UseVisualStyleBackColor = true;
            // 
            // rdbRuim
            // 
            this.rdbRuim.AutoSize = true;
            this.rdbRuim.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRuim.Location = new System.Drawing.Point(360, 107);
            this.rdbRuim.Name = "rdbRuim";
            this.rdbRuim.Size = new System.Drawing.Size(51, 15);
            this.rdbRuim.TabIndex = 25;
            this.rdbRuim.TabStop = true;
            this.rdbRuim.Text = "Ruim";
            this.rdbRuim.UseVisualStyleBackColor = true;
            // 
            // lblsecao
            // 
            this.lblsecao.AutoSize = true;
            this.lblsecao.BackColor = System.Drawing.Color.DarkGray;
            this.lblsecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsecao.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecao.Location = new System.Drawing.Point(33, 139);
            this.lblsecao.Name = "lblsecao";
            this.lblsecao.Size = new System.Drawing.Size(279, 14);
            this.lblsecao.TabIndex = 26;
            this.lblsecao.Text = "QUAL A SECAO QUE VOCE MAIS GOSTOU?";
            // 
            // lbloutra
            // 
            this.lbloutra.AutoSize = true;
            this.lbloutra.BackColor = System.Drawing.Color.DarkGray;
            this.lbloutra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutra.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutra.Location = new System.Drawing.Point(318, 139);
            this.lbloutra.Name = "lbloutra";
            this.lbloutra.Size = new System.Drawing.Size(55, 14);
            this.lbloutra.TabIndex = 27;
            this.lbloutra.Text = "OUTRA:";
            // 
            // txtoutra
            // 
            this.txtoutra.Location = new System.Drawing.Point(318, 156);
            this.txtoutra.Name = "txtoutra";
            this.txtoutra.Size = new System.Drawing.Size(181, 20);
            this.txtoutra.TabIndex = 29;
            // 
            // lblcomen
            // 
            this.lblcomen.AutoSize = true;
            this.lblcomen.BackColor = System.Drawing.Color.DarkGray;
            this.lblcomen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcomen.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomen.Location = new System.Drawing.Point(101, 191);
            this.lblcomen.Name = "lblcomen";
            this.lblcomen.Size = new System.Drawing.Size(175, 14);
            this.lblcomen.TabIndex = 30;
            this.lblcomen.Text = "C O M E N T A R I O S";
            // 
            // cmbSecao
            // 
            this.cmbSecao.FormattingEnabled = true;
            this.cmbSecao.Location = new System.Drawing.Point(33, 155);
            this.cmbSecao.Name = "cmbSecao";
            this.cmbSecao.Size = new System.Drawing.Size(279, 21);
            this.cmbSecao.TabIndex = 32;
            // 
            // txtComen
            // 
            this.txtComen.Location = new System.Drawing.Point(33, 208);
            this.txtComen.Multiline = true;
            this.txtComen.Name = "txtComen";
            this.txtComen.Size = new System.Drawing.Size(279, 121);
            this.txtComen.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 371);
            this.Controls.Add(this.txtComen);
            this.Controls.Add(this.cmbSecao);
            this.Controls.Add(this.lblcomen);
            this.Controls.Add(this.txtoutra);
            this.Controls.Add(this.lbloutra);
            this.Controls.Add(this.lblsecao);
            this.Controls.Add(this.rdbRuim);
            this.Controls.Add(this.rdbRegular);
            this.Controls.Add(this.rdbBom);
            this.Controls.Add(this.rdbExc);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblava);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Site de Pesquisa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.RadioButton rdbExc;
        private System.Windows.Forms.RadioButton rdbBom;
        private System.Windows.Forms.RadioButton rdbRegular;
        private System.Windows.Forms.RadioButton rdbRuim;
        private System.Windows.Forms.Label lblsecao;
        private System.Windows.Forms.Label lbloutra;
        private System.Windows.Forms.TextBox txtoutra;
        private System.Windows.Forms.Label lblcomen;
        private System.Windows.Forms.ComboBox cmbSecao;
        private System.Windows.Forms.TextBox txtComen;
    }
}