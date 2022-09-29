
namespace ProjetoAcesso
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEsqueci = new System.Windows.Forms.Button();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblacesso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.DarkGray;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "USERNAME:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(107, 96);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(256, 15);
            this.txtUsername.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.DarkGray;
            this.lblSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSenha.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(12, 140);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "SENHA:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(78, 140);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(285, 15);
            this.txtSenha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONFIRMAR SENHA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 188);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 15);
            this.textBox1.TabIndex = 6;
            // 
            // btnEsqueci
            // 
            this.btnEsqueci.BackColor = System.Drawing.Color.DarkGray;
            this.btnEsqueci.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueci.Location = new System.Drawing.Point(66, 263);
            this.btnEsqueci.Name = "btnEsqueci";
            this.btnEsqueci.Size = new System.Drawing.Size(194, 24);
            this.btnEsqueci.TabIndex = 8;
            this.btnEsqueci.Text = "ESQUECI MINHA SENHA";
            this.btnEsqueci.UseVisualStyleBackColor = false;
            this.btnEsqueci.Click += new System.EventHandler(this.btnEsqueci_Click);
            // 
            // btnAcesso
            // 
            this.btnAcesso.BackColor = System.Drawing.Color.DarkGray;
            this.btnAcesso.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcesso.Location = new System.Drawing.Point(169, 293);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(194, 24);
            this.btnAcesso.TabIndex = 9;
            this.btnAcesso.Text = "FINALIZAR ACESSO";
            this.btnAcesso.UseVisualStyleBackColor = false;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCriar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(266, 263);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(194, 24);
            this.btnCriar.TabIndex = 10;
            this.btnCriar.Text = "CRIAR ACESSO";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoAcesso.Properties.Resources.Gingham_Check_in_Succulent_Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblacesso);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 65);
            this.panel1.TabIndex = 0;
            // 
            // lblacesso
            // 
            this.lblacesso.AutoSize = true;
            this.lblacesso.BackColor = System.Drawing.Color.Transparent;
            this.lblacesso.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacesso.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblacesso.Location = new System.Drawing.Point(136, 11);
            this.lblacesso.Name = "lblacesso";
            this.lblacesso.Size = new System.Drawing.Size(198, 40);
            this.lblacesso.TabIndex = 1;
            this.lblacesso.Text = "A C E S S O";
            this.lblacesso.Click += new System.EventHandler(this.lblacesso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnAcesso);
            this.Controls.Add(this.btnEsqueci);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Acesso do Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblacesso;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEsqueci;
        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Button btnCriar;
    }
}

