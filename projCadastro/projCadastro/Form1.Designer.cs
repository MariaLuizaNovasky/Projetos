
namespace projCadastro
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
            this.nome = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cad = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(12, 133);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(40, 12);
            this.nome.TabIndex = 0;
            this.nome.Text = "NOME:";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(12, 107);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(54, 12);
            this.codigo.TabIndex = 1;
            this.codigo.Text = "CÓDIGO:";
            // 
            // cargo
            // 
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(12, 165);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(47, 12);
            this.cargo.TabIndex = 2;
            this.cargo.Text = "CARGO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cad);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 82);
            this.panel1.TabIndex = 3;
            // 
            // cad
            // 
            this.cad.AutoSize = true;
            this.cad.Font = new System.Drawing.Font("Javanese Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cad.ForeColor = System.Drawing.Color.Black;
            this.cad.Location = new System.Drawing.Point(83, 7);
            this.cad.Name = "cad";
            this.cad.Size = new System.Drawing.Size(304, 80);
            this.cad.TabIndex = 0;
            this.cad.Text = "C A D A S T R O\r\n";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(70, 103);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(200, 20);
            this.txtcod.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(70, 129);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(413, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(70, 160);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(413, 20);
            this.txtcargo.TabIndex = 6;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(12, 270);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(121, 20);
            this.txtsalario.TabIndex = 7;
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario.Location = new System.Drawing.Point(13, 255);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(96, 12);
            this.salario.TabIndex = 8;
            this.salario.Text = "SALARIO BASE:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(12, 211);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(200, 20);
            this.txtcpf.TabIndex = 9;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(13, 196);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(82, 12);
            this.cpf.TabIndex = 10;
            this.cpf.Text = "CPF / CNPJ:";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(338, 196);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(89, 12);
            this.info.TabIndex = 11;
            this.info.Text = "INFORMAÇÕES:";
            // 
            // pnlinfo
            // 
            this.pnlinfo.BackColor = System.Drawing.Color.MintCream;
            this.pnlinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinfo.Location = new System.Drawing.Point(261, 211);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(222, 117);
            this.pnlinfo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 340);
            this.Controls.Add(this.pnlinfo);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cad;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label salario;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Panel pnlinfo;
    }
}

