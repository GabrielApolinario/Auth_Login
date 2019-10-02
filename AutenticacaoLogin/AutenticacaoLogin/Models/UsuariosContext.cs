using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AutenticacaoLogin.Models
{
    public class UsuariosContext : DbContext
    {
        
        //UsuariosContext esta herdando de 'base' que por sua vez está recebendo uma string de conexão chamada 'Conexao'
        public UsuariosContext():base("Conexao")
        {

        }

        
        public DbSet<Usuario> Conexao { get; set; }
    }
}