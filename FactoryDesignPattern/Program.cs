using FactoryDesignPattern;

Console.WriteLine("Let's make some bread!");
List<IBread> breadList = new List<IBread>();
var cakeFactory = new CakeFactory();
var toastFactory = new ToastFactory();
var bread = toastFactory.CreateBread("Peanut butter toast");
var bread1 = toastFactory.CreateBread("Chocolate toast");
var bread2 = cakeFactory.CreateBread("Cheesecake");
var bread3 = cakeFactory.CreateBread("Strawberry cake");
breadList.AddRange(new IBread[] { bread, bread1, bread2, bread3 });

foreach (var item in breadList)
{
    switch (item)
    {
        case Toast x:
            Console.WriteLine(x.GetBreadName());
            break;
        case Cake x:
            Console.WriteLine(x.GetBreadName());
            Console.WriteLine(x.GetShape());
            break;
        default:
            throw new ArgumentException("Wrong bread type");
    }
}