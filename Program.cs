int alcool = 0;
int gasolina = 0;
int diesel = 0;

int n = int.Parse(Console.ReadLine());

while (n != 4)
{
    if (n == 1)
    {
        alcool = alcool + 1;
    }
    else if (n == 2)
    {
        gasolina = gasolina + 1;
    }
    else if (n == 3)
    {
        diesel = diesel + 1;
    }
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " +alcool);
Console.WriteLine("Gasolina: " +gasolina);
Console.WriteLine("Diesel: " +diesel);

