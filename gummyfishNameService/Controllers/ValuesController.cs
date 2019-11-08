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
            string[] consonants = { "B", "C", "Ch", "D", "F", "G", "H", "J", "K", "L", "M", "L", "N", "P", "Q", "R", "S", "S", "Sh", "T", "V", "W", "X", "Z", "Zh" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };


            string Name = consonants[r.Next(consonants.Length)];
            string Name2 = consonants[r.Next(consonants.Length)];


            if (len == 0)
            {
                len = new Random().Next(2, 8);
            }
            for (int i = 0; i < len; i += 2)
            {

                Name += vowels[r.Next(vowels.Length)].ToLower();
                Name += consonants[r.Next(consonants.Length)].ToLower();


                Name2 += vowels[r.Next(vowels.Length)].ToLower();
                Name2 += consonants[r.Next(consonants.Length)].ToLower();

            }



            return new string[] { Name, Name2 };

        }

        // GET api/values/cities
        [Route("cities")]
        [HttpGet]

        public ActionResult<IEnumerable<string>> GetCity()
        {

            {
                Random rc = new Random();


                //city prefix

                string[] cityPre = { "Beacon", "North", "South", "West", "East", "Northern", "Southern", "Eastern", "Western", "Noble", "King", "Twin", "Prince", "Mason", "Double", "Tawdry", "Tipton", "Embris", "Ember", "Nar", "High", "Thunder", "Sleeping", "Moon", "Sun", "Hollow", "Hallow", "Honey", "Amber", "Stone", "Gleaming", "Glow", "Light", "Flint", "Anvil", "Archer", "Dragon", "Bard", "Dark", "New", "Old", "Shadow", "Spindle", "Shade", "Fairy", "Fae", "Sharp", "Shaw", "Hammer", "Honed", "Queen", "Ray", "Bane", "Bone", "Show", "Sheen", "Eagle", "Flight", "Fane", "Fame", "Farrow", "Gold", "Grey", "Black", "Bless", "Blade", "Blood", "Blind" };

                //city Post

                string[] cityPos = { "Cove", "Port", "Shire", "Shore", "Bluff", "Borough", "County", "Stables", "Farm", "Pub", "Inn", "Manor", "Landing", "Cobble", "Village", "County", "Pond", "Town", "Square", "Vin", "Ville", "Vein", "Von", "Sierra", "Creek", "Drove", "Valley", "Narrows", "Field", "Bell", "Spelton", "Host", "Horn", "Moor", "Front", "Shear", "Den", "Stormton", "Watch", "Tower", "Point", "Ford", "Vale", "Falls", "Thorn", "Burrow", "Burrows" };


                //city random

                string NamecityPre = cityPre[rc.Next(cityPre.Length)];
                string NamecityPos = cityPos[rc.Next(cityPos.Length)].ToLower();
                





                return new string[] { NamecityPre + NamecityPos };
            }
        }


       
        //get api/values/citiesSpaced
        [Route("citiesSpaced")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCities()
        {
            { Random rcs = new Random();
                string[] cityPre = { "Beacon", "North", "South", "West", "East", "Northern", "Southern", "Eastern", "Western", "Noble", "King", "Twin", "Prince", "Mason", "Double", "Tawdry", "Tipton", "Embris", "Ember", "Nar", "High", "Thunder", "Sleeping", "Moon", "Sun", "Hollow", "Hallow", "Honey", "Amber", "Stone", "Gleaming", "Glow", "Light", "Flint", "Anvil", "Archer", "Dragon", "Bard", "Dark", "New", "Old", "Shadow", "Spindle", "Shade", "Fairy", "Fae", "Sharp", "Shaw", "Hammer", "Honed", "Queen", "Ray", "Bane", "Bone", "Show", "Sheen", "Eagle", "Flight", "Fane", "Fame", "Farrow", "Gold", "Grey", "Black", "Bless", "Blade", "Blood", "Blind" };
                string[] cityPos = { "Cove", "Port", "Shire", "Shore", "Bluff", "Borough", "County", "Stables", "Farm", "Pub", "Inn", "Manor", "Landing", "Cobble", "Village", "County", "Pond", "Town", "Square", "Vin", "Ville", "Vein", "Von", "Sierra", "Creek", "Drove", "Valley", "Narrows", "Field", "Bell", "Spelton", "Host", "Horn", "Moor", "Front", "Shear", "Den", "Stormton", "Watch", "Tower", "Point", "Ford", "Vale", "Falls", "Thorn", "Burrow", "Burrows" };

                string NamecityPre2 = cityPre[rcs.Next(cityPre.Length)];
                string NamecityPos2 = cityPos[rcs.Next(cityPos.Length)];

                return new string[] { NamecityPre2, NamecityPos2 };
            }
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

