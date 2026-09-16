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

double kedvezmeny = 0.0;

