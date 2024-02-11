namespace TechUp.Models
{
    public interface IT_Solution
    {
        public int? ITSolutionID { get; set; }
        public string? ITSolutionBudget{ get; set; }
        public string? ITSolutionType{ get; set;} 
        public string? ITSolutionDescription { get; set;}
    }
}
