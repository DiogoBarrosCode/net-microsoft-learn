/*

1- O código public static void Main() e o conjunto de chaves dele definem um tipo de 
bloco de código chamado de método. Um método contém um agrupamento de código que funciona 
para uma única finalidade ou responsabilidade em seu sistema de software.

2- Os métodos são organizados dentro de outros blocos de código chamados de classes. 
Uma classe pode conter um ou mais métodos. A classe no código anterior chama-se Program.

3- A linha de código Console.WriteLine() inserida no nosso método, está chamando ou 
executando o método WriteLine(). O método WriteLine() está contido na classe Console.

4- Na verdade, o nome completo dele é System.Console.WriteLine(). 
A palavra System foi omitida na sua chamada para Console.WriteLine(). 
Mas a primeira linha de código using System; instruirá o compilador do C# 
a procurar na biblioteca de classes base.

*/


using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}