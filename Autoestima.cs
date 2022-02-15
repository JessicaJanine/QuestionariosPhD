using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doutorado
{
    public partial class Autoestima : Form
    {
        public Autoestima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO tbAutoestimaCasal (AE1, AE2, AE3, AE4, AE5, AE6, AE7, AE8, AE9,AE10) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", Conexao);
            try
            {
                Conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                throw;
            }
            finally
            {
                Conexao.Close();
            }
            
            Close();
            Sociossexualidade newSociossexualidade = new Sociossexualidade();
            newSociossexualidade.ShowDialog();
        }

        private void Autoestima_Load(object sender, EventArgs e)
        {

        }
    }
}
