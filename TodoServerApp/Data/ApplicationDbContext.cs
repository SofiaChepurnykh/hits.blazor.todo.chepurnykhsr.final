using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<EmployeeItem> EmployeeItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EmployeeItem>().HasData([
                new() { Id = 1, Name="�������� �����", Position="��������", Time=8, Salary=300000},
            new() { Id = 2, Name="��������� ������", Position="�����������", Time=8, Salary=150000},
            new() { Id = 3, Name="�������� �������", Position="��������", Time=12, Salary=80000},
            new() { Id = 4, Name="��������� ���������", Position="���������", Time=12, Salary=80000},
            ]);
        }
    }
}
