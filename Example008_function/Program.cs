int Max(int a, int b, int c)
{
    int res = a;
    if (b > res) res = b;
    if (c > res) res = c;
    return res;
}
int[] mas = {11, 12, 3, 14, 25, 36, 47, 18, 19};
int result = Max(Max(mas[0], mas[1], mas[2]), 
Max(mas[3], mas[4], mas[5]), 
Max(mas[6], mas[7], mas[8]));
Console.WriteLine(result);