﻿using MoneyMonitor.API.Domain.Repositories;
using MoneyMonitor.API.Persistence.Contexts;
using System.Threading.Tasks;

namespace MoneyMonitor.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
