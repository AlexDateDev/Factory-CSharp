// ----------------------------------------------------------------------------
// Título:    Mostrar archivo Excel por pantalla
//
// Fecha:     04/10/2013
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

StringBuilder sb = new StringBuilder( );

BuscarJuicio buscarJuicio = new BuscarJuicio( );
buscarJuicio.WhereAuto = Factory.Form.Input.GetValue( this.inpFindAuto );
if( this.inpDdlFecha.SelectedValue != "0" ) {
    buscarJuicio.WhereFecha = this.inpDdlFecha.SelectedValue;
}
buscarJuicio.WhereTitulo = Factory.Form.Input.GetValue( this.inpFindTitulo );
buscarJuicio.WhereJuzgado = Factory.Form.Combo.GetSelectedValueInt( this.inpDdlJuzgados );
buscarJuicio.WhereTipo = Factory.Form.Combo.GetSelectedValueInt( this.inpDdlTipoJuicio );

int TotalRegistros = 0;
IEnumerable<Juicio> lstJucios = this._providerJuicio.FindAll( "FechaJuicio", "des", out TotalRegistros, buscarJuicio );


sb.Append( RC.Fecha + ";" + RC.Auto + ";" + RC.TipoJuicio + ";" + RC.Juzgado + ";" + RC.Edicto + ";" + RC.Titular + "\n");
foreach( Juicio oneJuicio in lstJucios ) {

    string csvFecha = oneJuicio.FechaJuicio.ToShortDateString( );
    string csvAuto = oneJuicio.Auto;
    string csvJuzgado = oneJuicio.Juzgado.Nombre;
    string csvEdicto = oneJuicio.Edicto;
    string csvTipo = "";
    string csvTitular = "";
    if( Factory.Session.Idioma.Id == Factory.Session.Idioma.CAT ) {
        csvTipo = oneJuicio.TipoJuicio.NombreCat;
        csvTitular = oneJuicio.TitularCat;
    }
    else{
        csvTipo = oneJuicio.TipoJuicio.NombreEsp;
        csvTitular = oneJuicio.TitularEsp;

    }
    if( null == csvTitular ) {
        csvTitular = "";
    }
    csvTitular  = System.Text.RegularExpressions.Regex.Replace( csvTitular, "<[^>]*>", string.Empty );

    sb.Append( csvFecha + ";" + csvAuto + ";" + csvTipo + ";" +  csvJuzgado + ";" + csvEdicto + ";" + csvTitular + "\n");
}

Response.Clear( );
Response.Buffer = true;
Response.ContentType = "application/vnd.ms-excel";
Response.AddHeader( "Content-Disposition", "attachment;filename=data.csv" );
Response.Charset = "UTF-8";
Response.ContentEncoding = Encoding.Default;
Response.Write( sb.ToString() );
Response.End( );

