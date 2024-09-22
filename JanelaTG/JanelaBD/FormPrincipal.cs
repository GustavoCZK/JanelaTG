using JanelaBD.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JanelaBD
{
    public partial class FormPrin : Form
    {
        enum Acoes
        {
            DESENHAR,
            LIMPAR
        }
        private Acoes acao = Acoes.LIMPAR;

        private int count = 1;
        public FormPrin()
        {
            InitializeComponent();

        }

        private List<Entities.Point> points = new List<Entities.Point>();
        private int DrawIndex = -1; 
        private bool active_drawing = false;

        public FormPrin(string o)
        {
            InitializeComponent();
            lbObjetos.Items.Add(o);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CheckBox cbp = cbPonto;
            CheckBox cbr = cbReta;
            CheckBox cbpl = cbPoli;

            if (cbp.Checked == true || cbr.Checked == true || cbpl.Checked == true)
            {
                Objeto o = new Objeto(boxName.Text, cbPonto, cbReta, cbPoli, Int32.Parse(corX.Text), Int32.Parse(corY.Text), Int32.Parse(corZ.Text));
                lbObjetos.Items.Add(o);

                boxName.Text = "";
                corX.Text = "";
                corY.Text = "";
                corZ.Text = "";


                acao = Acoes.DESENHAR;
                pbCaixaDesenho.Invalidate();

            }
            else if (cbp.Checked == false && cbr.Checked == false && cbpl.Checked == false)
            {
                MessageBox.Show("Selecione Um Tipo De Desenho!");
            }
            else
            {
                MessageBox.Show("Selecione Somente Um Tipo!");
            }

            // CreateObject createObject = new CreateObject();
            // createObject.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int posicao = lbObjetos.SelectedIndex;
            if (posicao != -1)
            {
                lbObjetos.Items.RemoveAt(lbObjetos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            acao = Acoes.LIMPAR;
            lbObjetos.Items.Clear();
            pbCaixaDesenho.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbCaixaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen caneta = new Pen(Color.Black, 5);
            Brush Pincel = new SolidBrush(Color.Black);

            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(50.0F, 150.0F);
            PointF point3 = new PointF(150.0F, 150.0F);

            PointF[] curvepoints = { point1, point2, point3 };

            System.ComponentModel.TypeConverter converter =
            System.ComponentModel.TypeDescriptor.GetConverter(typeof(int));

            //int port1 = (int)converter.ConvertFromString(corX.Text);
            //int port2 = (int)converter.ConvertFromString(corY.Text);


            // ZOOM
            // g.TranslateTransform((float)pbCaixaDesenho.Width / 2, (float)pbCaixaDesenho.Height / 2);

            e.Graphics.SetParameters(pbCaixaDesenho.Height);
            if (points.Count > 0)
            {
                foreach (Entities.Point p in points)
                {
                    e.Graphics.DrawPoint(new Pen(Color.Red, 0), p);
                }
            }



            if (acao == Acoes.DESENHAR)
            {
                if (cbPonto.Checked == true && cbReta.Checked == false && cbPoli.Checked == false)
                {
                    g.FillEllipse(Pincel, 5, 5, 10, 10);
                }
                else if (cbPonto.Checked == false && cbReta.Checked == true && cbPoli.Checked == false)
                {
                   //  g.DrawLine(caneta,
                       //          new Point((int)20, (int)20),
                        //         new Point((int)100, (int)100));
                }
                else
                {
                    g.DrawPolygon(caneta, curvepoints);
                }
            }
            else if (acao == Acoes.LIMPAR)
            {
                g.Clear(SystemColors.ActiveCaption);
            }

            // Desenha uma borda
            g.DrawRectangle(caneta, 0, 0,
                        pbCaixaDesenho.Width - 1,
                        pbCaixaDesenho.Height - 1);

            System.Diagnostics.Debug.WriteLine(count++);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {

        }

        private void cbPonto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textnumX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbPoli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private Vector3 currentPosition;

        private void pbCaixaDesenho_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            cordenate.Text = string.Format("{0},{1}", currentPosition.X, currentPosition.Y);
        }

        // Get Screen DPI
        private float DPI
        {
            get
            {
                using (var g = CreateGraphics())
                    return g.DpiX;
            }
        }

        // Convert system point

        private Vector3 PointToCartesian(PointF point)
        {

            return new Vector3(-((pbCaixaDesenho.Width / 2) - point.X), (pbCaixaDesenho.Height / 2) - point.Y);
        }

        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (active_drawing)
                {
                    switch (DrawIndex)
                    {
                        case 0://Point
                            points.Add(new Entities.Point(currentPosition));
                            break;
                    }
                    pbCaixaDesenho.Refresh();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DrawIndex = 0;
            active_drawing = true;
            pbCaixaDesenho.Cursor = Cursors.Cross;
        }
    }

}
