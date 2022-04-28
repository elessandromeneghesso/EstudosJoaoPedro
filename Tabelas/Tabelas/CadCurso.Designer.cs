namespace Tabelas
{
    partial class CadCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeC = new System.Windows.Forms.TextBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbIdCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Curso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período Do Curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNomeC
            // 
            this.txbNomeC.Location = new System.Drawing.Point(149, 85);
            this.txbNomeC.Name = "txbNomeC";
            this.txbNomeC.Size = new System.Drawing.Size(156, 20);
            this.txbNomeC.TabIndex = 1;
            this.txbNomeC.TextChanged += new System.EventHandler(this.txbNomeC_TextChanged);
            this.txbNomeC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNomeC_KeyPress);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Manhã\t",
            "Tarde",
            "Integral",
            "Noite"});
            this.cbPeriodo.Location = new System.Drawing.Point(149, 123);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(156, 21);
            this.cbPeriodo.TabIndex = 3;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(185, 150);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txbIdCurso
            // 
            this.txbIdCurso.Enabled = false;
            this.txbIdCurso.Location = new System.Drawing.Point(149, 43);
            this.txbIdCurso.Name = "txbIdCurso";
            this.txbIdCurso.Size = new System.Drawing.Size(46, 20);
            this.txbIdCurso.TabIndex = 0;
            this.txbIdCurso.TextChanged += new System.EventHandler(this.txbIdCurso_TextChanged);
            this.txbIdCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIdCurso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo do curso";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(201, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 20);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIdCurso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.txbNomeC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Curso";
            this.Text = "Cadastro de Cursos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Curso_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeC;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbIdCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}