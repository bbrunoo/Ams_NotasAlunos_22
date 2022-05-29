using static System.Console;

int nota1 = 0;
int nota2 = 0;
int nota3 = 0;
int nota4 = 0;

WriteLine("--------------------------------");

WriteLine("Escreva a nota 1:");
nota1 = Convert.ToInt32(ReadLine());

WriteLine("--------------------------------");

WriteLine("Escreva a nota 2:");
nota2 = Convert.ToInt32(ReadLine());

WriteLine("--------------------------------");

WriteLine("Escreva a nota 3:");
nota3 = Convert.ToInt32(ReadLine());

WriteLine("--------------------------------");

WriteLine("Escreva a nota 4:");
nota4 = Convert.ToInt32(ReadLine());

WriteLine("--------------------------------");




int Media = (nota1 + nota2 + nota3 + nota4) / 4;

WriteLine($"A media final das notas é: {Media}");

if (Media > 7)
{
    WriteLine("Aprovado!");
}
else if (Media < 7)
{
     WriteLine("Reprovado!!!");
}

WriteLine("--------------------------------");
