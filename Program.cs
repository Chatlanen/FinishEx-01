
string[] arr = new string[6] {"257", "45", "hello", "world", "res","456"};

string[] getArr (string[] arr)
{
    string[] ret = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        ret[count] = arr[i];
        count++;
        }
    }
    Array.Resize(ref ret,count);
    return ret;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]},");
    }
    Console.WriteLine();
}

PrintArray(getArr(arr));
