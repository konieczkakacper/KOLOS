namespace WinFormsApp1
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_passwd1 = new System.Windows.Forms.TextBox();
            this.textBox_passwd2 = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(227, 68);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(255, 23);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_passwd1
            // 
            this.textBox_passwd1.Location = new System.Drawing.Point(227, 137);
            this.textBox_passwd1.Name = "textBox_passwd1";
            this.textBox_passwd1.Size = new System.Drawing.Size(255, 23);
            this.textBox_passwd1.TabIndex = 1;
            // 
            // textBox_passwd2
            // 
            this.textBox_passwd2.Location = new System.Drawing.Point(227, 190);
            this.textBox_passwd2.Name = "textBox_passwd2";
            this.textBox_passwd2.Size = new System.Drawing.Size(255, 23);
            this.textBox_passwd2.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(309, 257);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(97, 31);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(295, 321);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(133, 96);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "REGISTER";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.textBox_passwd2);
            this.Controls.Add(this.textBox_passwd1);
            this.Controls.Add(this.textBox_name);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_name;
        private TextBox textBox_passwd1;
        private TextBox textBox_passwd2;
        private Button login_button;
        private Button register_button;
    }
}