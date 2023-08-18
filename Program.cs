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