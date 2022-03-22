using System;

/// <summary>
/// Summary description for contrat
/// </summary>
/// 
namespace ConsoleApp1.entities
{
	public class contrat : baseEntity
	{
		public contrat(partenaires aPartenaire, offre aOffre, DateTime aDateSignature, DateTime aEcheancePaiment, DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
		{
			montant = aOffre.montant;
			if (aPartenaire is prospect)
			{
				partenaire = new client();
				partenaire.initialise((prospect)aPartenaire, aOffre, aDateEmission, aDatePaiment, aEstPayer);
			}
			else
			{
				partenaire = aPartenaire;
			}
			offre = aOffre;
			dateSignature = aDateSignature;
			echeancePaiment = aEcheancePaiment;
		}
		public partenaires partenaire { get; set; }

		public offre offre { get; set; }

		public int montant { get; set; }
		public DateTime dateSignature { get; set; }

		public DateTime echeancePaiment { get; set; }
	}
}