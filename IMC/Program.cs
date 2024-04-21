float peso=0, altura=0, imc=0;
char sexo;

Console.WriteLine("Digite o peso em kg: ");
peso=float.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura em metros: ");
altura=float.Parse(Console.ReadLine());

Console.WriteLine("Digite o sexo: M para masculino ou F para feminino");
sexo=char.Parse(Console.ReadLine());

imc=peso/(altura*altura);
Console.WriteLine("O resultado é: " + imc);

if (sexo == 'F' || sexo == 'f')
{
    if (imc < 19)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc < 23.9)
    {
        Console.WriteLine("Peso normal");
    }
    else if (imc < 28.9)
    {
        Console.WriteLine("Obesidade leve");
    }
    else if (imc < 38.9)
    {
        Console.WriteLine("Obesidade moderada");
    }
    else
    {
        Console.WriteLine("Obesidade mórbida");
    }
}
else if (sexo == 'M' || sexo == 'm')
{
    if (imc < 20)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc < 24.9)
    {
        Console.WriteLine("Peso normal");
    }
   else  if (imc < 29.9)
    {
        Console.WriteLine("Obesidade leve");
    }
    else if (imc < 39.9)
    {
        Console.WriteLine("Obesidade moderada");
    }
    else
    {
        Console.WriteLine("Obesidade mórbida");
    }
}
else
{
    Console.WriteLine("Sexo inválido");
}
