namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_showpas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_register = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.login_register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.login_showpas);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 408);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 405);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "welcome back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(317, 117);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(336, 22);
            this.login_username.TabIndex = 2;
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(317, 212);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(336, 22);
            this.login_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "username";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.login_btn.Location = new System.Drawing.Point(317, 293);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_showpas
            // 
            this.login_showpas.AutoSize = true;
            this.login_showpas.Location = new System.Drawing.Point(558, 252);
            this.login_showpas.Name = "login_showpas";
            this.login_showpas.Size = new System.Drawing.Size(122, 20);
            this.login_showpas.TabIndex = 7;
            this.login_showpas.Text = "show password";
            this.login_showpas.UseVisualStyleBackColor = true;
            this.login_showpas.CheckedChanged += new System.EventHandler(this.login_showpas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dont have an account?";
            // 
            // login_register
            // 
            this.login_register.AutoSize = true;
            this.login_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_register.Location = new System.Drawing.Point(527, 343);
            this.login_register.Name = "login_register";
            this.login_register.Size = new System.Drawing.Size(117, 20);
            this.login_register.TabIndex = 9;
            this.login_register.Text = "register here";
            this.login_register.Click += new System.EventHandler(this.login_register_Click);
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Location = new System.Drawing.Point(654, 9);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(15, 16);
            this.login_close.TabIndex = 10;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sighn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_showpas;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label login_register;
        private System.Windows.Forms.Label login_close;
    }
}

