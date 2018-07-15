//// ----------------------------------------------------------------------------
//// Título:    GetProperty
////
//// Fecha:     01/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//PropertyInfo  prop = typeof(ENT.Usuarios).GetProperty( ColumnSort );
//Type t = prop.PropertyType;
//switch( t.Name){
//    case "Nullable`1": // Bool?
//        ExpOrderByBool = BaseLinq.CreateExpresion<ENT.Usuarios, bool?>( ColumnSort );
//        break;

//    case "Int32":
//        ExpOrderByInt = BaseLinq.CreateExpresion<ENT.Usuarios, int>( ColumnSort );
//        break;

//    case "String":
//        ExpOrderByObj = BaseLinq.CreateExpresionObject<ENT.Usuarios>( ColumnSort );
//        break;
//}


//Usuario uss =  AtxCombobox.InsertFirst<Usuario>( p => p.UsuarioID, p => p.Apellidos, "KKK" );

//public static T InsertFirst<T>( Expression<Func<T, int>> key, Expression<Func<T, string>> val, string txt )
//{
//    string keyName = GetMemberInfo( key ).Member.Name;
//    string valueName = GetMemberInfo( val ).Member.Name; //"FieldNameText;

//    Type NameClass = typeof( T );
//    object instance = Activator.CreateInstance( NameClass );

//    // Get a property on the type that is stored in the
//    // property string
//    PropertyInfo propKey = NameClass.GetProperty( keyName );
//    propKey.SetValue( instance, 0, null );

//    PropertyInfo propValue = NameClass.GetProperty( valueName );
//    propValue.SetValue( instance, txt, null );
//    return ( T ) instance;
//}

//private static MemberExpression GetMemberInfo( Expression method )
//{
//    LambdaExpression lambda = method as LambdaExpression;
//    if( lambda == null )
//        throw new ArgumentNullException( "method" );

//    MemberExpression memberExpr = null;

//    if( lambda.Body.NodeType == ExpressionType.Convert ) {
//        memberExpr =
//            ( ( UnaryExpression ) lambda.Body ).Operand as MemberExpression;
//    } else if( lambda.Body.NodeType == ExpressionType.MemberAccess ) {
//        memberExpr = lambda.Body as MemberExpression;
//    }

//    if( memberExpr == null )
//        throw new ArgumentException( "method" );

//    return memberExpr;
//}
