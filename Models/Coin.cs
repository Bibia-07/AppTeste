using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste.Models
{
    public class Coin
    {
        public string Lado { get; set; } = string.Empty;

        public string Jogar()
        {
            int LadoSorteado = new Random().Next(2);
            Lado = (LadoSorteado == 0) ? "Cara" : "Coroa"; 
            return Lado;
        }

        public string Jogar(string LadoEscolhido)
        {
            int LadoSorteado = new Random().Next(2);
            Lado = (LadoSorteado == 0) ? "Cara" : "Coroa";

            string Resultado = (Lado == LadoEscolhido) ?
                $"Parabéns, Você pediu {LadoEscolhido} e deu {Lado}" :
                $"Que pena, você {LadoEscolhido} e deu {Lado}";
            
            return Resultado;
        }
    }
}
