using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gummyfishNameService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]

        public ActionResult<IEnumerable<string>> Get(int len = 0)
        {
            Random r = new Random();
            string[] consonants = { "B", "C", "Ch", "D", "F", "G", "H", "J", "K", "L", "M", "L", "N", "P", "Q", "R", "S", "Sh", "T", "V", "W", "X", "Z", "Zh" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = consonants[r.Next(consonants.Length)];
            string Name2 = consonants[r.Next(consonants.Length)];
            
            if (len == 0)
            {
                len = new Random().Next(2, 12);
            }
            for (int i = 0; i < len; i+=2)
            {

                Name += vowels[r.Next(vowels.Length)].ToLower();
                Name += consonants[r.Next(consonants.Length)].ToLower();
                
                Name2 += vowels[r.Next(vowels.Length)].ToLower();
                Name2 += consonants[r.Next(consonants.Length)].ToLower();
            }

           
           return new string[] { Name, Name2 };
        }

        
        [Route("cities")]  // Example: https://localhost:44331/api/values/cities
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCityNames()
        {
            return new string[] { "City", "Names", "I", "love", "you." };
        }

        [Route("npcs")]     // Example: https://localhost:44331/api/values/npcs
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetNpcNames()
        {
            return new string[] { "NPC", "Names", "I", "love", "you." };
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
