namespace Bank
{
    partial class NewTransactionPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.Dropdown_From_Account = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Dropdown_To_Account = new System.Windows.Forms.ComboBox();
            this.Textbox_Amount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Till Konto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Från Konto";
            // 
            // Dropdown_From_Account
            // 
            this.Dropdown_From_Account.FormattingEnabled = true;
            this.Dropdown_From_Account.Location = new System.Drawing.Point(139, 77);
            this.Dropdown_From_Account.Name = "Dropdown_From_Account";
            this.Dropdown_From_Account.Size = new System.Drawing.Size(159, 23);
            this.Dropdown_From_Account.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Belopp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(88, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Genomför transaktionen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(249, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Avbryt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dropdown_To_Account
            // 
            this.Dropdown_To_Account.FormattingEnabled = true;
            this.Dropdown_To_Account.Location = new System.Drawing.Point(139, 108);
            this.Dropdown_To_Account.Name = "Dropdown_To_Account";
            this.Dropdown_To_Account.Size = new System.Drawing.Size(159, 23);
            this.Dropdown_To_Account.TabIndex = 3;
            // 
            // Textbox_Amount
            // 
            this.Textbox_Amount.Location = new System.Drawing.Point(139, 137);
            this.Textbox_Amount.Name = "Textbox_Amount";
            this.Textbox_Amount.Size = new System.Drawing.Size(159, 23);
            this.Textbox_Amount.TabIndex = 8;
            // 
            // NewTransactionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Textbox_Amount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dropdown_To_Account);
            this.Controls.Add(this.Dropdown_From_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTransactionPopup";
            this.Text = "NewTransactionPopup";
            this.Load += new System.EventHandler(this.NewTransactionPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        public ComboBox Dropdown_From_Account;
        public ComboBox Dropdown_To_Account;
        public TextBox Textbox_Amount;
    }
}