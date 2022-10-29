void shellSort(int[] arr)
{
    int j;
    int step = arr.Length / 2;
    while (step > 0)
    {
        for (int i = 0; i < (arr.Length - step); i++)
        {
            j = i;
            while ((j >= 0) && (arr[j] > arr[j + step]))
            {
                int tmp = arr[j];
                arr[j] = arr[j + step];
                arr[j + step] = tmp;
                j -= step;
            }
        }
        step = step / 2;
    }
}