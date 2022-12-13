int number;
List<int> orders = new List<int>();
do
{
    Console.WriteLine("==========MENU==========");
    Console.WriteLine("*****Dishes Menu*****");
    Console.WriteLine("1. Spaghetti $10.99");
    Console.WriteLine("2. Lasagna $12.99");
    Console.WriteLine("3. Pizza $8");
    Console.WriteLine("4. Calzone $6");
    Console.WriteLine("*****Dishes Menu*****");
    Console.WriteLine("+++++Beverages Menu+++++");
    Console.WriteLine("5. Soda $6.5");
    Console.WriteLine("6. Wine $9");
    Console.WriteLine("7. Beer $7.5");
    Console.WriteLine("+++++Beverages Menu+++++");
    Console.WriteLine("==========MENU==========");
    Console.WriteLine("Choose an option: ");
    number = Convert.ToInt32(Console.ReadLine());
    switch (number)
    {
        case 1:
            {
                orders.Add(1);
                clearMenu();
                break;
            }
        case 2:
            {
                orders.Add(2);
                clearMenu();
                break;
            }
        case 3:
            {
                orders.Add(3);
                clearMenu();
                break;
            }
        case 4:
            {
                orders.Add(4);
                clearMenu();
                break;
            }
        case 5:
            {
                orders.Add(5);
                clearMenu();
                break;
            }
        case 6:
            {
                orders.Add(6);
                clearMenu();
                break;
            }
        case 7:
            {
                orders.Add(7);
                clearMenu();
                break;
            }
        default:
            {
                validOption();
                break;
            }
    }
} while (orders.Count <= 4);
priceOfOrder(orders);

static string paymentMethods()
{
    int cashOrCard;
    Console.WriteLine("$$$$$Payment Methods$$$$$");
    Console.WriteLine("8. Cash");
    Console.WriteLine("9. Card");
    Console.WriteLine("$$$$$Payment Methods$$$$$");
    Console.WriteLine("Choose an option: ");
    cashOrCard = Convert.ToInt32(Console.ReadLine());
    if ((cashOrCard == 8) || (cashOrCard == 9))
    {
        if (cashOrCard == 8) return "Cash";
        else return "Card";
    }
    else
    {
        validOption();
        return paymentMethods();
    }
}
static void clearMenu()
{
    Console.Clear();
    Console.WriteLine("Registered order \n\n\n");
}
static void validOption()
{
    Console.Clear();
    Console.WriteLine("Please select a valid option \n\n\n");
}
static void priceOfOrder(List<int> dishesBeveragesOrder)
{
    double totalPrice = 0;
    double[] dishesAndBeveragesPrices = { 10.99, 12.99, 8, 6, 6.5, 9, 7.5 };
    string customerName, paymentMethod;
    Console.Clear();
    Console.WriteLine("Please write your name:");
    customerName = Console.ReadLine();
    foreach (var item in dishesBeveragesOrder)
    {
        switch (item)
        {
            case 1: totalPrice += dishesAndBeveragesPrices[0]; break;
            case 2: totalPrice += dishesAndBeveragesPrices[1]; break;
            case 3: totalPrice += dishesAndBeveragesPrices[2]; break;
            case 4: totalPrice += dishesAndBeveragesPrices[3]; break;
            case 5: totalPrice += dishesAndBeveragesPrices[4]; break;
            case 6: totalPrice += dishesAndBeveragesPrices[5]; break;
            case 7: totalPrice += dishesAndBeveragesPrices[6]; break;
        }
    }
    Console.Clear();
    paymentMethod = paymentMethods();
    Console.Clear();
    Console.WriteLine("==========Showing The Bill==========");
    Console.WriteLine($"Client: {customerName}, total cost: ${double.Round(totalPrice, 2)} / payment method: {paymentMethod}");
    Console.WriteLine("==========Showing The Bill==========");
}