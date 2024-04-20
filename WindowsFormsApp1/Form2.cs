using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\logindatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (sighnup_email.Text == "" || sighnup_pass.Text == "" || signup_username.Text == "")
            {
                MessageBox.Show("please enter the blanks");
            }

            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM accounts WHERE username = '"
                            + signup_username.Text.Trim() + "'";// accounts is our table name
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + "already exists");
                            }
                            else
                            {
                                string insertData = "INSERT INTO accounts (email, username, password, date_created) " +
                                    "VALUES(@email, @username, @pass, @date)";
                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", sighnup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", sighnup_pass.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("registerd sucessfuly", "information message");

                                    // to switch to the form
                                    Form1 form1 = new Form1();
                                    form1.Show();
                                    this.Hide();
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error connecting database " + ex, "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showpass.Checked)
            {
                sighnup_pass.PasswordChar = '\0';
            }
            else
            {
                sighnup_pass.PasswordChar = '*';
            }
        }
    }
}
