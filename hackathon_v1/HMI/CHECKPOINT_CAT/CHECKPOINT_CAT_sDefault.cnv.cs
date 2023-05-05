/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 12/17/2022
 * Time: 6:56 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CHECKPOINT_CAT
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.INITIALIZED_Fired += INITIALIZED_Fired_EventHandler;
			this.PUBLISHED_Fired += PUBLISHED_Fired_EventHandler;
			this.RESET_Fired += RESET_Fired_EventHandler;
		}

		void INITIALIZED_Fired_EventHandler(object sender, INITIALIZEDEventArgs e)
		{
			ellipse1.BrushColor = System.Drawing.Color.Yellow;
		}

		void PUBLISHED_Fired_EventHandler(object sender, PUBLISHEDEventArgs e)
		{
			ellipse1.BrushColor = System.Drawing.Color.ForestGreen;
		}

		void RESET_Fired_EventHandler(object sender, RESETEventArgs e)
		{
			ellipse1.BrushColor = System.Drawing.Color.White;
		}
	}
}
