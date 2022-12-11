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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(557, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Area";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1394, 460);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserAreaGreeting
            // 
            this.UserAreaGreeting.AutoSize = true;
            this.UserAreaGreeting.ForeColor = System.Drawing.SystemColors.Control;
            this.UserAreaGreeting.Location = new System.Drawing.Point(483, 67);
            this.UserAreaGreeting.Name = "UserAreaGreeting";
            this.UserAreaGreeting.Size = new System.Drawing.Size(400, 32);
            this.UserAreaGreeting.TabIndex = 2;
            this.UserAreaGreeting.Text = "All user information is shown below:";
            // 
            // AddEntry
            // 
            this.AddEntry.Location = new System.Drawing.Point(120, 771);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(150, 46);
            this.AddEntry.TabIndex = 3;
            this.AddEntry.Text = "Add Entry";
            this.AddEntry.UseVisualStyleBackColor = true;
            // 
            // WebsiteInput
            // 
            this.WebsiteInput.Location = new System.Drawing.Point(12, 568);
            this.WebsiteInput.Name = "WebsiteInput";
            this.WebsiteInput.Size = new System.Drawing.Size(378, 39);
            this.WebsiteInput.TabIndex = 4;
            this.WebsiteInput.Text = "Enter Website";
            this.WebsiteInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(12, 613);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(378, 39);
            this.UsernameInput.TabIndex = 5;
            this.UsernameInput.Text = "Enter Username (If Applicable)";
            this.UsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(12, 658);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(378, 39);
            this.EmailInput.TabIndex = 6;
            this.EmailInput.Text = "Enter Email (If Applicable)";
            this.EmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(12, 703);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(378, 39);
            this.PasswordInput.TabIndex = 7;
            this.PasswordInput.Text = "Enter Password";
            this.PasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDInputDelete
            // 
            this.IDInputDelete.Location = new System.Drawing.Point(505, 703);
            this.IDInputDelete.Name = "IDInputDelete";
            this.IDInputDelete.Size = new System.Drawing.Size(378, 39);
            this.IDInputDelete.TabIndex = 8;
            this.IDInputDelete.Text = "Enter ID to Delete";
            this.IDInputDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(620, 771);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 46);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Entry";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // PasswordChange
            // 
            this.PasswordChange.Location = new System.Drawing.Point(1028, 703);
            this.PasswordChange.Name = "PasswordChange";
            this.PasswordChange.Size = new System.Drawing.Size(378, 39);
            this.PasswordChange.TabIndex = 14;
            this.PasswordChange.Text = "Enter New Password";
            this.PasswordChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailChange
            // 
            this.EmailChange.Location = new System.Drawing.Point(1028, 658);
            this.EmailChange.Name = "EmailChange";
            this.EmailChange.Size = new System.Drawing.Size(378, 39);
            this.EmailChange.TabIndex = 13;
            this.EmailChange.Text = "Enter New Email";
            this.EmailChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameChange
            // 
            this.UsernameChange.Location = new System.Drawing.Point(1028, 613);
            this.UsernameChange.Name = "UsernameChange";
            this.UsernameChange.Size = new System.Drawing.Size(378, 39);
            this.UsernameChange.TabIndex = 12;
            this.UsernameChange.Text = "Enter New Username";
            this.UsernameChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDInputModify
            // 
            this.IDInputModify.Location = new System.Drawing.Point(1028, 568);
            this.IDInputModify.Name = "IDInputModify";
            this.IDInputModify.Size = new System.Drawing.Size(378, 39);
            this.IDInputModify.TabIndex = 11;
            this.IDInputModify.Text = "Enter ID to Modify";
            this.IDInputModify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1136, 771);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1418, 829);
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "UserInterface";
            this.Text = "Manager by Samuel Tyler & Zach Vandecar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView listView1;
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
    }
}