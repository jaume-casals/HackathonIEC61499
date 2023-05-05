/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 12/17/2022
 * Time: 8:01 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #COURIER_CAT_HMI;

namespace HMI.Main.Symbols.COURIER_CAT
{

  public class SD_SUBSCRIBEDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public SD_SUBSCRIBEDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class REQ_SERVICE_DETAIL_CNFEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_SERVICE_DETAIL_CNFEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_SERVICE_DETAIL_TXT(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String SERVICE_DETAIL_TXT
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

  public class TIMEOUTEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public TIMEOUTEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class REQ_SENTEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_SENTEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class DATA_RECEIVEDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public DATA_RECEIVEDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_RecPayload1(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String RecPayload1
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

}

namespace HMI.Main.Symbols.COURIER_CAT
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.COURIER_CAT.SD_SUBSCRIBEDEventArgs> SD_SUBSCRIBED_Fired;

    private event EventHandler<HMI.Main.Symbols.COURIER_CAT.REQ_SERVICE_DETAIL_CNFEventArgs> REQ_SERVICE_DETAIL_CNF_Fired;

    private event EventHandler<HMI.Main.Symbols.COURIER_CAT.TIMEOUTEventArgs> TIMEOUT_Fired;

    private event EventHandler<HMI.Main.Symbols.COURIER_CAT.REQ_SENTEventArgs> REQ_SENT_Fired;

    private event EventHandler<HMI.Main.Symbols.COURIER_CAT.DATA_RECEIVEDEventArgs> DATA_RECEIVED_Fired;

    protected override void OnEndInit()
    {
      if (SD_SUBSCRIBED_Fired != null)
        AttachEventInput(0);
      if (REQ_SERVICE_DETAIL_CNF_Fired != null)
        AttachEventInput(1);
      if (TIMEOUT_Fired != null)
        AttachEventInput(2);
      if (REQ_SENT_Fired != null)
        AttachEventInput(3);
      if (DATA_RECEIVED_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (SD_SUBSCRIBED_Fired != null)
          {
            try
            {
              SD_SUBSCRIBED_Fired(this, new HMI.Main.Symbols.COURIER_CAT.SD_SUBSCRIBEDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SD_SUBSCRIBED_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_SERVICE_DETAIL_CNF_Fired != null)
          {
            try
            {
              REQ_SERVICE_DETAIL_CNF_Fired(this, new HMI.Main.Symbols.COURIER_CAT.REQ_SERVICE_DETAIL_CNFEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_SERVICE_DETAIL_CNF_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (TIMEOUT_Fired != null)
          {
            try
            {
              TIMEOUT_Fired(this, new HMI.Main.Symbols.COURIER_CAT.TIMEOUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","TIMEOUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REQ_SENT_Fired != null)
          {
            try
            {
              REQ_SENT_Fired(this, new HMI.Main.Symbols.COURIER_CAT.REQ_SENTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_SENT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (DATA_RECEIVED_Fired != null)
          {
            try
            {
              DATA_RECEIVED_Fired(this, new HMI.Main.Symbols.COURIER_CAT.DATA_RECEIVEDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","DATA_RECEIVED_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #COURIER_CAT_HMI;

#endregion Definitions;
