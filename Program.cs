int Max(int arg1, int arg2, int arg3)
{
    int result =arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int [] array = {1,25,38,48,57,66,75,87,32,43,54,66,75};
array [0] = 2;

Console.WriteLine (array[0]);

int max = Max(
    Max(array[0], array[1], array[2]);
    Max(array[3], array[4], array[5]);
    Max(array[6], array[7], array[8]);
    Max(array[9], array[10], array[11]);
    Max(array[12]);
);
Console.WriteLine(max);