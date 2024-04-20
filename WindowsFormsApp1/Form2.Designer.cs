namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_loginhere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showpass = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sighnup_pass = new System.Windows.Forms.TextBox();
            this.sighnup_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 405);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.signup_username);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.signup_loginhere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_showpass);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sighnup_pass);
            this.panel1.Controls.Add(this.sighnup_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 408);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(654, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // signup_loginhere
            // 
            this.signup_loginhere.AutoSize = true;
            this.signup_loginhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginhere.Location = new System.Drawing.Point(539, 343);
            this.signup_loginhere.Name = "signup_loginhere";
            this.signup_loginhere.Size = new System.Drawing.Size(98, 20);
            this.signup_loginhere.TabIndex = 9;
            this.signup_loginhere.Text = "Login here";
            this.signup_loginhere.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already have an account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // signup_showpass
            // 
            this.signup_showpass.AutoSize = true;
            this.signup_showpass.Location = new System.Drawing.Point(557, 269);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(122, 20);
            this.signup_showpass.TabIndex = 7;
            this.signup_showpass.Text = "show password";
            this.signup_showpass.UseVisualStyleBackColor = true;
            this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signup_btn.Location = new System.Drawing.Point(317, 293);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 6;
            this.signup_btn.Text = "sign up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sighnup_pass
            // 
            this.sighnup_pass.Location = new System.Drawing.Point(317, 229);
            this.sighnup_pass.Name = "sighnup_pass";
            this.sighnup_pass.PasswordChar = '*';
            this.sighnup_pass.Size = new System.Drawing.Size(336, 22);
            this.sighnup_pass.TabIndex = 3;
            this.sighnup_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sighnup_email
            // 
            this.sighnup_email.Location = new System.Drawing.Point(317, 117);
            this.sighnup_email.Name = "sighnup_email";
            this.sighnup_email.Size = new System.Drawing.Size(336, 22);
            this.sighnup_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get started";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Username";
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(317, 174);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(336, 22);
            this.signup_username.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label signup_loginhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sighnup_pass;
        private System.Windows.Forms.TextBox sighnup_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox signup_username;
    }
}