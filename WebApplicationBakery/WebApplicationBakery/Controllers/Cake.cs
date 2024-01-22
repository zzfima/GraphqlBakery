namespace WebApplicationBakery.Controllers
{
	public class Cake: ISweet
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Fill { get; set; }
	}

	public class CakeCollection
	{
		public CakeCollection()
		{
			Cakes = new List<Cake>(){
				new Cake() { Id = 5, Name = "Napoleon", Fill = "Cream" },
				new Cake() { Id = 6, Name = "Zebra", Fill = "Nougat" },};
		}

		public List<Cake> Cakes { get; }
	}
}
