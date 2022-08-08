using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public Cliente(string name = "sem nome")
        {
            Nome = name;
        }
        public string Nome { get; set; }
    }
}
