using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Modelo
{
    public class Quiz
    {
        public string NomeDoQuiz { get; set; }
        public List<Questao> ListaDeQuestoes { get; set; }

        public int Nota { get; set; }

        public void MostrarQuiz()
        {
            Console.WriteLine(NomeDoQuiz);
        }
    }
}
