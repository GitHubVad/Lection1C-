int [] array = { 1, 21, 13, 37, 4, 5, 16,  37, 8};

int n = array.Length;
int find = 37;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
