using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int input = 129;
//transform input into bits
List<int> binary = new List<int>();
int input_aux = input;
int x;
while (input_aux != 0)
{
    x = input_aux % 2;
    binary.Add(x);
    input_aux = input_aux / 2;
    Console.WriteLine(x);
}
binary.Reverse();
//count bits
int c = 0;
foreach (int n in binary)
{
    if (n == 1) { c++; }
}
Console.WriteLine(c);
//transform each of next number into bits----------------------
int v = 0;
List<int> binary2 = new List<int>();
int retorno = input;
int c_2 = 0;
while (v == 0)
{
    retorno = retorno + 1;
    int next_number = retorno;
    Console.Write(retorno);
    //gerar binario:
    while (next_number != 0)
    {
        x = next_number % 2;
        binary2.Add(x);
        next_number = next_number / 2;
    }
    binary2.Reverse();
    //count bits
    c_2 = 0;
    foreach (int n in binary2)
    {
        if (n == 1) { c_2++;  
        }
    }
    Console.WriteLine(c_2);
    //verify the condition
    if (c == c_2) { v = 1;
        Console.WriteLine(retorno);
    }
    binary2.Clear();
}