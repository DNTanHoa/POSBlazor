using POSSolution.Application.Context;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using POSBlazor.Data.Models;

namespace POSBlazor.Data.Services.Common
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseModel
    {

        private readonly POSContext _context;

        public ServiceBase(POSContext context)
        {
            _context = context;
        }

        public async Task<int> Create(TEntity model)
        {
            _context.Set<TEntity>().Add(model);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int modelId)
        {
            var existModel = await GetById(modelId);
            if (existModel != null)
            {
                _context.Set<TEntity>().Remove(existModel);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllToList()
        {
            var result = await _context.Set<TEntity>().ToListAsync();
            return result != null ? result : new List<TEntity>();
        }

        public async Task<TEntity> GetById(int modelId)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(model => model.Id == modelId);
        }

        public async Task<int> Update(int modelId, TEntity model)
        {
            var existModel = await GetById(modelId);
            if(existModel != null)
            {
                existModel = model;
                _context.Set<TEntity>().Update(existModel);
            }
            return await _context.SaveChangesAsync();
        }
    }
}
