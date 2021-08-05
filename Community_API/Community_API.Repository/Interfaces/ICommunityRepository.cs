using Community_API.DTO.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Community_API.Repository.Interfaces
{
    public interface ICommunityRepository
    {
        Task<List<CommunityDTO>> GetCommunities();
    }
}