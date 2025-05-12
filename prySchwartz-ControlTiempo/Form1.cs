using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySchwartz_ControlTiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nomBoton = "Trabajo";
        int segundos = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            btn.Text = "Trabajo";
            timer.Interval = 1000;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblTimepo.Text = segundos.ToString();
        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            if (btn.Text == nomBoton)
            {
                segundos = 0;
                lblTimepo.Text = "0 segundos";
                lblTimepo.Visible = true;
                timer.Start();
                btn.Text = "Finalizar";
                btn.BackColor = Color.Red;

            }
            else
            {
                lblTimepo.Visible = false;
                timer.Stop();
                btn.Text = "Trabajo";
                btn.BackColor = Color.White;
                MessageBox.Show($"Pasaron {segundos} segundos.", "Tiempo transcurrido");
            }
        }
    }
}
