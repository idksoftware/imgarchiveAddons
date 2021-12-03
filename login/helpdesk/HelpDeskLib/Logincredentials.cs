

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;


namespace HelpDeskLib
{

    public class Item
    {
        private String m_email;
        private String m_hashedPassword;
        public Item(String hashedPW, String email)
        {
            m_email = email;
            m_hashedPassword = hashedPW;
        }

        public String Email
        {
            get { return m_email; }
            set { m_email = value; }
        }

        public String HashedPassword
        {
            get { return m_hashedPassword; }
            set { m_hashedPassword = value; }
        }
    }
    public class Logincredentials
    {


        Dictionary<string, Item> m_passwordList;


        static public bool ValidatePassword(string password)
        {
            const int MIN_LENGTH = 10;

            String nonString = "\"!£$%^&*()_-+={}[]:@~;'#|\\.,<>?/";

            if (password == null)
            {
                return false;
            }

            if (password.Length <= MIN_LENGTH)
            {
                return false;
            }
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNon = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                foreach (char sc in nonString)
                {
                    if (c == sc)
                    {
                        hasNon = true;
                    }
                }

            }

            bool isValid = hasUpper && hasLower && hasNon;
            return isValid;

        }

        static private String HashPassword(String password)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 loginSHA256 = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = loginSHA256.ComputeHash(enc.GetBytes(password));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }

        private bool addEntry(String user, String password, String email)
        {

            if (readFile() == false)
            {
                return false;
            }
            String hashedPassword = HashPassword(password);
            Item item = new Item(hashedPassword, email);
            m_passwordList.Add(user, item);

            if (writeFile() == false)
            {
                return false;
            }
            return true;
        }



        private bool readFile()
        {
            String path = @"C:\temp\passwd.csv";
            if (File.Exists(path))
            {
                m_passwordList.Clear();
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        String line = reader.ReadLine();
                        String[] values = line.Split(',');

                        string user = values[0];
                        string hashedPassword = values[1];
                        string email = values[2];
                        Item item = new Item(hashedPassword, email);
                        m_passwordList.Add(user, item);
                    }
                }
            }
            return true;
        }

        private bool writeFile()
        {
            using (var w = new StreamWriter(@"C:\temp\passwd.csv"))
            {
                foreach (KeyValuePair<string, Item> entry in m_passwordList)
                {
                    var user = entry.Key;
                    var hash = entry.Value.HashedPassword;
                    var email = entry.Value.Email;
                    var line = string.Format("{0},{1},{2}", user, hash, email);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
            return true;
        }


        public Logincredentials()
        {
            m_passwordList = new Dictionary<string, Item>();
        }

        public bool Login(String userName, String password)
        {

            if (readFile() == false)
            {
                return false;
            }
            Item item;
            if (m_passwordList.TryGetValue(userName, out item) == false)
            {
                return false;
            }
            String hashedPassword = HashPassword(password);
            if (String.Compare(item.HashedPassword, hashedPassword) != 0)
            {
                return false;
            }
            return true;
        }
        // longer that 10, 1 Upper 1 lower anf 1 non char
        public bool NewUser(String userName, String password, String email)
        {
            if (ValidatePassword(password) == false)
            {
                return false;
            }
            addEntry(userName, password, email);
            return true;
        }

        public bool AddUser(String userName, String password, String email)
        {
            addEntry(userName, password, email);
            return true;
        }

        public bool NewPassword(String userName, String password, String newpassword)
        {
            if (ValidatePassword(newpassword) == false)
            {
                return false;
            }
            if (Login(userName, password) == false)
            {

                return false;
            }

            Item item = m_passwordList[userName];
            String hashedPassword = HashPassword(newpassword);
            item.HashedPassword = hashedPassword;
            m_passwordList[userName] = item;

            if (writeFile() == false)
            {
                return false;
            }

            return true;
        }

        public String ForgotPassword(String userName)
        {
            if (readFile() == false)
            {
                return null;
            }
            Item item;
            if (m_passwordList.TryGetValue(userName, out item) == false)
            {
                return null;
            }
            return item.Email;
        }
    }
}
