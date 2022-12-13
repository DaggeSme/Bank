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
        
        private void button1_Click(object sender, EventArgs e)
        {
            StartPanel.BringToFront();

        }

        private void Button_Account_Page_Click(object sender, EventArgs e)
        {
            KontonPanel.BringToFront();
            Utility.ReadBankAccount(User.Current_User_Id);
            AccountSelector.Items.Clear();
            foreach (string item in User.Current_Bank_Account_Name)
            {
                AccountSelector.Items.Add(item);
            }
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            Utility.ReadUsers();
            //Check if the user name and password is correct when login in button is pressed.
            if (User.Global_User_Name.Contains(Textbox_Login_Name.Text) && User.Global_User_Password[User.Global_User_Name.IndexOf(Textbox_Login_Name.Text)].Contains(TextBox_Login_Password.Text))
            {
                //If the user name and password is correct the user is logged in and the user id is saved in a static variable.
                User.Current_User_Id = User.Global_User_Id[User.Global_User_Name.IndexOf(Textbox_Login_Name.Text)];
                //Show navigation buttons and startpanel
                StartPanel.BringToFront();
                Button_Start_Page.Visible = true;
                Button_Account_Page.Visible = true;
                Button_New_Transaction.Visible = true;
            }
            else
            {
                MessageBox.Show("Du angav Fel l�senord eller Namn!", "Fel!");
            }      
        }
        
        private void Button_Create_User_Click_2(object sender, EventArgs e)
        {
            Utility.ReadUsers();
            if (User.Global_User_Name.Contains(Textbox_Login_Name.Text))
            {
                MessageBox.Show("Detta namnet �r redan anv�nt! \nVar god v�lj ett annat namn!\n", "Upptaget!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Utility.CreateUser(Textbox_Login_Name.Text, TextBox_Login_Password.Text);
                    MessageBox.Show("Tack!\nDitt konto har nu blitit skapat!", "Lyckades!");
                    StartPanel.BringToFront();
                    Button_Start_Page.Visible = true;
                    Button_Account_Page.Visible = true;
                    Button_New_Transaction.Visible = true;
                }
                catch 
                {
                    MessageBox.Show("Ett ov�ntat fel har uppst�tt", "FEL!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Create_Bank_Account_Click(object sender, EventArgs e)
        {
            AccountCreatePopup popup = new AccountCreatePopup();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            Utility.ReadBankAccount(User.Current_User_Id);
            if (dialogresult == DialogResult.OK)
            {
                if (User.Current_Bank_Account_Name.Contains(popup.AccountName.Text))
                {
                    MessageBox.Show("Detta namnet �r redan anv�nt! \nVar god v�lj ett annat namn!\n", "Upptaget!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Utility.CreateBankAccount(popup.AccountName.Text);
                        MessageBox.Show("Tack!\nDitt bank konto har nu blitit skapat!", "Lyckades!");
                        Utility.ReadBankAccount(User.Current_User_Id);
                        AccountSelector.Items.Clear();
                        foreach (string item in User.Current_Bank_Account_Name)
                        {
                            AccountSelector.Items.Add(item);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ett ov�ntat fel har uppst�tt", "FEL!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Button_New_Transaction_Click(object sender, EventArgs e)
        {
            Utility.ReadBankAccount(User.Current_User_Id);
            NewTransactionPopup popup = new NewTransactionPopup();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            
            if (dialogresult == DialogResult.OK)
            {
                //Moeny // From // To
                Utility.CreateTransaction(Convert.ToDouble(popup.Textbox_Amount.Text), User.Current_Bank_Account_Id[User.Current_Bank_Account_Name.IndexOf(popup.Dropdown_From_Account.Text)], popup.Dropdown_To_Account.Text);
                
            }
        }
    }
    public class User
    {
        public static List<string> Global_User_Id = new();
        public static List<string> Global_User_Name = new();
        public static List<string> Global_User_Password = new();
        public static string Current_User_Id = "";
        public static List<string> Global_Bank_Account_Id = new();
        public static List<string> Global_Bank_Account_User_Id = new();
        public static List<string> Current_Bank_Account_Id = new();
        public static List<string> Current_Bank_Account_Name = new();
    }
    public class Utility
    {
        public static string GuidGenerator()
        {
            //Create the list
            List<string> Guids = new();
            string Path = "Data/Guids.xml";
            //Trying to read from the .xml file if the file is empty or not created this step is skipped!
            try
            {
                Guids = new List<string>(XDocument.Load(Path).Descendants("item").Select(element => element.Value).ToArray());
            }
            catch
            {
            }
            //Generate a new Guid and check if it is already used if not add it to the list if it generates a new Guid.
            string newGuid = Guid.NewGuid().ToString();
            while (Guids.Contains(newGuid))
            {
                newGuid = Guid.NewGuid().ToString();
            }
            Guids.Add(newGuid);
            //Saving the list/array to a .xml file
            XDocument xml = new();
            xml.Add(new XElement("root", Guids.Select(x => new XElement("item", x))));
            xml.Save(Path);
            //After everything is done return the newly generated Guid.
            return (newGuid);
        }
        public static void CreateUser(string Name, string Pass)
        {
            Directory.CreateDirectory("Data");
            string NewUserId = GuidGenerator();
            User.Current_User_Id = NewUserId;
            string path = "Data/Users.xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.CreateElement("User");
            XmlElement user_id = doc.CreateElement("Id");
            XmlElement name = doc.CreateElement("Name");
            XmlElement password = doc.CreateElement("Password");
            user_id.InnerText = NewUserId;
            name.InnerText = Name;
            password.InnerText = Pass;
            root.AppendChild(user_id);
            root.AppendChild(name);
            root.AppendChild(password);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
            Directory.CreateDirectory("Data/Users/" + NewUserId);
            if (!File.Exists("Data/Users/" + NewUserId + "/Bank-Accounts.xml"))
            {
                File.AppendAllText("Data/Users/" + NewUserId + "/Bank-Accounts.xml", "<root>\r\n</root>");
            }
        }
        public static void CreateBankAccount(string Name)
        {

            string New_Bank_Account_Id = GuidGenerator();

            //Save new Bank account to global file
            //Save only account id and user_id
            string path = "Data/Global-Bank-Accounts.xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.CreateElement("Account");
            XmlElement bank_account_id = doc.CreateElement("Bank_Account_Id");
            XmlElement user_id = doc.CreateElement("User_Id");
            bank_account_id.InnerText = New_Bank_Account_Id;
            user_id.InnerText = User.Current_User_Id;
            root.AppendChild(bank_account_id);
            root.AppendChild(user_id);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);



            //Save new bank account to user file
            //Save Account name and id
            path = "Data/Users/" + User.Current_User_Id + "/Bank-Accounts.xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            XmlElement name = doc.CreateElement("Name");
            doc.Load(path);
            bank_account_id.InnerText = New_Bank_Account_Id;
            name.InnerText = Name;
            root.AppendChild(bank_account_id);
            root.AppendChild(name);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
        }
        public static void ReadUsers()
        {
            string path = "Data/Users.xml";
            try
            {
                //Create list to load data in to progam for .xml file
                User.Global_User_Id = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Id").Select(element => element.Value).ToArray());
                User.Global_User_Name = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Name").Select(element => element.Value).ToArray());
                User.Global_User_Password = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Password").Select(element => element.Value).ToArray());
            }
            catch
            {
            }

        }
        public static void ReadBankAccount(string user)
        {
            try
            {
                //Create list to load data in to progam for .xml file
                if (user == "Global")
                {
                    string path = "Data/Global-Bank-Accounts.xml";
                    User.Global_Bank_Account_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Bank_Account_Id").Select(element => element.Value).ToArray());
                    User.Global_Bank_Account_User_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("User_Id").Select(element => element.Value).ToArray());
                }
                else
                {
                    string path = "Data/Global-Bank-Accounts.xml";
                    User.Global_Bank_Account_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Bank_Account_Id").Select(element => element.Value).ToArray());
                    User.Global_Bank_Account_User_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("User_Id").Select(element => element.Value).ToArray());
                    path = "Data/Users/" + User.Current_User_Id + "/Bank-Accounts.xml";
                    User.Current_Bank_Account_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Bank_Account_Id").Select(element => element.Value).ToArray());
                    User.Current_Bank_Account_Name = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Name").Select(element => element.Value).ToArray());
                }
            }
            catch
            {
            }

        }
        public static void CreateTransaction(double Money, string from_id, string to_id)
        {
            string New_Transaction_Id = GuidGenerator();
            //Begin with removing money form fist account
            //Find out what path is using user id form global accounts file
            ReadBankAccount("Global");
            string path = "Data/Users/" + User.Global_Bank_Account_User_Id[User.Global_Bank_Account_Id.IndexOf(from_id)] + "/" + from_id + ".xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.CreateElement("Transaction");
            XmlElement Transaction_Id = doc.CreateElement("Transaction_id");
            XmlElement Direction = doc.CreateElement("Direction");
            XmlElement Amount = doc.CreateElement("Amount");
            XmlElement Destination = doc.CreateElement("Destination");
            Transaction_Id.InnerText = New_Transaction_Id;
            Direction.InnerText = "Out";
            Amount.InnerText = Convert.ToString(Money);
            Destination.InnerText = to_id;
            root.AppendChild(Transaction_Id);
            root.AppendChild(Direction);
            root.AppendChild(Amount);
            root.AppendChild(Destination);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
            //Then add money to destination

            path = "Data/Users/" + User.Global_Bank_Account_User_Id[User.Global_Bank_Account_Id.IndexOf(to_id)] + "/" + to_id + ".xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            doc.Load(path);
            XmlElement Source = doc.CreateElement("Source");
            Transaction_Id.InnerText = New_Transaction_Id;
            Direction.InnerText = "In";
            Amount.InnerText = Convert.ToString(Money);
            Source.InnerText = from_id;
            root.AppendChild(Transaction_Id);
            root.AppendChild(Direction);
            root.AppendChild(Amount);
            root.AppendChild(Destination);
            root.AppendChild(Source);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
        }
        public static void Transactions(string Bank_Account_Id)
        {

        }
    }
}