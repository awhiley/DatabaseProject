namespace DatabaseProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GreetingText = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ForgotPassButton = new System.Windows.Forms.Button();
            this.CreateAccButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingText
            // 
            this.GreetingText.AutoSize = true;
            this.GreetingText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GreetingText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GreetingText.Location = new System.Drawing.Point(14, 80);
            this.GreetingText.Name = "GreetingText";
            this.GreetingText.Size = new System.Drawing.Size(679, 32);
            this.GreetingText.TabIndex = 0;
            this.GreetingText.Text = "Please enter your username and password below to login!";
            this.GreetingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GreetingText.Click += new System.EventHandler(this.GreetingText_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameLabel.Location = new System.Drawing.Point(176, 121);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(126, 32);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(136, 156);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(200, 39);
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordLabel.Location = new System.Drawing.Point(386, 121);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(116, 32);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(342, 156);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(200, 39);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(225, 201);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(216, 46);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(89, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(486, 58);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Password Manager";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // ForgotPassButton
            // 
            this.ForgotPassButton.Location = new System.Drawing.Point(225, 253);
            this.ForgotPassButton.Name = "ForgotPassButton";
            this.ForgotPassButton.Size = new System.Drawing.Size(216, 46);
            this.ForgotPassButton.TabIndex = 7;
            this.ForgotPassButton.Text = "Forgot Password";
            this.ForgotPassButton.UseVisualStyleBackColor = true;
            this.ForgotPassButton.Click += new System.EventHandler(this.ForgotPassButton_Click);
            // 
            // CreateAccButton
            // 
            this.CreateAccButton.Location = new System.Drawing.Point(225, 305);
            this.CreateAccButton.Name = "CreateAccButton";
            this.CreateAccButton.Size = new System.Drawing.Size(216, 46);
            this.CreateAccButton.TabIndex = 8;
            this.CreateAccButton.Text = "Create Account";
            this.CreateAccButton.UseVisualStyleBackColor = true;
            this.CreateAccButton.Click += new System.EventHandler(this.CreateAccButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(this.CreateAccButton);
            this.Controls.Add(this.ForgotPassButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.GreetingText);
            this.Name = "LoginForm";
            this.Text = "Manager by Samuel Tyler & Zach Vandecar";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label GreetingText;
        private Label UsernameLabel;
        private TextBox UsernameBox;
        private Label PasswordLabel;
        private TextBox PasswordBox;
        private Button LoginButton;
        private Label NameLabel;
        private Button ForgotPassButton;
        private Button CreateAccButton;
    }
}