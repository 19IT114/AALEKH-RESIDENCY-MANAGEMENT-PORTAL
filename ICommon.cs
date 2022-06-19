using AALEKH_SOCIETY_COOP.Models;

namespace AALEKH_SOCIETY_COOP
{
    public interface ICommon
    {
        Task<List<FixedCharges>> GetFixedCharges();
        Task<int> AddFixedCharges(FixedCharges charges);
    }
}
