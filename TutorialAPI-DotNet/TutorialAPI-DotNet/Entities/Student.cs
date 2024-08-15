namespace TutorialAPI_DotNet.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        
        public string firstName { get; set; } = string.Empty;

        public string lastName { get; set; } = string.Empty;

        public int lastGrade { get; set; }

        public Student(StudentRequest studentDTO)
        {
            Name = studentDTO.Name;
            firstName = studentDTO.firstName;
            lastName = studentDTO.lastName;
            lastGrade = studentDTO.lastGrade;
        }

        public Student(string name, string firstName, string lastName, int lastGrade)
        {
            this.Name = name;
            this.firstName = firstName;
            this.lastName = lastName;
            this.lastGrade = lastGrade;
        }
    }
}
