while (true)
{

    double cateto1 = 0;
    double cateto2 = 0;
    double hipotenusa;
    double potenciaCatetos = 0;


    do
    {
        Console.Write("Digite o valor do cateto 1: ");
        cateto1 = float.Parse(Console.ReadLine());
        if (cateto1 == 0 || cateto1 < 0)
        {
            Console.WriteLine("\n|O cateto de um triângulo não pode ser menor ou igual a zero.");
            Console.WriteLine("--------------------------------------------------------------------");
        }

    } while (cateto1 == 0 || cateto1 < 0);

    do
    {
        Console.Write("Digite o valor do cateto 2: ");
        cateto2 = float.Parse(Console.ReadLine());
        if (cateto2 == 0 || cateto2 < 0)
        {
            Console.WriteLine("\n|O cateto de um triângulo não pode ser menor ou igual a zero.");
            Console.WriteLine("--------------------------------------------------------------------");
        }

    } while (cateto2 == 0 || cateto2 < 0);

    potenciaCatetos = cateto1 * cateto1 + cateto2 * cateto2;
    hipotenusa = Math.Sqrt(potenciaCatetos);

    Console.WriteLine("\nA hipotenusa é: {0:0.00}", hipotenusa);
    Console.WriteLine("\n\n|Pressione qualquer tecla: ");
    Console.ReadKey();
    Console.Clear();

}







