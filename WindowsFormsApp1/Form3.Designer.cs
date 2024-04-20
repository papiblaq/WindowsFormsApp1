namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.radkg = new System.Windows.Forms.RadioButton();
            this.radpound = new System.Windows.Forms.RadioButton();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "weight";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "height";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(235, 32);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(247, 22);
            this.txt_weight.TabIndex = 3;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(235, 82);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(247, 22);
            this.txt_height.TabIndex = 5;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(235, 174);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(247, 101);
            this.txt_result.TabIndex = 6;
            // 
            // radkg
            // 
            this.radkg.AutoSize = true;
            this.radkg.Location = new System.Drawing.Point(235, 119);
            this.radkg.Name = "radkg";
            this.radkg.Size = new System.Drawing.Size(80, 20);
            this.radkg.TabIndex = 7;
            this.radkg.TabStop = true;
            this.radkg.Text = "kilogram";
            this.radkg.UseVisualStyleBackColor = true;
            // 
            // radpound
            // 
            this.radpound.AutoSize = true;
            this.radpound.Location = new System.Drawing.Point(379, 119);
            this.radpound.Name = "radpound";
            this.radpound.Size = new System.Drawing.Size(73, 20);
            this.radpound.TabIndex = 8;
            this.radpound.TabStop = true;
            this.radpound.Text = "pounds";
            this.radpound.UseVisualStyleBackColor = true;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(235, 296);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(247, 23);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(407, 354);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(235, 354);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.radpound);
            this.Controls.Add(this.radkg);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.RadioButton radkg;
        private System.Windows.Forms.RadioButton radpound;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
    }
}