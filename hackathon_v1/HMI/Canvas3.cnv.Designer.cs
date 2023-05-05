/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/16/2023
 * Time: 12:39 AM
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
	/// Summary description for Canvas3.
	/// </summary>
	partial class Canvas3
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.IoTMx.Symbols.TM251MDESE.sDefault();
			this.sDefault2 = new SE.IoTMx.Symbols.TM3XHSC202_G.sDefault();
			this.sDefault3 = new SE.IoTMx.Symbols.TM3DI16_G.sDefault();
			this.sDefault4 = new SE.IoTMx.Symbols.TM3DI16_G.sDefault();
			this.sDefault5 = new SE.IoTMx.Symbols.TM3AM6_G.sDefault();
			this.sDefault6 = new SE.IoTMx.Symbols.TM3DQ16T_G.sDefault();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.AngleIgnore = false;
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 16D);
			this.sDefault1.HeaderText = "";
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "129E7231A8408D9";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.AngleIgnore = false;
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 16D);
			this.sDefault2.HeaderText = "";
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "A05466BE5DB2613E";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.AngleIgnore = false;
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 392D, 16D);
			this.sDefault3.HeaderText = "";
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "B32927E9C1EA8422";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.AngleIgnore = false;
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 488D, 16D);
			this.sDefault4.HeaderText = "";
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "B9FA2A8C580FF5B9";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.AngleIgnore = false;
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 584D, 16D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "DF30F1DD1E6811D7";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.AngleIgnore = false;
			this.sDefault6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 680D, 16D);
			this.sDefault6.HeaderText = "";
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "18C97C70FD4278A4";
			this.sDefault6.EndInit();
			// 
			// Canvas3
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1920D)), ((float)(1000D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas3";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.sDefault2,
			this.sDefault3,
			this.sDefault4,
			this.sDefault5,
			this.sDefault6});
			this.Size = new System.Drawing.Size(1920, 1000);

		}
		private SE.IoTMx.Symbols.TM3XHSC202_G.sDefault sDefault2;
		private SE.IoTMx.Symbols.TM251MDESE.sDefault sDefault1;
		private SE.IoTMx.Symbols.TM3DI16_G.sDefault sDefault3;
		private SE.IoTMx.Symbols.TM3DI16_G.sDefault sDefault4;
		private SE.IoTMx.Symbols.TM3AM6_G.sDefault sDefault5;
		private SE.IoTMx.Symbols.TM3DQ16T_G.sDefault sDefault6;
		#endregion
	}
}
