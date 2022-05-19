using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

//CRACKED By RyanXp#9278 On Discord//
// DONT USE IT THIS SHIT maybe RAT or webhook stealer//

namespace MouseManager.Properties
{
	// Token: 0x02000010 RID: 16
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000081 RID: 129 RVA: 0x001A8111 File Offset: 0x001A0B11
		internal Resources()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000082 RID: 130 RVA: 0x001A8514 File Offset: 0x001A0F14
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("MouseManager.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000083 RID: 131 RVA: 0x001A8543 File Offset: 0x001A0F43
		// (set) Token: 0x06000084 RID: 132 RVA: 0x001A854A File Offset: 0x001A0F4A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000085 RID: 133 RVA: 0x001A8555 File Offset: 0x001A0F55
		internal static Bitmap cropped_cropped_riologo_gold_3
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("cropped-cropped-riologo_gold_3", Resources.resourceCulture);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000086 RID: 134 RVA: 0x001A8570 File Offset: 0x001A0F70
		internal static Bitmap mouse
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("mouse", Resources.resourceCulture);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000087 RID: 135 RVA: 0x001A858B File Offset: 0x001A0F8B
		internal static Bitmap settings
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("settings", Resources.resourceCulture);
			}
		}

		// Token: 0x04000050 RID: 80
		private static ResourceManager resourceMan;

		// Token: 0x04000051 RID: 81
		private static CultureInfo resourceCulture;
	}
}
