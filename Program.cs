Console.Write("Digite Somente o Número par de 0 a ?");

int NumeroDigitado = Convert.ToInt32(Console.ReadLine());


if (NumeroDigitado >= 1)

{   int numeroPar = 0;

while (numeroPar <= NumeroDigitado)

{ 
    Console.Write($"{numeroPar}");
    numeroPar += 2;

}
Console.WriteLine();

} 

else

{

    Console.WriteLine($" O Número {NumeroDigitado} não é positivo");
}