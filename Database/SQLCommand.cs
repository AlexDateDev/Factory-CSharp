//// ----------------------------------------------------------------------------
//// Título:    SQLCommand
////
//// Fecha:     02/05/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//using( SqlConnection conn = new SqlConnection( this._StrConnection ) ) {

//    conn.Open( );

//    string query = @"SELECT rel.Id
//                            FROM RelacionJuzgadoSJ AS rel
//                            WHERE rel.IdSecretarioJudicial = @IdUsuario
//                                AND rel.IdJuzgado = @IdJuzgado
//                                AND rel.Principal = @Principal
//                                AND FechaFin IS NULL";


//    SqlCommand cmd = new SqlCommand( query, conn );

//    cmd.Parameters.AddWithValue( "@IdUsuario", IdUsuario );
//    cmd.Parameters.AddWithValue( "@IdJuzgado", IdJuzgado );
//    cmd.Parameters.AddWithValue( "@Principal", EsPrincipal );

//    SqlDataReader reader = cmd.ExecuteReader( CommandBehavior.CloseConnection );

//    reader.Read( );
//    int? Id = FactoryData.Sql.ToInt( reader, "Id" );
//    if( null != Id && !reader.IsClosed ) {
//        if( null != dbTransaction ) {
//            this._RelacionJuzgadoSJProvider.ContinueTransaction( dbTransaction );
//        }

//        RelacionJuzgadoSJ rel = this._RelacionJuzgadoSJProvider.Obtener1( Id );
//        rel.FechaFin = DateTime.Now;
//        this._RelacionJuzgadoSJProvider.Actualizar(
//            rel.Id,
//            rel.IdJuzgado,
//            rel.IdSecretarioJudicial,
//            rel.FechaInicio,
//            rel.FechaFin,
//            rel.Descripcion,
//            rel.Principal,
//            rel.MarcaTiempo );
//    }

//    return true;
//}

