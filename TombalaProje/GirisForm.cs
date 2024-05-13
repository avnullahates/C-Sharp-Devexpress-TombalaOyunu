using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TombalaProje
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }


        
        private void GirisForm_Load(object sender, EventArgs e)
        {
            

            foreach (Label x in this.gbOyuncuLabel.Controls)
            {
                x.Visible = false;
            }



            foreach (TextBox x in this.gbOyuncuText.Controls)
            {
                x.Visible = false;
            }

        }

        private void cbOyuncuAdet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSecilenIndex.Text = cbOyuncuAdet.SelectedIndex.ToString();
            IsimGosterme();
        }

        
        void IsimGosterme()
        {
            if (cbOyuncuAdet.SelectedIndex == 0)
            {
                lblIsim1.Visible = Enabled;
                txtIsim1.Visible = Enabled;
                lblIsim2.Visible = false;
                txtIsim2.Visible = false;
                lblIsim3.Visible = false;
                txtIsim3.Visible = false;
                lblIsim4.Visible = false;
                txtIsim4.Visible = false;
            }
            else if (cbOyuncuAdet.SelectedIndex == 1)
            {
                lblIsim1.Visible = Enabled;
                txtIsim1.Visible = Enabled;
                lblIsim2.Visible = Enabled;
                txtIsim2.Visible = Enabled;
                lblIsim3.Visible = false;
                txtIsim3.Visible = false;
                lblIsim4.Visible = false;
                txtIsim4.Visible = false;
            }
            else if (cbOyuncuAdet.SelectedIndex == 2)
            {
                lblIsim1.Visible = Enabled;
                txtIsim1.Visible = Enabled;
                lblIsim2.Visible = Enabled;
                txtIsim2.Visible = Enabled;
                lblIsim3.Visible = Enabled;
                txtIsim3.Visible = Enabled;
                lblIsim4.Visible = false;
                txtIsim4.Visible = false;
            }
            else if (cbOyuncuAdet.SelectedIndex == 3)
            {
                lblIsim1.Visible = Enabled;
                txtIsim1.Visible = Enabled;
                lblIsim2.Visible = Enabled;
                txtIsim2.Visible = Enabled;
                lblIsim3.Visible = Enabled;
                txtIsim3.Visible = Enabled;
                lblIsim4.Visible = Enabled;
                txtIsim4.Visible = Enabled;
            }

        }
    }
}
