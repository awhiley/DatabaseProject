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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 64);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(859, 289);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.AddEntry.Location = new System.Drawing.Point(74, 482);
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
            this.WebsiteInput.Size = new System.Drawing.Size(234, 27);
            this.WebsiteInput.TabIndex = 4;
            this.WebsiteInput.Text = "Enter Website";
            this.WebsiteInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WebsiteInput.TextChanged += new System.EventHandler(this.WebsiteInput_TextChanged);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(7, 383);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(234, 27);
            this.UsernameInput.TabIndex = 5;
            this.UsernameInput.Text = "Enter Username (If Applicable)";
            this.UsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(7, 411);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(234, 27);
            this.EmailInput.TabIndex = 6;
            this.EmailInput.Text = "Enter Email (If Applicable)";
            this.EmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(7, 439);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(234, 27);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 482);
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
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(873, 518);
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private TextBox textBox1;
        private TextBox textBox2;
    }
}