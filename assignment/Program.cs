// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter amount");
double amount = Convert.ToDouble(Console.ReadLine());


if (amount < 0)
{
    Console.WriteLine($"invalid amount : {amount}");

}
else if (amount >= 500)
{
    double discountamount = (amount * 0.2);
    double finalamount = amount - discountamount;

}
else if (amount < 500 && amount >= 300)
{
    double discountamount = amount * 0.2;
    double finalamount = amount - discountamount;
    Console.WriteLine($"the final amount after discount (10%) : {finalamount}");

}
else
{
    Console.WriteLine($"the the final amount : {amount}");
}