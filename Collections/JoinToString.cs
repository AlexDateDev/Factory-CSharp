using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Help.Collections
{
	public class HelperCollection
	{
		public static string JoinToString<T>( IEnumerable<T> lst, string concat=", " )
		{			
			return string.Join( concat, lst.ToArray( ) );
		}
	}
}