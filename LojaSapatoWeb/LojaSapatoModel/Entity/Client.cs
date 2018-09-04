using LojaSapatoModel.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatoModel.Entity
{
    class Client : GenericModelImpl
    {
        public String nome;
        public String cpf;
        public int idade;
    }
}
