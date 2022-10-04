
using static System.Console;

string[] WriteArray() 
{
    Console.Write("Введите значения: ");
    return ReadLine().Split(" ");
}
string[] array = WriteArray();
string[] result = GetNewArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] GetNewArray(string[] array1, int n) 
{
string[] array2 = new string[Array(array1, n)]; 

    for(int i = 0, j = 0; i < array1.Length; i++) 
    {
        if(array1[i].Length <= n) 
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}
int Array(string[] array1, int n) 
{
    int count = 0;
    for(int i = 0; i < array1.Length; i++)
     {
        if(array1[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}


