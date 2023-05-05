/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/16/2023
 * Time: 12:47 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.MOTOR_SWITCH
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.upDown = new System.HMI.Symbols.Base.SwitchButton();
			this.motorOn = new System.HMI.Symbols.Base.SwitchButton();
			// 
			// upDown
			// 
			this.upDown.BeginInit();
			this.upDown.AngleIgnore = false;
			this.upDown.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6D, 0D, 0D, 1D, 48.000000000000007D, 24D);
			this.upDown.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.upDown.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.upDown.FalseText = "DOWN";
			this.upDown.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.upDown.Name = "upDown";
			this.upDown.TagName = "upDown";
			this.upDown.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.upDown.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.upDown.TrueText = "UP";
			this.upDown.Value = false;
			this.upDown.EndInit();
			// 
			// motorOn
			// 
			this.motorOn.BeginInit();
			this.motorOn.AngleIgnore = false;
			this.motorOn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6D, 0D, 0D, 1D, 48.000000000000007D, 72D);
			this.motorOn.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.motorOn.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.motorOn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.motorOn.Name = "motorOn";
			this.motorOn.TagName = "motorOn";
			this.motorOn.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.motorOn.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.motorOn.Value = false;
			this.motorOn.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.upDown,
			this.motorOn});
			this.SymbolSize = new System.Drawing.Size(304, 176);

		}
		private System.HMI.Symbols.Base.SwitchButton upDown;
		private System.HMI.Symbols.Base.SwitchButton motorOn;
		#endregion
	}
}
