using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Defaultt
{
    public partial class CreateAdmin : Form
    {
        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void CreateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ClosingForm();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Main.AdminWrite();
            this.Hide();
            Main f = new Main();
            f.Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                int create = 2;

                if (tbxusername.Text == "" || tbxpassword.Text == "")
                {
                    throw new NullException();
                }

                else
                {
                    if (rbnadvance.Checked)
                    {
                        AdvancedAdmin admin = new AdvancedAdmin(tbxusername.Text, tbxpassword.Text, "ADVANCE");
                        create = admin.createaccount(Main.adminlist, (object)admin, tbxstaffid.Text);
                    }

                    if (rbnnormal.Checked)
                    {
                        NormalAdmin admin = new NormalAdmin(tbxusername.Text, tbxpassword.Text, "NORMAL");
                        create = admin.createaccount(Main.adminlist, (object)admin, tbxstaffid.Text);
                    }
                }

                tbxusername.Text = "";
                tbxpassword.Text = "";
                tbxstaffid.Text = "";

                if (create == 1)
                    MessageBox.Show("ACCOUNT CREATED SUCCESSFULLY");
                else if (create == -1)
                    MessageBox.Show("You have no privilage to register advance admin account");
                else if (create == 0)
                    MessageBox.Show("Duplicated Account");
            }

            catch (NullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblprivilege_Click(object sender, EventArgs e)
        {
            AdvancedAdmin ada = new AdvancedAdmin("", "", "ADVANCE");
            NormalAdmin adn = new NormalAdmin("", "", "NORMAL");

            rtbadvance.Visible = true;
            rtbnormal.Visible = true;

            rtbnormal.Text = ada.displayprivilage();
            rtbadvance.Text = adn.displayprivilage();
        }
    }
}
