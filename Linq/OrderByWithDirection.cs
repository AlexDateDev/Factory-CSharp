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
		/// partiendo de un IQueryable devuelve la query ordenada por una expresion
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TKey"></typeparam>
		/// <param name="source"></param>
		/// <param name="keySelector"></param>
		/// <param name="ascending"></param>
		/// <returns></returns>
		public static IQueryable<TSource> OrderByWithDirection<TSource, TKey>
													( this IQueryable<TSource> source,
														Expression<Func<TSource, TKey>> keySelector,
														bool ascending )
		{
			// Si no hay condición de ordenación devolvemos la misma query
			if( null == keySelector ) {
				return source;
			}
			return ascending ?
				source.OrderBy( keySelector ) :
				source.OrderByDescending( keySelector );

		}

	}
}
