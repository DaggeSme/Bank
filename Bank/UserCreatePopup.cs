using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class UserCreatePopup : Form
    {
        public UserCreatePopup()
        {
            InitializeComponent();
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            if (Textbox_Name.Text.Length < 1)
            {
                MessageBox.Show("Var god skriv in ett namn! \n", "Tomt fält!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Textbox_Email.Text.Length < 1)
            {
                MessageBox.Show("Var god skriv in en email! \n", "Tomt fält!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Textbox_Password.Text.Length < 1)
            {
                MessageBox.Show("Var god skriv in ett lösenord! \n", "Tomt fält!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Textbox_Email.Text.Contains('@') == false || Textbox_Email.Text.Contains('.') == false)
            {
                MessageBox.Show("Emailen du angav är inte giltig! \nVar god ange en giltig Email!\n", "Ej giltig!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Utility.Global_User_Email.Contains(Textbox_Email.Text))
            {
                MessageBox.Show("Denna Emailen är redan använd! \nVar god välj en annat Email!\n", "Upptaget!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
