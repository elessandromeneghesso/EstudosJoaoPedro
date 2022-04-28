namespace Tabelas
{
    partial class CadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAluno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCursos = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txbTelefone);
            this.groupBox1.Controls.Add(this.txbCpf);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Location = new System.Drawing.Point(178, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 183);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Aluno";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Excluir ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(191, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 20);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoSize = true;
            this.txtTelefone.Location = new System.Drawing.Point(19, 110);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(52, 13);
            this.txtTelefone.TabIndex = 20;
            this.txtTelefone.Text = "Telefone:";
            // 
            // txtCpf
            // 
            this.txtCpf.AutoSize = true;
            this.txtCpf.Location = new System.Drawing.Point(19, 30);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(30, 13);
            this.txtCpf.TabIndex = 19;
            this.txtCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(19, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(38, 13);
            this.txtNome.TabIndex = 17;
            this.txtNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(22, 152);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 23);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.txbTelefone.Location = new System.Drawing.Point(22, 126);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(202, 20);
            this.txbTelefone.TabIndex = 16;
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.SystemColors.Window;
            this.txbCpf.Location = new System.Drawing.Point(22, 49);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(163, 20);
            this.txbCpf.TabIndex = 14;
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.Window;
            this.txbNome.Location = new System.Drawing.Point(22, 87);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(202, 20);
            this.txbNome.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtCursos);
            this.groupBox2.Location = new System.Drawing.Point(100, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 202);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursos Matriculados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Excluir Curso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(202, 120);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(224, 76);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(85, 23);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCursos
            // 
            this.txtCursos.AutoSize = true;
            this.txtCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursos.Location = new System.Drawing.Point(13, 28);
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(52, 16);
            this.txtCursos.TabIndex = 19;
            this.txtCursos.Text = "Cursos:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 442);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadAluno";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.Label txtCpf;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtCursos;
        private System.Windows.Forms.Button button4;
    }
}

