
using ShopTask;

try
{
    Storage storage = new Storage();
    storage.ProductFromFile(@"list.txt");
    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}