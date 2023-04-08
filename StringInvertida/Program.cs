using System;

Console.WriteLine("Escreve um texto para invertê-lo");
string texto = Console.ReadLine();
string textoInvertido = new string(texto.Reverse().ToArray());
Console.WriteLine(textoInvertido);
