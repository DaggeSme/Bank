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
            this.components = new System.ComponentModel.Container();
            this.Button_Start_Page = new System.Windows.Forms.Button();
            this.Button_Account_Page = new System.Windows.Forms.Button();
            this.Button_New_Transaction = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KontonPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountSelector = new System.Windows.Forms.ComboBox();
            this.Button_Create_Bank_Account = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreate = new System.Windows.Forms.Panel();
            this.Button_Create_User = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.TextBox_Login_Password = new System.Windows.Forms.TextBox();
            this.Textbox_Login_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartPanel.SuspendLayout();
            this.KontonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.btnCreate.SuspendLayout();
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
            this.Button_Start_Page.Click += new System.EventHandler(this.button1_Click);
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
            this.Button_New_Transaction.Location = new System.Drawing.Point(123, 22);
            this.Button_New_Transaction.Name = "Button_New_Transaction";
            this.Button_New_Transaction.Size = new System.Drawing.Size(96, 25);
            this.Button_New_Transaction.TabIndex = 2;
            this.Button_New_Transaction.Text = "Ny transaktion";
            this.Button_New_Transaction.UseVisualStyleBackColor = true;
            this.Button_New_Transaction.Visible = false;
            this.Button_New_Transaction.Click += new System.EventHandler(this.Button_New_Transaction_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.label4);
            this.StartPanel.Controls.Add(this.label2);
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Location = new System.Drawing.Point(646, 427);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(599, 378);
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
            this.label2.Location = new System.Drawing.Point(73, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "Under konton kan du se alla dina konton och skapa nya konton.\r\nOm du trycker på n" +
    "y transakrtion kan du genomföra en ny \r\ntransaktion från eller till ett av dina " +
    "konton\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen till din bank! \r\n";
            // 
            // KontonPanel
            // 
            this.KontonPanel.Controls.Add(this.dataGridView1);
            this.KontonPanel.Controls.Add(this.button1);
            this.KontonPanel.Controls.Add(this.AccountSelector);
            this.KontonPanel.Controls.Add(this.Button_Create_Bank_Account);
            this.KontonPanel.Controls.Add(this.Button_New_Transaction);
            this.KontonPanel.Controls.Add(this.label3);
            this.KontonPanel.Location = new System.Drawing.Point(12, 43);
            this.KontonPanel.Name = "KontonPanel";
            this.KontonPanel.Size = new System.Drawing.Size(599, 378);
            this.KontonPanel.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test,
            this.Amount,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(20, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 209);
            this.dataGridView1.TabIndex = 10;
            // 
            // test
            // 
            this.test.HeaderText = "Date";
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Location";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Balance";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AccountSelector
            // 
            this.AccountSelector.FormattingEnabled = true;
            this.AccountSelector.Location = new System.Drawing.Point(314, 51);
            this.AccountSelector.Name = "AccountSelector";
            this.AccountSelector.Size = new System.Drawing.Size(104, 23);
            this.AccountSelector.TabIndex = 8;
            this.AccountSelector.SelectedIndexChanged += new System.EventHandler(this.AccountSelector_SelectedIndexChanged);
            // 
            // Button_Create_Bank_Account
            // 
            this.Button_Create_Bank_Account.Location = new System.Drawing.Point(123, 53);
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
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Bank.Account);
            // 
            // btnCreate
            // 
            this.btnCreate.Controls.Add(this.Button_Create_User);
            this.btnCreate.Controls.Add(this.Button_Login);
            this.btnCreate.Controls.Add(this.TextBox_Login_Password);
            this.btnCreate.Controls.Add(this.Textbox_Login_Name);
            this.btnCreate.Controls.Add(this.label6);
            this.btnCreate.Controls.Add(this.label5);
            this.btnCreate.Location = new System.Drawing.Point(646, 46);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(599, 375);
            this.btnCreate.TabIndex = 5;
            // 
            // Button_Create_User
            // 
            this.Button_Create_User.Location = new System.Drawing.Point(34, 182);
            this.Button_Create_User.Name = "Button_Create_User";
            this.Button_Create_User.Size = new System.Drawing.Size(96, 25);
            this.Button_Create_User.TabIndex = 7;
            this.Button_Create_User.Text = "Skapa konto";
            this.Button_Create_User.UseVisualStyleBackColor = true;
            this.Button_Create_User.Click += new System.EventHandler(this.Button_Create_User_Click_2);
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
            // TextBox_Login_Password
            // 
            this.TextBox_Login_Password.Location = new System.Drawing.Point(34, 122);
            this.TextBox_Login_Password.Name = "TextBox_Login_Password";
            this.TextBox_Login_Password.PlaceholderText = "Lösenord";
            this.TextBox_Login_Password.Size = new System.Drawing.Size(156, 23);
            this.TextBox_Login_Password.TabIndex = 3;
            // 
            // Textbox_Login_Name
            // 
            this.Textbox_Login_Name.Location = new System.Drawing.Point(34, 93);
            this.Textbox_Login_Name.Name = "Textbox_Login_Name";
            this.Textbox_Login_Name.PlaceholderText = "Namn";
            this.Textbox_Login_Name.Size = new System.Drawing.Size(156, 23);
            this.Textbox_Login_Name.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 744);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.KontonPanel);
            this.Controls.Add(this.Button_Start_Page);
            this.Controls.Add(this.Button_Account_Page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bank";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.KontonPanel.ResumeLayout(false);
            this.KontonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.btnCreate.ResumeLayout(false);
            this.btnCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Button_Start_Page;
        private Button Button_Account_Page;
        private Button Button_New_Transaction;
        private Panel StartPanel;
        private Label label2;
        private Label label1;
        private Panel KontonPanel;
        private Label label3;
        private Label label4;
        private Panel btnCreate;
        private Button Button_Login;
        private TextBox TextBox_Login_Password;
        private TextBox Textbox_Login_Name;
        private Label label6;
        private Label label5;
        private Button Button_Create_User;
        private Button Button_Create_Bank_Account;
        private ComboBox AccountSelector;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource accountBindingSource;
        private DataGridViewTextBoxColumn test;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}