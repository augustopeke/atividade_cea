using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCea
{
    public class Animal
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    type = value;
                }
                else
                {
                    type = "Peixe";
                }
            }

        }
    }
}
