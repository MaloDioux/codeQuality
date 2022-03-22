using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for offre
/// </summary>
/// 
namespace ConsoleApp1.entities
{
#nullable
	public class offre : baseEntity
	{
		public offre()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public facture enFacture(DateTime aDateEmission, DateTime aDatePaiment, bool aEstPayer)
		{

			facture aRetourner = new facture();
			if (estValider)
			{
				aRetourner.dateEmission = aDateEmission;
				aRetourner.datePaiment = aDatePaiment;
				aRetourner.estPayer = aEstPayer;
				aRetourner.montant = montant;
				aRetourner.offre = this;
			}
			return aRetourner;

		}
		public int montant { get; set; }
		public string nom { get; set; }
		public DateTime dateValidite { get; set; }
		public bool estValider { get; set; }


	}
}