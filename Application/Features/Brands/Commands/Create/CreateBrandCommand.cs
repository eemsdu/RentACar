using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

//mediatr burada ırequest olduğu görüyor mediatr bunu biliyor tanıyor bunu handle etmem lazım diyor implemente etmem gerekiyor  cqrs de commandin handlersız handlerın ise commanda-siz bir analmı yoktur o yüzden buraya yazıcaz handler sınıfımızı 
public class CreateBrandCommand : IRequest<CreatedBrandResponse>
//kullacının yapacağı istek  kullanıcı bize bir tane create brandcommand  gönderecek bize bir command gelecek ve bizde bunu mapleyerek veri tabanımıza kaydedeceğiz  marka eklemek için gerekli request nesnesi brand nesnesi aslında ama biz createbrandcommand nesnei alıyoruz  niye aslında veri tabanımızda bir çok nesne var ama kulllanıcıdan 3 tanesi alıyoruz ya da daha az ... 
// bu nesne evet bir istek request asma geriyer ne döndürücek onu da generic bir şekilde vermeliyiz ...
{
    public string Name { get; set; }
    public class CreateBrandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        //sana createbrandcommand gönderilirse bunun içini çalıştır demiş oluyoruz ve aynı zamanda bunun responsunuda vvermemiz gerekir.Burada verilen command başka bir handlera yazılamaz unbeguis belirsiz bir durum ortaya çıkar ve hata verir...
        public Task<CreatedBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            //burada gelen command okumaya çalışalım
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = request.Name;
            createdBrandResponse.Id = new Guid();
            return null;
        }
    }

}
