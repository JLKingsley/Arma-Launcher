using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_Launcher
{
	class core
	{
		// Global environment vars
		public static string AppPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
		public static string AppDirectory = System.IO.Path.GetDirectoryName(AppPath);
	}
}
