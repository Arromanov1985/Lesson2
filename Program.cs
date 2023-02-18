int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//              0 1  2  3  4  5  6  7 8 
int[] array = {71,62,53,34,25,62,7,18,92};
array[0] = 72;
Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[0], array[0]),
   Max(array[0], array[0], array[0]),
    Max(array[0], array[0], array[0]));



Console.WriteLine(max);
