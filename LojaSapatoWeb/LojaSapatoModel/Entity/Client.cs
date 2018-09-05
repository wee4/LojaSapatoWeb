using LojaSapatoModel.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatoModel.Entity
{
    class Client : ModelRepository<Client>
    {
        private String nome;
        private String cpf;
        private int idade;
       
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
