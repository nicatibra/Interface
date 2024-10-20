using Interface.Models;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student's surname: ");
            string surname = Console.ReadLine();


            if (Student.CheckName(name) && Student.CheckName(surname))
            {
                Student student1 = new Student(name, surname);
                Console.WriteLine($"Stundent {student1.Name} {student1.Surname} created.");

                Console.WriteLine($"Email: {student1.CodeEmail}");

                Console.WriteLine("-----------------------------------------------------------------------------");

                Group groupA = new Group("Group A");
                Group groupB = new Group("Group B");

                //AddStudent() method usage:
                groupA.AddStudent(student1);
                groupA.AddStudent(new Student("Azad", "Ashurov"));
                groupA.AddStudent(new Student("Ismayil", "Memmedli"));
                groupA.AddStudent(new Student("Ayxan", "Huseynov"));

                groupB.AddStudent(new Student("Sabir", "Quliyev"));
                groupB.AddStudent(new Student("Emil", "Abdullayev"));
                groupB.AddStudent(new Student("Ryan", "Gosling"));
                groupB.AddStudent(new Student("Tony", "Stark"));

                Console.WriteLine("ShowStudents() Method for group A: ");
                groupA.ShowStudents();

                Console.WriteLine("\nShowStudents() Method for group B:");
                groupB.ShowStudents();

                Console.WriteLine("-----------------------------------------------------------------------------");

                //Shows GroupName, GroupCount, GroupID
                Console.WriteLine("GetGroupInfo() Method for group A:");
                groupA.GetGroupInfo();
                Console.WriteLine("\nGetGroupInfo() Method for group B:");
                groupB.GetGroupInfo();

                Console.WriteLine("\nSearch() Method:");

                Student retrievedStudent = groupA.GetStudent(1);

                if (retrievedStudent == null)
                {
                    Console.WriteLine($"No student found.");
                }

                groupA.Search("Nicat");

                Console.WriteLine("-----------------------------------------------------------------------------");

                groupA.RemoveStudent(1);
                Console.WriteLine("After removing from Group A: ");
                groupA.ShowStudents();

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("ShowAllGroups() Method: ");
                Group.ShowAllGroups();

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Adding groups: ");
                Group.AddGroup(groupA);
                Group.AddGroup(groupB);

                Group.ShowAllGroups();

                Console.WriteLine("-----------------------------------------------------------------------------");

            }
            else
            {
                Console.WriteLine("Invalid name or surname. ");
            }

        }
    }
}
