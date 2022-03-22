using System;
namespace ConsoleApp1.entities
{
	public abstract class baseEntity
	{
		protected baseEntity()
		{
		}
		public Guid id { get; set; }
	}
}