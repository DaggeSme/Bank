using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace Bank
{
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
        public static void CreateUser(string Name, string Pass, string Email)
        {
            Directory.CreateDirectory("Data");
            string NewUserId = GuidGenerator();
            Utility.Current_User_Id = NewUserId;
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
            XmlElement email = doc.CreateElement("Email");
            user_id.InnerText = NewUserId;
            name.InnerText = Name;
            password.InnerText = Pass;
            email.InnerText = Email;
            root.AppendChild(user_id);
            root.AppendChild(name);
            root.AppendChild(password);
            root.AppendChild(email);
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
            user_id.InnerText = Utility.Current_User_Id;
            root.AppendChild(bank_account_id);
            root.AppendChild(user_id);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);

            

            //Save new bank account to user file
            //Save Account name and id
            path = "Data/Users/" + Utility.Current_User_Id + "/Bank-Accounts.xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            XmlElement name = doc.CreateElement("Name");
            doc.Load(path);
            bank_account_id.InnerText = New_Bank_Account_Id;
            name.InnerText = Name;
            root.RemoveChild(user_id);
            root.AppendChild(bank_account_id);
            root.AppendChild(name);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
        }
        public static void ReadUsers()
        {
            Utility.Global_User_Id.Clear();
            Utility.Global_User_Name.Clear();
            Utility.Global_User_Password.Clear();
            Utility.Global_User_Email.Clear();
            string path = "Data/Users.xml";
            try
            {
                //Create list to load data in to progam for .xml file
                Utility.Global_User_Id = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Id").Select(element => element.Value).ToArray());
                Utility.Global_User_Name = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Name").Select(element => element.Value).ToArray());
                Utility.Global_User_Password = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Password").Select(element => element.Value).ToArray());
                Utility.Global_User_Email = new List<string>(XDocument.Load(path).Descendants("User").Descendants("Email").Select(element => element.Value).ToArray());
            }
            catch
            {
            }

        }
        public static void ReadBankAccount(string user)
        {
            Utility.Global_Bank_Account_Id.Clear();
            Utility.Global_Bank_Account_User_Id.Clear();
            Utility.Current_Bank_Account_Id.Clear();
            Utility.Current_Bank_Account_Name.Clear();
            try
            {
                //Create list to load data in to progam for .xml file
                if (user == "Global")
                {
                    string path = "Data/Global-Bank-Accounts.xml";
                    Utility.Global_Bank_Account_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Bank_Account_Id").Select(element => element.Value).ToArray());
                    Utility.Global_Bank_Account_User_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("User_Id").Select(element => element.Value).ToArray());
                }
                else
                {
                    string path = "Data/Global-Bank-Accounts.xml";
                    Utility.Global_Bank_Account_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Bank_Account_Id").Select(element => element.Value).ToArray());
                    Utility.Global_Bank_Account_User_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("User_Id").Select(element => element.Value).ToArray());
                    path = "Data/Users/" + Utility.Current_User_Id + "/Bank-Accounts.xml";
                    Utility.Current_Bank_Account_Id = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Bank_Account_Id").Select(element => element.Value).ToArray());
                    Utility.Current_Bank_Account_Name = new List<string>(XDocument.Load(path).Descendants("Account").Descendants("Name").Select(element => element.Value).ToArray());
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
            string Date = Convert.ToString(DateTime.Now);

            ReadBankAccount("Global");
            string path = "Data/Users/" + Utility.Global_Bank_Account_User_Id[Utility.Global_Bank_Account_Id.IndexOf(from_id)] + "/" + from_id + ".xml";
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
            XmlElement Location = doc.CreateElement("Location");
            XmlElement date = doc.CreateElement("Date");
            Transaction_Id.InnerText = New_Transaction_Id;
            Direction.InnerText = "Out";
            Amount.InnerText = Convert.ToString(Money);
            Location.InnerText = to_id;
            date.InnerText = Date;
            root.AppendChild(Transaction_Id);
            root.AppendChild(Direction);
            root.AppendChild(Amount);
            root.AppendChild(Location);
            root.AppendChild(date);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
            //Then add money to destination
            path = "Data/Users/" + Utility.Global_Bank_Account_User_Id[Utility.Global_Bank_Account_Id.IndexOf(to_id)] + "/" + to_id + ".xml";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            doc.Load(path);
            Transaction_Id.InnerText = New_Transaction_Id;
            Direction.InnerText = "In";
            Amount.InnerText = Convert.ToString(Money);
            Location.InnerText = from_id;
            root.AppendChild(Transaction_Id);
            root.AppendChild(Direction);
            root.AppendChild(Amount);
            root.AppendChild(Location);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
        }
        public static void ReadTransactions(string User_Id, string Bank_Account_Id)
        {
            Utility.Date.Clear();
            Utility.Amount.Clear();
            Utility.Location.Clear();
            Utility.Direction.Clear();
            Utility.Balance.Clear();
            //Show date, amount, current balance, destination/source
            string path = "Data/Users/" + User_Id + "/" + Bank_Account_Id + ".xml";
            Utility.Date = new List<string>(XDocument.Load(path).Descendants("Transaction").Descendants("Date").Select(element => element.Value).ToArray());
            Utility.Amount = new List<string>(XDocument.Load(path).Descendants("Transaction").Descendants("Amount").Select(element => element.Value).ToArray());
            Utility.Direction = new List<string>(XDocument.Load(path).Descendants("Transaction").Descendants("Direction").Select(element => element.Value).ToArray());
            Utility.Location = new List<string>(XDocument.Load(path).Descendants("Transaction").Descendants("Location").Select(element => element.Value).ToArray());
            double tempsum = 1000;
            for (int i = 0; i <= Utility.Amount.Count - 1; i++)
            {
                if (Convert.ToString(Utility.Direction[i]) == "In")
                {
                    tempsum += Convert.ToDouble(Utility.Amount[i]);
                    Utility.Amount[i] = "+" + Utility.Amount[i];
                }
                else
                {
                    tempsum -= Convert.ToDouble(Utility.Amount[i]);
                    Utility.Amount[i] = "-" + Utility.Amount[i];
                }
                Utility.Balance.Add(tempsum);
            }
            
        }


        public static List<string> Global_User_Id = new();
        public static List<string> Global_User_Name = new();
        public static List<string> Global_User_Password = new();
        public static List<string> Global_User_Email = new();
        public static string Current_User_Id = "";
        public static List<string> Global_Bank_Account_Id = new();
        public static List<string> Global_Bank_Account_User_Id = new();
        public static List<string> Current_Bank_Account_Id = new();
        public static List<string> Current_Bank_Account_Name = new();

        //Show date, amount, current balance, destination/source
        public static List<string> Date = new();
        public static List<string> Amount = new();
        public static List<double> Balance = new();
        public static List<string> Location = new();
        public static List<string> Direction = new();
    }
}
