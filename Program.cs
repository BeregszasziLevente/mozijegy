Console.Write("Add meg a neved: ");
string nev = Console.ReadLine();

Console.Write("Add meg a korod: ");
int kor = int.Parse(Console.ReadLine());

Console.Write("Van diákigazolványod? (igen/nem): ");
string diakIgazolvany = Console.ReadLine();
bool vanDiak = false;
if (diakIgazolvany=="igen")
{
    vanDiak=true;
} else if (diakIgazolvany=="nem")
{
    vanDiak = false;
}

Console.Write("A mozijegy ára: ");
int jegyar=int.Parse(Console.ReadLine());

Console.Write("Vásárolt popcorn darabszáma: ");
int popcorn=int.Parse(Console.ReadLine());

Console.Write("A popcorn egységára: ");
int popcornAr=int.Parse(Console.ReadLine());

double vegeredmeny = 0;

string status = "Nem vagy jogosult kedvezményre!";

double alaposszeg= (popcorn * popcornAr) + jegyar;

if (vanDiak==true || kor<18)
{
    vegeredmeny = alaposszeg*((100-(0.2*100))/100);
    status = "Jogosult vagy 20% kedvezményre!";
    
} else
{
    vegeredmeny = alaposszeg;

}

Console.WriteLine($"Vasárló neve: {nev} ({kor} éves)");
Console.WriteLine($"Rendelés: 1 db Mozijegy + {popcorn} db Popcorn");
Console.WriteLine($"Alapösszeg: {alaposszeg:F0} Ft");
Console.WriteLine($"Fizetendő végösszeg: {vegeredmeny:F0} Ft");
Console.WriteLine($"Státusz: {status}");

