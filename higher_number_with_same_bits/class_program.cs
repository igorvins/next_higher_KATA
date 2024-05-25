using System.Security.Cryptography;
public class Kata
    {
        public int nextHigher(int value)
        {
        //call to transform input into bits
        var result = BinaryConversor(value);
            //trasnform each of next number into bits
            int next_number=0;
            int v = 0;
            while (v == 0)
            {
                next_number = value + 1;
                //call to transform next into bits
                var result_2=BinaryConversor(next_number);
                //verify the condition
                if (result.c == result_2.c) { v = 1; }
            }
            return next_number;
        }
        public (string binary_return, int c) BinaryConversor(int input_aux)
        {
            int x;
            List<int> binary = new List<int>();
            //gerar binario:
            while (input_aux != 0)
            {
                x = input_aux % 2;
                binary.Add(x);
                input_aux = input_aux / 2;
            }
            binary.Reverse();
            int c = 0;
            //conta quantidade de 1:
            foreach (int n in binary)
            {
                if (n == 1) { c++; }
            }
            string binary_return = string.Join("", binary);
            //retorna tupla de numero binario e quantidade:
            Console.WriteLine(binary_return);
            Console.WriteLine(c);
            return (binary_return, c);
        }
}


