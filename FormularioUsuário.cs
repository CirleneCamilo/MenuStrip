using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class FormularioUsuário : Form
    {
        public FormularioUsuário()
        {
            InitializeComponent();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            //this - próprio objeto : fechar essa janela
            DialogResult resposta = MessageBox.Show("Deseja realmente fechar ? ", "ATENÇÃO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void DataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGV.DataSource = Cads_Usuario.lista();
        }
    }
}
