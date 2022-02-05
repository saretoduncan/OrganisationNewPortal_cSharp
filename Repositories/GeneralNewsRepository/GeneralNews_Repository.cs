using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organisationnewportal.Data;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.GeneralNewsRepository
{
    public class GeneralNews_Repository : IGeneralRepository
    {
        public readonly IDataContext _context;
        public GeneralNews_Repository(IDataContext context)
        {
            _context = context;

        }
        public async Task AddGeneralNews(GeneralNews generalNews)
        {
            _context.GeneralNews.Add(generalNews);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGeneralNews(int id)
        {
            var itemToDelete = await _context.GeneralNews.FindAsync(id);
            if (itemToDelete == null) throw new NullReferenceException();
            _context.GeneralNews.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<GeneralNews> Get(int id)
        {
            return await _context.GeneralNews.FindAsync(id);
        }

        public async Task<IEnumerable<GeneralNews>> GetAll()
        {
            return await _context.GeneralNews.ToListAsync();
        }

        public async Task Update(GeneralNews generalNews)
        {
            var itemsToUpdate = await _context.GeneralNews.FindAsync(generalNews.Id);
            if (itemsToUpdate == null) throw new NullReferenceException();
            itemsToUpdate.NewsHeading = generalNews.NewsHeading;
            itemsToUpdate.News = generalNews.News;
            await _context.SaveChangesAsync();

        }
    }
}