using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutenticacaoLogin.Models;
using AutenticacaoLogin.ViewModels;
using AutenticacaoLogin.Utils;

namespace AutenticacaoLogin.Controllers
{
    public class AutenticacaoController : Controller
    {
        //Instanciando objeto do tipo UsuariosContext
        private UsuariosContext db = new UsuariosContext();
        // GET: Autenticacao
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroUsuarioViewModel viewmodel)
        {
            //Checa se os dados digitados são validos e cumprem os requisitos desejados
            if (!ModelState.IsValid)
            {   //Se não forem, retorna para a viewmodel
                return View(viewmodel);
            }
            
                //Contando se dentro do banco já existe algum login igual ao que está se cadastrando
            if (db.Conexao.Count (u => u.Login == viewmodel.Login) > 0)
            {
                //Vincula esse modelo de erro ao 'Login'
                ModelState.AddModelError("Login","Já existe um usuário com este login");
                return View(viewmodel);
            }
            
            //Instancia novo usuario
            Usuario novoUsuario = new Usuario
            {
                //Usuario receberá os dados pela viewmodel
                Nome = viewmodel.Nome,
                Login = viewmodel.Login,
                //Recebendo metodo de encriptação criado
                Senha = Hash.GerarHash(viewmodel.Senha)
            };

            //Adiciona o novo usuario para o banco de dados
            db.Conexao.Add(novoUsuario);
            //Salva as mudanças
            db.SaveChanges();

            //Redireciona para a Action Index do controlador Home
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login (string ReturnUrl)
        {
            var viewmodel = new LoginViewModel
            {
                UrlRetorno = ReturnUrl
            };

            return View(viewmodel);
        }

    }
}