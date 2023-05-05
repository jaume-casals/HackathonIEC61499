/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 1/24/2023
 * Time: 4:53 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace UAO.Hackathon.Faceplates.CHECKPOINT_DISCOVERY_CAT
{
	/// <summary>
	/// Summary description for log.
	/// </summary>
	partial class log
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.drawnTextBox1 = new NxtControl.GuiFramework.DrawnTextBox();
			// 
			// drawnTextBox1
			// 
			this.drawnTextBox1.AngleIgnore = true;
			this.drawnTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.drawnTextBox1.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(16D)), ((float)(184D)), ((float)(25D)));
			this.drawnTextBox1.Font = new NxtControl.Drawing.Font("TextBoxFont");
			this.drawnTextBox1.FontScale = true;
			this.drawnTextBox1.Maximum = 100D;
			this.drawnTextBox1.Minimum = 0D;
			this.drawnTextBox1.Name = "drawnTextBox1";
			this.drawnTextBox1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.drawnTextBox1.TextAutoSizeHorizontalOffset = 10;
			this.drawnTextBox1.TextAutoSizeVerticalOffset = 2;
			this.drawnTextBox1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// log
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Name = "log";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.drawnTextBox1});
			this.Size = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.DrawnTextBox drawnTextBox1;
		#endregion
	}
}
