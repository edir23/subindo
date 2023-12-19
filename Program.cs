
double nota1, nota2, nota3;
double media;

Console.WriteLine("Digite a primeira nota:");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
nota3 = Convert.ToDouble(Console.ReadLine());


media = (nota1 + nota2 + nota3) / 3;
if (media >= 70)
{
    Console.WriteLine("Aprovado por média");
}

else
{
    Console.WriteLine("Reprovado");
}