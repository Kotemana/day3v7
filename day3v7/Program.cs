int[] orders = new int[] { 120, 17, 43, 33, 13 };
//the same:
//int[] orders = new int[5];
//orders[0] = 120;
//orders[4] = 17;
//orders[2] = 43;
//orders[3] = 33;
//orders[4] = 13;

var result = BillSumForeach(orders);
Console.WriteLine(result);
List<int> ordersList = new List<int>() { 120, 17, 43, 33, 13 };
Console.WriteLine(ordersList[0]);
ordersList.Add(3);
List<string> productNames = new List<string>();

productNames.Add("Apple");
productNames.Add("Wine");
productNames.Add("Meat");
productNames.Add("Egg");
productNames.Add("Spread");
foreach (string product in productNames)
{
    Console.WriteLine(product);
}

int BillSum(int[] ordersInBill)
{
    int sum = 0;
    for (int i = 0; i < ordersInBill.Length; i++)
    {
        sum += ordersInBill[i];
    }
    return sum;
}

int BillSumForeach(int[] orders)
{
    int sum = 0;
    foreach (int item in orders)
    {
        sum += item;
    }
    return sum;
}

int MaxPriceInBill(int[] orders)
{
    var maxPrice = 0;
    for (int i = 0; i < orders.Length; i++)
    {
        if (orders[i] > maxPrice)
        {
            maxPrice = orders[i];
        }
    }

    return maxPrice;
}

int MinPriceInBill(int[] orders)
{
    int minPrice = orders[0];
    foreach (int item in orders)
    {
        if (item < minPrice)
        {
            minPrice = item;
        }
    }
    return minPrice;
}

int AveragePrice(int[] orders)
{
    var sum = BillSum(orders);
    return sum / orders.Length;
}