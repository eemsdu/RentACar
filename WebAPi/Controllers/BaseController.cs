using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPi.Controllers
{
    public class BaseController:ControllerBase   // ıoc ye dahil edicez ama birden fazla ıoc konfigirasyonu olujcak bu yüzden her katman için bir tane ıoc conteiner yazmak istiyorum 
    {
        //bunu sadece inject edenler inherit edebilsin diye protected yapıyorum 
        private IMediator? _mediator;
        protected IMediator? Mediator => _mediator??= HttpContext.RequestServices.GetService<IMediator>();

        //Benim burada bir mediatorım var ise başka bir deyiş ile set edilmiş ise onu döndğr yok eğer elimde bir mediştarım yok ise git injectionlara bak bulduğun noktada onu set et demiş oluyoruz 
        //Daha önce mediator inject edilmiş ise onu döndür yok ise git ıoc ortamına bak ve ımediatorun karşılığı ne ise bana ver demiş oluyoruz bunu dedikten sonra Imeditr injection yapmamış olucam 
    }
}
