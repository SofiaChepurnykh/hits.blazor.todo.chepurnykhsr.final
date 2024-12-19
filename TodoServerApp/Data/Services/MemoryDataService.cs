using System.Threading.Tasks;
using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<EmployeeItem> Employees { get; } = [
            new() { Id = 1, Name="Чепурных Софья", Position="Директор", Time=8, Salary=300000},
            new() { Id = 2, Name="Шаукерова Аделия", Position="Разработчик", Time=8, Salary=150000},
            new() { Id = 3, Name="Шананина Валерия", Position="Менеджер", Time=12, Salary=80000},
            new() { Id = 4, Name="Косишнева Анастасия", Position="Бухгалтер", Time=12, Salary=80000},
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeItem>> GetEmployeeItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Employees);
        }

        public Task<EmployeeItem> GetEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(EmployeeItem item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
