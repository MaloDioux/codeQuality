using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public enum TypeRue
{
	Rue = 0,
	Avenue
}
public class addresse
{
	
	public addresse()
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
