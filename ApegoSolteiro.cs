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
    public partial class ApegoSolteiro : Form
    {
        public ApegoSolteiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO tbApegoSolteiro(A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21, A22, A23, A24, A25, A26, A27, A28, A29, A30, A31, A32, A33, A34, A35, A36) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "')", Conexao);
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
            AutoavaliacaoSolteiro newAutoavaliacaoSolteiro = new AutoavaliacaoSolteiro();
            newAutoavaliacaoSolteiro.ShowDialog();
        }
    }
}
