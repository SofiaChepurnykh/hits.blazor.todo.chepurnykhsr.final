namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<EmployeeItem>> GetAllAsync();
        Task SaveAsync(EmployeeItem item);
        Task<EmployeeItem> GetEmployeeAsync(int id);
        Task DeleteAsync(int id);
    }
}
