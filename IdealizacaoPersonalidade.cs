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
    public partial class IdealizacaoPersonalidade : Form
    {
        public IdealizacaoPersonalidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO BigFiveParIdeal(BF1, BF2, BF3, BF4, BF5, BF6, BF7, BF8, BF9, BF10, BF11, BF12, BF13, BF14, BF15, BF16, BF17, BF18, BF19, BF20, BF21, BF22, BF23, BF24, BF25, BF26, BF27, BF28, BF29, BF30, BF31, BF32, BF33, BF34, BF35, BF36, BF37, BF38, BF39, BF40, BF41, BF42, BF43, BF44) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "','" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + textBox41.Text + "','" + textBox42.Text + "','" + textBox43.Text + "','" + textBox44.Text + "')", Conexao);
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
            Agradecimento newAgradecimento2 = new Agradecimento();
            newAgradecimento2.ShowDialog();
        }
    }
}
