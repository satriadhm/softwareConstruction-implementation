using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmod9_1302213015.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("GLORIOUS SATRIA DHAMANG AJI", "1302213015"),
            new Mahasiswa("KEVIN", "1302210019"),
            new Mahasiswa("RAFIDHIA HAIKAL PASYA", "1302210127"),
            new Mahasiswa("PUTU VIDYA ANANDA RATMAYANTI", "1302213026"),
            new Mahasiswa("PUTU VIDYA ANANDA RATMAYANTI", "1302213026")
        };

        // GET: api/<mahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<mahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<mahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // PUT api/<mahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;  
        }

        // DELETE api/<mahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id); 
        }
    }
}
