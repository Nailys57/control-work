using System;
using static System.Console;
Clear();

string[] starray = {"Start", "Flex", "57", "Max", "N", ":-)"};
int len = starray.Length;
int y = 0;
for (int i = 0; i < len; i++)
{
    string str = starray[i];
    int x = str.Length;
    if (x <= 3)
    {
        y++;
    }
}

string[] CreateArray(int size) 
{
    return new string[size];
}
void Fill(int Length, string[] array) 
{
    int a = 0;
    for (int i = 0; i < Length; i++)
    {
        string str = starray[i];
        int x = str.Length;
        if (x <= 3)
        {
            array[a] = str;
            a++;
        }
    }
}
string Print(string[] array) 
{
    int size = array.Length;
    string res = string.Empty;
    res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i]}";
        if(i < size - 1)
        {
            res += ", ";
        }
    }
    res += " ]";
    return res;
}

string[] array = CreateArray(y);
Fill(len, array);
WriteLine(Print(array));

