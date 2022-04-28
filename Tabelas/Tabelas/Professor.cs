using MySql.Data.MySqlClient;
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
    public partial class Professor : Form
    {
        private MySqlConnection coon2;
        private string data_source = "server=mysql.ispac.com.br;port=3306;database=ispac24;uid=ispac24;password=ispac123";
        private int contador = 0;

        public Professor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbTelefoneP_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroP_Click(object sender, EventArgs e)
        {
            try
            {
                coon2 = new MySqlConnection(data_source);
                coon2.Open();

                string sql = "SELECT Cpf FROM Professor WHERE Cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, coon2);

                cmd.Parameters.AddWithValue("@cpf", txbcepef.Text);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                if (contador > 0)
                {
                    MessageBox.Show("Professor Ja Esta Cadastrado");
                    return;
                }
                
                coon2.Close();
                coon2.Open();

                sql = "INSERT INTO Professor (Nome,Cpf,Telefone) VALUES (@nome,@cpf,@telefone)";
                cmd = new MySqlCommand(sql, coon2);
                
                cmd.Parameters.AddWithValue("@nome", txbNomeP.Text);
                cmd.Parameters.AddWithValue("@cpf", txbcepef.Text);
                cmd.Parameters.AddWithValue("@telefone", txbTelP.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Professor Cadastrado Com Sucesso");

                coon2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                coon2.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
