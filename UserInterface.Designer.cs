namespace DatabaseProject
{
    partial class UserInterface
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
            this.UserAreaGreeting = new System.Windows.Forms.Label();
            this.AddEntry = new System.Windows.Forms.Button();
            this.WebsiteInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.IDInputDelete = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PasswordChange = new System.Windows.Forms.TextBox();
            this.EmailChange = new System.Windows.Forms.TextBox();
            this.UsernameChange = new System.Windows.Forms.TextBox();
            this.IDInputModify = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.isdisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(343, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Area";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserAreaGreeting
            // 
            this.UserAreaGreeting.AutoSize = true;
            this.UserAreaGreeting.ForeColor = System.Drawing.SystemColors.Control;
            this.UserAreaGreeting.Location = new System.Drawing.Point(297, 42);
            this.UserAreaGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserAreaGreeting.Name = "UserAreaGreeting";
            this.UserAreaGreeting.Size = new System.Drawing.Size(248, 20);
            this.UserAreaGreeting.TabIndex = 2;
            this.UserAreaGreeting.Text = "All user information is shown below:";
            // 
            // AddEntry
            // 
            this.AddEntry.Location = new System.Drawing.Point(186, 470);
            this.AddEntry.Margin = new System.Windows.Forms.Padding(2);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(92, 29);
            this.AddEntry.TabIndex = 3;
            this.AddEntry.Text = "Add Entry";
            this.AddEntry.UseVisualStyleBackColor = true;
            this.AddEntry.Click += new System.EventHandler(this.AddEntry_Click);
            // 
            // WebsiteInput
            // 
            this.WebsiteInput.Location = new System.Drawing.Point(7, 355);
            this.WebsiteInput.Margin = new System.Windows.Forms.Padding(2);
            this.WebsiteInput.Name = "WebsiteInput";
            this.WebsiteInput.Size = new System.Drawing.Size(141, 27);
            this.WebsiteInput.TabIndex = 4;
            this.WebsiteInput.Text = "Enter Website Link";
            this.WebsiteInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WebsiteInput.TextChanged += new System.EventHandler(this.WebsiteInput_TextChanged);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(7, 383);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(257, 27);
            this.UsernameInput.TabIndex = 5;
            this.UsernameInput.Text = "Enter Username (If Applicable)";
            this.UsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(7, 411);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(257, 27);
            this.EmailInput.TabIndex = 6;
            this.EmailInput.Text = "Enter Email (If Applicable)";
            this.EmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(7, 439);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(257, 27);
            this.PasswordInput.TabIndex = 7;
            this.PasswordInput.Text = "Enter Password";
            this.PasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDInputDelete
            // 
            this.IDInputDelete.Location = new System.Drawing.Point(311, 439);
            this.IDInputDelete.Margin = new System.Windows.Forms.Padding(2);
            this.IDInputDelete.Name = "IDInputDelete";
            this.IDInputDelete.Size = new System.Drawing.Size(234, 27);
            this.IDInputDelete.TabIndex = 8;
            this.IDInputDelete.Text = "Enter ID to Delete";
            this.IDInputDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDInputDelete.TextChanged += new System.EventHandler(this.IDInputDelete_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(382, 482);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Entry";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PasswordChange
            // 
            this.PasswordChange.Location = new System.Drawing.Point(633, 439);
            this.PasswordChange.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordChange.Name = "PasswordChange";
            this.PasswordChange.Size = new System.Drawing.Size(234, 27);
            this.PasswordChange.TabIndex = 14;
            this.PasswordChange.Text = "Enter New Password";
            this.PasswordChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailChange
            // 
            this.EmailChange.Location = new System.Drawing.Point(633, 411);
            this.EmailChange.Margin = new System.Windows.Forms.Padding(2);
            this.EmailChange.Name = "EmailChange";
            this.EmailChange.Size = new System.Drawing.Size(234, 27);
            this.EmailChange.TabIndex = 13;
            this.EmailChange.Text = "Enter New Email";
            this.EmailChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailChange.TextChanged += new System.EventHandler(this.EmailChange_TextChanged);
            // 
            // UsernameChange
            // 
            this.UsernameChange.Location = new System.Drawing.Point(633, 383);
            this.UsernameChange.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameChange.Name = "UsernameChange";
            this.UsernameChange.Size = new System.Drawing.Size(234, 27);
            this.UsernameChange.TabIndex = 12;
            this.UsernameChange.Text = "Enter New Username";
            this.UsernameChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameChange.TextChanged += new System.EventHandler(this.UsernameChange_TextChanged);
            // 
            // IDInputModify
            // 
            this.IDInputModify.Location = new System.Drawing.Point(633, 355);
            this.IDInputModify.Margin = new System.Windows.Forms.Padding(2);
            this.IDInputModify.Name = "IDInputModify";
            this.IDInputModify.Size = new System.Drawing.Size(234, 27);
            this.IDInputModify.TabIndex = 11;
            this.IDInputModify.Text = "Enter ID to Modify";
            this.IDInputModify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDInputModify.TextChanged += new System.EventHandler(this.IDInputModify_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Authorization Password";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(590, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 27);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Authorization Username";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 355);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 27);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Website Name";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 470);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 27);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "Enter Phone";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(633, 472);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 27);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "Enter New Phone";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // isdisplay
            // 
            this.isdisplay.Location = new System.Drawing.Point(-7, 79);
            this.isdisplay.Margin = new System.Windows.Forms.Padding(2);
            this.isdisplay.Multiline = true;
            this.isdisplay.Name = "isdisplay";
            this.isdisplay.ReadOnly = true;
            this.isdisplay.Size = new System.Drawing.Size(873, 272);
            this.isdisplay.TabIndex = 21;
            this.isdisplay.Text = "...";
            this.isdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isdisplay.TextChanged += new System.EventHandler(this.isdisplay_TextChanged);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(873, 518);
            this.Controls.Add(this.isdisplay);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordChange);
            this.Controls.Add(this.EmailChange);
            this.Controls.Add(this.UsernameChange);
            this.Controls.Add(this.IDInputModify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IDInputDelete);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.WebsiteInput);
            this.Controls.Add(this.AddEntry);
            this.Controls.Add(this.UserAreaGreeting);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInterface";
            this.Text = "Manager by Samuel Tyler & Zach Vandecar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label UserAreaGreeting;
        private Button AddEntry;
        private TextBox WebsiteInput;
        private TextBox UsernameInput;
        private TextBox EmailInput;
        private TextBox PasswordInput;
        private TextBox IDInputDelete;
        private Button DeleteButton;
        private TextBox PasswordChange;
        private TextBox EmailChange;
        private TextBox UsernameChange;
        private TextBox IDInputModify;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox isdisplay;
    }
}