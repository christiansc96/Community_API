using Community_API.DTO.Models;
using Community_API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Community_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitiesController : ControllerBase
    {
        private readonly ICommunityRepository _communityRepository;

        public CommunitiesController(ICommunityRepository communityRepository)
        {
            _communityRepository = communityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCommunities()
        {
            List<CommunityDTO> communitiesFromDatabase = await _communityRepository.GetCommunities();
            return Ok(communitiesFromDatabase);
        }
    }
}