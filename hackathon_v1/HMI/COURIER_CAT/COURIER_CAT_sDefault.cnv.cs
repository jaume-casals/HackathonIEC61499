/*
 * Created by EcoStruxure Automation Expert.
 * User: Dmitrii
 * Date: 12/17/2022
 * Time: 8:01 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.COURIER_CAT
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
			this.SD_SUBSCRIBED_Fired += SD_SUBSCRIBED_Fired_EventHandler;
			this.REQ_SERVICE_DETAIL_CNF_Fired += REQ_SERVICE_DETAIL_CNF_Fired_EventHandler;
			this.TIMEOUT_Fired += TIMEOUT_Fired_EventHandler;
			this.REQ_SENT_Fired += REQ_SENT_Fired_EventHandler;
			this.DATA_RECEIVED_Fired += DATA_RECEIVED_Fired_EventHandler;
		}

		void SD_SUBSCRIBED_Fired_EventHandler(object sender, SD_SUBSCRIBEDEventArgs e)
		{
			discoveryIndicator.BrushColor = System.Drawing.Color.Yellow;
		}

		void REQ_SERVICE_DETAIL_CNF_Fired_EventHandler(object sender, REQ_SERVICE_DETAIL_CNFEventArgs e)
		{
			discoveryIndicator.BrushColor = System.Drawing.Color.Green;
		}

		void TIMEOUT_Fired_EventHandler(object sender, TIMEOUTEventArgs e)
		{
			// reset indicators
			discoveryIndicator.BrushColor = System.Drawing.Color.Yellow;
			mqttIndicator.BrushColor = System.Drawing.Color.Yellow;
		}

		void REQ_SENT_Fired_EventHandler(object sender, REQ_SENTEventArgs e)
		{
			mqttIndicator.BrushColor = System.Drawing.Color.Yellow;
		}

		void DATA_RECEIVED_Fired_EventHandler(object sender, DATA_RECEIVEDEventArgs e)
		{
			mqttIndicator.BrushColor = System.Drawing.Color.Green;
		}
	}
}
