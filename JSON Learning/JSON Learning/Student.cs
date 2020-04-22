using System.Collections.Generic;

namespace JSON_Learning
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string  Degree { get; set; }
        public List<string> Hobbies { get; set; }

        public override string ToString()
        {
            return string.Format("Student Information:\n\tID: {0},\n\tName: {1},\n\tDegree: {2},\n\tHobbies: {3}",ID,Name,Degree,string.Join(",",Hobbies.ToArray()));
        }
    }
}
