using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_Defaultt
{
    public partial class Main : Form
    {
        public static ArrayList adminlist = new ArrayList();
        public static object user = null;
        public static bool is_Showed = false;
        public Main()
        {
            InitializeComponent();
            Form form = new Form();
            form.BackColor = Color.BlueViolet;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AdminRead();

            if (!File.Exists("StudentList.txt") && !File.Exists("HostelList.txt"))
            {
                FileStream fs = File.Create("StudentList.txt");
                fs.Close();
                FileStream f = File.Create("HostelList.txt");
                f.Close();
            }

            if (File.Exists("StudentList.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("StudentList.txt");
                    int lineNo = 0;
                    string[] studentinfo = new string[5];
                    string line = reader.ReadLine();
                    while (line != null && lineNo != (Admin.book.StudentList.Length - 1))
                    {
                        studentinfo = line.Split('/');
                        Admin.book.StudentList[lineNo] = new Student(studentinfo[0], studentinfo[1], studentinfo[2], Convert.ToInt32(studentinfo[3]), Convert.ToInt32(studentinfo[4]));
                        lineNo++;
                        line = reader.ReadLine();
                    }
                    reader.Close();
                }
                catch (IOException exc)
                {
                    MessageBox.Show("File Error: " + exc.Message);
                }
            }

            if (File.Exists("HostelList.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("HostelList.txt");
                    string line = reader.ReadLine();
                    string[] hostelinfo = new string[3];
                    int numberofHostel = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (line != null && numberofHostel != (Admin.book.HostelRoomList.Length - 1))
                            {
                                hostelinfo = line.Split('/');

                                if (hostelinfo[1] != "")
                                    Admin.book.NumberOfBooking++;
                                else
                                    hostelinfo[1] = null;

                                Admin.book.HostelRoomList[j, k] = new Hostel(Convert.ToInt32(hostelinfo[0]), hostelinfo[1], Convert.ToBoolean(hostelinfo[2]));
                                numberofHostel++;
                                line = reader.ReadLine();
                            }
                        }
                    }
                    reader.Close();
                }
                catch (IOException exc)
                {
                    MessageBox.Show("File Error: " + exc.Message);
                }
            }
        }
        /* load our text file here (stream file code) , because if we put it into the admin form, 
        it will load back the old text file everytime we return back to it.*/
        public static void AdminRead()//read Admin list txt file into the program
        {
            if (!File.Exists("AdminList.txt"))
            {
                FileStream f = File.Create("AdminList.txt");
                f.Close();
            }

            if (File.Exists("AdminList.txt"))
            {
                adminlist.Clear();

                StreamReader reader = new StreamReader("AdminList.txt");
                string[] admininfo = new string[4];
                string line = reader.ReadLine();

                while (line != null)
                {
                    admininfo = line.Split('*');

                    if (admininfo[2] == "NORMAL")
                    {
                        NormalAdmin norad = new NormalAdmin(admininfo[0], admininfo[1], admininfo[2],
                            Convert.ToDateTime(admininfo[3]));

                        adminlist.Add(norad);
                    }
                    else if (admininfo[2] == "ADVANCE")
                    {
                        AdvancedAdmin norad = new AdvancedAdmin(admininfo[0], admininfo[1], admininfo[2],
                             Convert.ToDateTime(admininfo[3]));

                        adminlist.Add(norad);
                    }

                    line = reader.ReadLine();
                }

                reader.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxID.Text == "" || tbxPassword.Text == "")
                {
                    throw new NullException();
                }

                else
                {
                    if (rbnAdvance.Checked)
                    {
                        string id = Convert.ToString(tbxID.Text);
                        string password = Convert.ToString(tbxPassword.Text);

                        AdvancedAdmin admin = new AdvancedAdmin(tbxID.Text, tbxPassword.Text, "ADVANCE");
                        string login = admin.login(adminlist, (object)admin);

                        if (login == "true")
                        {
                            user = admin;
                            this.Hide();
                            Admin f = new Admin();
                            f.Show();
                        }
                        else if (login == "password")
                            MessageBox.Show("Invalid Password"); // all message box can turn into exception
                        else if (login == "username")
                            MessageBox.Show("Invalid Username");
                        else if (login == "status")
                            MessageBox.Show("Invalid Privilage");
                        else if (login == "none")
                            MessageBox.Show("Admin account not exist");
                    }

                    if (rbnNormal.Checked)
                    {
                        string id = Convert.ToString(tbxID.Text);
                        string password = Convert.ToString(tbxPassword.Text);

                        NormalAdmin admin = new NormalAdmin(tbxID.Text, tbxPassword.Text, "NORMAL");
                        string login = admin.login(adminlist, (object)admin);

                        if (login == "true")
                        {
                            user = admin;
                            this.Hide();
                            Admin f = new Admin();
                            f.Show();
                        }
                        else if (login == "password")
                            MessageBox.Show("Invalid Password");
                        else if (login == "username")
                            MessageBox.Show("Invalid Username");
                        else if (login == "status")
                            MessageBox.Show("Invalid Privilage");
                        else if (login == "none")
                            MessageBox.Show("Admin account not exist");
                    }
                }
            }
            
            catch(NullException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void ClosingForm()
        {
            AdminWrite();

            if (File.Exists("StudentList.txt"))
            {
                try
                {
                    StreamWriter writer = new StreamWriter("StudentList.txt", false);
                    int i = 0;

                    while (Admin.book.StudentList[i] != null)
                    {
                        string studentinfo = String.Format("{0}/{1}/{2}/{3}/{4}", Admin.book.StudentList[i].Name,
                            Admin.book.StudentList[i].Id, Admin.book.StudentList[i].StudySemester,
                            Admin.book.StudentList[i].HostelRoom, Admin.book.StudentList[i].HostelFloor);

                        writer.WriteLine(studentinfo);
                        i++;
                    }
                    writer.Close();
                }
                catch (IOException exc)
                {
                    MessageBox.Show("File Error: " + exc.Message);
                }
            }

            if (File.Exists("HostelList.txt"))
            {

                try
                {
                    StreamWriter writer = new StreamWriter("HostelList.txt", false);

                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (Admin.book.HostelRoomList[j, k] != null)
                            {
                                string hostelinfo = String.Format("{0}/{1}/{2}",
                                    Admin.book.HostelRoomList[j, k].RoomNumber,
                                    Admin.book.HostelRoomList[j, k].RoomOccupant,
                                    Admin.book.HostelRoomList[j, k].RoomStatus);

                                writer.WriteLine(hostelinfo);

                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    writer.Close();
                }
                catch (IOException exc)
                {
                    MessageBox.Show("File Error: " + exc.Message);
                }
            }

            System.Windows.Forms.Application.Exit();
        }

        public static void AdminWrite()//write data into Admin list txt file
        {
            if (File.Exists("AdminList.txt"))
            {
                StreamWriter writer = new StreamWriter("AdminList.txt");
                int i = 0;

                while (i < adminlist.Count)
                {
                    if (adminlist[i] is NormalAdmin)
                    {
                        NormalAdmin norm = (NormalAdmin)adminlist[i];
                        string admininfo = String.Format("{0}*{1}*{2}*{3}", norm.Username, norm.Password,
                            norm.Status, norm.RegisterDate.ToString());

                        writer.WriteLine(admininfo);
                    }
                    else if (adminlist[i] is AdvancedAdmin)
                    {
                        AdvancedAdmin norm = (AdvancedAdmin)adminlist[i];
                        string admininfo = String.Format("{0}*{1}*{2}*{3}", norm.Username, norm.Password,
                            norm.Status, norm.RegisterDate.ToString());

                        writer.WriteLine(admininfo);
                    }
                    


                    i++;
                }

                writer.Close();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) // save our stream file here
        {
            ClosingForm();
            if (is_Showed == false)
            {
                MessageBox.Show("The App is closing");
                is_Showed = true;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAdmin f = new CreateAdmin();
            f.Show();
        }

        private void BtnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:\n- Chan Jia Lin\n- Goh Way Siang\n- Milton Choo Xin Hong\n- Tan Carlson\n- Tan Eong Seang");
        }
    }
}
