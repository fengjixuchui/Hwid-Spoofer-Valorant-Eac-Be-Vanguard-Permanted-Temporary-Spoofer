namespace MouseManager
{
	// Token: 0x02000009 RID: 9
	public partial class MainPage : global::System.Windows.Forms.Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x001A834B File Offset: 0x001A0D4B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x001AA7D8 File Offset: 0x001A31D8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.AnimatorNS.Animation animation2 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.Profile1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Profile2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Profile3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            this.siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneHtmlLabel4, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneHtmlLabel4.Enabled = false;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(65, 63);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(113, 26);
            this.siticoneHtmlLabel4.TabIndex = 2;
            this.siticoneHtmlLabel4.Text = "Spoofer Settings";
            // 
            // Profile1
            // 
            this.Profile1.Animated = true;
            this.Profile1.BorderThickness = 2;
            this.Profile1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.Profile1.Checked = true;
            this.Profile1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Profile1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Profile1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Profile1.CheckedState.Parent = this.Profile1;
            this.Profile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile1.CustomImages.Parent = this.Profile1;
            this.siticoneTransition1.SetDecoration(this.Profile1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.Profile1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profile1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profile1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profile1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profile1.DisabledState.Parent = this.Profile1;
            this.Profile1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Profile1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.Profile1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Profile1.HoverState.ForeColor = System.Drawing.Color.White;
            this.Profile1.HoverState.Parent = this.Profile1;
            this.Profile1.Location = new System.Drawing.Point(12, 97);
            this.Profile1.Name = "Profile1";
            this.Profile1.ShadowDecoration.Parent = this.Profile1;
            this.Profile1.Size = new System.Drawing.Size(198, 35);
            this.Profile1.TabIndex = 4;
            this.Profile1.Text = "Valorant Spoofer";
            this.Profile1.Click += new System.EventHandler(this.Profile1_Click);
            // 
            // Profile2
            // 
            this.Profile2.Animated = true;
            this.Profile2.BorderThickness = 2;
            this.Profile2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.Profile2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Profile2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Profile2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Profile2.CheckedState.Parent = this.Profile2;
            this.Profile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile2.CustomImages.Parent = this.Profile2;
            this.siticoneTransition1.SetDecoration(this.Profile2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.Profile2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profile2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profile2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profile2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profile2.DisabledState.Parent = this.Profile2;
            this.Profile2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Profile2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.Profile2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Profile2.HoverState.ForeColor = System.Drawing.Color.White;
            this.Profile2.HoverState.Parent = this.Profile2;
            this.Profile2.Location = new System.Drawing.Point(12, 138);
            this.Profile2.Name = "Profile2";
            this.Profile2.ShadowDecoration.Parent = this.Profile2;
            this.Profile2.Size = new System.Drawing.Size(198, 35);
            this.Profile2.TabIndex = 5;
            this.Profile2.Text = "EAC Spoofer";
            this.Profile2.Click += new System.EventHandler(this.Profile2_Click);
            // 
            // Profile3
            // 
            this.Profile3.Animated = true;
            this.Profile3.BorderThickness = 2;
            this.Profile3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.Profile3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Profile3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Profile3.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Profile3.CheckedState.Parent = this.Profile3;
            this.Profile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile3.CustomImages.Parent = this.Profile3;
            this.siticoneTransition1.SetDecoration(this.Profile3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.Profile3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profile3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profile3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profile3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profile3.DisabledState.Parent = this.Profile3;
            this.Profile3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Profile3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.Profile3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Profile3.HoverState.ForeColor = System.Drawing.Color.White;
            this.Profile3.HoverState.Parent = this.Profile3;
            this.Profile3.Location = new System.Drawing.Point(12, 179);
            this.Profile3.Name = "Profile3";
            this.Profile3.ShadowDecoration.Parent = this.Profile3;
            this.Profile3.Size = new System.Drawing.Size(198, 35);
            this.Profile3.TabIndex = 6;
            this.Profile3.Text = "BE Spoofer";
            this.Profile3.Click += new System.EventHandler(this.Profile3_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(796, -3);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 56);
            this.siticoneControlBox1.TabIndex = 8;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.siticoneControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.siticoneControlBox2.HoverState.IconColor = System.Drawing.Color.Aqua;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(734, -4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 56);
            this.siticoneControlBox2.TabIndex = 9;
            // 
            // PanelSlider
            // 
            this.siticoneTransition1.SetDecoration(this.PanelSlider, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.PanelSlider.Location = new System.Drawing.Point(250, 58);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(554, 484);
            this.PanelSlider.TabIndex = 7;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BorderThickness = 2;
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneButton1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(12, 220);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(198, 35);
            this.siticoneButton1.TabIndex = 10;
            this.siticoneButton1.Text = "FiveM Spoofer";
            this.siticoneButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Animated = true;
            this.siticoneButton2.BorderThickness = 2;
            this.siticoneButton2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneButton2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(12, 302);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(198, 35);
            this.siticoneButton2.TabIndex = 11;
            this.siticoneButton2.Text = "Misc";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.Animated = true;
            this.siticoneButton4.BorderThickness = 2;
            this.siticoneButton4.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton4.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneTransition1.SetDecoration(this.siticoneButton4, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.DisabledState.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(12, 343);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(198, 35);
            this.siticoneButton4.TabIndex = 13;
            this.siticoneButton4.Text = "Check HWID";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // siticonePictureBox2
            // 
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox2.Enabled = false;
            this.siticonePictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox2.ImageRotate = 0F;
            this.siticonePictureBox2.Location = new System.Drawing.Point(12, 65);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
            this.siticonePictureBox2.Size = new System.Drawing.Size(47, 24);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox2.TabIndex = 3;
            this.siticonePictureBox2.TabStop = false;
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.Animated = true;
            this.siticoneButton3.BorderThickness = 2;
            this.siticoneButton3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton3.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneTransition1.SetDecoration(this.siticoneButton3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.DisabledState.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton3.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoverState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(12, 384);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(198, 35);
            this.siticoneButton3.TabIndex = 12;
            this.siticoneButton3.Text = "Disable Antivirus";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.Desktop.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation2;
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.Animated = true;
            this.siticoneButton5.BorderThickness = 2;
            this.siticoneButton5.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton5.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneTransition1.SetDecoration(this.siticoneButton5, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton5.DisabledState.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton5.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoverState.Parent = this.siticoneButton5;
            this.siticoneButton5.Location = new System.Drawing.Point(12, 261);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(198, 35);
            this.siticoneButton5.TabIndex = 14;
            this.siticoneButton5.Text = "COD Spoofer";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneHtmlLabel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneHtmlLabel1.Enabled = false;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(542, 37);
            this.siticoneHtmlLabel1.TabIndex = 15;
            this.siticoneHtmlLabel1.Text = "GG Spoofer Surce | Cracked by RyanXP#9278 on Discord";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(868, 616);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.PanelSlider);
            this.Controls.Add(this.Profile3);
            this.Controls.Add(this.Profile2);
            this.Controls.Add(this.Profile1);
            this.Controls.Add(this.siticonePictureBox2);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.siticoneTransition1.SetDecoration(this, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001C RID: 28
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;

		// Token: 0x0400001D RID: 29
		private global::Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox2;

		// Token: 0x0400001E RID: 30
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Profile1;

		// Token: 0x0400001F RID: 31
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Profile2;

		// Token: 0x04000020 RID: 32
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Profile3;

		// Token: 0x04000021 RID: 33
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000022 RID: 34
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000023 RID: 35
		private global::Siticone.Desktop.UI.WinForms.SiticonePanel PanelSlider;

		// Token: 0x04000024 RID: 36
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x04000025 RID: 37
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;

		// Token: 0x04000026 RID: 38
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;

		// Token: 0x04000027 RID: 39
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;

		// Token: 0x04000028 RID: 40
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000029 RID: 41
		private global::Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400002A RID: 42
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;

		// Token: 0x0400002B RID: 43
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
	}
}
