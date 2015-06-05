using System.Collections.Generic;
using System.Web;
using System.Web.Helpers;

namespace WebGridImplementacao.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public static List<Pessoa> GetPessoas()
        {
            var pessoas = new List<Pessoa>();
            for (var i = 1; i < 100; i++)
            {
                var p = new Pessoa{Id = i, Nome = "Fulano " + i, Idade = i, Email = "fulano" + i + "@.com.br", Endereco = "Rua 10" + i };
                pessoas.Add(p);
            }
            return pessoas;
        }
    }
}