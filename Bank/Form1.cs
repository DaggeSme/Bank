using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
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
        static string GuidGenerator()
        {
            //Create the list
            List<string> Guids = new();
            string Path = "Used-Guids.xml";
            //Trying to read from the .xml file if the file is empty or not created this step is skipped!
            try
            {
                Guids = new List<string>(XDocument.Load(Path).Descendants("item").Select(element => element.Value).ToArray());
            }
            catch
            {
                Console.WriteLine("The file was empty or non existent, skipping reading process!");
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
        static void CreateUser(string Name, string Pass)
        {
            
            string NewUserId = GuidGenerator();
            string path = "Users.xml";
            Debug.WriteLine("===============");
            Debug.WriteLine(File.Exists(path));
            if (!File.Exists(path))
            {
                File.AppendAllText(path, "<root>\r\n</root>");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.CreateElement("User");
            XmlElement user_id = doc.CreateElement("User_id");
            XmlElement name = doc.CreateElement("name");
            XmlElement password = doc.CreateElement("password");
            user_id.InnerText = NewUserId;
            name.InnerText = Name;
            password.InnerText = Pass;
            root.AppendChild(user_id);
            root.AppendChild(name);
            root.AppendChild(password);
            doc.DocumentElement.AppendChild(root);
            doc.Save(path);
            Directory.CreateDirectory(NewUserId);
            if (!File.Exists(NewUserId + "/" + "konton.xml"))
            {
                File.AppendAllText(NewUserId + "/" + "konton.xml", "<root>\r\n</root>");
            }
        }

        public static void ReadUsers()
        {
            try
            {
                //Create list to load data in to progam for .xml file
                User.User_id = new List<string>(XDocument.Load("Users.xml").Descendants("User").Descendants("User_id").Select(element => element.Value).ToArray());
                User.Name = new List<string>(XDocument.Load("Users.xml").Descendants("User").Descendants("name").Select(element => element.Value).ToArray());
                User.Password = new List<string>(XDocument.Load("Users.xml").Descendants("User").Descendants("password").Select(element => element.Value).ToArray());
            }
            catch 
            {
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartPanel.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontonPanel.BringToFront();
        }

        private void KontonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ReadUsers();
            //Check if the user name and password is correct when login in button is pressed.
            if (User.Name.Contains(LoginName.Text) && User.Password[User.Name.IndexOf(LoginName.Text)].Contains(LoginPassword.Text))
            {
                //Show navigation buttons and startpanel
                StartPanel.BringToFront();
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("Du angav Fel lösenord eller Namn!", "Fel!");
            }

                
        }
        public class User
        {
            public static List<string> User_id = new();
            public static List<string> Name = new();
            public static List<string> Password = new();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            ReadUsers();
            if (User.Name.Contains(LoginName.Text))
            {
                MessageBox.Show("Detta namnet är redan använt! \nVar god välj ett annat namn!\n", "Upptaget!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try 
                {
                    CreateUser(LoginName.Text, LoginPassword.Text);
                    MessageBox.Show("Tack!\nDitt konto har nu blitit skapat!", "Lyckades!");
                    StartPanel.BringToFront();
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                }
                catch 
                {
                    MessageBox.Show("Ett oväntat fel har uppstått", "FEL!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnCreate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}