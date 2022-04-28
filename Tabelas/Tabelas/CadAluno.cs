using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Tabelas.Commands;
using Tabelas.Entities;

namespace Tabelas
{
    public partial class CadAluno : Form
    {
        private MySqlConnection coon;
        public string data_source = "server=mysql.ispac.com.br;port=3306;database=ispac24;uid=ispac24;password=ispac123";
        public List<string> ListaCursoTemporaria = new List<string>();
        public int contador = 0;

        public CadAluno()
        {
            InitializeComponent();
            PopularSelectBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void txbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCpf_Enter(object sender, EventArgs e)
        {

        }

        private void txbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                coon = new MySqlConnection(data_source);
                coon.Open();

                string sql = "SELECT Cpf,Nome,Telefone FROM Aluno WHERE Cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, coon);

                cmd.Parameters.AddWithValue("@cpf", txbCpf.Text);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    txbNome.Text = dr.GetString(1);
                    txbTelefone.Text = dr.GetString(2);
                    txbNome.Focus();
                    return;
                }
                LimparDados();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ListaCursoTemporaria.Add(comboBox1.SelectedItem.ToString());
            MessageBox.Show(ListaCursoTemporaria.ToString());
        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCpf.ValidaCPF.IsCpf(txbCpf.Text))
            {
                MessageBox.Show("Cpf Invalido!");
                return;
            }

            try
            {
                coon = new MySqlConnection(data_source);
                coon.Open();

                string sql = "SELECT Cpf FROM Aluno WHERE Cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, coon);

                cmd.Parameters.AddWithValue("@cpf", txbCpf.Text);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DialogResult confirm = MessageBox.Show("Aluno já cadastrado, deseja alterar os dados ?", "Menssagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        coon.Close();

                        coon.Open();

                        sql = "UPDATE Aluno SET Nome = @nome, Telefone = @telefone WHERE Cpf = @cpf";
                        cmd = new MySqlCommand(sql, coon);

                        cmd.Parameters.AddWithValue("@cpf", txbCpf.Text);
                        cmd.Parameters.AddWithValue("@nome", txbNome.Text);
                        cmd.Parameters.AddWithValue("@telefone", txbTelefone.Text);
                        cmd.ExecuteNonQuery();

                        coon.Close();

                        MessageBox.Show("Dados Alterados com sucesso");

                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                coon.Close();
                coon.Open();

                sql = "INSERT INTO Aluno (Cpf,Nome,Telefone) VALUES (@cpf,@nome,@telefone)";
                cmd = new MySqlCommand(sql, coon);

                cmd.Parameters.AddWithValue("@cpf", txbCpf.Text);
                cmd.Parameters.AddWithValue("@nome", txbNome.Text);
                cmd.Parameters.AddWithValue("@telefone", txbTelefone.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno Cadastrado Com Sucesso");
                coon.Close();
                LimparDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                coon.Close();
            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void LimparDados()
        {
            txbCpf.Clear();
            txbNome.Clear();
            txbTelefone.Clear();
            txbCpf.Focus();
        }

        public void PopularSelectBox()
        {
            coon = new MySqlConnection(data_source);
            coon.Open();
            string sql = "SELECT * FROM Curso";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, coon);
            DataTable set = new DataTable();
            set.Clear();
            da.Fill(set);
            List<Curso> listaCurso = new List<Curso>();

            foreach (DataRow datarow in set.Rows)
            {
                var cursos = new Curso()
                {
                    Id = 1,
                };

                listaCurso.Add(cursos);
            }

            foreach (DataRow datarow in set.Rows)
            {
                listaCurso.Add(new Curso() { Id = datarow.});
            }

        }

    }

    //    if (dr.HasRows)
    //    {
    //        dr.Read();
    //        var listaCursos = new List<Curso>
    //        {

    //            listaCursos.Add(dr.GetString(0).ToString());
    //            txbTelefone.Text = dr.GetString(2);
    //            txbNome.Focus();
    //            return;
    //    }
    //}

    ////coon = new MySqlConnection(data_source);
    ////coon.Open();
    ////string sql = "SELECT * FROM Curso";
    ////MySqlDataAdapter da = new MySqlDataAdapter(sql , coon);
    ////DataTable set = new DataTable();
    ////set.Clear();
    ////comboBox1.DataSource = null;
    ////da.Fill(set);
    ////comboBox1.DataSource = set;
    ////comboBox1.ValueMember = "Id";
    ////comboBox1.DisplayMember = "Nome";
    ////comboBox1.SelectedItem = null;
    ////comboBox1.Refresh();


    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
    {

    }
}
}

