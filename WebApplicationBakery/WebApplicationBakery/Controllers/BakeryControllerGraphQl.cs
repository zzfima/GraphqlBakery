using GraphQL;
using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;

namespace WebApplicationBakery.Controllers
{
	public class BakeryControllerGraphQl : GraphController
	{
		List<Donut> donuts;
		List<Cake> cakes;

		public BakeryControllerGraphQl()
		{
			donuts = new DonutsCollection().Donuts;
			cakes = new CakeCollection().Cakes;
		}

		//A Basic Controller
		[QueryRoot("firstDonut")]
		public Donut FirstDonut() => donuts[0];

		[QueryRoot("lastDonut")]
		public Donut LastDonut() => donuts[donuts.Count - 1];

		[QueryRoot("allDonuts")]
		public List<Donut> AllDonuts() => donuts;

		[QueryRoot("allCakes")]
		public List<Cake> AllCakes() => cakes;

		[QueryRoot("DonutByID")]
		public Donut DonutByID(int id) => donuts.Where(x => x.Id == id).FirstOrDefault();

		//Using an Interface
		[QueryRoot(typeof(Cake), typeof(Donut))]
		public ISweet GetSweet(string sweetType)
		{
			switch (sweetType)
			{
				case "Donut":
					return donuts[0];
				case "Cake":
					return cakes[0];
				default: return null;
			}
		}

		[QueryRoot(typeof(ISweet))]
		public ISweet GetSweetEnum(SweetType sweetType)
		{
			switch (sweetType)
			{
				case SweetType.Donut:
					return donuts[0];
				case SweetType.Cake:
					return cakes[0];
				default: return null;
			}
		}
	}
}
