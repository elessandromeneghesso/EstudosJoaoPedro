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
    public partial class CadCurso : Form
    {
        private MySqlConnection coon;
        private string data_source = "server=mysql.ispac.com.br;port=3306;database=ispac24;uid=ispac24;password=ispac123";
        private int contador = 0;

        public CadCurso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                coon = new MySqlConnection(data_source);
                coon.Open();

                //string sql = "SELECT Id FROM Curso WHERE Id = @id";
                //MySqlCommand cmd = new MySqlCommand(sql, coon);
                //cmd.Parameters.AddWithValue("@id", txbIdCurso.Text);
                //MySqlDataReader dr = cmd.ExecuteReader();
                
                //if (dr.HasRows)
                //{
                //    DialogResult confirm = MessageBox.Show("Curso já cadastrado, deseja alterar os dados ?", "Menssagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                //    if (confirm.ToString().ToUpper() == "YES")
                //    {
                //        coon.Close();

                //        coon.Open();

                //        sql = "UPDATE Curso SET Nome = @nome, Periodo = @periodo WHERE Id = @id";
                //        cmd = new MySqlCommand(sql, coon);

                //        cmd.Parameters.AddWithValue("@nome", txbNomeC.Text);
                //        cmd.Parameters.AddWithValue("@periodo", cbPeriodo.SelectedItem);
                //        cmd.ExecuteNonQuery();

                //        coon.Close();

                //        MessageBox.Show("Dados Alterados com sucesso");

                //        return;
                //    }
                //    else
                //    {
                //        return;
                //    }
                //}


                string sql = "SELECT MAX(Id) FROM Curso";
                MySqlCommand cmd = new MySqlCommand(sql, coon);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int idCurso = 0;
                idCurso = dr.GetInt32(0);
                idCurso++;

                coon.Close();
                coon.Open();

                sql = "INSERT INTO Curso (Id,Nome,Periodo) VALUES (@id,@nome,@periodo)";
                cmd = new MySqlCommand(sql, coon);
                
                cmd.Parameters.AddWithValue("@id", idCurso);
                cmd.Parameters.AddWithValue("@nome", txbNomeC.Text);
                cmd.Parameters.AddWithValue("@periodo", cbPeriodo.Text);
                cmd.ExecuteNonQuery();

                coon.Close();

                MessageBox.Show("Curso Cadastrado Com Sucesso. Codigo do Curso: ", idCurso.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                coon.Close();
            }
        }

        private void txbNomeC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Curso_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbIdCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIdCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txbNomeC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                coon = new MySqlConnection(data_source);
                coon.Open();

                string sql = "SELECT Id,Nome,Periodo FROM Curso WHERE Nome = @nome";
                MySqlCommand cmd = new MySqlCommand(sql, coon);

                cmd.Parameters.AddWithValue("@nome", txbNomeC.Text);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    txbIdCurso.Text = dr.GetString(0);
                    cbPeriodo.Text = dr.GetString(2);
                    txbNomeC.Focus();
                    return;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }    
}


