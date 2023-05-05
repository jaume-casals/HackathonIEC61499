/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/24/2023
 * Time: 4:31 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region CHECKPOINT_DISCOVERY_CAT_HMI;

namespace UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT
{
  partial class sDefault
  {

    private UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT.log log
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT.log faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT.log)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT.log));
        
        if (faceplate == null)
        {
          faceplate = new UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT.log();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    protected override void DoOpenFaceplate(OpenFaceplate openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if ("log" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = log;

      if (hmiFaceplate != null)
      {
        if (hmiFaceplate.Initialized == true)
          hmiFaceplate.Activate();
        else
        {
          OnInitializeFaceplate(hmiFaceplate);
          hmiFaceplate.Show(this);
        }
      }
    }

    public override void DoOpenFaceplate(string openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if ("log" == openFaceplate)
        hmiFaceplate = log;

      if (hmiFaceplate != null)
      {
        if (hmiFaceplate.Initialized == true)
          hmiFaceplate.Activate();
        else
        {
          OnInitializeFaceplate(hmiFaceplate);
          hmiFaceplate.Show(this);
        }
      }
    }

  }
}
#endregion CHECKPOINT_DISCOVERY_CAT_HMI;

#endregion Definitions;
