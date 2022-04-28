namespace Tabelas
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.btnCadProf = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadCurso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadAluno.Location = new System.Drawing.Point(210, 52);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(238, 40);
            this.btnCadAluno.TabIndex = 0;
            this.btnCadAluno.Text = "Cadastrar Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = false;
            this.btnCadAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadProf
            // 
            this.btnCadProf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadProf.Location = new System.Drawing.Point(210, 98);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(238, 40);
            this.btnCadProf.TabIndex = 1;
            this.btnCadProf.Text = "Cadastrar Professor";
            this.btnCadProf.UseVisualStyleBackColor = false;
            this.btnCadProf.Click += new System.EventHandler(this.btnCadProf_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultar.Location = new System.Drawing.Point(210, 190);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(238, 40);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oque Deseja Fazer ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadCurso
            // 
            this.btnCadCurso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadCurso.Location = new System.Drawing.Point(210, 144);
            this.btnCadCurso.Name = "btnCadCurso";
            this.btnCadCurso.Size = new System.Drawing.Size(238, 40);
            this.btnCadCurso.TabIndex = 4;
            this.btnCadCurso.Text = "Cadastrar Curso";
            this.btnCadCurso.UseVisualStyleBackColor = false;
            this.btnCadCurso.Click += new System.EventHandler(this.btnCadCurso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 239);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadProf);
            this.Controls.Add(this.btnCadAluno);
            this.Name = "TelaInicial";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadAluno;
        private System.Windows.Forms.Button btnCadProf;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadCurso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}