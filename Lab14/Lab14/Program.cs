using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using static System.Console;

namespace Lab14
{
    [Serializable]
    public abstract class IntelligentCreature
    {
        private int lifelength;
        protected int LifeLength
        {
            get => lifelength;
            set => lifelength = value;
        }
    }
    [Serializable][XmlRoot]
    public sealed class Human : IntelligentCreature
    {
        private string sex;
        private int age;
        private int height;
        private string name;
        public Human()
        {
            LifeLength = 100;
            sex = "";
            age = -1;
            height = -1;
            name = "";
        }
        public Human(string _sex, int _age, int _height, string _name)
        {
            LifeLength = 100;
            sex = _sex;
            age = _age;
            height = _height;
            name = _name;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Sex
        {
            get => sex;
            set => sex = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public override string ToString()
        {
            return "Человек:\n" +
                   "Продолжительность жизни: " + "~" + LifeLength + " лет" +
                   "\nИмя: " + name.ToString() +
                   "\nПол: " + sex.ToString() +
                   "\nВозвраст: " + age.ToString() + " лет" +
                   "\nРост: " + height.ToString() + " см";
        }
    }
    [Serializable] [XmlRoot("Human")]
    public class Army
    {
        private List<Human> units = new List<Human>();
        [XmlAttribute]
        public int Count => units.Count;
        [XmlArray("ListofUnits")]
        [XmlArrayItem("Human")]
        public List<Human> ListofUnits
        {
            get => units;
            set => units = value;
        }
        public void Add(Human human) => units.Add(human);
        public void Remove(Human human) => units.Remove(human);
        public void ToConsole()
        {
            Human[] arr = units.ToArray();
            for (int i = 0; i < arr.Length; i++)
                WriteLine((i + 1).ToString() + ' ' + arr[i].ToString() + '\n');
        }
    }
    class Program
    {
        public static void Main()
        {
            Army army = new Army();
            army.Add(new Human("Man", 19, 175, "Evgen"));
            army.Add(new Human("Man", 18, 175, "Aleksey"));
            army.Add(new Human("Man", 25, 175, "Petya"));
            Human human = new Human("Man", 19, 175, "Evgen");
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream("serializeBinary.dat", FileMode.OpenOrCreate);
            binary.Serialize(file, human);
            file.Close();
            file = new FileStream("serializeBinary.dat", FileMode.OpenOrCreate);
            WriteLine(((Human)binary.Deserialize(file)).ToString());
            file.Close();
            file = new FileStream("serializeSOAP.xml", FileMode.OpenOrCreate);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(file, human);
            file.Close();
            file = new FileStream("serializeSOAP.xml", FileMode.OpenOrCreate);
            WriteLine(((Human)soap.Deserialize(file)).ToString());
            file.Close();
            file = new FileStream("serializeJSON.json", FileMode.OpenOrCreate);
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Army));
            json.WriteObject(file, army);
            file.Close();
            file = new FileStream("serializeJSON.json", FileMode.OpenOrCreate);
            ((Army)json.ReadObject(file)).ToConsole();
            file.Close();
            file = new FileStream("serializeXML.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Army));
            xml.Serialize(file, army);
            file.Close();
            file = new FileStream("serializeXML.xml", FileMode.OpenOrCreate);
            ((Army)xml.Deserialize(file)).ToConsole();
            file.Close();
            Human[] humans = new Human[] { new Human("Man", 19, 175, "Evgen"), new Human("Woman", 18, 165, "Alesya"), new Human("Man", 25, 180, "Petya") };
            file = new FileStream("serializeXML2.xml", FileMode.OpenOrCreate);
            xml = new XmlSerializer(typeof(Human[]));
            xml.Serialize(file, humans);
            file.Close();
            file = new FileStream("serializeXML2.xml", FileMode.OpenOrCreate);
            foreach (Human x in (Human[])xml.Deserialize(file))
                WriteLine(x.ToString());
            file.Close();
            XPathDocument xmldoc = new XPathDocument("serializeXML2.xml");
            foreach (XPathItem x in xmldoc.CreateNavigator().Select("//Human/Name"))
                WriteLine(x.Value);
            WriteLine();
            foreach (XPathItem x in xmldoc.CreateNavigator().Select("//Human[Sex = \"Man\"]/Name"))
                WriteLine(x.Value);
            WriteLine();
            file = new FileStream("serializeXML3.xml", FileMode.OpenOrCreate);
            xml = new XmlSerializer(typeof(Human[]));
            xml.Serialize(file, humans);
            file.Close();
            XDocument doc = XDocument.Load("serializeXML3.xml");
            IEnumerable<XElement> items = from x in doc.Element("ArrayOfHuman").Elements("Human") where (x.Element("Age").Value == "18") select x;
            foreach (XElement x in items)
                foreach (XNode y in x.Nodes())
                    WriteLine(y.CreateNavigator().Value);
            WriteLine();
            IEnumerable<XElement> items2 = from x in doc.Element("ArrayOfHuman").Elements("Human") where (x.Element("Name").Value.Contains("P") == true) select x;
            foreach (XElement x in items2)
                foreach (XNode y in x.Nodes())
                    WriteLine(y.CreateNavigator().Value);
            ReadKey();
        }
    }
}
