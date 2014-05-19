// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
// operation over the first letter of the string with the first of the key, the second – with the second, etc. 
// When the last key character is reached, the next is the first.

using System;
using System.Text;

namespace EncodeDecodeString
{
    class EncodeDecodeString
    {
        static void Main()
        {
            string input = "Jules, if you give that fuckin' nimrod fifteen hundred dollars, I'm gonna shoot him on general principles.";
            string key = "PulpFiction";                        
            string encoded = Encode(input, key);
            Console.Write("Encrypted: \"{0}\"", encoded);
            Console.WriteLine();
            Console.WriteLine();
            string decoded = Decode(encoded, key);
            Console.Write("Decrypted: \"{0}\"", decoded);
            Console.WriteLine();
        }

        static string Encode(string input, string key)
        {
            char[] array = input.ToCharArray();
            char[] keyArray = new char[array.Length];
            StringBuilder encoded = new StringBuilder();
            for (int i = 0, k = 0; i < keyArray.Length; k++, i++)
            {
                keyArray[i] = key[k];
                if (k == key.Length - 1)
                {
                    k = -1;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                encoded.Append((char)(array[i] ^ keyArray[i]));
            }
            return encoded.ToString();
        }

        static string Decode(string encoded, string key)
        {
            string decoded = Encode(encoded, key).ToString();
            return decoded;
        }
    }
}
