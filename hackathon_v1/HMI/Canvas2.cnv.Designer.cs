/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/14/2023
 * Time: 3:56 AM
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
	/// Summary description for Canvas2.
	/// </summary>
	partial class Canvas2
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.HwCommon.Symbols.DigitalOutput8Channel.sDefault();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.AngleIgnore = false;
			this.sDefault1.DDO_Channel0No = "$key:lblXX";
			this.sDefault1.DDO_Channel1No = "$key:lblXX";
			this.sDefault1.DDO_Channel2No = "$key:lblXX";
			this.sDefault1.DDO_Channel3No = "$key:lblXX";
			this.sDefault1.DDO_Channel4No = "$key:lblXX";
			this.sDefault1.DDO_Channel5No = "$key:lblXX";
			this.sDefault1.DDO_Channel6No = "$key:lblXX";
			this.sDefault1.DDO_Channel7No = "$key:lblXX";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 656D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "EBF5A4304EBADD1B.ddo8Chn0to7";
			this.sDefault1.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1328D)), ((float)(936D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas2";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1});
			this.Size = new System.Drawing.Size(1328, 936);

		}
		private SE.HwCommon.Symbols.DigitalOutput8Channel.sDefault sDefault1;
		#endregion
	}
}
