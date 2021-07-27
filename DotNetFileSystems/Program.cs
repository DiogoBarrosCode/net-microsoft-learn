using System;

/* Necessário para utilizar os tipos internos para trabalhar com o sistema de arquivos */
using System.IO;

/* Necessário para utilizar IEnumerable<> */
using System.Collections.Generic;

namespace DotNetFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /* lista os diretórios dentro de obj */
            IEnumerable<string> listDir = Directory.EnumerateDirectories("obj");
            
            Console.WriteLine("Diretórios:");
            foreach (var dir in listDir)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("\n");


            /* lista os arquivos dentro de obj */
            IEnumerable<string> files = Directory.EnumerateFiles("obj");
            
            Console.WriteLine("Arquivos:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("\n");

           /* lista os arquivos dentro de obj com sobrecarga especificando um padrão de busca *.json */
            IEnumerable<string> FilesInFolder = Directory.EnumerateFiles("obj", "*.json");

             Console.WriteLine("Arquivos .json:");
            foreach(var file in FilesInFolder)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("\n");

           /* lista os arquivos dentro de obj com sobrecarga especificando um padrão de busca *.json e 
           sobrecarga que aceita um parâmetro para indicar se é preciso percorrer recursivamente 
           uma pasta especificada e todas as suas subpastas  */
            IEnumerable<string> FilesInAllFolders = Directory.EnumerateFiles("obj", "*.cache", SearchOption.AllDirectories);

             Console.WriteLine("Arquivos .cache em outros diretórios:");
            foreach(var file in FilesInAllFolders)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("\n");

            /* Lista todos os diretórios utilizando sobrecargas */
            IEnumerable<string> listDirAll = Directory.EnumerateDirectories("obj", "", SearchOption.AllDirectories);
            
            Console.WriteLine("Todos os Diretórios:");
            foreach (var dir in listDirAll)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("\n");

            /* Lista todos os diretórios e busca todos os arquivos utilizando sobrecargas */
            IEnumerable<string> listDirAllFiles = Directory.EnumerateFiles("obj", "", SearchOption.AllDirectories);
            
            Console.WriteLine("Todos os Diretórios e arquivos:");
            foreach (var dir in listDirAllFiles)
            {
                Console.WriteLine(dir);
            }

        }
    }
}
