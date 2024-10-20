using Interface.Interface;
using System.Text.RegularExpressions;

namespace Interface.Models
{
    internal class Student : ICodeAcademy
    {
        private static int Count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public Student(string name, string surname)
        {
            Name = Capitalize(name);
            Surname = Capitalize(surname);

            Count++;
            Id = Count;

            GenerateEmail();
        }
        public static string Capitalize(string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
        }


        public static bool CheckName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.Length >= 3 && name.Length <= 25 && Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        public void GenerateEmail()
        {
            CodeEmail = Name.ToLower() + "." + Surname.ToLower() + Id + "@code.edu.az";
        }

    }
}
