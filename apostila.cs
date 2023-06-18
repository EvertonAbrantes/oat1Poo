using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apostila
{
    public class Carro
    {
        public int idCarro { get; set; }
        public string nomeCarro { get; set; }
        public string marcaCarro { get; set; }
        public string modeloCarro { get; set; }
        public string placaCarro { get; set; }
        public string corCarro { get; set; }


        public string Acelerar()
        {
            return "O carro está em movimento";
        }

        public string freiar()
        {
            return "O carro está parado";
        }

    }
}
