﻿namespace Crud_WebAPI.Data
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _appDbContext.Set<Employee>().AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
