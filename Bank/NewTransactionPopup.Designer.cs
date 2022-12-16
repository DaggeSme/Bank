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
            this.Dropdown_To_Account = new System.Windows.Forms.ComboBox();
            this.Textbox_Amount = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Till Konto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Från Konto";
            // 
            // Dropdown_From_Account
            // 
            this.Dropdown_From_Account.FormattingEnabled = true;
            this.Dropdown_From_Account.Location = new System.Drawing.Point(88, 12);
            this.Dropdown_From_Account.Name = "Dropdown_From_Account";
            this.Dropdown_From_Account.Size = new System.Drawing.Size(159, 23);
            this.Dropdown_From_Account.TabIndex = 2;
            this.Dropdown_From_Account.Text = "Välj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Belopp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Genomför transaktionen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dropdown_To_Account
            // 
            this.Dropdown_To_Account.FormattingEnabled = true;
            this.Dropdown_To_Account.Location = new System.Drawing.Point(88, 43);
            this.Dropdown_To_Account.Name = "Dropdown_To_Account";
            this.Dropdown_To_Account.Size = new System.Drawing.Size(159, 23);
            this.Dropdown_To_Account.TabIndex = 3;
            this.Dropdown_To_Account.Text = "Välj";
            // 
            // Textbox_Amount
            // 
            this.Textbox_Amount.Location = new System.Drawing.Point(88, 72);
            this.Textbox_Amount.Name = "Textbox_Amount";
            this.Textbox_Amount.PlaceholderText = "Belopp";
            this.Textbox_Amount.Size = new System.Drawing.Size(159, 23);
            this.Textbox_Amount.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(173, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Avbryt";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NewTransactionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 145);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Textbox_Amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dropdown_To_Account);
            this.Controls.Add(this.Dropdown_From_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewTransactionPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ny transaktion";
            this.Load += new System.EventHandler(this.NewTransactionPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        public ComboBox Dropdown_From_Account;
        public ComboBox Dropdown_To_Account;
        public TextBox Textbox_Amount;
        private Button button3;
    }
}