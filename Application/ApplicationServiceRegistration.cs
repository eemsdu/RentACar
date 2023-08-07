using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application;

public static class ApplicationServiceRegistration
{
    //buraya bir tane extencion yazıcaz  bunun için yapısının static olması gerekir 

    //burada application ile ilgili tüm registrationlarımı yapıcam program.cs onunla kirlenmicek apime gidip bu servisi dahil ediyorum 
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            //configuration için konfigirasyon yap RegisterServicesFromAssembly mediatr git bütün assmebly tara onların commandlerını  queryleini bul yine onların handlerlarını bul onları biibiri ile eşleştir ve listene koy ben yarın bir gün sana send yapar isem git onun handlerı ne ise git onu çalıştır diyorum   //peki burada taranacak olan assemblyler hangisi  assembly.getexecutingassembly diyerek mevcut olan assemblyi alıyoruz 
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());    

        });    
        return services;
    }
}
