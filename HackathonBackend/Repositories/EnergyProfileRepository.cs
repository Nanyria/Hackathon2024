
using HackathonBackend.Data;
using HackathonBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HackathonBackend.Repositories
{
    public class EnergyProfileRepository : IEnergyRepository<EnergyProfile>
    {
        private readonly AppDbContext _context;

        public EnergyProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<EnergyProfile> Create(EnergyProfile entity)
        {
            _context.Set<EnergyProfile>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Set<EnergyProfile>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<EnergyProfile>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<EnergyProfile>> GetAll()
        {
            return await _context.Set<EnergyProfile>().ToListAsync();
        }

        public async Task<EnergyProfile> GetById(int id)
        {
            return await _context.Set<EnergyProfile>().FindAsync(id);
        }

        public async Task<EnergyProfile> Update(int id, EnergyProfile entity)
        {
            var existingEntity = await _context.Set<EnergyProfile>().FindAsync(id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
                return existingEntity;
            }
            return null;
        }
    }
}
