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
    public partial class Sociodemografico4 : Form
    {
        public Sociodemografico4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDoCombo12 = comboBox12.SelectedItem.ToString();
            string valorDoCombo1 = comboBox1.SelectedItem.ToString();
            string valorDoCombo2 = comboBox2.SelectedItem.ToString();
            string valorDoCombo3 = comboBox3.SelectedItem.ToString();
            string valorDoCombo4 = comboBox4.SelectedItem.ToString();
            string valorDoCombo5 = comboBox5.SelectedItem.ToString();
            string valorDoCombo6 = comboBox6.SelectedItem.ToString();
            string valorDoCombo7 = comboBox7.SelectedItem.ToString();
            string valorDoCombo8 = comboBox8.SelectedItem.ToString();

            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO TbSociodemografico4(Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24) VALUES ('" + valorDoCombo12 + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + valorDoCombo1 + "','" + textBox5.Text + "','" + valorDoCombo2 + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + valorDoCombo3 + "','" + valorDoCombo4 + "','" + valorDoCombo5 + "','" + valorDoCombo6 + "','" + valorDoCombo7 + "','" + valorDoCombo8 + "')", Conexao);
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
            IdealizacaoParceiro2 newIdealizacaoParceiro2 = new IdealizacaoParceiro2();
            newIdealizacaoParceiro2.ShowDialog();
        }
    }
}
