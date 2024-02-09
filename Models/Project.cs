namespace TechUp.Models
{
    public class Project
    {
        public int ProjectCode {get; set; }
        public string? ProjectDeadline{ get; set; }
        public string? ProjectDescription{ get; set; }
        public int? ProjectDuration{ get; set; }
    }
}
