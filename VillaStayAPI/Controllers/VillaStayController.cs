using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VillaStayAPI.Data;
using VillaStayAPI.Model;

namespace VillaStayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaStayController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetVillas()
        {
            return Ok(VillaStore.villas);
        }
        [HttpGet]
        [Route("name")]
        public IActionResult GetVillasByName(string name)
        {
            Villa? villa = VillaStore.villas.FirstOrDefault(villa => villa.Name == name);
            if (villa != null)
            {
                return Ok(villa);
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("name")]
        public IActionResult DeleteVillasByName(string name)
        {
            Villa? villa = VillaStore.villas.FirstOrDefault(villa => villa.Name == name);
            if (villa != null)
            {
                VillaStore.villas.Remove(villa);
                return Ok(VillaStore.villas);
            }
            return NotFound();
        }
        [HttpPost]
        [Route("name")]
        public IActionResult AddVillasByName(string name)
        {
            
            if (ModelState.IsValid)
            {
                Villa? villa = new Villa() { 
                    Name = name, Id = Guid.NewGuid(), CreatedDate = DateTime.Today };
                VillaStore.villas.Add(villa);
                return Ok(villa);
            }
            return BadRequest();
        }
    }
}
