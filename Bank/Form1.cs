using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Bank
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Button_Start_Page_Click(object sender, EventArgs e)
        {
            StartPanel.BringToFront();
        }

        private void Button_Account_Page_Click(object sender, EventArgs e)
        {
            KontonPanel.BringToFront();
            Utility.ReadBankAccount(Utility.Current_User_Id);
            AccountSelector.Text = "Välj";
            Saldo.Text = "";
            AccountSelector.Items.Clear();
            Bank_account_View.Rows.Clear();
            foreach (string item in Utility.Current_Bank_Account_Name)
            {
                AccountSelector.Items.Add(item);
            }
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            Utility.ReadUsers();
            //Check if the email and password is correct
            if (Utility.Global_User_Email.Contains(Textbox_Login_Email.Text) && Utility.Global_User_Password[Utility.Global_User_Email.IndexOf(Textbox_Login_Email.Text)] == (Textbox_Login_Password.Text))
            {
                //If the email and password is correct the user is logged in and the user id is saved in a static variable.
                Utility.Current_User_Id = Utility.Global_User_Id[Utility.Global_User_Email.IndexOf(Textbox_Login_Email.Text)];
                //Show navigation buttons and startpanel
                StartPanel.BringToFront();
                Button_Start_Page.Visible = true;
                Button_Account_Page.Visible = true;
                Button_Logout.Visible = true;
                Welcome.Text = "Välkommen " + Utility.Global_User_Name[Utility.Global_User_Email.IndexOf(Textbox_Login_Email.Text)];
            }
            else
            {
                MessageBox.Show("Du angav Fel lösenord eller Namn!", "Fel!");
            }      
        }
        
        private void Button_Create_User_Click(object sender, EventArgs e)
        {
            Utility.ReadUsers();
            UserCreatePopup popup = new UserCreatePopup();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();

            if (dialogresult == DialogResult.OK)
            {
                try
                {
                    Utility.CreateUser(popup.Textbox_Name.Text, popup.Textbox_Password.Text, popup.Textbox_Email.Text);
                    MessageBox.Show("Tack!\nDitt konto har nu blitit skapat!", "Lyckades!");
                    StartPanel.BringToFront();
                    Button_Start_Page.Visible = true;
                    Button_Account_Page.Visible = true;
                    Button_Logout.Visible = true;
                    Welcome.Text = "Välkommen " + popup.Textbox_Name.Text;
                }
                catch
                {
                    MessageBox.Show("Ett oväntat fel har uppstått", "FEL!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void Button_Create_Bank_Account_Click(object sender, EventArgs e)
        {
            AccountCreatePopup popup = new AccountCreatePopup();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            Utility.ReadBankAccount(Utility.Current_User_Id);
            if (dialogresult == DialogResult.OK)
            {
                if (Utility.Current_Bank_Account_Name.Contains(popup.AccountName.Text))
                {
                    MessageBox.Show("Detta namnet är redan använt! \nVar god välj ett annat namn!\n", "Upptaget!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Utility.CreateBankAccount(popup.AccountName.Text);
                        MessageBox.Show("Tack!\nDitt bank konto har nu blitit skapat!", "Lyckades!");
                        Utility.ReadBankAccount(Utility.Current_User_Id);
                        AccountSelector.Items.Clear();
                        foreach (string item in Utility.Current_Bank_Account_Name)
                        {
                            AccountSelector.Items.Add(item);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ett oväntat fel har uppstått", "FEL!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Button_New_Transaction_Click(object sender, EventArgs e)
        {
            Utility.ReadBankAccount(Utility.Current_User_Id);
            NewTransactionPopup popup = new NewTransactionPopup();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            
            if (dialogresult == DialogResult.OK)
            {
                //Check to see what method should be used depeding on what account is chosen
                if (Utility.Current_Bank_Account_Name.Contains(popup.Dropdown_To_Account.Text))
                {
                    Utility.CreateTransaction(Convert.ToDouble(popup.Textbox_Amount.Text), Utility.Current_Bank_Account_Id[Utility.Current_Bank_Account_Name.IndexOf(popup.Dropdown_From_Account.Text)], Utility.Current_Bank_Account_Id[Utility.Current_Bank_Account_Name.IndexOf(popup.Dropdown_To_Account.Text)]);
                }
                else
                {
                    Utility.CreateTransaction(Convert.ToDouble(popup.Textbox_Amount.Text), Utility.Current_Bank_Account_Id[Utility.Current_Bank_Account_Name.IndexOf(popup.Dropdown_From_Account.Text)], popup.Dropdown_To_Account.Text);
                }
                //Update transaction view if account has had a new transaction made
                if (popup.Dropdown_From_Account.Text == AccountSelector.Text || popup.Dropdown_To_Account.Text == AccountSelector.Text)
                {
                    AccountSelector_SelectedIndexChanged(sender, e);
                }
                

            }
        }

        public void AccountSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Bank_account_View.Rows.Clear();
                Utility.ReadBankAccount(Utility.Current_User_Id);
                Utility.ReadTransactions(Utility.Current_User_Id, Utility.Current_Bank_Account_Id[Utility.Current_Bank_Account_Name.IndexOf(AccountSelector.Text)]);
                for (int i = 0; i <= Utility.Balance.Count - 1; i++)
                {
                    Bank_account_View.Rows.Insert(0, Utility.Date[i], Utility.Amount[i], Utility.Location[i], Utility.Balance[i]);
                }
                Bank_account_View.Update();
                Saldo.Text = "Saldo för bankkontot " + AccountSelector.Text + " är " + Convert.ToString(Utility.Balance.Last()) + "kr";
            }
            catch
            {
                MessageBox.Show("Detta kontot har inte några transaktioner ännu", "Fel!");
            }
            
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            Button_Start_Page.Visible = false;
            Button_Account_Page.Visible = false;
            Button_Logout.Visible = false;
            Textbox_Login_Email.Clear();
            Textbox_Login_Password.Clear();
            LoginPanel.BringToFront();
            
        }
    }
}