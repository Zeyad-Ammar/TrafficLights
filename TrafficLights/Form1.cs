using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTraficLight1.ctrlStart();
        }

        private void ctrlTraficLight1_onGreenLight(object sender, ctrlTraficLight.CustomEventArgs e)
        {
            MessageBox.Show(e.Color.ToString());
        }

        private void ctrlTraficLight1_onYellowLight(object sender, ctrlTraficLight.CustomEventArgs e)
        {
            MessageBox.Show(e.Color.ToString());
        }


        private void ctrlTraficLight1_onRedLight(object sender, ctrlTraficLight.CustomEventArgs e)
        {
            MessageBox.Show(e.Color.ToString());
        }
    }
}
