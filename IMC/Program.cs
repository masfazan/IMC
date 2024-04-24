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
    switch (imc)
    {
        case (imc < 19):
            Console.WriteLine("Abaixo do peso");
            break;
        case (imc < 23.9):
            Console.WriteLine("Peso normal");
            break;
        case (imc < 28.9):
            Console.WriteLine("Obesidade leve");
            break;
        case (imc < 38.9):
            Console.WriteLine("Obesidade moderada");
            break;
        default:
            Console.WriteLine("Obesidade mórbida");
            break;
    }
}
else if (sexo == 'M' || sexo == 'm')
{
    switch(imc)
    {
        case (imc < 20):
        Console.WriteLine("Abaixo do peso");
            break;
        case (imc < 24.9):
        Console.WriteLine("Peso normal");
            break;
        case (imc < 29.9):
        Console.WriteLine("Obesidade leve");
            break;
        case (imc < 39.9):
        Console.WriteLine("Obesidade moderada");
            break;
        default:
        Console.WriteLine("Obesidade mórbida");
            break;
    }
}
else
{
    Console.WriteLine("Sexo inválido");
}
