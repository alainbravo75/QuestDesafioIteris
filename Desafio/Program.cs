// See https://aka.ms/new-console-template for more information
using Desafio.Modelo;
Quiz quiz1 = new Quiz()
{
    NomeDoQuiz = "Bem vindo ao Quiz Iteris.\nEsse quiz é composto por 3 Questôes"
};
quiz1.MostrarQuiz();

//Alternativas da questão 1
Alternativa alternativa1Quest1 = new Alternativa();

    alternativa1Quest1.Texto = "4";
    alternativa1Quest1.Letra = "a.";


Alternativa alternativa2Quest1 = new Alternativa();

    alternativa2Quest1.Texto = "5";
    alternativa2Quest1.Letra = "b.";

//Lista dos objetos da questão 1
List<Alternativa>alternativas = new List<Alternativa>();
alternativas.Add(alternativa1Quest1);
alternativas.Add(alternativa2Quest1);
Questao questao1 = new Questao("Quanto é 2 + 2?", alternativas, "a");



//Alternativa da questão 2
Alternativa alternativa1Quest2 = new Alternativa();
{
    alternativa1Quest2.Texto = "4";
    alternativa1Quest2.Letra = "a";
 
}
Alternativa alternativa2Quest2 = new Alternativa();
{
    alternativa2Quest2.Texto = "7";
    alternativa2Quest2.Letra = "b";

}

//Lista dos objetos da questão 2
List<Alternativa> alternativas2 = new List<Alternativa>();
alternativas2.Add(alternativa1Quest2);
alternativas2.Add(alternativa2Quest2);
Questao questao2 = new Questao("Quanto é 2 + 5?", alternativas2, "b");



// Alternativa da questão 3
Alternativa alternativa1Quest3 = new Alternativa();
{
    alternativa1Quest3.Texto = "2^2";
    alternativa1Quest3.Letra = "a."; 
}

Alternativa alternativa2Quest3 = new Alternativa();
{
    alternativa2Quest3.Texto = "- 2 * 2";
    alternativa2Quest3.Letra = "b.";
}

Alternativa alternativa3Quest3 = new Alternativa();
{
    alternativa3Quest3.Texto = "2 * 2";
    alternativa3Quest3.Letra = "c.";
}

Alternativa alternativa4Quest3 = new Alternativa();
{
    alternativa4Quest3.Texto = "4^1";
    alternativa4Quest3.Letra = "d.";
}

//Lista dos objetos da questão 3
List<Alternativa> alternativas3 = new List<Alternativa>();
    alternativas3.Add(alternativa1Quest3);
    alternativas3.Add(alternativa2Quest3);
    alternativas3.Add(alternativa3Quest3);
    alternativas3.Add(alternativa4Quest3);
Questao questao3 = new Questao("4 = X. Quais os possível valores de X:", alternativas3, "abd");

quiz1.ListaDeQuestoes = new List<Questao>()
{
    questao1,
    questao2,
    questao3
};
int Num = 1;
foreach (var item in quiz1.ListaDeQuestoes)
{
    
    Console.WriteLine(Num + ". " + item.Texto);
    

    foreach(var alt in item.ListaDeAlternativas)
    {
        Console.WriteLine(alt.Letra + ". " + alt.Texto );
    }
    Console.Write("Sua resposta: "); string res = Console.ReadLine();//Ponteiro fica esperando 

    if (item.Acertou(res))
    {
        quiz1.Nota++;
    }
    
    Num++;
};
Console.WriteLine("Sua nota é: " + quiz1.Nota);



