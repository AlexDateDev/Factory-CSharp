using System;
using System.Linq;
using System.Web;
using System.IO;

namespace Help.GUIDs
{
	public static class HelperGUID
	{
		public static Guid Create(){
		    return Guid.NewGuid();
		}
	}
}