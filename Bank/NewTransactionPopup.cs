using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class NewTransactionPopup : Form
    {
        public NewTransactionPopup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewTransactionPopup_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox= false;
            Dropdown_From_Account.Items.Clear();
            Dropdown_To_Account.Items.Clear();
            foreach (string items in Utility.Current_Bank_Account_Name)
            {
                Dropdown_From_Account.Items.Add(items);
                Dropdown_To_Account.Items.Add(items);
            }
            
            foreach (string items in Utility.Global_Bank_Account_Id)
            {
                if (Utility.Current_Bank_Account_Id.Contains(items) == false)
                {
                    Dropdown_To_Account.Items.Add(items);
                }
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Textbox_Amount.Text.Contains('.'))
            {
                MessageBox.Show("Du har använt en punkt istället för ett kommatecken! \nVar god byt ut punkten till ett kommatecken!", "Fel format",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    //if the account has -500 in balnace after the transacten do error!
                    Utility.ReadTransactions(Utility.Current_User_Id, Utility.Current_Bank_Account_Id[Utility.Current_Bank_Account_Name.IndexOf(Dropdown_From_Account.Text)]);
                    if (Utility.Balance.Last() - Convert.ToDouble(Textbox_Amount.Text) <= -500.0)
                    {
                        MessageBox.Show("Saldot på kontot blir under -500kr om transaktionen genomförs! \nVar god skriv in ett lägre belopp\nSaldo på kontot är just nu: " + Utility.Balance.Last(), "Lågt saldo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //First determine what method to use to obtain to account balance then get that and then check
                    //if the account has 1 000 000 in balance after the transacten do error!
                    else if (Utility.Current_Bank_Account_Name.Contains(Dropdown_To_Account.Text))
                    {
                        //parse user id of the bank account owner
                        Utility.ReadTransactions(Utility.Current_User_Id, Utility.Current_Bank_Account_Id[Utility.Current_Bank_Account_Name.IndexOf(Dropdown_To_Account.Text)]);
                        if (Utility.Balance.Last() + Convert.ToDouble(Textbox_Amount.Text) >= 1000000.0)
                        {
                            MessageBox.Show("Saldot på kontot blir över 1 000 000kr om transaktionen genomförs! \nVar god skriv in ett lägre belopp\nSaldo på kontot är just nu: " + Utility.Balance.Last(), "Högt saldo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else if (Utility.Global_Bank_Account_Id.Contains(Dropdown_To_Account.Text))
                    {
                        Utility.ReadTransactions(Utility.Global_Bank_Account_User_Id[Utility.Global_Bank_Account_Id.IndexOf(Dropdown_To_Account.Text)], Dropdown_To_Account.Text);
                        if (Utility.Balance.Last() + Convert.ToDouble(Textbox_Amount.Text) >= 1000000.0)
                        {
                            MessageBox.Show("Saldot på kontot blir över 1 000 000kr om transaktionen genomförs! \nVar god skriv in ett lägre belopp\nSaldo på kontot är just nu: " + Utility.Balance.Last(), "Högt saldo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            
        }
    }
}
