using System;
using System.Windows.Forms;
using WebCamLib;

namespace CS345___Image_Processing
{
	public class WebcamIntegrations
	{
		private Device[] webcamDevices;
		private Device currentWebcamDevice;
		private bool isWebcamMode = false;
		private PictureBox displayTarget;
		private ToolStripMenuItem menuItem;

		public WebcamIntegrations(PictureBox displayTarget, ToolStripMenuItem menuItem)
		{
			this.displayTarget = displayTarget;
			this.menuItem = menuItem;
		}

		public bool IsWebcamMode => isWebcamMode;

		public void ToggleWebcam()
		{
			if (isWebcamMode)
			{
				StopWebcam();
			}
			else
			{
				InitializeWebcam();
			}
		}

		public void InitializeWebcam()
		{
			try
			{
				webcamDevices = DeviceManager.GetAllDevices();

				if (webcamDevices.Length == 0)
				{
					MessageBox.Show("No webcam device detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				currentWebcamDevice = webcamDevices[0];
				currentWebcamDevice.ShowWindow(displayTarget);

				isWebcamMode = true;
				menuItem.Text = "Stop Webcam";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error initializing webcam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void StopWebcam()
		{
			if (currentWebcamDevice != null)
			{
				currentWebcamDevice.Stop();
				currentWebcamDevice = null;
			}

			isWebcamMode = false;
			menuItem.Text = "Use Webcam";
		}

		public void CleanupResources()
		{
			if (isWebcamMode)
			{
				StopWebcam();
			}
		}
	}
}