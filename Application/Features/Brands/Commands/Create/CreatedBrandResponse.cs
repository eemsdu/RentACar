using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

public class CreatedBrandResponse
{
    //burada istek sonucunda ne dönecekse onu vermeliyim   
    public Guid Id { get; set; }
    public string Name { get; set; }    
}
