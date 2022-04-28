namespace Tabelas
{
    partial class Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor));
            this.txtNomeP = new System.Windows.Forms.Label();
            this.txbCpfP = new System.Windows.Forms.Label();
            this.txbNomeP = new System.Windows.Forms.TextBox();
            this.txbcepef = new System.Windows.Forms.TextBox();
            this.txtCursos = new System.Windows.Forms.Label();
            this.btnCadastroP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTelP = new System.Windows.Forms.TextBox();
            this.btnAdcP = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeP
            // 
            this.txtNomeP.AutoSize = true;
            this.txtNomeP.Location = new System.Drawing.Point(173, 19);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(38, 13);
            this.txtNomeP.TabIndex = 0;
            this.txtNomeP.Text = "Nome:";
            this.txtNomeP.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbCpfP
            // 
            this.txbCpfP.AutoSize = true;
            this.txbCpfP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbCpfP.Location = new System.Drawing.Point(173, 59);
            this.txbCpfP.Name = "txbCpfP";
            this.txbCpfP.Size = new System.Drawing.Size(33, 13);
            this.txbCpfP.TabIndex = 1;
            this.txbCpfP.Text = "CPF :";
            this.txbCpfP.Click += new System.EventHandler(this.txbTelefoneP_Click);
            // 
            // txbNomeP
            // 
            this.txbNomeP.BackColor = System.Drawing.SystemColors.Window;
            this.txbNomeP.Location = new System.Drawing.Point(176, 35);
            this.txbNomeP.Name = "txbNomeP";
            this.txbNomeP.Size = new System.Drawing.Size(262, 20);
            this.txbNomeP.TabIndex = 4;
            // 
            // txbcepef
            // 
            this.txbcepef.BackColor = System.Drawing.SystemColors.Window;
            this.txbcepef.Location = new System.Drawing.Point(176, 75);
            this.txbcepef.Name = "txbcepef";
            this.txbcepef.Size = new System.Drawing.Size(137, 20);
            this.txbcepef.TabIndex = 5;
            // 
            // txtCursos
            // 
            this.txtCursos.AutoSize = true;
            this.txtCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursos.Location = new System.Drawing.Point(173, 136);
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(52, 16);
            this.txtCursos.TabIndex = 12;
            this.txtCursos.Text = "Cursos:";
            // 
            // btnCadastroP
            // 
            this.btnCadastroP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastroP.Location = new System.Drawing.Point(176, 296);
            this.btnCadastroP.Name = "btnCadastroP";
            this.btnCadastroP.Size = new System.Drawing.Size(191, 23);
            this.btnCadastroP.TabIndex = 13;
            this.btnCadastroP.Text = "Cadastrar ";
            this.btnCadastroP.UseVisualStyleBackColor = false;
            this.btnCadastroP.Click += new System.EventHandler(this.btnCadastroP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(319, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 20);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txbTelP
            // 
            this.txbTelP.Location = new System.Drawing.Point(176, 113);
            this.txbTelP.Name = "txbTelP";
            this.txbTelP.Size = new System.Drawing.Size(100, 20);
            this.txbTelP.TabIndex = 16;
            // 
            // btnAdcP
            // 
            this.btnAdcP.Location = new System.Drawing.Point(303, 155);
            this.btnAdcP.Name = "btnAdcP";
            this.btnAdcP.Size = new System.Drawing.Size(75, 21);
            this.btnAdcP.TabIndex = 17;
            this.btnAdcP.Text = "Adicionar ";
            this.btnAdcP.UseVisualStyleBackColor = true;
            this.btnAdcP.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTel
            // 
            this.txtTel.AutoSize = true;
            this.txtTel.Location = new System.Drawing.Point(173, 97);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(55, 13);
            this.txtTel.TabIndex = 18;
            this.txtTel.Text = "Telefone :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(166, 109);
            this.dataGridView1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnAdcP);
            this.Controls.Add(this.txbTelP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastroP);
            this.Controls.Add(this.txtCursos);
            this.Controls.Add(this.txbcepef);
            this.Controls.Add(this.txbNomeP);
            this.Controls.Add(this.txbCpfP);
            this.Controls.Add(this.txtNomeP);
            this.Name = "Professor";
            this.Text = "Cadastro Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNomeP;
        private System.Windows.Forms.Label txbCpfP;
        private System.Windows.Forms.TextBox txbNomeP;
        private System.Windows.Forms.TextBox txbcepef;
        private System.Windows.Forms.Label txtCursos;
        private System.Windows.Forms.Button btnCadastroP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTelP;
        private System.Windows.Forms.Button btnAdcP;
        private System.Windows.Forms.Label txtTel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}