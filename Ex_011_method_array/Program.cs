int[] array = {10,82,73,24,35,56,27,27,8};

int n = array.Length;
int find = 27;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}