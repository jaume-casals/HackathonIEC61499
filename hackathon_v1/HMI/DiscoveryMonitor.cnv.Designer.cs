/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 4/5/2023
 * Time: 4:18 PM
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
	/// Summary description for DiscoveryMonitor.
	/// </summary>
	partial class DiscoveryMonitor
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Checkpoint1 = new HMI.Main.Symbols.CHECKPOINT_CAT.sDefault();
			this.Checkpoint2 = new HMI.Main.Symbols.CHECKPOINT_CAT.sDefault();
			// 
			// Checkpoint1
			// 
			this.Checkpoint1.BeginInit();
			this.Checkpoint1.AngleIgnore = false;
			this.Checkpoint1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 16D);
			this.Checkpoint1.Name = "Checkpoint1";
			this.Checkpoint1.SecurityToken = ((uint)(4294967295u));
			this.Checkpoint1.TagName = "8A28C6CBFA019969";
			this.Checkpoint1.EndInit();
			// 
			// Checkpoint2
			// 
			this.Checkpoint2.BeginInit();
			this.Checkpoint2.AngleIgnore = false;
			this.Checkpoint2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 72D);
			this.Checkpoint2.Name = "Checkpoint2";
			this.Checkpoint2.SecurityToken = ((uint)(4294967295u));
			this.Checkpoint2.TagName = "4A02EE460E9CDDF1";
			this.Checkpoint2.EndInit();
			// 
			// DiscoveryMonitor
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(800D)), ((float)(480D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "DiscoveryMonitor";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Checkpoint1,
			this.Checkpoint2});
			this.Size = new System.Drawing.Size(800, 480);
			this.Title = "Discovery monitor";

		}
		private HMI.Main.Symbols.CHECKPOINT_CAT.sDefault Checkpoint1;
		private HMI.Main.Symbols.CHECKPOINT_CAT.sDefault Checkpoint2;
		#endregion
	}
}
