/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 4/12/2023
 * Time: 4:41 PM
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
	/// Summary description for Courier.
	/// </summary>
	partial class Courier
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Courier_1 = new HMI.Main.Symbols.COURIER_CAT.sDefault();
			// 
			// Courier_1
			// 
			this.Courier_1.BeginInit();
			this.Courier_1.AngleIgnore = false;
			this.Courier_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 24D);
			this.Courier_1.Name = "Courier_1";
			this.Courier_1.SecurityToken = ((uint)(4294967295u));
			this.Courier_1.TagName = "36F4160B51F5E197";
			this.Courier_1.EndInit();
			// 
			// Courier
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(800D)), ((float)(480D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Courier";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Courier_1});
			this.Size = new System.Drawing.Size(800, 480);

		}
		private HMI.Main.Symbols.COURIER_CAT.sDefault Courier_1;
		#endregion
	}
}
