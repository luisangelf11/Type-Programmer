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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DarkModeStylesControls()
        {
            this.BackColor = Color.FromArgb(32, 46, 68);
            txtName.BackColor = Color.FromArgb(32, 46, 68);
            txtName.ForeColor = Color.White;
            txtAge.BackColor = Color.FromArgb(32, 46, 68);
            txtAge.ForeColor = Color.White;
            txtLast.BackColor = Color.FromArgb(32, 46, 68);
            txtLast.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            gbData.ForeColor = Color.White;
            gbLanguage.ForeColor = Color.White;
        }

        private void NormalModeStylesControles()
        {
            this.BackColor = Color.White;
            txtAge.ForeColor = Color.Black;
            txtAge.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.Black;
            txtLast.ForeColor = Color.Black;
            txtLast.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            gbData.ForeColor = Color.Black;
            gbLanguage.ForeColor = Color.Black;
        }
        private void swDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (swDarkMode.Checked == false)
            {
                NormalModeStylesControles();
            }
            else if (swDarkMode.Checked == true)
            {
                DarkModeStylesControls();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.TabIndex = 0;
            btnSend.Focus();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name") txtName.Text = "";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "") txtName.Text = "Name";
        }

        private void txtLast_Enter(object sender, EventArgs e)
        {
            if (txtLast.Text == "Last Name") txtLast.Text = "";
        }

        private void txtLast_Leave(object sender, EventArgs e)
        {
            if (txtLast.Text == "") txtLast.Text = "Last Name";
        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "Age") txtAge.Text = "";
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "") txtAge.Text = "Age";
        }

        private void ClearCheckedAndTextBox()
        {
            chCSharp.Checked = false;
            chCss.Checked = false;
            chGo.Checked = false;
            chHtml.Checked = false;
            chJava.Checked = false;
            chJS.Checked = false;
            chPhp.Checked = false;
            chPython.Checked = false;
            txtAge.Text = "Age";
            txtLast.Text = "Last Name";
            txtName.Text = "Name";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCheckedAndTextBox();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtAge.Text != "Age" && txtLast.Text != "Last Name" && txtName.Text !="Name")
            {
                string typeProgrammer = "None";

                if (chHtml.Checked == false && chCss.Checked == false)
                {
                    typeProgrammer = "Back-end Developer";
                }
                else if ((chCSharp.Checked == false && chGo.Checked == false && chJava.Checked == false && chPhp.Checked == false && chPython.Checked == false) && chCss.Checked == true && chHtml.Checked == true && chJS.Checked == true)
                {
                    typeProgrammer = "Front-end Developer";
                }
                else if (chCSharp.Checked == false && chGo.Checked == false && chJava.Checked == false && chPhp.Checked == false && chPython.Checked == false && chJS.Checked == false)
                {
                    typeProgrammer = "Web Designer";
                }
                else if ((chPython.Checked != false || chPhp.Checked != false || chGo.Checked != false || chCSharp.Checked != false || chJava.Checked != false) && chHtml.Checked == true && chCss.Checked == true && chJS.Checked == true)
                {
                    typeProgrammer = "Full-Stack Developer";
                }
                else if ((chJS.Checked !=false || chPython.Checked != false || chPhp.Checked != false || chGo.Checked != false || chCSharp.Checked != false || chJava.Checked != false) && chHtml.Checked == true && chCss.Checked)
                {
                    typeProgrammer = "Web Designer and Back-end Developer";
                }

                //...
                DialogResult dialog = new DialogResult();
                Stats stats = new Stats(txtName.Text + " " + txtLast.Text + " of " + txtAge.Text + " years old, is a programmer " + typeProgrammer);
                dialog = stats.ShowDialog();
            }
            else
            {
                DialogResult dialog = new DialogResult();
                Notification notification = new Notification();
                dialog = notification.ShowDialog();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
