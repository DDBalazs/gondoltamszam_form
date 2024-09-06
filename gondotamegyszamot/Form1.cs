using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gondotamegyszamot
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            txtipp.Enabled = false;
            txkn.Enabled = false;
            bttipp.Visible = false;
            btfelad.Visible = false;
            lb3.Visible = false;
            lb4.Visible = false;
        }

        private void btujj_Click(object sender, EventArgs e)
        {
            btujj.Visible = false;
            btfelad.Visible=true;
            txtipp.Enabled = true;
            bttipp.Visible=true;
            lb3.Visible=true;
            lb4.Visible=true;

            Random rnd = new Random();
            lbgond.Text = Convert.ToString(rnd.Next(1, 51));
        }

        private void btfelad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feladtad! Vesztettél!");
        }
    }
}
