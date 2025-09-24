using System;
using System.Drawing;
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
			MessageBox.Show("Buggy ang webcam if using internal webcam. Try using external webcam or use ManyCam", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

		public void CaptureFrame()
		{
			if (currentWebcamDevice == null || !isWebcamMode)
				return;

			try
			{
				currentWebcamDevice.Sendmessage();

				if (Clipboard.ContainsImage())
				{
					Image capturedImage = Clipboard.GetImage();

					if (capturedImage != null)
					{
						if (displayTarget.Image != null)
						{
							Image oldImage = displayTarget.Image;
							displayTarget.Image = null;
							oldImage.Dispose();
						}

						displayTarget.Image = capturedImage;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error capturing frame: " + ex.Message);
			}
		}

	}
}