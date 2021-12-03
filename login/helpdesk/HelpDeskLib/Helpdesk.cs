using System;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelpDeskLib
{
    public class Customer
    {
        private String m_name;
        private String m_address;
        private String m_phone;
        private String m_email;
        private String m_user;
        private String m_password;

        public Customer()
        { }
        public Customer(String name, String address, String phone,
                            String email, String user, String password)
        {
            m_name = name;
            m_address = address;
            m_phone = phone;
            m_email = email;
            m_user = user;
            m_password = password;
        }
        public String Name
        { get { return m_name;  } set { m_name = value; }}

        public String Address
        { get { return m_address;  } set { m_address = value; }}

        public String Phone
        { get { return m_phone; } set { m_phone = value; } }

        public String Email
        { get { return m_email; } set { m_email = value; } }

        public String User
        { get { return m_user; } set { m_user = value; } }

        public String Password
        { get { return m_password; } set { m_password = value; } }

    }

      
    public class HelpDeskData
    {
        Dictionary<string, Customer> m_customerList;
        public bool ReadFile()
        {
            String path = @"C:\\temp\\Customers.xml";
            
            if (File.Exists(path))
            {

                m_customerList.Clear();
                XmlTextReader reader = new XmlTextReader(path);
                reader.Read();
                while (reader.Read())
                {
                    if (reader.Name == "Customers")
                    {
                        reader.Read();
                        while (reader.NodeType == XmlNodeType.Element && reader.Name == "Customer") 
                        {
                            Customer customer = new Customer();
                            reader.Read();
                            while (reader.NodeType != XmlNodeType.EndElement && reader.Name != "Customer")
                            {
                                
                                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Name")
                                {
                                    reader.Read();
                                    customer.Name = reader.Value;
                                    reader.Read();
                                    reader.Read();
                                    continue;
                                }
                                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Address")
                                {
                                    reader.Read();
                                    customer.Address = reader.Value;
                                    reader.Read();
                                    reader.Read();
                                    continue;
                                }
                                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Phone")
                                {
                                    reader.Read();
                                    customer.Phone = reader.Value;
                                    reader.Read();
                                    reader.Read();
                                    continue;
                                }
                                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Email")
                                {
                                    reader.Read();
                                    customer.Email = reader.Value;
                                    reader.Read();
                                    reader.Read();
                                    continue;
                                }
                                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "User")
                                {
                                    reader.Read();
                                    customer.User = reader.Value;
                                    reader.Read();
                                    reader.Read();
                                    m_customerList.Add(customer.User, customer);
                                    continue;
                                }
                                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Password")
                                {
                                    reader.Read();
                                    customer.Password = reader.Value;
                                    reader.Read();
                                    reader.Read();
                                    
                                    continue;
                                }
                               
                            }
                            reader.Read();
                        }

                    }
                }
            }
            return true;
        }

        public HelpDeskData()
        {
            m_customerList = new Dictionary<string, Customer>();
        }

        public bool WriteFile()
        {
            XmlTextWriter textWriter = new XmlTextWriter(@"C:\\temp\\Customers.xml", null);
            // Opens the document  
            textWriter.WriteStartDocument();
            
            // Write first element  
            textWriter.WriteStartElement("Customers");
            foreach (KeyValuePair<string, Customer> entry in m_customerList)
            {
                textWriter.WriteStartElement("Customer");

                textWriter.WriteStartElement("Name");
                textWriter.WriteString(entry.Value.Name);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Address");
                textWriter.WriteString(entry.Value.Address);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Phone");
                textWriter.WriteString(entry.Value.Phone);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Email");
                textWriter.WriteString(entry.Value.Email);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("User");
                textWriter.WriteString(entry.Value.User);
                textWriter.WriteEndElement();

                textWriter.WriteStartElement("Password");
                textWriter.WriteString(entry.Value.Password);
                textWriter.WriteEndElement();

                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();
            // Ends the document.  
            textWriter.WriteEndDocument();
            // close writer  
            textWriter.Close();
            return true;
        }

        public bool NewCustomer(Customer customer)
        {
            if (m_customerList.ContainsKey(customer.User)) 
            {
                // Added already
                return false;
            }
            m_customerList.Add(customer.User, customer);
            return true;
        }

        public bool GetCustomer(String user, out Customer customer)
        {
    
            customer = m_customerList[user];
            if (customer == null)
            {
                return false;
            }
            return true;
        }

        public bool DeleteCustomer(String user)
        {
            Customer customer = m_customerList[user];
            if (customer == null)
            {
                return false;
            }
            m_customerList.Remove(user);
            
            return true;
        }
    }
}