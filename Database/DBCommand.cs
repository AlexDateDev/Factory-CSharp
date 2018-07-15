// ----------------------------------------------------------------------------
// Título:    DBCommand
//
// Date : 02/05/2013
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

//Database _database = DatabaseFactory.CreateDatabase( );

//string query1 = @"SELECT rel.Id
//                        FROM RelacionJuzgadoSJ AS rel
//                        WHERE rel.IdSecretarioJudicial = @IdUsuario
//                            AND rel.IdJuzgado = @IdJuzgado
//                            AND rel.Principal = @Principal
//                            AND FechaFin IS NULL";

//DbCommand dbCommand = _database.GetSqlStringCommand( query1 );

//_database.AddInParameter( dbCommand, "IdJuzgado", DbType.Int32, IdJuzgado );
//_database.AddInParameter( dbCommand, "IdUsuario", DbType.Int32, IdUsuario );
//_database.AddInParameter( dbCommand, "Principal", DbType.Boolean, EsPrincipal );

//IDataReader reader = null;
//if( dbTransaction != null ) {
//    reader = _database.ExecuteReader( dbCommand, dbTransaction );
//} else {
//    reader = _database.ExecuteReader( dbCommand );
//}
//reader.Read( );
//int? Id = FactoryData.Sql.ToInt( reader, "Id" );

///*while(reader.Read( )){
//    int? Id = FactoryData.Sql.ToInt( reader, "Id" );
//}*/

//reader.Close( );


//--------------
//string query = @"UPDATE RelacionJuzgadoAutos
//                    SET FechaFin = GETDATE()
//                WHERE idauto = @IdAuto AND FechaFin IS NULL";

//DbCommand dbCommand = this.CreateDbCommand( query );
//this.AddParameter( dbCommand, "IdAuto", oneAuto.Id );

//IDataReader reader = this.ExecuteDbCommand( dbCommand, dbTransaction );
//reader.Close( );

//--------
//public IDataReader ExecuteDbCommand( DbCommand dbCommand, DbTransaction dbTransaction )
//{
//    InitDatabase( );
//    if( dbTransaction != null ) {
//        return _db.ExecuteReader( dbCommand, dbTransaction );
//    } else {
//        return _db.ExecuteReader( dbCommand );
//    }
//}
//-----------
///// <summary>
///// Crea una instancia de DbCommand
///// </summary>
///// <param name="query"></param>
///// <returns></returns>
//public DbCommand CreateDbCommand( string query )
//{
//    this.InitDatabase( );
//    return _db.GetSqlStringCommand( query );
//}
