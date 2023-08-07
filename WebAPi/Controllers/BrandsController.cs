using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            //burada mediatr kullanabilmek için onu inject etmemiz gerekiyor bunu paketi tüm controllerımda kullanacağım için onu burada değil de global bir noktadan inject edicem base bir controller oluşturuyorum 
           CreatedBrandResponse reponse= await Mediator.Send(createBrandCommand);
            //send diyince gidiyor handler sınıfını buluyor onun içinde ki  kod bloğunu çalıştırıyor bana da response döndürüyor 
            return Ok(reponse); 

        }
    }
}
