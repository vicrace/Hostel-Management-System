using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment_Defaultt
{
    public partial class Information_List : Form
    {
        public Information_List()
        {
            InitializeComponent();
        }

        private void Information_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ClosingForm();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            bool numberOnlyResult = Regex.IsMatch(tbxStudentSearch.Text, "^[0-9]*$");
            bool nameResult = Regex.IsMatch(tbxStudentSearch.Text.Trim(), @"^[a-zA-Z]+(([ ][a-zA-Z])?[a-zA-Z])$");
            try
            {
                if (tbxStudentSearch.Text == "" && cmbStudentSearch.Text != "ALL")
                {
                    throw new NoneSearchException();
                }

                else if (cmbStudentSearch.Text == "ROOM" || cmbStudentSearch.Text == "FLOOR" && !numberOnlyResult)
                {
                    throw new NumberOnlyException(tbxStudentSearch.Text);
                }

                else if (cmbStudentSearch.Text == "NAME" && !nameResult)
                {
                    throw new LetterOnlyException(tbxStudentSearch.Text);
                }

                else if (cmbStudentSearch.Text == "ID" && !numberOnlyResult)
                {
                    throw new NumberOnlyException(tbxStudentSearch.Text);
                }

                else
                {
                    Student[] student = Admin.book.SearchStudentInfo(tbxStudentSearch.Text, cmbStudentSearch.Text);
                    var studentList = student;
                    dgvStudentList.DataSource = studentList;
                }
            }

            catch (NoneSearchException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (NumberOnlyException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (LetterOnlyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f = new Admin();
            f.Show();
        }

        private void btnHostelSearch_Click(object sender, EventArgs e)
        {
            bool roomResult = Regex.IsMatch(tbxHostelSearch.Text.Trim(), "^[0-9]*$");

            try
            {
                if (tbxHostelSearch.Text == "" && cmbHostel.Text == "ROOM NUM")
                {
                    throw new NoneSearchException();
                }



                else if (!roomResult)
                {
                    throw new NumberOnlyException(tbxHostelSearch.Text);
                }

                else
                {
                    string input = tbxHostelSearch.Text;
                    int roomNo = 0;
                    if (input != "")
                    {
                        roomNo = Convert.ToInt32(input);
                        Hostel[] hostel = Admin.book.SearchHostelInfo(roomNo, cmbHostel.Text);
                        var hostelList = hostel;
                        dgvHostelList.DataSource = hostelList;
                    }

                    else
                    {
                        Hostel[] hostel = Admin.book.SearchHostelInfo(0, cmbHostel.Text);
                        var hostelList = hostel;
                        dgvHostelList.DataSource = hostelList;
                    }
                }
            }

            catch (NoneSearchException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (NumberOnlyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Information_List_Load(object sender, EventArgs e)
        {

        }
    }
}
