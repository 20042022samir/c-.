

using homeworkk2.homeworkk;
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("Enter the employe limit");
int limitt=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the salary limit");
int limittsal=int.Parse(Console.ReadLine());
department departmenr = new department(limitt,limittsal);
Console.WriteLine("1: add employee");
Console.WriteLine("2: show employee");

try
{
    int select = Convert.ToInt32(Console.ReadLine());
    switch (select)
    {
        case 1:
            departmenr.AddEmploye();
            break;
        case 2:
		     departmenr.ShowEmploye();
            break;
        default:
            Console.WriteLine("there are only two choices");
            break;
    }
}
catch (Exception)
{
    Console.WriteLine("enter something accepted");
}
