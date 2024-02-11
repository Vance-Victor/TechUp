using Microsoft.EntityFrameworkCore;

namespace TechUp.Models
{
    public class OrganizationContext : DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffSkill> StaffSkill { get; set; }
        public DbSet<Task> Task { get; set; }
    }
}
