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
		/// Devuelve el miembro de una expresión
		/// </summary>
		/// <param name="method"></param>
		/// <returns></returns>
		public static MemberExpression GetExpresionMember( Expression method )
		{
			LambdaExpression lambda = method as LambdaExpression;
			if( lambda == null )
				throw new ArgumentNullException( "method" );

			MemberExpression memberExpr = null;

			if( lambda.Body.NodeType == ExpressionType.Convert ) {
				memberExpr =
					( ( UnaryExpression ) lambda.Body ).Operand as MemberExpression;
			} else if( lambda.Body.NodeType == ExpressionType.MemberAccess ) {
				memberExpr = lambda.Body as MemberExpression;
			}

			if( memberExpr == null ) {
				throw new ArgumentException( "method" );
			}
			return memberExpr;
		}

	}
}
