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
    }
}
