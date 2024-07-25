//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i+ " Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");



for (int i = 2; i < 20; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");



for (int i = 1; i < 20; i++)
{
    if(i % 2==0)
    Console.WriteLine(i);
}

Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
int sum = 0;
for (int i = 50; i < 150; i++)
{
    sum = sum + i;
   
}
Console.WriteLine(sum);


Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız");

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamları");
int sumCift = 0;
int sumTek = 0;

// 1 ile 120 arasındaki sayıları tek ve çift olarak ayırıp toplamak
for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        // Çift sayıları toplama
        sumCift += i;
    }
    else
    {
        // Tek sayıları toplama
        sumTek += i;
    }
}

Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + sumCift);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + sumTek);


