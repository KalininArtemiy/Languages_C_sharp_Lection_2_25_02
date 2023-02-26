// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}
int q = 12;
int w = 42;
int e = 33;
int r = 44;
int t = 75;
int y = 36;
int u = 67;
int i = 28;
int o = 96;
int max1 = Max(q, w, e);
int max2 = Max(r, t, y);
int max3 = Max(u, i, o);
int max = Max(max1, max2, max3);
Console.WriteLine(max);