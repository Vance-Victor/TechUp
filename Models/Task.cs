namespace TechUp.Models
{
    public class Task 
    {
        public int? TaskID{ get; set; }
        public string? TaskBudget{ get; set; }
        public string? TaskName{ get; set;} 
        public string? TaskDescription { get; set;}
        public Project Project { get; set;}
        public Staff Staff { get; set;}
    }
}
