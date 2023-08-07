using Core.Persistance.Repositories; //local ortamdan referaqnced verdik 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

//marka 
public class Brand:Entity<Guid>
{
    //public Guid Id { get; set; } //her projede nesnede değişir id common bir şey ortak 
    public string Name  { get; set; }

    public Brand()
    {
            
    }
    public Brand(Guid id,string name)
    {
          Id=id;   
          Name=name;    
    }
}
  