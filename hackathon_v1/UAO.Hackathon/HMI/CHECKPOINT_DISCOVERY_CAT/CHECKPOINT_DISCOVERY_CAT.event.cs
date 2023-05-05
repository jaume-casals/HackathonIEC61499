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
#region #CHECKPOINT_DISCOVERY_CAT_HMI;

namespace UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT
{

  public class PUBLISH_CNFEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public PUBLISH_CNFEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_SD_ID(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String SD_ID
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_mqtt_endpoint(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String mqtt_endpoint
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_request_topic(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String request_topic
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_response_topic(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String response_topic
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_SD_INTERFACE_STATUS(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String SD_INTERFACE_STATUS
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

  public class STARTOEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public STARTOEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_SD_ID(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String SD_ID
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_mqtt_endpoint(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String mqtt_endpoint
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_request_topic(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String request_topic
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_response_topic(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String response_topic
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_SD_MANAGER_STATUS(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SD_MANAGER_STATUS
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }

  }

}

namespace UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT
{
  partial class sDefault
  {

    private event EventHandler<UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.PUBLISH_CNFEventArgs> PUBLISH_CNF_Fired;

    private event EventHandler<UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.STARTOEventArgs> STARTO_Fired;

    protected override void OnEndInit()
    {
      if (PUBLISH_CNF_Fired != null)
        AttachEventInput(0);
      if (STARTO_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PUBLISH_CNF_Fired != null)
          {
            try
            {
              PUBLISH_CNF_Fired(this, new UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.PUBLISH_CNFEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PUBLISH_CNF_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (STARTO_Fired != null)
          {
            try
            {
              STARTO_Fired(this, new UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.STARTOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","STARTO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_CNF(UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.CNFEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT
{
  partial class log
  {

    private event EventHandler<UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.PUBLISH_CNFEventArgs> PUBLISH_CNF_Fired;

    private event EventHandler<UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.STARTOEventArgs> STARTO_Fired;

    protected override void OnEndInit()
    {
      if (PUBLISH_CNF_Fired != null)
        AttachEventInput(0);
      if (STARTO_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PUBLISH_CNF_Fired != null)
          {
            try
            {
              PUBLISH_CNF_Fired(this, new UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.PUBLISH_CNFEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PUBLISH_CNF_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (STARTO_Fired != null)
          {
            try
            {
              STARTO_Fired(this, new UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.STARTOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","STARTO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_CNF(UAO.Hackathon.Symbols.CHECKPOINT_DISCOVERY_CAT.CNFEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #CHECKPOINT_DISCOVERY_CAT_HMI;

#endregion Definitions;
