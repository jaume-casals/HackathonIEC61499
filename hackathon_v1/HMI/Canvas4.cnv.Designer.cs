/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/16/2023
 * Time: 12:41 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas4.
	/// </summary>
	partial class Canvas4
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault4 = new HMI.Main.Symbols.MOTOR_SWITCH.sDefault();
			this.sDefault2 = new SE.HwCommon.Symbols.DigitalOutput8Channel.sDefault();
			this.sDefault3 = new SE.HwCommon.Symbols.DigitalOutput8Channel.sDefault();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.AngleIgnore = false;
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 792D, 80D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "426FC653CF44BC87.vertical";
			this.sDefault4.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.AngleIgnore = false;
			this.sDefault2.DDO_Channel0No = "$key:lblXX";
			this.sDefault2.DDO_Channel1No = "$key:lblXX";
			this.sDefault2.DDO_Channel2No = "$key:lblXX";
			this.sDefault2.DDO_Channel3No = "$key:lblXX";
			this.sDefault2.DDO_Channel4No = "$key:lblXX";
			this.sDefault2.DDO_Channel5No = "$key:lblXX";
			this.sDefault2.DDO_Channel6No = "$key:lblXX";
			this.sDefault2.DDO_Channel7No = "$key:lblXX";
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 992D, 56D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "18C97C70FD4278A4.ddo8Chn0to7";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.AngleIgnore = false;
			this.sDefault3.DDO_Channel0No = "$key:lblXX";
			this.sDefault3.DDO_Channel1No = "$key:lblXX";
			this.sDefault3.DDO_Channel2No = "$key:lblXX";
			this.sDefault3.DDO_Channel3No = "$key:lblXX";
			this.sDefault3.DDO_Channel4No = "$key:lblXX";
			this.sDefault3.DDO_Channel5No = "$key:lblXX";
			this.sDefault3.DDO_Channel6No = "$key:lblXX";
			this.sDefault3.DDO_Channel7No = "$key:lblXX";
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 992D, 384D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "18C97C70FD4278A4.ddo8Chn8to15";
			this.sDefault3.EndInit();
			// 
			// Canvas4
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1920D)), ((float)(1000D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas4";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault4,
			this.sDefault2,
			this.sDefault3});
			this.Size = new System.Drawing.Size(1920, 1000);

		}
		private HMI.Main.Symbols.MOTOR_SWITCH.sDefault sDefault4;
		private SE.HwCommon.Symbols.DigitalOutput8Channel.sDefault sDefault2;
		private SE.HwCommon.Symbols.DigitalOutput8Channel.sDefault sDefault3;
		#endregion
	}
}
