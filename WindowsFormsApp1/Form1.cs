using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\logindatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_register_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showpas_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpas.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("please fill the blank");
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM accounts WHERE username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {

                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@password", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("you are logged in");

                                Form3 form3 = new Form3();
                                form3.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("incorrect username and password");
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error connecting:" + ex, "error message");
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
