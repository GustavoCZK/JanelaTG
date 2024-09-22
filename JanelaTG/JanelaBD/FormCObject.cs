using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelaBD
{
    public partial class CreateObject : Form
    {
        enum Acoes
        {
            DESENHAR,
            LIMPAR
        }
        private Acoes acao = Acoes.LIMPAR;

        private int count = 1;
        public CreateObject()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Objeto o = new Objeto(tbNome.Text, ckboxPonto, ckboxReta, cbboxPoli, Int32.Parse(cord_X.Text), Int32.Parse(cord_Y.Text), Int32.Parse(cord_Z.Text));

            //FormPrin formPrin = new FormPrin(o.ToString());
            
            tbNome.Text = "";
            cord_X.Text = "";
            cord_Y.Text = "";
            cord_Z.Text = "";
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void cord_X_TextChanged(object sender, EventArgs e)
        {

        }

        private void cord_Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void cord_Z_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbxReta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbxPonto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeWind_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
