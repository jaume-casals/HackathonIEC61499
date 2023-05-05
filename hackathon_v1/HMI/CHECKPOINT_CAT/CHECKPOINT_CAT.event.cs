/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 12/17/2022
 * Time: 6:56 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CHECKPOINT_CAT_HMI;

namespace HMI.Main.Symbols.CHECKPOINT_CAT
{

  public class INITIALIZEDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public INITIALIZEDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class PUBLISHEDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public PUBLISHEDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class RESETEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESETEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace HMI.Main.Symbols.CHECKPOINT_CAT
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.CHECKPOINT_CAT.INITIALIZEDEventArgs> INITIALIZED_Fired;

    private event EventHandler<HMI.Main.Symbols.CHECKPOINT_CAT.PUBLISHEDEventArgs> PUBLISHED_Fired;

    private event EventHandler<HMI.Main.Symbols.CHECKPOINT_CAT.RESETEventArgs> RESET_Fired;

    protected override void OnEndInit()
    {
      if (INITIALIZED_Fired != null)
        AttachEventInput(0);
      if (PUBLISHED_Fired != null)
        AttachEventInput(1);
      if (RESET_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (INITIALIZED_Fired != null)
          {
            try
            {
              INITIALIZED_Fired(this, new HMI.Main.Symbols.CHECKPOINT_CAT.INITIALIZEDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","INITIALIZED_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (PUBLISHED_Fired != null)
          {
            try
            {
              PUBLISHED_Fired(this, new HMI.Main.Symbols.CHECKPOINT_CAT.PUBLISHEDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PUBLISHED_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_Fired != null)
          {
            try
            {
              RESET_Fired(this, new HMI.Main.Symbols.CHECKPOINT_CAT.RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #CHECKPOINT_CAT_HMI;

#endregion Definitions;
