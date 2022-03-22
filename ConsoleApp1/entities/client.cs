using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for client
/// </summary>
public class client : partenaires
{
	public static int count { get; set; }
	public client()
	{
		
	}
	public client(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact, List<facture> aFactures, adresse aAdresse) : base(aRaisonSocial, aContacts, aDateDeContact, aAdresse)
	{
		count++;
		factures = aFactures;
		//
		// TODO: Add constructor logic here
		//
	}
	public override bool initialise(prospect aProspect, offre offreCourante, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
    {
		bool aRetourner = false;
		if ((aProspect.dateDeContact - DateTime.Now) <= TimeSpan.FromHours(24) && aProspect.offresProposer.Count != 0)
        {
			base.init(aProspect.raisonSocial, aProspect.contacts, aProspect.dateDeContact, aProspect.adresse);
			count++;
			offre offreTrouve = aProspect.offresProposer.Single(Offre => Offre.id == offreCourante.id);
			factures.Add(offreTrouve.enFacture(aDateEmission, aDatePaiment, aEstPayer));
			aRetourner = true;
		}
		return aRetourner;


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
