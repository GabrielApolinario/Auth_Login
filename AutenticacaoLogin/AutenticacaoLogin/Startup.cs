using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(AutenticacaoLogin.Startup))]

namespace AutenticacaoLogin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                //Valor default
                AuthenticationType = "ApplicationCookie",
                
                //Pagina de login da aplicação
                LoginPath = new PathString("/Autenticacao/Login")
            });


        }
    }
}
