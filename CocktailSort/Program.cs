Random random = new Random();

bool IsSorted(List<int> list, int size)
{
    for (int i = 0; i < size - 1; i++)
    {
        if (list[i] > list[i + 1])
        {
            return false;
        }
    }
    return true;
}

int CocktailSort(List<int> list, int size)
{
    int timesRan = 0;
    int tempNum;
    while (!IsSorted(list, size))
    {
        timesRan += 1;
        for (int i = 0; i < size-1; i++)
        {
            if (list[i] > list[i + 1])
            {
                tempNum = list[i];
                list[i] = list[i + 1];
                list[i + 1] = tempNum;
            }
        }
    }
    return timesRan;
}

int Sort(int size)
{
    int temp = 0;
    for (int i = 0; i < 5; i++)
    {
        temp += CocktailSort(CreateRandomList(size), size);
    }
    Console.WriteLine(Convert.ToInt32((float)temp / 5));
    return Convert.ToInt32((float)temp / 5);
}
List<int> CreateRandomList(int size)
{
    List<int> list = new List<int>();
    for (int i = 0; i < size; i++)
    {
        list.Add(random.Next(0, size));
    }
    return list;
}

Sort(1000000);

