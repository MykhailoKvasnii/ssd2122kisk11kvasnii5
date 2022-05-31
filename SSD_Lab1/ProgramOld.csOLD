using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//INI
using IniParser;
using IniParser.Model;
using IniParser.Parser;
//XML
using System.Xml;
using System.Xml.Linq;
using System.IO;
//JSON
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SSD_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Read and Write to Console: INI, JSON, XML \n");

            //Path to INI file
            string pathINI = "C:\\Users\\micha\\source\\repos\\MykhailoKvasnii\\ssd2223kisk11kvasnii5\\SSD_Lab1\\INI.ini";
            //Path to INI file
            string pathJSON = "C:\\Users\\micha\\source\\repos\\MykhailoKvasnii\\ssd2223kisk11kvasnii5\\SSD_Lab1\\JSON.json";
            //Path to INI file
            string pathXML = "C:\\Users\\micha\\source\\repos\\MykhailoKvasnii\\ssd2223kisk11kvasnii5\\SSD_Lab1\\XML.xml";
            
            //Read from INI and write to console all data
            Console.WriteLine(ReadFromINI(pathINI)+ "\n" + "END INI File");  

            //Read from JSON and write to console all data
            Console.WriteLine(ReadFromJSON(pathJSON)+ "\n" + "END JSON File"); 

            //Read from XML and write to console all data
            Console.WriteLine(ReadFromXML(pathXML)+ "\n" + "END XML File"); 

        }

        static String ReadFromINI(string pathINI)
        {
            Console.WriteLine("\nSTART Write INI\n");

            // Use a FileIniDataParser instance to easily parse or persist ini files.
            var parser = new FileIniDataParser();

            // This load the INI file, reads the data contained in the file, and parses that data
            IniData data = parser.ReadFile(pathINI);         
            
            return data.ToString();
            
        }

        static string ReadFromJSON(string pathJSON)
        {
            Console.WriteLine("\nSTART Write JSON\n");
            JObject data;
            using (StreamReader reader = File.OpenText(pathJSON))
            {
                data = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                Console.WriteLine(data);
                // do stuff
            }

            string dataString = File.ReadAllText(pathJSON);
            return dataString; 

        }

        static String ReadFromXML(string pathXML)
        {
            Console.WriteLine("\nSTART Write XML\n");

            Console.WriteLine("All Female Employee\n");
            XElement xelement = XElement.Load(pathXML);
            var name = from nm in xelement.Elements("Employee")
                       where (string)nm.Element("Sex") == "Female"
                       select nm;
            Console.WriteLine("Details of Female Employees:");
            foreach (XElement xEle in name)
            Console.WriteLine(xEle);

            Console.WriteLine("\nAll file \n");
            string data = File.ReadAllText(pathXML);

            return data;   

        }

    }
}
