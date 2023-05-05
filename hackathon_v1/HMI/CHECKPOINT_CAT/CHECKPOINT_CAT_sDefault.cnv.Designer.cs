/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 12/17/2022
 * Time: 6:56 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CHECKPOINT_CAT
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
			this.groupBox1 = new NxtControl.GuiFramework.GroupBox();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			// 
			// groupBox1
			// 
			this.groupBox1.BeginInit();
			this.groupBox1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(24D)), ((float)(192D)), ((float)(48D)));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("log", NxtControl.GuiFramework.MouseButtonType.DoubleClick));
			this.groupBox1.Radius = 20D;
			this.groupBox1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.ellipse1});
			this.groupBox1.EndInit();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(32D)), ((float)(32D)), ((float)(32D)));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(24D, 40D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Service discovery status";
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.groupBox1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.GroupBox groupBox1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		#endregion
	}
}
