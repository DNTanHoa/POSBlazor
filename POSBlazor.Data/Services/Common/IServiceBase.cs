using POSBlazor.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace POSBlazor.Data.Services.Common
{
    public interface IServiceBase<TEntity> where TEntity : BaseModel
    {
        public Task<int> Create(TEntity model);

        public Task<int> Update(int modelId, TEntity model);

        public Task<int> Delete(int modelId);

        public Task<List<TEntity>> GetAllToList();

        public Task<TEntity> GetById(int modelId);
    }
}
