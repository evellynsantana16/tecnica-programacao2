
using System.Collections.Generic;

// Todas as operações utilizadas no ArrayList funcionam no List,
// mas o List é mais performático e mais seguro, pois é tipado.

// O List precisa informar qual tipo de dado ele vai armazenar.
// Neste caso, estamos criando uma lista de strings.
List<string> nomes = new List<string>() { "Lana", "Del", "Rey" };


// MÉTODOS:

// Find() - retorna o primeiro elemento que satisfaz
// a condição do predicado.

// FindLast() - retorna o último elemento que satisfaz
// a condição do predicado.

// FindIndex() - retorna o índice do primeiro elemento
// que satisfaz a condição do predicado.

// FindLastIndex() - retorna o índice do último elemento
// que satisfaz a condição do predicado.

// FindAll() - retorna todos os elementos que satisfazem
// a condição do predicado.

// O que é predicado?
// É uma função que recebe um elemento e retorna um booleano.
// Ou seja, é uma função que verifica se o elemento
// satisfaz uma condição ou não.

// Contains() - verifica se a lista contém um elemento específico.


// Usando uma função como predicado
var ret = nomes.Find(procurar);

Console.WriteLine(ret);


// Função que será utilizada como predicado.
// Recebe uma string e retorna true ou false.
static bool procurar(string nome)
{
    return nome.Contains('a');
}


// Expressão lambda
// É uma forma mais curta de escrever uma função.

var ret2 = nomes.Find(i => i.Contains('a'));

Console.WriteLine(ret2);


// FindAll()
// Retorna todos os elementos que satisfazem a condição.

var ret3 = nomes.FindAll(i => i.Contains('a'));

foreach (var nome in ret3)
{
    Console.WriteLine(nome);
}


// FindLast()
// Retorna o último elemento que satisfaz a condição.

var ret4 = nomes.FindLast(i => i.Contains('a'));

Console.WriteLine(ret4);


// Criando uma lista de objetos Produto.
// Aqui precisamos informar o tipo entre < >.
var produtos = new List<Produto>();


// Adicionando um produto na lista.
// Add() recebe um objeto Produto.
produtos.Add(new Produto(1, "Camiseta", 29.90m));
produtos.Add(new Produto(2, "Calça", 79.90m));

foreach (var produto in produtos)
{
    Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Price}"); //interpolação de string
    //php - =>; c# - .; 
}


// Classe Produto
public class Produto
{
    public Produto()
    {
    }

    public Produto(int id, string nome, decimal price)
    {
        Id = id;
        Nome = nome;
        Price = price;
    }

    public int Id { get; set; }

    public string? Nome { get; set; }

    public decimal? Price { get; set; }
}

