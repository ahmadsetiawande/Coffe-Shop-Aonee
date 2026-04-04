namespace Coffe_Shop.views.forms
{
    partial class SignUpForm
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
            label1 = new Label();
            textName = new TextBox();
            buttonLogin = new Button();
            textConfirmPassword = new TextBox();
            textUsername = new TextBox();
            textPhone = new TextBox();
            textPassword = new TextBox();
            textEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textAddress = new TextBox();
            buttonSubmit = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textName
            // 
            textName.Location = new Point(73, 67);
            textName.Name = "textName";
            textName.Size = new Size(165, 23);
            textName.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(73, 369);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Location = new Point(271, 191);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(165, 23);
            textConfirmPassword.TabIndex = 3;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(271, 126);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(165, 23);
            textUsername.TabIndex = 4;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(271, 67);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(165, 23);
            textPhone.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(73, 191);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(165, 23);
            textPassword.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(73, 126);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(165, 23);
            textEmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 173);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 8;
            label2.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 173);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 108);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 108);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 49);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(73, 253);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(363, 95);
            textAddress.TabIndex = 13;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(163, 369);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 14;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 235);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 15;
            label7.Text = "Address";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(label7);
            Controls.Add(buttonSubmit);
            Controls.Add(textAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textEmail);
            Controls.Add(textPassword);
            Controls.Add(textPhone);
            Controls.Add(textUsername);
            Controls.Add(textConfirmPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Button buttonLogin;
        private TextBox textConfirmPassword;
        private TextBox textUsername;
        private TextBox textPhone;
        private TextBox textPassword;
        private TextBox textEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textAddress;
        private Button buttonSubmit;
        private Label label7;
    }
}