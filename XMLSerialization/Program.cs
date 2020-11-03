using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization; // used to create the XML Serialization
using System.IO; // This is needed for the TextWriter

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.ID = 123;
            emp.Name = "Ninja Nerd";
            emp.SSNumber = 123456789;
            emp.EntryDate = DateTime.Now;

            Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name}\nEmployee SS#: {emp.SSNumber}\nDate Created: {emp.EntryDate}");

            // Creating Location to store your XML File
            string FilePath = "C:\\Users\\medley_jamagiae\\Documents\\";
            string FileName = "Ninja.xml";
            // new trick to create the path to save the file ^^^ combine the two variables above on the next line down
            TextWriter writer = new StreamWriter(FilePath + FileName);

            //Actual Part for Serialization
            XmlSerializer ser = new XmlSerializer(typeof(Employee));

            //get the writer stream and the instance of the class we have... below
            ser.Serialize(writer, emp);
            writer.Close();

            Console.ReadLine();
        }


    }
}
