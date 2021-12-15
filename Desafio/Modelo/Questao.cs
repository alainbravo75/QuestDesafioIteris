using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Modelo
{
    public class Questao
    {
        public Questao(string Texto, List<Alternativa> ListaDeAlternativas, string Resposta)
        {
            this.Texto = Texto;
            this.ListaDeAlternativas = ListaDeAlternativas;
            this.Resposta = Resposta;
        }
        public string? Texto { get; set; }
        public bool Acertou(string? res)

        {
            //Console.WriteLine(res + " " + this.Resposta);(código de verificação)
            if (res == this.Resposta)
                return true;
            else
                return false;
        }
        public string Resposta { get; set; }
        public List<Alternativa> ListaDeAlternativas { get; set; }
        
    }
}
