using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for prospect
/// </summary>
public class prospect : partenaires
{
	public static int count { get; set; }
	public prospect()
    {
		count++;
	}
	public prospect(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact, adresse aAdresse)
	{
		count++;
		raisonSocial = aRaisonSocial;
		contacts = aContacts;
		dateDeContact = aDateDeContact;
		adresse = aAdresse;
	}
	public prospect(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact, adresse aAdresse, List<offre> aOffresProposer) : this(aRaisonSocial, aContacts, aDateDeContact, aAdresse)
	{
		count++;
		offresProposer = aOffresProposer;
	}
	public List<offre> offresProposer { get; set; }

    public override bool initialise(prospect aProspect, offre offreCourante, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
    {
        throw new NotImplementedException();
    }
}
