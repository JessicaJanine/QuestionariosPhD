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
    public partial class Sociossexualidade : Form
    {
        public Sociossexualidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDoCombo1 = comboBox1.SelectedItem.ToString();
            string valorTrackBar1 = trackBar1.Value.ToString();
            string valorTrackBar2 = trackBar2.Value.ToString();
            string valorTrackBar3 = trackBar3.Value.ToString();

            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO TbSociossexualidade(S1, S2, S3, S4, S5, S6, S7) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + valorDoCombo1 + "','" + valorTrackBar1 + "','" + valorTrackBar2 + "','" + valorTrackBar3 + "')", Conexao);
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
            Sociodemografico1 newSociodemografico1 = new Sociodemografico1();
            newSociodemografico1.ShowDialog();
        }
    }
}
