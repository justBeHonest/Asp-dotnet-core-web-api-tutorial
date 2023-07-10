
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace deneme2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character{ Id = 1, Name = "Marry" }
        };
        private static Character singleCharacter = new
        Character
        { Name = "Sam", Defense = 15, Strength = 20 };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        [Route("GetSingle")]
        public ActionResult<Character> GetSingleCharacter()
        {
            return Ok(singleCharacter);
        }

        [HttpGet("GetSingleCharacterById/{id}")]
        public ActionResult<Character> GetSingleCharacterById(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }


        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            characters.Add(newCharacter);
            return Ok(characters);
        }

    }
}