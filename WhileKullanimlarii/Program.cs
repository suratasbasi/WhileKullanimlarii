
// While döngüsünü kullanarak Console ekranına 10 defa ilgili metni yazdırıyorum.
int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}


Console.WriteLine("\n--------------------------------------------------------------------------\n");


// While döngüsüyle 1 ile 20 arasındaki sayıları yazdırıyorum.
Console.WriteLine("1 ile 20 arasındaki sayılar:");
int x = 1;
while (x <= 20)
{
    Console.WriteLine(x);
    x++;
}


Console.WriteLine("\n--------------------------------------------------------------------------\n");


// While döngüsüyle 1 ile 20 arasındaki çift sayıları yazdırıyorum. ( 0'ı dahil etmeden yazdırıyorum.)
Console.WriteLine("1 ile 20 arasındaki çift sayılar:");
int y = 1;
while (y <= 20)
{
    if (y % 2 == 0)

        Console.WriteLine(y);
    y++;
}


Console.WriteLine("\n--------------------------------------------------------------------------\n");


// While döngüsüyle 50 ile 150 arasındaki sayıların toplamını yazdırıyorum.
int toplam = 0;
int z = 50;
while (z <= 150)
{
    toplam = toplam + z;
    z++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);


Console.WriteLine("\n--------------------------------------------------------------------------\n");


// While döngüsüyle 1 ile 120 arasındaki tek ve çift sayıların toplamını ayrı ayrı yazdırıyorum.
int ciftSayiToplam = 0;
int tekSayiToplam = 0;
int m = 1;
while (m <= 120)
{
    if (m % 2 == 0)
    {
        ciftSayiToplam = ciftSayiToplam + m;
    }

    else
    {
        tekSayiToplam = tekSayiToplam + m;
    }
    m++;
}

Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftSayiToplam);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekSayiToplam);