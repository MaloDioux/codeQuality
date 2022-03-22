using System;

/// <summary>
/// Summary description for adresse
/// </summary>
/// 
namespace ConsoleApp1.types
{
	public enum TypeRue
	{
		Rue = 0,
		Avenue
	}
	public class adresse
	{

		public adresse()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public string numero { get; set; }
		public string nomRue { get; set; }
		public TypeRue typeRue { get; set; }
		public string ville { get; set; }
	}
}

