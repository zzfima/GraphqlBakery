using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;

namespace WebApplicationBakery.Controllers
{
	public class BakeryControllerGraphQl : GraphController
	{
		List<Donut> _donuts;
		List<Cake> _cakes;

		public BakeryControllerGraphQl()
		{
			_donuts = new DonutsCollection().Donuts;
			_cakes = new CakeCollection().Cakes;
		}

		//A Basic Controller
		[QueryRoot("firstDonut")]
		public Donut firstDonut() => _donuts[0];

		[QueryRoot("lastDonut")]
		public Donut lastDonut() => _donuts[_donuts.Count - 1];

		[QueryRoot("donuts")]
		public List<Donut> donuts() => _donuts;

		[QueryRoot("cakes")]
		public List<Cake> cakes() => _cakes;

		[QueryRoot("donutByID")]
		public Donut donutByID(int id) => _donuts.Where(x => x.Id == id).FirstOrDefault();

		//Using an Interface
		[QueryRoot(typeof(Cake), typeof(Donut))]
		public ISweet? getSweet(string sweetType)
		{
			switch (sweetType)
			{
				case "Donut":
					return _donuts[0];
				case "Cake":
					return _cakes[0];
				default: return null;
			}
		}

		[QueryRoot(typeof(ISweet))]
		public ISweet? getSweetEnum(SweetType sweetType)
		{
			switch (sweetType)
			{
				case SweetType.Donut:
					return _donuts[0];
				case SweetType.Cake:
					return _cakes[0];
				default: return null;
			}
		}
	}
}
