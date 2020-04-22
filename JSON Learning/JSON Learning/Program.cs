using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace JSON_Learning
{

    class JsonParser
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                ID = 36302,
                Name = "Tomás",
                Degree = "Game Development",
                Hobbies = new List<string>
                {
                    "Reading",
                    " Playing Games",
                    " Procrastinating"
                }

            };

            string result = JsonConvert.SerializeObject(s1);
            File.WriteAllText(@"student.json", result);
            Console.WriteLine("Stored!");


            result = String.Empty;
            result = File.ReadAllText(@"student.json");
            //Student s2 = JsonConvert.DeserializeObject<Student>(result);
            //Console.WriteLine(s2.ToString());



            var s3 = JsonConvert.DeserializeObject<IDictionary>(result);
            foreach(DictionaryEntry entry in s3)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
