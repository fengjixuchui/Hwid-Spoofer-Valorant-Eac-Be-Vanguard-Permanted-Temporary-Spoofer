using System;
using System.Windows.Forms;

namespace MouseManager
{
	// Token: 0x0200000F RID: 15
	internal static class Program
	{
		// Token: 0x06000080 RID: 128 RVA: 0x001A84F9 File Offset: 0x001A0EF9
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainPage());
		}
	}
}
