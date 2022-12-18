namespace Bank
{
    partial class UserCreatePopup
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
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lösenord";
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.Location = new System.Drawing.Point(72, 4);
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(154, 23);
            this.Textbox_Name.TabIndex = 3;
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.Location = new System.Drawing.Point(72, 33);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(154, 23);
            this.Textbox_Email.TabIndex = 4;
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.Location = new System.Drawing.Point(72, 61);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.Size = new System.Drawing.Size(154, 23);
            this.Textbox_Password.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(126, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stäng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(10, 90);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(100, 23);
            this.Button_Ok.TabIndex = 7;
            this.Button_Ok.Text = "Skapa konto";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // UserCreatePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 122);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Textbox_Password);
            this.Controls.Add(this.Textbox_Email);
            this.Controls.Add(this.Textbox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCreatePopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserCreatePopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button Button_Ok;
        public TextBox Textbox_Name;
        public TextBox Textbox_Email;
        public TextBox Textbox_Password;
    }
}