namespace LinkedList_CafeManagement
{
	public class Drink
	{
		public string Name { get; set; }

		public double Price { get; set; }

		public Drink() { }
		public Drink(string Name, double Price)
		{
			this.Name = Name;
			this.Price = Price;
		}

		public override string ToString()
		{
			return $"{this.Name,20}\t{this.Price}VND";
		}
	}
}