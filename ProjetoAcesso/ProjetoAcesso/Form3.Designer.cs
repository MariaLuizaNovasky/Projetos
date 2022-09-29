
namespace ProjetoAcesso
{
    partial class Form3
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbdIA = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.RbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.lblProf = new System.Windows.Forms.Label();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSeguir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkGray;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 117);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 15);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "NOME:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DarkGray;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 15);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "EMAIL:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.BackColor = System.Drawing.Color.DarkGray;
            this.lblNasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNasc.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.Location = new System.Drawing.Point(316, 113);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(180, 15);
            this.lblNasc.TabIndex = 37;
            this.lblNasc.Text = "DATA DE NASCIMENTO:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(80, 80);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 19);
            this.txtEmail.TabIndex = 38;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(71, 115);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 19);
            this.txtNome.TabIndex = 39;
            // 
            // cmbdIA
            // 
            this.cmbdIA.FormattingEnabled = true;
            this.cmbdIA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbdIA.Location = new System.Drawing.Point(316, 131);
            this.cmbdIA.Name = "cmbdIA";
            this.cmbdIA.Size = new System.Drawing.Size(51, 21);
            this.cmbdIA.TabIndex = 40;
            this.cmbdIA.Text = "Dia";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(373, 131);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(56, 21);
            this.cmbMes.TabIndex = 41;
            this.cmbMes.Text = "Mes";
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbAno.Location = new System.Drawing.Point(435, 131);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(61, 21);
            this.cmbAno.TabIndex = 42;
            this.cmbAno.Text = "Ano";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.DarkGray;
            this.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSexo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(12, 151);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(63, 15);
            this.lblSexo.TabIndex = 43;
            this.lblSexo.Text = "Sexo: ";
            // 
            // RbFem
            // 
            this.RbFem.AutoSize = true;
            this.RbFem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFem.Location = new System.Drawing.Point(81, 148);
            this.RbFem.Name = "RbFem";
            this.RbFem.Size = new System.Drawing.Size(75, 17);
            this.RbFem.TabIndex = 44;
            this.RbFem.TabStop = true;
            this.RbFem.Text = "FEMININO";
            this.RbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasc.Location = new System.Drawing.Point(162, 148);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(84, 17);
            this.rbMasc.TabIndex = 45;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "MASCULINO";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.BackColor = System.Drawing.Color.DarkGray;
            this.lblProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProf.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(13, 192);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(99, 15);
            this.lblProf.TabIndex = 46;
            this.lblProf.Text = "PROFISSÃO:";
            // 
            // txtPro
            // 
            this.txtPro.BackColor = System.Drawing.Color.White;
            this.txtPro.Location = new System.Drawing.Point(117, 187);
            this.txtPro.Multiline = true;
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(379, 24);
            this.txtPro.TabIndex = 47;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeletar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(162, 263);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(79, 24);
            this.btnDeletar.TabIndex = 50;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(247, 263);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 24);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(55, 263);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 24);
            this.btnEditar.TabIndex = 48;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSeguir
            // 
            this.btnSeguir.BackColor = System.Drawing.Color.DarkGray;
            this.btnSeguir.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguir.Location = new System.Drawing.Point(369, 263);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(127, 24);
            this.btnSeguir.TabIndex = 51;
            this.btnSeguir.Text = "PROSSEGUIR ->";
            this.btnSeguir.UseVisualStyleBackColor = false;
            this.btnSeguir.Click += new System.EventHandler(this.btnSeguir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoAcesso.Properties.Resources.Gingham_Check_in_Succulent_Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblpesquisa);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 59);
            this.panel1.TabIndex = 34;
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
            this.lblpesquisa.Click += new System.EventHandler(this.lblpesquisa_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 293);
            this.Controls.Add(this.btnSeguir);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtPro);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.RbFem);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbdIA);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Cadastro de Pessoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbdIA;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton RbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSeguir;
    }
}