
using ShopTask;
Product candy= new Product("romashka", 139, 1);
Meat chicken = new Meat("chicken breast", 100, 1, Meat.Category.TopGrade, Meat.Species.Chicken);
Buy buy = new Buy(candy);
candy.percentСhange(100);
buy.AddProduct(chicken);
chicken.percentСhange(100);
Check.PrintInfo(buy);
Storage storage = new Storage(chicken);
storage.fillingByDialog();
storage.changePriceOfAllProducts(100);
storage.FindMeat();
storage.PrintInfo();




