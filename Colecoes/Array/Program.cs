int[] numeros = new int[] { 1, 2, 3 }; ;
var nomes = new string[] { "Alice", "Bob", "Charlie" };

foreach (var n in nomes)

{
    Console.WriteLine($"{n}"); // duas maneiras de escrever a mesma coisa, esse é interpolação de string
    Console.WriteLine( n ); // Esse é o jeito tradicional de escrever que é concatenação de string
    nomes.Sort(); // ordena os elementos da lista em ordem alfabética
}
;
// diferença de vetor e array é: 
//vetor é uma estrutura de dados que pode crescer dinamicamente, enquanto array tem tamanho fixo.

//array de dus dimensões
int[,] numeros2 = new int[,] { { 1, 2, 3 }, { 3, 4, 6 } };
for(int l =0; l<numeros2.GetLength(0); l++)
{
    for (int c= 0; c< numeros2.GetLength(0); c++)
    {
        Console.WriteLine(numeros2[l, c]);
    }
}
Console.WriteLine("usando foreach");
foreach(var numero in numeros2)
{
    Console.WriteLine(numero);
}
