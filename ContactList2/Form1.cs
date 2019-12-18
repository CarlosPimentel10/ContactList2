using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ContactList2
{
    public partial class Form1 : Form
    {
        // global 
        private Contact[] phoneBook = new Contact[1];

        public Form1()
        {
            InitializeComponent();
        }
        // write contacts to the array file text document
        private void Write(Contact obj)
        {
            StreamWriter sw = new StreamWriter("Contacts.txt");
            sw.WriteLine(phoneBook.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName);
            sw.WriteLine(obj.Phone);

            for (int x = 0; x < phoneBook.Length; x++)
            {
                sw.WriteLine(phoneBook[x].FirstName);
                sw.WriteLine(phoneBook[x].LastName);
                sw.WriteLine(phoneBook[x].Phone);
            }

            sw.Close();
        }
        // Read the data casted into the array of contacts
        private void Read()
        {
            StreamReader sr = new StreamReader("Contacts.txt");
            phoneBook = new Contact[Convert.ToInt32(sr.ReadLine())];

            for (int i = 0; i < phoneBook.Length; i++)
            {
                phoneBook[i] = new Contact();
                phoneBook[i].FirstName = sr.ReadLine();
                phoneBook[i].LastName = sr.ReadLine();
                phoneBook[i].Phone = sr.ReadLine();
            }
            sr.Close();
        }
        private void Display()
        {
            lstContacts.Items.Clear();

            for (int i = 0; i < phoneBook.Length; i++ )
            {
                lstContacts.Items.Add(phoneBook[i].ToString());
            }
        }
        private void Clear()
        {
            textFirstName.Text = String.Empty;
            textLastName.Text = String.Empty;
            textPhone.Text = String.Empty;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact();
            obj.FirstName = textFirstName.Text;
            obj.LastName = textLastName.Text;
            obj.Phone = textPhone.Text;

            Write(obj);
            Read();
            Display();
            Clear();

            lstContacts.Items.Add(obj.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            BubbleSort();
            Display();
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            BubbleSort();
            Display();

        }
        private void BubbleSort()
        {
            Contact temp;
            bool swap;

            do
            {
                swap = false;

                for(int i = 0; i < (phoneBook.Length - 1); i++)
                {
                    if (phoneBook[i].LastName.CompareTo(phoneBook[i + 1].LastName) > 0)
                    {
                        temp = phoneBook[i];
                        phoneBook[i] = phoneBook[i + 1];
                        phoneBook[i + 1] = temp;

                        swap = true;
                    }
                }

            } while (swap == true);
        }
    }
}
