


using File_Dictionary_Seralization;
using Newtonsoft.Json;
using System;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

//Person person = null;
//person = new Person()
//{
//    FullName = "Ibrahim Abadullayev",
//    Age = 14
//};
//person = DeserializeJson();

//Console.WriteLine(person);
//#region json
////void SerializeJson(Person person)
////{


////    using (FileStream fileStream = new FileStream("C:\\Users\\Farid\\Desktop\\homewotk\\c#\\File-Dictionary-Seralization\\File-Dictionary-Seralization\\Person\\person.json", FileMode.Create))
////    {
////        DataContractJsonSerializer dataj = new DataContractJsonSerializer(typeof(Person));
////        dataj.WriteObject(fileStream, person);
////    }
////}

////Person DeserializeJson()
////{
////    Person person2 = null;
////    using (FileStream fs = new FileStream("C:\\Users\\Farid\\Desktop\\homewotk\\c#\\File-Dictionary-Seralization\\File-Dictionary-Seralization\\Person\\person.json", FileMode.Open))
////    {
////        DataContractJsonSerializer dataj = new DataContractJsonSerializer(typeof(Person));
////        person2 = dataj.ReadObject(fs) as Person;
////    }
////    return person2;
////}
//#endregion
//void SerializeJson(Person person)
//{
//    using (FileStream fileStream = new FileStream("C:\\Users\\Farid\\Desktop\\homewotk\\c#\\File-Dictionary-Seralization\\File-Dictionary-Seralization\\Person\\person.json", FileMode.Create))
//    {
//        var js = JsonConvert.SerializeObject(person);
//        StreamWriter writer = new StreamWriter(fileStream);
//        writer.Write(js);
//        writer.Close();
//        //DataContractJsonSerializer dataj = new DataContractJsonSerializer(typeof(Person));
//        //dataj.WriteObject(fileStream, person);
//    }
//}
//Person DeserializeJson()
//{
//    Person person2 = null;
//    using (FileStream fs = new FileStream("C:\\Users\\Farid\\Desktop\\homewotk\\c#\\File-Dictionary-Seralization\\File-Dictionary-Seralization\\Person\\person.json", FileMode.Open))
//    {
//        //DataContractJsonSerializer dataj = new DataContractJsonSerializer(typeof(Person));
//        //person2 = dataj.ReadObject(fs) as Person;

//        StreamReader sr = new StreamReader(fs);
//        var js = sr.ReadToEnd();
//        person2 = JsonConvert.DeserializeObject<Person>(js);
//    }
//    return person2;
//}




List<Person> persons = new List<Person>();

string choice;
do
{
    persons = DeserializePersonList();
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Person add");
    Console.WriteLine("2. Show Persons");
    Console.WriteLine("0. Exit");
    Console.Write("Emeliyat secin: ");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
         
            Console.WriteLine("FullName daxil edin");
            string fullNameStr = Console.ReadLine();
            Console.WriteLine("Yasi daxil edin");
            string ageStr = Console.ReadLine();
            byte age = Convert.ToByte(ageStr);
            Person person = new Person()
            {
                FullName = fullNameStr,
                Age = age,
            };
            persons.Add(person);
    
            SerializePersonList(persons);
        


            break;
        case "2":
            Console.WriteLine("\nPersons:\n");
            persons = DeserializePersonList();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
            break;
        case "0":
            Console.WriteLine("Program bitdi...");
            break;
        default:
            Console.WriteLine("Duzgun emeliyyat secin.");
            break;
    }
} while (choice != "0");
void SerializePersonList(List<Person> personList)
{
   
    using (FileStream fileStream = new FileStream("C:\\Users\\Farid\\Desktop\\homewotk\\c#\\File-Dictionary-Seralization\\File-Dictionary-Seralization\\Person\\personlist.json", FileMode.Create))
    {
        var js = JsonConvert.SerializeObject(personList);
        StreamWriter writer = new StreamWriter(fileStream);
        writer.Write(js);
        writer.Close();
    }
   
}
List<Person> DeserializePersonList()
{
    List<Person> person2 = null;
    using (FileStream fs = new FileStream("C:\\Users\\Farid\\Desktop\\homewotk\\c#\\File-Dictionary-Seralization\\File-Dictionary-Seralization\\Person\\personlist.json", FileMode.Open))
    {
        StreamReader sr = new StreamReader(fs);
        var js = sr.ReadToEnd();
        person2 = JsonConvert.DeserializeObject<List<Person>>(js);
    }
    return person2;
}

