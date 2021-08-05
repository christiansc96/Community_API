using Community_API.Database.Context;
using Community_API.Database.DbModels;
using Community_API.DTO.Models;
using Community_API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Community_API.Repository.Repository
{
    public class CommunityRepository : ICommunityRepository
    {
        private readonly CommunityContext _context;
        public CommunityRepository(CommunityContext context)
        {
            _context = context;
        }

        public async Task<List<CommunityDTO>> GetCommunities()
        {
            List<Community> communitiesFromDatabase = await _context.Community.ToListAsync();

            List<CommunityDTO> communities = communitiesFromDatabase.Select(community => new CommunityDTO()
            {
                CommunityId = community.CommunityId,
                CommunityName = community.CommunityName
            }).ToList();
            return communities;
        }
    }
}