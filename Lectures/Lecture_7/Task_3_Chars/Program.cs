﻿// char[] s = {'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     System.Console.WriteLine($"{n++, -2}{s[i]}");
// }
int n =1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}"); return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);