class Property
{
    public string Address { get; set; }
    public decimal Price { get; set; }
   
    protected int NumberOfBedrooms { get; set; }
    public Property(string address, decimal price, int bedrooms)
    {
        Address = address;
        Price = price;
        NumberOfBedrooms = bedrooms;
    }
    public void DisplayPropertyInfo()
    {
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Number of Bedrooms: {NumberOfBedrooms}");
    }
}
class ResidentialProperty : Property
{
    public ResidentialProperty(string address, decimal price, int bedrooms) : base(address, price, bedrooms)
    {
    }
   
    public void ModifyBedroomCount(int newCount)
    {
       
        NumberOfBedrooms = newCount;
    }
}
class Program
{
    static void Main()
    {
        ResidentialProperty house = new ResidentialProperty("123 Main St", 250000.0m, 3);
        house.DisplayPropertyInfo();
        
        house.ModifyBedroomCount(4);
        
        house.DisplayPropertyInfo();
    }
}