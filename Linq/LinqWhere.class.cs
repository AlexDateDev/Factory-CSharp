using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Help.Linqs
{
	/// <summary>
	/// Expresiones where
	/// </summary>
	/// <typeparam name="EntityType"></typeparam>
	public class HelperLinqWhere<EntityType> where EntityType : class 
	{
		private const string AND = "A";
		private const string OR = "O";

		// Diccionario de predicados where y su operación AND/OR
		private Dictionary< Expression<Func<EntityType, bool>>, string> _lstExpWhere = new Dictionary<Expression<Func<EntityType, bool>>, string>( );

		/// <summary>
		/// Añade un predicado a la lista como AND
		/// </summary>
		/// <param name="predicate"></param>
		public void And( Expression<Func<EntityType, bool>> predicate ){
			this._lstExpWhere.Add( predicate,  AND);
		}

		/// <summary>
		/// Añade un predicado a la lista como OR
		/// </summary>
		/// <param name="predicate"></param>
		public void Or( Expression<Func<EntityType, bool>> predicate )
		{
			this._lstExpWhere.Add( predicate, OR );
		}

		/// <summary>
		/// Devuelve la expresión final con todas los predicados con AND/OR
		/// </summary>
		public Expression<Func<EntityType, bool>> GetExpresion( )
		{
			Expression<Func<EntityType, bool>> ExpWhereResult = null;

			foreach( KeyValuePair<Expression<Func<EntityType, bool>>, string> expr in this._lstExpWhere ) {
				if( ExpWhereResult == null ) {
					ExpWhereResult = expr.Key;
				}
				else{
					switch( expr.Value ){
						case AND:
							ExpWhereResult = HelperLinqPredicateBuilder.And( ExpWhereResult, expr.Key );
							break;
						case OR:
							ExpWhereResult = HelperLinqPredicateBuilder.Or( ExpWhereResult, expr.Key );
							break;
						default:
							break;
					}
				}			
			}
			return ExpWhereResult;
		}

	}
}
