/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 12/17/2022
 * Time: 8:01 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.COURIER_CAT
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.groupBox1 = new NxtControl.GuiFramework.GroupBox();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.connectionIndicator = new NxtControl.GuiFramework.Ellipse();
			this.groupBox2 = new NxtControl.GuiFramework.GroupBox();
			this.discoveryIndicator = new NxtControl.GuiFramework.Ellipse();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.groupBox3 = new NxtControl.GuiFramework.GroupBox();
			this.mqttIndicator = new NxtControl.GuiFramework.Ellipse();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// groupBox1
			// 
			this.groupBox1.BeginInit();
			this.groupBox1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(184D)), ((float)(48D)));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Radius = 20D;
			this.groupBox1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.connectionIndicator});
			this.groupBox1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(32D, 32D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Checkpoint connection";
			// 
			// connectionIndicator
			// 
			this.connectionIndicator.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(24D)), ((float)(32D)), ((float)(32D)));
			this.connectionIndicator.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.connectionIndicator.Name = "connectionIndicator";
			// 
			// groupBox2
			// 
			this.groupBox2.BeginInit();
			this.groupBox2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(72D)), ((float)(184D)), ((float)(48D)));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Radius = 20D;
			this.groupBox2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.discoveryIndicator});
			this.groupBox2.EndInit();
			// 
			// discoveryIndicator
			// 
			this.discoveryIndicator.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(80D)), ((float)(32D)), ((float)(32D)));
			this.discoveryIndicator.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.discoveryIndicator.Name = "discoveryIndicator";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(32D, 88D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Discovery status";
			// 
			// groupBox3
			// 
			this.groupBox3.BeginInit();
			this.groupBox3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(128D)), ((float)(184D)), ((float)(48D)));
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Radius = 20D;
			this.groupBox3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.mqttIndicator,
			this.freeText3});
			this.groupBox3.EndInit();
			// 
			// mqttIndicator
			// 
			this.mqttIndicator.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(136D)), ((float)(32D)), ((float)(32D)));
			this.mqttIndicator.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mqttIndicator.Name = "mqttIndicator";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(32D, 144D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "MQTT";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(216D)), ((float)(24D)), ((float)(232D)), ((float)(136D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.groupBox1,
			this.groupBox2,
			this.groupBox3,
			this.freeText2,
			this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(496, 208);

		}
		private NxtControl.GuiFramework.GroupBox groupBox1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Ellipse connectionIndicator;
		private NxtControl.GuiFramework.GroupBox groupBox2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Ellipse discoveryIndicator;
		private NxtControl.GuiFramework.GroupBox groupBox3;
		private NxtControl.GuiFramework.Ellipse mqttIndicator;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
