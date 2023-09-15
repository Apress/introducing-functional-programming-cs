using static System.Console;
//WriteLine("Imperative versus Declarative");
#region imperative
int flag = 0;
int random1 = new Random().Next(0, 2);
int random2 = new Random().Next(10, 15);
WriteLine($"The random number 1 is: {random1}");
WriteLine($"The random number 2 is: {random2}");
if (random1 % 2 == 0)
{
    flag++;
}

if (random2 >= 13)
{
    flag += 2;
}
WriteLine($"The flag is: {flag}");
#endregion


#region declarative
int flag1 = 0;
flag1 += (random1 % 2 == 0 ? 1 : 0)
      + (random2 >= 13 ? 2 : 0);
WriteLine($"The flag1 is: {flag1}");
#endregion