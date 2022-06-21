using AALEKH_SOCIETY_COOP.Areas.Identity.Data;
using AALEKH_SOCIETY_COOP.Models;
using Microsoft.EntityFrameworkCore;

namespace AALEKH_SOCIETY_COOP
{
    public class Common : ICommon
    {
        private readonly ApplicationDbContext _context;
        public Common(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<FixedCharges>> GetFixedCharges()
        {
            var charges = await _context.FixedCharges.ToListAsync();
            return charges;
        }
        public async Task<int> AddFixedCharges(FixedCharges charges)
        {
            _context.FixedCharges.Add(charges);
            return await _context.SaveChangesAsync();
        }

        public async Task<FixedCharges> GetFixedChargesbyId(int? id)
        {
            return await _context.FixedCharges.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<int> UpdateFixedCharges(FixedCharges charges)
        {
             _context.FixedCharges.Update(charges);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckFixedChargesExists(int id)
        {
            return await _context.FixedCharges.AnyAsync(x => x.id == id);
        }

        public async Task<int> RemoveFixedCharge(FixedCharges charges)
        {
             _context.FixedCharges.Remove(charges);
            return await _context.SaveChangesAsync(); 
        }

        public async Task<List<Residents>> GetAllResidents()
        {
           return await _context.Residents.ToListAsync();
        }

        public async Task<int> AddResidents(Residents residents)
        {
            _context.Residents.Add(residents);
            return await _context.SaveChangesAsync();
        }

        public async Task<Residents> GetResidentsById(int id )
        {
            return await _context.Residents.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
