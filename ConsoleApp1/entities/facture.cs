using System;

/// <summary>
/// Summary description for facture
/// </summary>
public class facture : baseEntity
{
	public facture()
	{
	}
	public facture(int aMontant, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer, offre aOffre)
	{
		montant = aMontant;
		dateEmission = aDateEmission;
		datePaiment = aDatePaiment;
		estPayer = aEstPayer;
		offre = aOffre;
	}
	public facture(int aMontant, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
	{
		montant = aMontant;
		dateEmission = aDateEmission;
		datePaiment = aDatePaiment;
		estPayer = aEstPayer;
		offre = null;
	}
	public facture(DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer, offre aOffre)
	{
		montant = aOffre.montant;
		dateEmission = aDateEmission;
		datePaiment = aDatePaiment;
		estPayer = aEstPayer;
		offre = aOffre;
	}
	public int montant { get; set; }
    public DateTime dateEmission { get; set; }
	public DateTime datePaiment { get; set; }

	public bool estPayer { get; set; }

	public offre? offre { get; set; }
}
