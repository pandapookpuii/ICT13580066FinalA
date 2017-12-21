using System;
using SQLite;
namespace ICT13580066FinalA.Models
{
    public class Product
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[NotNull]
		[MaxLength(200)]
		public string Name { get; set; }
		public string Lasname { get; set; }
		public string Address { get; set; }
		public string Dpm { get; set; }

		[NotNull]
		[MaxLength(100)]

		public string Gender { get; set; }
		public string Email { get; set; }
		public string Marry { get; set; }
		public int Age { get; set; }
		public int phone { get; set; }
		public int Baby { get; set; }
		public decimal Salary { get; set; }
    }
}
