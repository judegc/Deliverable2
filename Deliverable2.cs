// See https://aka.ms/new-console-template for more information
// ask the user for a party size. They should enter an integer.
{
    Console.WriteLine("Hello! Welcome to the all-you-can eat buffet, only $9.99 per person! The only additional charge is for soda. " +
    "How many people are in your group? At this time, we can accommadate parties of 6 or lower");
}
double party = int.Parse(Console.ReadLine());
{
}
double cost_of_soda_per_person = 1.00;
double Buffet_cost_per_person = 9.99;
// The maximum party size is 6. If a greater number is entered, display a polite rejection message and end the program.
if (party > 6)
{
    Console.WriteLine("");
    Console.WriteLine("I'm sorry, we can only accept reservations for parties of 6 or fewer, we must reject your reservation at this time. " +
        "We hope you can dine with us soon!");
}
if (party > 6)
{
    Environment.Exit(0);
}
if (party < 1)
{
    Console.WriteLine("");
    Console.WriteLine("I'm sorry, " + party + " is not a valid party size. We hope you can dine with us soon!");
}
if (party < 1)
{
    Environment.Exit(0);
}
// Display a list of drinks and prices. Ask for each party member's drink order. 
if (party <= 6)
{
    Console.WriteLine("");
    Console.WriteLine("We are happy to seat your party of " + party + ". What would each party like to drink? Soda is $1.00 per glass, " +
        "water is free");
    Console.WriteLine("");
}
    string approved_drink_1 = "Soda";
    string approved_drink_2 = "soda";
    string approved_drink_3 = "Water";
    string approved_drink_4 = "water";
    double soda = 0;
    double water = 0;
for (int i = 1; i <= party; i++)
{
    Console.WriteLine("");
    Console.WriteLine("What would party member " + i + " like to drink?");
    string drink_order = Console.ReadLine();
    {
        if (drink_order == approved_drink_1 || drink_order == approved_drink_2)
            {
                Console.WriteLine("");
                Console.WriteLine("Great! Soda it is.");
                soda++;
            }
            if (drink_order == approved_drink_3 || drink_order == approved_drink_4)
            {
                Console.WriteLine("");
                Console.WriteLine("Alright, we'll bring you water.");
                water++;
            }
            while ((drink_order != approved_drink_1) && (drink_order != approved_drink_2) && (drink_order != approved_drink_3) &&
            (drink_order != approved_drink_4))
            {
                Console.WriteLine("");
                Console.WriteLine("I'm sorry, " + drink_order + " is not a valid drink order. No drink will be provided.");
                break;
            }
    }
}
{
    Console.WriteLine("");
    Console.WriteLine("Alright, we have " + soda + " sodas, priced at $" + cost_of_soda_per_person + ".00 each, for a total additional charge of $" +
    (soda * cost_of_soda_per_person) + ".00 and " + water + " waters, for no additional cost. Enjoy your meal!");
    Console.WriteLine("");
    Console.WriteLine("Your total bill is $" + ((soda * cost_of_soda_per_person) + (Buffet_cost_per_person * party)));
}






// Keep track of how many times each drink was ordered
// Present a bill with the accurate total price. The buffet price is $9.99/ person. Drinks are charged separately. Water is free. Coffee is $2.00
// After taking the orders, calculate the total and print out that value to the user.