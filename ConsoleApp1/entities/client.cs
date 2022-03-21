using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class client : prospect
{
	public client(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact, List<facture> aFactures) : base(aRaisonSocial, aContacts, aDateDeContact)
	{
		factures = aFactures;
		//
		// TODO: Add constructor logic here
		//
	}
	public bool estRecurant()
    {
		bool estRecurant = false;
		if (factures.Count == 1)
        {
			estRecurant = true;
		}
		return estRecurant;

	}
	public bool estUnBonPayeur()
    {
		bool estUnBonPayeur = true;
		foreach (facture facture in factures)
		{
			if(!facture.estPayer)
            {
				estUnBonPayeur = false;
			}
		}
		return estUnBonPayeur;
	}
	public List<facture> factures { get; set; }
}
