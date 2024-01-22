using GraphQL.AspNet.Attributes;
using System;

namespace WebApplicationBakery.Controllers
{
	public interface ISweet
	{
		int Id { get; set; }
		string Name { get; set; }
	}

	public enum SweetType { Donut, Cake, }
}