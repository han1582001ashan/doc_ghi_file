// See https://aka.ms/new-console-template for more information

using System;
using System.Text.Json;
using System.Text;
namespace DEMOFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Hoang Hoa Tham", "Ha Noi");
            Person person = new Person("Vinh", new DateTime(2015, 12, 31), address);
            var jsonObject = JsonSerializer.Serialize(person);
            string sourceFilePath = @"/Users/loopo/OneDrive/Desktop/BT Codegym/doc_file_csv/demo1.json";
            FileStream fileStream = new FileStream(sourceFilePath, FileMode.Create);
            byte[] bytes = Encoding.UTF8.GetBytes(jsonObject);
            fileStream.Write(bytes, 0, jsonObject.Length);
            fileStream.Close();


            string strPerson = File.ReadAllText(sourceFilePath);
            person = JsonSerializer.Deserialize<Person>(strPerson);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Birth);
            Console.WriteLine(person.Address.Road);
            Console.WriteLine(person.Address.City);
        }
    }
}

