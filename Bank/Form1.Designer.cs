namespace Bank
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button_Start_Page = new System.Windows.Forms.Button();
            this.Button_Account_Page = new System.Windows.Forms.Button();
            this.Button_New_Transaction = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.KontonPanel = new System.Windows.Forms.Panel();
            this.Saldo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bank_account_View = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountSelector = new System.Windows.Forms.ComboBox();
            this.Button_Create_Bank_Account = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Button_Create_User = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Textbox_Login_Password = new System.Windows.Forms.TextBox();
            this.Textbox_Login_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Logout = new System.Windows.Forms.Button();
            this.StartPanel.SuspendLayout();
            this.KontonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_account_View)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Start_Page
            // 
            this.Button_Start_Page.Location = new System.Drawing.Point(12, 12);
            this.Button_Start_Page.Name = "Button_Start_Page";
            this.Button_Start_Page.Size = new System.Drawing.Size(96, 25);
            this.Button_Start_Page.TabIndex = 0;
            this.Button_Start_Page.Text = "Start";
            this.Button_Start_Page.UseVisualStyleBackColor = true;
            this.Button_Start_Page.Visible = false;
            this.Button_Start_Page.Click += new System.EventHandler(this.Button_Start_Page_Click);
            // 
            // Button_Account_Page
            // 
            this.Button_Account_Page.Location = new System.Drawing.Point(114, 12);
            this.Button_Account_Page.Name = "Button_Account_Page";
            this.Button_Account_Page.Size = new System.Drawing.Size(96, 25);
            this.Button_Account_Page.TabIndex = 1;
            this.Button_Account_Page.Text = "Konton";
            this.Button_Account_Page.UseVisualStyleBackColor = true;
            this.Button_Account_Page.Visible = false;
            this.Button_Account_Page.Click += new System.EventHandler(this.Button_Account_Page_Click);
            // 
            // Button_New_Transaction
            // 
            this.Button_New_Transaction.Location = new System.Drawing.Point(239, 53);
            this.Button_New_Transaction.Name = "Button_New_Transaction";
            this.Button_New_Transaction.Size = new System.Drawing.Size(96, 25);
            this.Button_New_Transaction.TabIndex = 2;
            this.Button_New_Transaction.Text = "Ny transaktion";
            this.Button_New_Transaction.UseVisualStyleBackColor = true;
            this.Button_New_Transaction.Click += new System.EventHandler(this.Button_New_Transaction_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.label4);
            this.StartPanel.Controls.Add(this.label2);
            this.StartPanel.Controls.Add(this.Welcome);
            this.StartPanel.Location = new System.Drawing.Point(12, 43);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(600, 378);
            this.StartPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Under konton kan du se alla dina konton och skapa nya konton.\r\nDär kan du även ge" +
    "nomföra nya transaktioner om du önskar.\r\n";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Welcome.Location = new System.Drawing.Point(88, 45);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(247, 30);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Välkommen till din bank! \r\n";
            // 
            // KontonPanel
            // 
            this.KontonPanel.Controls.Add(this.Saldo);
            this.KontonPanel.Controls.Add(this.label7);
            this.KontonPanel.Controls.Add(this.Bank_account_View);
            this.KontonPanel.Controls.Add(this.AccountSelector);
            this.KontonPanel.Controls.Add(this.Button_Create_Bank_Account);
            this.KontonPanel.Controls.Add(this.Button_New_Transaction);
            this.KontonPanel.Controls.Add(this.label3);
            this.KontonPanel.Location = new System.Drawing.Point(12, 43);
            this.KontonPanel.Name = "KontonPanel";
            this.KontonPanel.Size = new System.Drawing.Size(600, 378);
            this.KontonPanel.TabIndex = 4;
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Saldo.Location = new System.Drawing.Point(20, 115);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(0, 21);
            this.Saldo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Välj ett bankkonto för att visa alla transaktioner";
            // 
            // Bank_account_View
            // 
            this.Bank_account_View.AllowUserToAddRows = false;
            this.Bank_account_View.AllowUserToDeleteRows = false;
            this.Bank_account_View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Bank_account_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Bank_account_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bank_account_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test,
            this.Belopp,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bank_account_View.DefaultCellStyle = dataGridViewCellStyle1;
            this.Bank_account_View.Location = new System.Drawing.Point(20, 139);
            this.Bank_account_View.Name = "Bank_account_View";
            this.Bank_account_View.ReadOnly = true;
            this.Bank_account_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bank_account_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Bank_account_View.RowHeadersWidth = 4;
            this.Bank_account_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Bank_account_View.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Bank_account_View.Size = new System.Drawing.Size(506, 195);
            this.Bank_account_View.TabIndex = 10;
            // 
            // test
            // 
            this.test.HeaderText = "Datum";
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.test.Width = 125;
            // 
            // Belopp
            // 
            this.Belopp.HeaderText = "Belopp";
            this.Belopp.Name = "Belopp";
            this.Belopp.ReadOnly = true;
            this.Belopp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Belopp.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Destination /Källa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Summa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 75;
            // 
            // AccountSelector
            // 
            this.AccountSelector.FormattingEnabled = true;
            this.AccountSelector.Location = new System.Drawing.Point(20, 55);
            this.AccountSelector.Name = "AccountSelector";
            this.AccountSelector.Size = new System.Drawing.Size(104, 23);
            this.AccountSelector.TabIndex = 8;
            this.AccountSelector.Text = "Välj";
            this.AccountSelector.SelectedIndexChanged += new System.EventHandler(this.AccountSelector_SelectedIndexChanged);
            // 
            // Button_Create_Bank_Account
            // 
            this.Button_Create_Bank_Account.Location = new System.Drawing.Point(130, 53);
            this.Button_Create_Bank_Account.Name = "Button_Create_Bank_Account";
            this.Button_Create_Bank_Account.Size = new System.Drawing.Size(96, 25);
            this.Button_Create_Bank_Account.TabIndex = 7;
            this.Button_Create_Bank_Account.Text = "Nytt konto";
            this.Button_Create_Bank_Account.UseVisualStyleBackColor = true;
            this.Button_Create_Bank_Account.Click += new System.EventHandler(this.Button_Create_Bank_Account_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Konton";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.Button_Create_User);
            this.LoginPanel.Controls.Add(this.Button_Login);
            this.LoginPanel.Controls.Add(this.Textbox_Login_Password);
            this.LoginPanel.Controls.Add(this.Textbox_Login_Email);
            this.LoginPanel.Controls.Add(this.label6);
            this.LoginPanel.Controls.Add(this.label5);
            this.LoginPanel.Location = new System.Drawing.Point(12, 43);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(600, 378);
            this.LoginPanel.TabIndex = 5;
            // 
            // Button_Create_User
            // 
            this.Button_Create_User.Location = new System.Drawing.Point(34, 182);
            this.Button_Create_User.Name = "Button_Create_User";
            this.Button_Create_User.Size = new System.Drawing.Size(96, 25);
            this.Button_Create_User.TabIndex = 7;
            this.Button_Create_User.Text = "Skapa konto";
            this.Button_Create_User.UseVisualStyleBackColor = true;
            this.Button_Create_User.Click += new System.EventHandler(this.Button_Create_User_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(34, 151);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(96, 25);
            this.Button_Login.TabIndex = 6;
            this.Button_Login.Text = "Logga in";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Textbox_Login_Password
            // 
            this.Textbox_Login_Password.Location = new System.Drawing.Point(34, 122);
            this.Textbox_Login_Password.Name = "Textbox_Login_Password";
            this.Textbox_Login_Password.PlaceholderText = "Lösenord";
            this.Textbox_Login_Password.Size = new System.Drawing.Size(156, 23);
            this.Textbox_Login_Password.TabIndex = 3;
            // 
            // Textbox_Login_Email
            // 
            this.Textbox_Login_Email.Location = new System.Drawing.Point(34, 93);
            this.Textbox_Login_Email.Name = "Textbox_Login_Email";
            this.Textbox_Login_Email.PlaceholderText = "Email";
            this.Textbox_Login_Email.Size = new System.Drawing.Size(156, 23);
            this.Textbox_Login_Email.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Var god logga in eller skapa ett konto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Välkommen!";
            // 
            // Button_Logout
            // 
            this.Button_Logout.Location = new System.Drawing.Point(500, 12);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(96, 25);
            this.Button_Logout.TabIndex = 6;
            this.Button_Logout.Text = "Logga ut";
            this.Button_Logout.UseVisualStyleBackColor = true;
            this.Button_Logout.Visible = false;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 432);
            this.Controls.Add(this.Button_Logout);
            this.Controls.Add(this.Button_Start_Page);
            this.Controls.Add(this.Button_Account_Page);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.KontonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.KontonPanel.ResumeLayout(false);
            this.KontonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_account_View)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Button_Start_Page;
        private Button Button_Account_Page;
        private Button Button_New_Transaction;
        private Panel StartPanel;
        private Label label2;
        private Label Welcome;
        private Panel KontonPanel;
        private Label label3;
        private Label label4;
        private Panel LoginPanel;
        private Button Button_Login;
        private TextBox Textbox_Login_Password;
        private TextBox Textbox_Login_Email;
        private Label label6;
        private Label label5;
        private Button Button_Create_User;
        private Button Button_Create_Bank_Account;
        private Label label7;
        private DataGridViewTextBoxColumn test;
        private DataGridViewTextBoxColumn Belopp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button Button_Logout;
        private Label Saldo;
        public ComboBox AccountSelector;
        public DataGridView Bank_account_View;
    }
}