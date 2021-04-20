using System.Threading.Tasks;
using dotnet_rpg.Services.CharacterService;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Dtos.Character;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Security.Claims;

namespace dotnet_rpg.Controllers
{
    [Authorize(Roles = "Player,Admin")]
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        //GET character/getall
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            //calls the method of our character service that returns a list of all the characters
            return Ok(await _characterService.GetAllCharacters());
        }
        //GET character/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }
        //POST character/
        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {           
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
        //PUT character/
        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {           
            ServiceResponse<GetCharacterDto> response = await _characterService.UpdateCharacter(updatedCharacter);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        //DELETE character/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.DeleteCharacter(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}