using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace MouseManager.UserControls
{
	// Token: 0x02000012 RID: 18
	public class Profile1 : UserControl
	{
		// Token: 0x0600008B RID: 139 RVA: 0x001A85CE File Offset: 0x001A0FCE
		public Profile1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void Profile1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x001A85E2 File Offset: 0x001A0FE2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x001B0484 File Offset: 0x001A8E84
		private void InitializeComponent()
		{
			this.siticoneButton4 = new SiticoneButton();
			this.siticoneHtmlLabel14 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel12 = new SiticoneHtmlLabel();
			this.Value1 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel9 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel8 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel7 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel5 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel6 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel10 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel11 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel13 = new SiticoneHtmlLabel();
			this.siticoneHtmlLabel15 = new SiticoneHtmlLabel();
			base.SuspendLayout();
			this.siticoneButton4.Animated = true;
			this.siticoneButton4.AutoRoundedCorners = true;
			this.siticoneButton4.BorderColor = Color.Lime;
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
			this.siticoneButton4.Location = new Point(142, 430);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new Size(247, 35);
			this.siticoneButton4.TabIndex = 37;
			this.siticoneButton4.Text = "Start Spoof";
			this.siticoneButton4.Click += this.siticoneButton4_Click;
			this.siticoneHtmlLabel14.BackColor = Color.Transparent;
			this.siticoneHtmlLabel14.Enabled = false;
			this.siticoneHtmlLabel14.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel14.ForeColor = Color.White;
			this.siticoneHtmlLabel14.Location = new Point(25, 260);
			this.siticoneHtmlLabel14.Name = "siticoneHtmlLabel14";
			this.siticoneHtmlLabel14.Size = new Size(103, 21);
			this.siticoneHtmlLabel14.TabIndex = 34;
			this.siticoneHtmlLabel14.Text = "Windows Reinstall:";
			this.siticoneHtmlLabel12.BackColor = Color.Transparent;
			this.siticoneHtmlLabel12.Enabled = false;
			this.siticoneHtmlLabel12.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel12.ForeColor = Color.White;
			this.siticoneHtmlLabel12.Location = new Point(25, 314);
			this.siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
			this.siticoneHtmlLabel12.Size = new Size(114, 21);
			this.siticoneHtmlLabel12.TabIndex = 31;
			this.siticoneHtmlLabel12.Text = "Supported Hardware:";
			this.Value1.BackColor = Color.Transparent;
			this.Value1.Enabled = false;
			this.Value1.Font = new Font("Bahnschrift Condensed", 18f);
			this.Value1.ForeColor = Color.White;
			this.Value1.Location = new Point(99, 223);
			this.Value1.Name = "Value1";
			this.Value1.Size = new Size(312, 31);
			this.Value1.TabIndex = 30;
			this.Value1.Text = "Valorant Spoofer System configuration";
			this.siticoneHtmlLabel9.BackColor = Color.Transparent;
			this.siticoneHtmlLabel9.Enabled = false;
			this.siticoneHtmlLabel9.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel9.ForeColor = Color.White;
			this.siticoneHtmlLabel9.Location = new Point(25, 368);
			this.siticoneHtmlLabel9.Name = "siticoneHtmlLabel9";
			this.siticoneHtmlLabel9.Size = new Size(83, 21);
			this.siticoneHtmlLabel9.TabIndex = 28;
			this.siticoneHtmlLabel9.Text = "Supported CPU:";
			this.siticoneHtmlLabel8.BackColor = Color.Transparent;
			this.siticoneHtmlLabel8.Enabled = false;
			this.siticoneHtmlLabel8.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel8.ForeColor = Color.White;
			this.siticoneHtmlLabel8.Location = new Point(25, 287);
			this.siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
			this.siticoneHtmlLabel8.Size = new Size(64, 21);
			this.siticoneHtmlLabel8.TabIndex = 24;
			this.siticoneHtmlLabel8.Text = "Works with:";
			this.siticoneHtmlLabel7.BackColor = Color.Transparent;
			this.siticoneHtmlLabel7.Enabled = false;
			this.siticoneHtmlLabel7.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel7.ForeColor = Color.White;
			this.siticoneHtmlLabel7.Location = new Point(25, 341);
			this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
			this.siticoneHtmlLabel7.Size = new Size(76, 21);
			this.siticoneHtmlLabel7.TabIndex = 23;
			this.siticoneHtmlLabel7.Text = "Supported OS:";
			this.siticoneHtmlLabel5.BackColor = Color.Transparent;
			this.siticoneHtmlLabel5.Enabled = false;
			this.siticoneHtmlLabel5.Font = new Font("Bahnschrift Condensed", 15f);
			this.siticoneHtmlLabel5.ForeColor = Color.White;
			this.siticoneHtmlLabel5.Location = new Point(207, 131);
			this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
			this.siticoneHtmlLabel5.Size = new Size(125, 26);
			this.siticoneHtmlLabel5.TabIndex = 21;
			this.siticoneHtmlLabel5.Text = "Currently disabled";
			this.siticoneHtmlLabel6.BackColor = Color.Transparent;
			this.siticoneHtmlLabel6.Enabled = false;
			this.siticoneHtmlLabel6.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel6.ForeColor = Color.White;
			this.siticoneHtmlLabel6.Location = new Point(157, 260);
			this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
			this.siticoneHtmlLabel6.Size = new Size(97, 21);
			this.siticoneHtmlLabel6.TabIndex = 42;
			this.siticoneHtmlLabel6.Text = "Not Required Now.";
			this.siticoneHtmlLabel10.BackColor = Color.Transparent;
			this.siticoneHtmlLabel10.Enabled = false;
			this.siticoneHtmlLabel10.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel10.ForeColor = Color.White;
			this.siticoneHtmlLabel10.Location = new Point(157, 287);
			this.siticoneHtmlLabel10.Name = "siticoneHtmlLabel10";
			this.siticoneHtmlLabel10.Size = new Size(356, 21);
			this.siticoneHtmlLabel10.TabIndex = 43;
			this.siticoneHtmlLabel10.Text = "Van 6, Van 5, Van 152, Van 61, Van 51, and all other HWID Van errors";
			this.siticoneHtmlLabel11.BackColor = Color.Transparent;
			this.siticoneHtmlLabel11.Enabled = false;
			this.siticoneHtmlLabel11.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel11.ForeColor = Color.White;
			this.siticoneHtmlLabel11.Location = new Point(157, 314);
			this.siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
			this.siticoneHtmlLabel11.Size = new Size(178, 21);
			this.siticoneHtmlLabel11.TabIndex = 44;
			this.siticoneHtmlLabel11.Text = "All laptops and desktops support.";
			this.siticoneHtmlLabel13.BackColor = Color.Transparent;
			this.siticoneHtmlLabel13.Enabled = false;
			this.siticoneHtmlLabel13.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel13.ForeColor = Color.White;
			this.siticoneHtmlLabel13.Location = new Point(157, 341);
			this.siticoneHtmlLabel13.Name = "siticoneHtmlLabel13";
			this.siticoneHtmlLabel13.Size = new Size(95, 21);
			this.siticoneHtmlLabel13.TabIndex = 45;
			this.siticoneHtmlLabel13.Text = "Any Windows 7-11";
			this.siticoneHtmlLabel15.BackColor = Color.Transparent;
			this.siticoneHtmlLabel15.Enabled = false;
			this.siticoneHtmlLabel15.Font = new Font("Bahnschrift Condensed", 12f);
			this.siticoneHtmlLabel15.ForeColor = Color.White;
			this.siticoneHtmlLabel15.Location = new Point(157, 368);
			this.siticoneHtmlLabel15.Name = "siticoneHtmlLabel15";
			this.siticoneHtmlLabel15.Size = new Size(60, 21);
			this.siticoneHtmlLabel15.TabIndex = 46;
			this.siticoneHtmlLabel15.Text = "Intel / AMD";
			base.AutoScaleDimensions = new SizeF(7f, 17f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(33, 33, 33);
			base.Controls.Add(this.siticoneHtmlLabel15);
			base.Controls.Add(this.siticoneHtmlLabel13);
			base.Controls.Add(this.siticoneHtmlLabel11);
			base.Controls.Add(this.siticoneHtmlLabel10);
			base.Controls.Add(this.siticoneHtmlLabel6);
			base.Controls.Add(this.siticoneButton4);
			base.Controls.Add(this.siticoneHtmlLabel14);
			base.Controls.Add(this.siticoneHtmlLabel12);
			base.Controls.Add(this.Value1);
			base.Controls.Add(this.siticoneHtmlLabel9);
			base.Controls.Add(this.siticoneHtmlLabel8);
			base.Controls.Add(this.siticoneHtmlLabel7);
			base.Controls.Add(this.siticoneHtmlLabel5);
			this.Font = new Font("Segoe UI", 10f);
			base.Margin = new Padding(3, 4, 3, 4);
			base.Name = "Profile1";
			base.Size = new Size(554, 484);
			base.Load += this.Profile1_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000053 RID: 83
		private IContainer components;

		// Token: 0x04000054 RID: 84
		private SiticoneButton siticoneButton4;

		// Token: 0x04000055 RID: 85
		private SiticoneHtmlLabel siticoneHtmlLabel14;

		// Token: 0x04000056 RID: 86
		private SiticoneHtmlLabel siticoneHtmlLabel12;

		// Token: 0x04000057 RID: 87
		private SiticoneHtmlLabel Value1;

		// Token: 0x04000058 RID: 88
		private SiticoneHtmlLabel siticoneHtmlLabel9;

		// Token: 0x04000059 RID: 89
		private SiticoneHtmlLabel siticoneHtmlLabel8;

		// Token: 0x0400005A RID: 90
		private SiticoneHtmlLabel siticoneHtmlLabel7;

		// Token: 0x0400005B RID: 91
		private SiticoneHtmlLabel siticoneHtmlLabel5;

		// Token: 0x0400005C RID: 92
		private SiticoneHtmlLabel siticoneHtmlLabel6;

		// Token: 0x0400005D RID: 93
		private SiticoneHtmlLabel siticoneHtmlLabel10;

		// Token: 0x0400005E RID: 94
		private SiticoneHtmlLabel siticoneHtmlLabel11;

		// Token: 0x0400005F RID: 95
		private SiticoneHtmlLabel siticoneHtmlLabel13;

		// Token: 0x04000060 RID: 96
		private SiticoneHtmlLabel siticoneHtmlLabel15;
	}
}
