using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerSalary
{
    public partial class Stats : Form
    {
        public Stats(string msj)
        {
            InitializeComponent();
            lblText.Text = msj;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            TransitionShow.Show(this);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
