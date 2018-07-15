using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Linq.Expressions;

namespace Help.Linqs
{
	public static partial class HelperLinq
	{
		/// <summary>
		/// Crea una expresión lambda sobre un campo de un objeto
		/// Dependiendo del tipo de valor se tiene que crear una expresion lambda de un tipo u otro
		/// Los string son Object y los demas se tienen de indicar su tipo
		///		Expression<Func<Usuario, Object>> ExpOrderBy = null;
		///		Expression<Func<Usuario, int>> ExpOrderByInt = null;
		///		Expression<Func<Usuario, bool?>> ExpOrderByBool = null;
		///		
		/// </summary>
		/// <typeparam name="TFunc"></typeparam>
		/// <typeparam name="T"></typeparam>
		/// <param name="fld"></param>
		/// <returns></returns>
		/// <sample>
		///		Expression<Func<Usuario, int>> ExpOrderByInt = null;
		///		ColumnSort = "PerfilID"
		///		ExpOrderByInt = AtxLinq.CreateExpresion<Usuario, int>( ColumnSort );
		///		Devuelve una expresion u => u.PerfilId
		/// </sample>

		public static Expression<Func<T, TRet>> CreateExpresion<T, TRet>( string fld )
		{
			var source = typeof( T );
			var t = Expression.Parameter( source, "t" );

			MemberExpression exp = Expression.Property( t, source.GetProperty( fld ) );
			// Construimos expresión
			return Expression.Lambda<Func<T, TRet>>( exp, t );
		}

	}
}
