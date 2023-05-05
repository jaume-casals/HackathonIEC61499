/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/16/2023
 * Time: 12:47 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MOTOR_SWITCH_HMI;

namespace HMI.Main.Symbols.MOTOR_SWITCH
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? upDown_field = null;
    public System.Boolean? upDown
    {
       get { return upDown_field; }
       set { upDown_field = value; }
    }
    private System.Boolean? motorOn_field = null;
    public System.Boolean? motorOn
    {
       get { return motorOn_field; }
       set { motorOn_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.MOTOR_SWITCH
{
  partial class sDefault
  {
    public bool FireEvent_CNF(System.Boolean upDown, System.Boolean motorOn)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {upDown, motorOn});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.MOTOR_SWITCH.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.upDown.HasValue) _values_[0] = ea.upDown.Value;
      if (ea.motorOn.HasValue) _values_[1] = ea.motorOn.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean upDown, bool ignore_upDown, System.Boolean motorOn, bool ignore_motorOn)
    {
      object[] _values_ = new object[2];
      if (!ignore_upDown) _values_[0] = upDown;
      if (!ignore_motorOn) _values_[1] = motorOn;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #MOTOR_SWITCH_HMI;

#endregion Definitions;
