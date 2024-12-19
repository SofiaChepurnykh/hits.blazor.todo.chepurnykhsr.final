using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<EmployeeItem>> GetAllAsync()
        {
            return await context.EmployeeItems.ToArrayAsync();
        }

        public async Task SaveAsync(EmployeeItem employeeItem)
        {
            if (employeeItem.Id == 0)
            {
                await context.EmployeeItems.AddAsync(employeeItem);
            }
            else
            {
                context.EmployeeItems.Update(employeeItem);
            }
            await context.SaveChangesAsync();
        }

        public async Task<EmployeeItem> GetEmployeeAsync(int id)
        {
            return await context.EmployeeItems.FirstAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var employeeItem = await context.EmployeeItems.FirstAsync(x => x.Id == id);
            context.EmployeeItems.Remove(employeeItem);
            await context.SaveChangesAsync();
        }
    }
}
