using HackathonBackend.Data;
using HackathonBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace HackathonBackend.Repositories
{
    public class UserInfoRepository : IEnergyRepository<UserInfo>
    {
        private readonly AppDbContext _context;

        public UserInfoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserInfo> Create(UserInfo entity)
        {
            _context.Set<UserInfo>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Set<UserInfo>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<UserInfo>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<UserInfo>> GetAll()
        {
            return await _context.Set<UserInfo>().ToListAsync();
        }

        public async Task<UserInfo> GetById(int id)
        {
            return await _context.Set<UserInfo>().FindAsync(id);
        }

        public async Task<UserInfo> Update(int id, UserInfo entity)
        {
            var existingEntity = await _context.Set<UserInfo>().FindAsync(id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
                return existingEntity;
            }
            return null;
        }

        public async Task<IEnumerable<UserInfo>> GetLatest24Hours()
        {
            var now = DateTime.UtcNow;
            var last24Hours = now.AddHours(-24);

            return await _context.Set<UserInfo>()
                .Where(u => u.AtDateTime >= last24Hours && u.AtDateTime <= now)
                .OrderByDescending(u => u.AtDateTime)
                .ToListAsync();
        }

        public async Task<IEnumerable<IGrouping<DateTime, UserInfo>>> GetUserInfosByHour()
        {
            var userInfos = await _context.Set<UserInfo>().ToListAsync();
            return userInfos.GroupBy(u => new DateTime(u.AtDateTime.Year, u.AtDateTime.Month, u.AtDateTime.Day, u.AtDateTime.Hour, 0, 0));
        }

        public async Task<IEnumerable<IGrouping<DateTime, UserInfo>>> GetUserInfosByDay()
        {
            var userInfos = await _context.Set<UserInfo>().ToListAsync();
            return userInfos.GroupBy(u => new DateTime(u.AtDateTime.Year, u.AtDateTime.Month, u.AtDateTime.Day));
        }

        public async Task<IEnumerable<IGrouping<int, UserInfo>>> GetUserInfosByWeek()
        {
            var userInfos = await _context.Set<UserInfo>().ToListAsync();
            return userInfos.GroupBy(u => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(u.AtDateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
        }
    }
}
