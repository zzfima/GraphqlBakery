namespace WebApplicationBakery.Controllers
{
	public class Donut : ISweet
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Flavor { get; set; }
	}

	public class DonutsCollection
	{
		public DonutsCollection()
		{
			Donuts = new List<Donut>(){
				new Donut() { Id = 3, Name = "Snowy Dream", Flavor = "Vanilla" },
				new Donut() { Id = 4, Name = "Green Dream", Flavor = "Apple" },
				new Donut() { Id = 5, Name = "Black Dream", Flavor = "Chocolate" } };
		}

		public List<Donut> Donuts { get; }
	}
}
