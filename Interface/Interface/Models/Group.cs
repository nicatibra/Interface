namespace Interface.Models
{
    internal class Group
    {
        public static Group[] Groups = new Group[0];
        public static int GroupCount = 0;

        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public Student[] Students;

        public Group(string groupname)
        {
            GroupName = groupname;
            GroupCount++;
            GroupId = GroupCount;

            Students = new Student[0];
            AddGroup(this);
        }


        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }

        public static void RemoveGroup(int groupId)
        {
            Group[] newGroups = new Group[Groups.Length - 1];
            int j = 0;
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].GroupId != groupId)
                {
                    newGroups[j] = Groups[i];
                    j++;
                }
            }
            Groups = newGroups;
            GroupCount--;
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"Group Name: {GroupName}, Student Count: {Students.Length}, Group Id: {GroupId}");
        }

        public Student GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Console.WriteLine($"Found Student: {Students[i].Name}");
                    return Students[i];
                }
            }
            return null;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void RemoveStudent(int id)
        {
            Student[] newStudents = new Student[Students.Length - 1];
            int j = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id != id)
                {
                    newStudents[j] = Students[i];
                    j++;
                }
            }
            Students = newStudents;
        }

        public void Search(string search)
        {
            foreach (var student in Students)
            {
                if (student.Name.ToLower().Contains(search) || student.Surname.ToLower().Contains(search))
                {
                    Console.WriteLine($"Found Student: {student.Name}, Surname: {student.Surname}, ID: {student.Id}, Email: {student.CodeEmail}");
                }
            }
        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Student: {student.Name} {student.Surname}, ID: {student.Id}, Email: {student.CodeEmail}");
            }
        }

        public static void ShowAllGroups()
        {
            foreach (var group in Groups)
            {
                Console.WriteLine($"Group: {group.GroupName}, ID: {group.GroupId}, Student Count: {group.Students.Length}");
            }
        }
    }
}
