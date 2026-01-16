using System;

Random rng = new Random();

int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;

for (int i = 0; i < 100; i++) // We rollen voor 100 keer.
{
    int roll = rng.Next(1, 7); // Het word binnen 6 rollen gegenereerd.

    if (roll == 1) count1++;
    else if (roll == 2) count2++;
    else if (roll == 3) count3++;
    else if (roll == 4) count4++;
    else if (roll == 5) count5++;
    else if (roll == 6) count6++;
}

Console.WriteLine("Results after 100 rolls:");
Console.WriteLine("1: " + count1);
Console.WriteLine("2: " + count2);
Console.WriteLine("3: " + count3);
Console.WriteLine("4: " + count4);
Console.WriteLine("5: " + count5);
Console.WriteLine("6: " + count6);

