using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.GeneralNewsRepository
{
    public interface IGeneralRepository
    {
        Task<GeneralNews> Get(int id);
        Task<IEnumerable<GeneralNews>> GetAll();
        Task AddGeneralNews(GeneralNews generalNews);
        Task DeleteGeneralNews(int id);
        Task Update(GeneralNews generalNews);



    }
}