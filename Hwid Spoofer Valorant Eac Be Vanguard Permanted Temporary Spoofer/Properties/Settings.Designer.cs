using System;
using System.Configuration;

namespace MouseManager.Properties
{
	// Token: 0x02000011 RID: 17
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000088 RID: 136 RVA: 0x001A85A6 File Offset: 0x001A0FA6
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000052 RID: 82
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
