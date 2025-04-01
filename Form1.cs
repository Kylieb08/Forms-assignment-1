using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_assignment_1
{
    public partial class FormGoodBad : Form
    {
        public FormGoodBad()
        {
            InitializeComponent();
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            imgBad.Visible = true;
            imgGood.Visible = false;
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            imgGood.Visible = true;
            imgBad.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            imgGood.Visible = false;
            imgBad.Visible = false;
        }
    }
}
