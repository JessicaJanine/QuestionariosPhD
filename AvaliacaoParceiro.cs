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
    public partial class AvaliacaoParceiro : Form
    {
        public AvaliacaoParceiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorTrackBar1 = trackBar3.Value.ToString();
            string valorDoCombo1 = comboBox19.SelectedItem.ToString();
            string valorDoCombo2 = comboBox20.SelectedItem.ToString();
            string valorDoCombo3 = comboBox21.SelectedItem.ToString();
            string valorDoCombo4 = comboBox22.SelectedItem.ToString();
            string valorDoCombo5 = comboBox23.SelectedItem.ToString();
            string valorDoCombo6 = comboBox24.SelectedItem.ToString();
            string valorDoCombo7 = comboBox25.SelectedItem.ToString();
            string valorDoCombo8 = comboBox26.SelectedItem.ToString();
            string valorDoCombo9 = comboBox27.SelectedItem.ToString();

            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\QCH\\BancoDoutorado.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO tbAvaliacaoParceiro(Rosto, Corpo, Saúde, Financeiro, Sociavel, Trabalhador, Inteligente, Humor, Fiel, Atratividade) VALUES ('" + valorDoCombo1 + "','" + valorDoCombo2 + "','" + valorDoCombo3 + "','" + valorDoCombo4 + "','" + valorDoCombo5 + "','" + valorDoCombo6 + "','" + valorDoCombo7 + "','" + valorDoCombo8 + "','" + valorDoCombo9 + "','" + valorTrackBar1 + "')", Conexao);
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
            IdealizacaoParceiro newIdealizacaoParceiro = new IdealizacaoParceiro();
            newIdealizacaoParceiro.ShowDialog();
        }
    }
}
