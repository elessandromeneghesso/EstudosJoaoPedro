using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabelas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CadAluno form1 = new CadAluno();
            form1.Show();

        }

        private void btnCadProf_Click(object sender, EventArgs e)
        {
            
            Professor form2 = new Professor();
            form2.Show();

        }

        private void btnCadCurso_Click(object sender, EventArgs e)
        {
            CadCurso form4 = new CadCurso();
            form4.Show();
        }
    }
}
