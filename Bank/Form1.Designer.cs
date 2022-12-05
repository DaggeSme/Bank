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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KontonPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartPanel.SuspendLayout();
            this.KontonPanel.SuspendLayout();
            this.btnCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Konton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ny transaktion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.label4);
            this.StartPanel.Controls.Add(this.label2);
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Location = new System.Drawing.Point(12, 43);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KontonPanel
            // 
            this.KontonPanel.Controls.Add(this.label3);
            this.KontonPanel.Location = new System.Drawing.Point(12, 43);
            this.KontonPanel.Name = "KontonPanel";
            this.KontonPanel.Size = new System.Drawing.Size(599, 378);
            this.KontonPanel.TabIndex = 4;
            this.KontonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.KontonPanel_Paint);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Controls.Add(this.button4);
            this.btnCreate.Controls.Add(this.btnLogin);
            this.btnCreate.Controls.Add(this.LoginPassword);
            this.btnCreate.Controls.Add(this.LoginName);
            this.btnCreate.Controls.Add(this.label6);
            this.btnCreate.Controls.Add(this.label5);
            this.btnCreate.Location = new System.Drawing.Point(12, 43);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(599, 375);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCreate_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "Skapa konto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(34, 151);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 25);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Logga in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(34, 122);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(156, 23);
            this.LoginPassword.TabIndex = 3;
            this.LoginPassword.Text = "Lösenord";
            // 
            // LoginName
            // 
            this.LoginName.Location = new System.Drawing.Point(34, 93);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(156, 23);
            this.LoginName.TabIndex = 2;
            this.LoginName.Text = "Namn";
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KontonPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.KontonPanel.ResumeLayout(false);
            this.KontonPanel.PerformLayout();
            this.btnCreate.ResumeLayout(false);
            this.btnCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel StartPanel;
        private Label label2;
        private Label label1;
        private Panel KontonPanel;
        private Label label3;
        private Label label4;
        private Panel btnCreate;
        private Button btnLogin;
        private TextBox LoginPassword;
        private TextBox LoginName;
        private Label label6;
        private Label label5;
        private Button button4;
    }
}