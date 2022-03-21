using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class prospectService
{
	public prospectService()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public bool prospectEnClient(ref prospect aProspect, ref client aClient)
    {
		bool transformationValide = false;
		if((aProspect.dateDeContact - DateTime.Now) <= TimeSpan.FromHours(24) && aProspect.offresProposer.Count != 0)
		{
			foreach(offre offreProposer in aProspect.offresProposer)
            {
				if(offreProposer.estValider)
                {
					transformationValide = true;
				}
            }
			
		}
		return transformationValide;
    }
	public List<client> clients { get; set; }
	public List<prospect> prospects { get; set; }
}
