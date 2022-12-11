namespace DatabaseProject
{
    partial class ForgotPassword
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
            this.ResetPassGreeting = new System.Windows.Forms.Label();
            this.SecretAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SecretQuestion = new System.Windows.Forms.Label();
            this.WhatIsUser = new System.Windows.Forms.Label();
            this.WhatIsUserBox = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.Label();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.SubmitNewPass = new System.Windows.Forms.Button();
            this.BackResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetPassGreeting
            // 
            this.ResetPassGreeting.AutoSize = true;
            this.ResetPassGreeting.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetPassGreeting.ForeColor = System.Drawing.SystemColors.Control;
            this.ResetPassGreeting.Location = new System.Drawing.Point(178, 9);
            this.ResetPassGreeting.Name = "ResetPassGreeting";
            this.ResetPassGreeting.Size = new System.Drawing.Size(412, 58);
            this.ResetPassGreeting.TabIndex = 0;
            this.ResetPassGreeting.Text = "Reset Password";
            // 
            // SecretAnswer
            // 
            this.SecretAnswer.AutoSize = true;
            this.SecretAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.SecretAnswer.Location = new System.Drawing.Point(240, 194);
            this.SecretAnswer.Name = "SecretAnswer";
            this.SecretAnswer.Size = new System.Drawing.Size(169, 32);
            this.SecretAnswer.TabIndex = 1;
            this.SecretAnswer.Text = "Secret Answer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 39);
            this.textBox1.TabIndex = 2;
            // 
            // SecretQuestion
            // 
            this.SecretQuestion.AutoSize = true;
            this.SecretQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecretQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.SecretQuestion.Location = new System.Drawing.Point(175, 67);
            this.SecretQuestion.Name = "SecretQuestion";
            this.SecretQuestion.Size = new System.Drawing.Size(415, 32);
            this.SecretQuestion.TabIndex = 3;
            this.SecretQuestion.Text = "What is your favorite type of food?";
            // 
            // WhatIsUser
            // 
            this.WhatIsUser.AutoSize = true;
            this.WhatIsUser.ForeColor = System.Drawing.SystemColors.Control;
            this.WhatIsUser.Location = new System.Drawing.Point(240, 117);
            this.WhatIsUser.Name = "WhatIsUser";
            this.WhatIsUser.Size = new System.Drawing.Size(271, 32);
            this.WhatIsUser.TabIndex = 4;
            this.WhatIsUser.Text = "What is your username?";
            // 
            // WhatIsUserBox
            // 
            this.WhatIsUserBox.Location = new System.Drawing.Point(240, 152);
            this.WhatIsUserBox.Name = "WhatIsUserBox";
            this.WhatIsUserBox.Size = new System.Drawing.Size(271, 39);
            this.WhatIsUserBox.TabIndex = 5;
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.ForeColor = System.Drawing.SystemColors.Control;
            this.NewPass.Location = new System.Drawing.Point(240, 271);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(171, 32);
            this.NewPass.TabIndex = 6;
            this.NewPass.Text = "New Password:";
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(240, 306);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(271, 39);
            this.NewPassBox.TabIndex = 7;
            // 
            // SubmitNewPass
            // 
            this.SubmitNewPass.Location = new System.Drawing.Point(240, 368);
            this.SubmitNewPass.Name = "SubmitNewPass";
            this.SubmitNewPass.Size = new System.Drawing.Size(271, 46);
            this.SubmitNewPass.TabIndex = 8;
            this.SubmitNewPass.Text = "Change Password";
            this.SubmitNewPass.UseVisualStyleBackColor = true;
            // 
            // BackResetButton
            // 
            this.BackResetButton.Location = new System.Drawing.Point(12, 9);
            this.BackResetButton.Name = "BackResetButton";
            this.BackResetButton.Size = new System.Drawing.Size(150, 46);
            this.BackResetButton.TabIndex = 13;
            this.BackResetButton.Text = "Back";
            this.BackResetButton.UseVisualStyleBackColor = true;
            this.BackResetButton.Click += new System.EventHandler(this.BackResetButton_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackResetButton);
            this.Controls.Add(this.SubmitNewPass);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.WhatIsUserBox);
            this.Controls.Add(this.WhatIsUser);
            this.Controls.Add(this.SecretQuestion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecretAnswer);
            this.Controls.Add(this.ResetPassGreeting);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ResetPassGreeting;
        private Label SecretAnswer;
        private TextBox textBox1;
        private Label SecretQuestion;
        private Label WhatIsUser;
        private TextBox WhatIsUserBox;
        private Label NewPass;
        private TextBox NewPassBox;
        private Button SubmitNewPass;
        private Button BackResetButton;
    }
}