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
    public partial class Sociodemografico3 : Form
    {
        public Sociodemografico3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDoCombo1 = comboBox1.SelectedItem.ToString();
            string valorDoCombo2 = comboBox2.SelectedItem.ToString();
            string valorDoCombo3 = comboBox3.SelectedItem.ToString();
            string valorDoCombo4 = comboBox4.SelectedItem.ToString();
            string valorDoCombo5 = comboBox5.SelectedItem.ToString();
            string valorDoCombo6 = comboBox6.SelectedItem.ToString();
            string valorDoCombo7 = comboBox7.SelectedItem.ToString();
            string valorDoCombo8 = comboBox8.SelectedItem.ToString();
            string valorDoCombo9 = comboBox9.SelectedItem.ToString();
            string valorDoCombo10 = comboBox10.SelectedItem.ToString();
            string valorDoCombo11 = comboBox11.SelectedItem.ToString();
            string valorDoCombo12 = comboBox12.SelectedItem.ToString();
            string valorDoCombo13 = comboBox13.SelectedItem.ToString();
            string valorDoCombo14 = comboBox14.SelectedItem.ToString();
            string valorDoCombo15 = comboBox15.SelectedItem.ToString();
            string valorDoCombo16 = comboBox16.SelectedItem.ToString();
            string valorDoCombo17 = comboBox17.SelectedItem.ToString();
            string valorDoCombo18 = comboBox18.SelectedItem.ToString();
            string valorDoCombo19 = comboBox19.SelectedItem.ToString();
            string valorDoCombo20 = comboBox20.SelectedItem.ToString();
            string valorDoCombo21 = comboBox21.SelectedItem.ToString();

            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO TbSociodemografico3(Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25) VALUES ('" + valorDoCombo1 + "','" + valorDoCombo2 + "','" + valorDoCombo3 + "','" + valorDoCombo4 + "','" + valorDoCombo5 + "','" + valorDoCombo6 + "','" + valorDoCombo7 + "','" + valorDoCombo8 + "','" + valorDoCombo9 + "','" + valorDoCombo10 + "','" + valorDoCombo11 + "','" + valorDoCombo12 + "','" + valorDoCombo13 + "','" + valorDoCombo14 + "','" + valorDoCombo15 + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + valorDoCombo16 + "','" + textBox4.Text + "','" + valorDoCombo17 + "' ,'" + valorDoCombo18 + "' ,'" + valorDoCombo19 + "' ,'" + valorDoCombo20 + "','" + valorDoCombo21 + "')", Conexao);
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
            Sociodemografico4 newSociodemografico4 = new Sociodemografico4();
            newSociodemografico4.ShowDialog();
        }
    }
}
