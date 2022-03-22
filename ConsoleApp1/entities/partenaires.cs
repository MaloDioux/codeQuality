using System;
using System.Collections.Generic;

public abstract class partenaires : baseEntity
{
	public partenaires()
	{
	}
	public partenaires(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact, adresse aAdresse)
	{
		raisonSocial = aRaisonSocial;
		contacts = aContacts;
		dateDeContact = aDateDeContact;
		adresse = aAdresse;
	}
	public abstract bool initialise(prospect aProspect, offre offreCourante, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer);
	public bool init(string aRaisonSocial, List<personne> aContacts, DateTime aDateDeContact, adresse aAdresse)
	{
		bool aRetourner = true;
		raisonSocial = aRaisonSocial;
		contacts = aContacts;
		dateDeContact = aDateDeContact;
		adresse = aAdresse;
		return aRetourner;
	}
	public string raisonSocial { get; set; }
	public List<personne> contacts { get; set; }
	public DateTime dateDeContact { get; set; }
	public adresse adresse { get; set; }
}
