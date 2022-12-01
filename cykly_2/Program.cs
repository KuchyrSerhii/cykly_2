// See https://aka.ms/new-console-template for more information
int body = 0;
Console.WriteLine("Je Slunce koulí žhavých plynů?");
string spravna_odpoved = "ano";
string odpoved = Console.ReadLine();
if (odpoved.ToLower() == spravna_odpoved.ToLower())
{
    Console.WriteLine("Spavně! Předtím jsi měl {0} bodů", ++body);
}


