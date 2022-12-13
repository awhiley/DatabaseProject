namespace DatabaseProject
{
    partial class CreateAccount
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
            this.CreateAccountGreeting = new System.Windows.Forms.Label();
            this.EmailCreate = new System.Windows.Forms.Label();
            this.EmailCreateBox = new System.Windows.Forms.TextBox();
            this.UsernameCreateBox = new System.Windows.Forms.TextBox();
            this.UsernameCreate = new System.Windows.Forms.Label();
            this.PasswordCreateBox = new System.Windows.Forms.TextBox();
            this.PasswordCreate = new System.Windows.Forms.Label();
            this.SecretPromptBox = new System.Windows.Forms.ComboBox();
            this.SecretPrompt = new System.Windows.Forms.Label();
            this.AnswerPrompt = new System.Windows.Forms.Label();
            this.SecretAnswerBox = new System.Windows.Forms.TextBox();
            this.CreateAccButton = new System.Windows.Forms.Button();
            this.BackCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAccountGreeting
            // 
            this.CreateAccountGreeting.AutoSize = true;
            this.CreateAccountGreeting.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccountGreeting.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateAccountGreeting.Location = new System.Drawing.Point(196, 6);
            this.CreateAccountGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateAccountGreeting.Name = "CreateAccountGreeting";
            this.CreateAccountGreeting.Size = new System.Drawing.Size(195, 29);
            this.CreateAccountGreeting.TabIndex = 0;
            this.CreateAccountGreeting.Text = "Create Account";
            // 
            // EmailCreate
            // 
            this.EmailCreate.AutoSize = true;
            this.EmailCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailCreate.Location = new System.Drawing.Point(121, 63);
            this.EmailCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailCreate.Name = "EmailCreate";
            this.EmailCreate.Size = new System.Drawing.Size(39, 15);
            this.EmailCreate.TabIndex = 1;
            this.EmailCreate.Text = "Email:";
            // 
            // EmailCreateBox
            // 
            this.EmailCreateBox.Location = new System.Drawing.Point(165, 62);
            this.EmailCreateBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailCreateBox.Name = "EmailCreateBox";
            this.EmailCreateBox.Size = new System.Drawing.Size(214, 23);
            this.EmailCreateBox.TabIndex = 2;
            this.EmailCreateBox.TextChanged += new System.EventHandler(this.EmailCreateBox_TextChanged);
            // 
            // UsernameCreateBox
            // 
            this.UsernameCreateBox.Location = new System.Drawing.Point(165, 83);
            this.UsernameCreateBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameCreateBox.Name = "UsernameCreateBox";
            this.UsernameCreateBox.Size = new System.Drawing.Size(214, 23);
            this.UsernameCreateBox.TabIndex = 4;
            this.UsernameCreateBox.TextChanged += new System.EventHandler(this.UsernameCreateBox_TextChanged);
            // 
            // UsernameCreate
            // 
            this.UsernameCreate.AutoSize = true;
            this.UsernameCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameCreate.Location = new System.Drawing.Point(94, 84);
            this.UsernameCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameCreate.Name = "UsernameCreate";
            this.UsernameCreate.Size = new System.Drawing.Size(63, 15);
            this.UsernameCreate.TabIndex = 3;
            this.UsernameCreate.Text = "Username:";
            // 
            // PasswordCreateBox
            // 
            this.PasswordCreateBox.Location = new System.Drawing.Point(165, 104);
            this.PasswordCreateBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordCreateBox.Name = "PasswordCreateBox";
            this.PasswordCreateBox.Size = new System.Drawing.Size(214, 23);
            this.PasswordCreateBox.TabIndex = 6;
            this.PasswordCreateBox.TextChanged += new System.EventHandler(this.PasswordCreateBox_TextChanged);
            // 
            // PasswordCreate
            // 
            this.PasswordCreate.AutoSize = true;
            this.PasswordCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordCreate.Location = new System.Drawing.Point(100, 106);
            this.PasswordCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordCreate.Name = "PasswordCreate";
            this.PasswordCreate.Size = new System.Drawing.Size(60, 15);
            this.PasswordCreate.TabIndex = 5;
            this.PasswordCreate.Text = "Password:";
            // 
            // SecretPromptBox
            // 
            this.SecretPromptBox.FormattingEnabled = true;
            this.SecretPromptBox.Location = new System.Drawing.Point(165, 125);
            this.SecretPromptBox.Margin = new System.Windows.Forms.Padding(2);
            this.SecretPromptBox.Name = "SecretPromptBox";
            this.SecretPromptBox.Size = new System.Drawing.Size(214, 23);
            this.SecretPromptBox.TabIndex = 7;
            this.SecretPromptBox.SelectedIndexChanged += new System.EventHandler(this.SecretPromptBox_SelectedIndexChanged);
            // 
            // SecretPrompt
            // 
            this.SecretPrompt.AutoSize = true;
            this.SecretPrompt.ForeColor = System.Drawing.SystemColors.Control;
            this.SecretPrompt.Location = new System.Drawing.Point(71, 127);
            this.SecretPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecretPrompt.Name = "SecretPrompt";
            this.SecretPrompt.Size = new System.Drawing.Size(85, 15);
            this.SecretPrompt.TabIndex = 8;
            this.SecretPrompt.Text = "Secret Prompt:";
            // 
            // AnswerPrompt
            // 
            this.AnswerPrompt.AutoSize = true;
            this.AnswerPrompt.ForeColor = System.Drawing.SystemColors.Control;
            this.AnswerPrompt.Location = new System.Drawing.Point(110, 148);
            this.AnswerPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerPrompt.Name = "AnswerPrompt";
            this.AnswerPrompt.Size = new System.Drawing.Size(49, 15);
            this.AnswerPrompt.TabIndex = 9;
            this.AnswerPrompt.Text = "Answer:";
            // 
            // SecretAnswerBox
            // 
            this.SecretAnswerBox.Location = new System.Drawing.Point(178, 216);
            this.SecretAnswerBox.Margin = new System.Windows.Forms.Padding(2);
            this.SecretAnswerBox.Name = "SecretAnswerBox";
            this.SecretAnswerBox.Size = new System.Drawing.Size(214, 23);
            this.SecretAnswerBox.TabIndex = 10;
            this.SecretAnswerBox.TextChanged += new System.EventHandler(this.SecretAnswerBox_TextChanged);
            // 
            // CreateAccButton
            // 
            this.CreateAccButton.Location = new System.Drawing.Point(94, 215);
            this.CreateAccButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateAccButton.Name = "CreateAccButton";
            this.CreateAccButton.Size = new System.Drawing.Size(80, 22);
            this.CreateAccButton.TabIndex = 11;
            this.CreateAccButton.Text = "Create";
            this.CreateAccButton.UseVisualStyleBackColor = true;
            this.CreateAccButton.Click += new System.EventHandler(this.CreateAccButton_Click);
            // 
            // BackCreateButton
            // 
            this.BackCreateButton.Location = new System.Drawing.Point(6, 6);
            this.BackCreateButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackCreateButton.Name = "BackCreateButton";
            this.BackCreateButton.Size = new System.Drawing.Size(80, 22);
            this.BackCreateButton.TabIndex = 12;
            this.BackCreateButton.Text = "Back";
            this.BackCreateButton.UseVisualStyleBackColor = true;
            this.BackCreateButton.Click += new System.EventHandler(this.BackCreateButton_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(584, 285);
            this.Controls.Add(this.BackCreateButton);
            this.Controls.Add(this.CreateAccButton);
            this.Controls.Add(this.SecretAnswerBox);
            this.Controls.Add(this.AnswerPrompt);
            this.Controls.Add(this.SecretPrompt);
            this.Controls.Add(this.SecretPromptBox);
            this.Controls.Add(this.PasswordCreateBox);
            this.Controls.Add(this.PasswordCreate);
            this.Controls.Add(this.UsernameCreateBox);
            this.Controls.Add(this.UsernameCreate);
            this.Controls.Add(this.EmailCreateBox);
            this.Controls.Add(this.EmailCreate);
            this.Controls.Add(this.CreateAccountGreeting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreateAccountGreeting;
        private Label EmailCreate;
        private TextBox EmailCreateBox;
        private TextBox UsernameCreateBox;
        private Label UsernameCreate;
        private TextBox PasswordCreateBox;
        private Label PasswordCreate;
        private ComboBox SecretPromptBox;
        private Label SecretPrompt;
        private Label AnswerPrompt;
        private TextBox SecretAnswerBox;
        private Button CreateAccButton;
        private Button BackCreateButton;
    }
}