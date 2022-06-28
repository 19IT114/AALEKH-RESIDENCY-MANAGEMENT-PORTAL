﻿using AALEKH_SOCIETY_COOP.Models;

namespace AALEKH_SOCIETY_COOP
{
    public interface ICommon
    {
        Task<List<FixedCharges>> GetFixedCharges();
        Task<int> AddFixedCharges(FixedCharges charges);

        Task<FixedCharges> GetFixedChargesbyId(int? id);
        Task<int> UpdateFixedCharges(FixedCharges charges);
        Task<bool> CheckFixedChargesExists(int id);
        Task<int> RemoveFixedCharge(FixedCharges charges);

        Task<List<Residents>> GetAllResidents();

        Task<int> AddResidents(Residents residents);
        Task<Residents> GetResidentsById(int id);
        Task<List<Residents>> GetAllStreetMembers();
        Task<int> UpdateResident(Residents residents);
        Task<bool> CheckResidentExists(int id);
    }

}
