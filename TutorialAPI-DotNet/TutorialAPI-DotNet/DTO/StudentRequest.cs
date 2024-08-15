namespace TutorialAPI_DotNet.Entities
{
    /// <summary>
    /// Student DTO (Data Transfer Object)
    /// </summary>
    public class StudentRequest
    {
        public string Name { get; set; }

        public string firstName { get; set; } = string.Empty;

        public string lastName { get; set; } = string.Empty;

        public int lastGrade { get; set; }

        public StudentRequest(string name, string firstName, string lastName, int lastGrade)
        {
            this.Name = name;
            this.firstName = firstName;
            this.lastName = lastName;
            this.lastGrade = lastGrade;
        }
    }
}
