using System.Collections;

var lista = new ArrayList() { "Paulo", 17, 1.75, true };

Console.WriteLine("ArrayList original");
Listar(lista);


Console.WriteLine("ArrayList usando Add");
lista.Add("Maria"); // adiciona um elemento no final da lista
Listar(lista);


Console.WriteLine("ArrayList usando Insert");
lista.Insert(1, false); // primeiro argumento é o índice, segundo é o valor a ser inserido
Listar(lista);


Console.WriteLine("ArrayList usando AddRange");
int[] vet = new int[] { 10, 20, 30 };

lista.AddRange(vet); // adiciona todos os elementos do vetor no final da lista
Listar(lista);


Console.WriteLine("ArrayList usando Remove");
lista.Remove(10); // o parâmetro é o valor a ser removido;
                  // se houver mais de um elemento com o mesmo valor,
                  // apenas o primeiro será removido
Listar(lista);


Console.WriteLine("ArrayList usando RemoveAt");
lista.RemoveAt(0); // o parâmetro é o índice do elemento a ser removido
Listar(lista);


Console.WriteLine("ArrayList usando RemoveRange");
lista.RemoveRange(4, 2); // primeiro parâmetro é o índice onde começa a remover,
                         // segundo parâmetro é a quantidade de elementos a serem removidos
Listar(lista);


lista.Clear(); // remove todos os elementos da lista
Listar(lista);


// Criando outro ArrayList
var nomes = new ArrayList() { "Michael", "Jackson", "Joseph" };

Console.WriteLine("ArrayList ordenado");

nomes.Sort(); // ordena os elementos da lista em ordem alfabética
Listar(nomes);


// Método responsável por listar todos os elementos do ArrayList
static void Listar(ArrayList lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}