using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class prospect
{
	public prospect(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact)
	{
		raisonSocial = aRaisonSocial;
		contacts = aContacts;
		dateDeContact = aDateDeContact;
		//
		// TODO: Add constructor logic here
		//
	}
    public string raisonSocial { get; set; }
	public List<personne> contacts  { get; set; }
	public DateTime dateDeContact { get; set; }
	public List<offre> offresProposer { get; set; }
}
