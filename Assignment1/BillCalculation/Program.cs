// Ask user to supply electricity units consumed on his/her meter and calculate total amount based on following slabs:
//  1 to 20 units = Rs 100
//  21 to 25 units = Rs 5 per unit
//  25 to 50 units = Rs 10 per unit
//  Above 50 units Rs 2000 flat 
// Note: Implement using both conditionals (if/else) and switch cases to solve


Console.WriteLine("Enter the meter reading:");
int unit = Convert.ToInt32(Console.ReadLine());

//using If-else
if (unit>=1 && unit<= 20)
{
    Console.WriteLine("Your total amount is Rs:100");
}
else if (unit<=25)
{
        Console.WriteLine($"Your total amount is Rs: {100 + (unit- 20)*5}");
}
else if (unit<=50)
{
        Console.WriteLine($"Your total amount is Rs: {125+ (unit-25)*10}");
}
else
{
        Console.WriteLine("Your total amount is Rs:2000");

}


