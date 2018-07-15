//// ----------------------------------------------------------------------------
//// Título:    Export CSV
////
//// Fecha:     07/11/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//	void btnExport_Click_csv( object sender, EventArgs e )
//    {
//        //StringBuilder sb = new StringBuilder( );

//        //BuscarJuicio buscarJuicio = new BuscarJuicio( );
//        //buscarJuicio.WhereAuto = Factory.UI.Input.GetValue( this.inpFindAuto );
//        //if( this.inpDdlFecha.SelectedValue != "0" ) {
//        //    buscarJuicio.WhereFecha = this.inpDdlFecha.SelectedValue;
//        //}
//        //buscarJuicio.WhereTitulo = Factory.UI.Input.GetValue( this.inpFindTitulo );
//        //buscarJuicio.WhereJuzgado = Factory.UI.Combo.GetSelectedValueInt( this.inpDdlJuzgados );
//        //buscarJuicio.WhereTipo = Factory.UI.Combo.GetSelectedValueInt( this.inpDdlTipoJuicio );

//        //int TotalRegistros = 0;
//        //IEnumerable<Juicio> lstJucios = this._providerJuicio.FindAll( "FechaJuicio", "des", out TotalRegistros, buscarJuicio );



//        ////sb.Append( RC.Fecha + ";" + RC.Auto + ";" + RC.TipoJuicio + ";" + RC.Juzgado + ";" + RC.Edicto + ";" + RC.Titular + "\n");
//        //sb.Append( "JORDI FONTQUERNI BAS;;;;;\n" );
//        //sb.Append( "Pocurador dels Tribunals;;;;;\n" );
//        //sb.Append( ";;;;;\n" );
//        //sb.Append( "Relació de Judicis Concursals i Diligències preparatòries;;;;;\n" );
//        //sb.Append( "Data: "+DateTime.Now.ToShortDateString()+ ";;;;;\n" );
//        //sb.Append( ";;;;;\n" );
//        //sb.Append( RC.Juzgado + ";" + RC.Fecha+ ";" + RC.Auto+ ";" + RC.TipoJuicio + ";" + RC.Edicto + ";" + RC.Titular + "\n" );
//        //foreach( Juicio oneJuicio in lstJucios ) {

//        //    string csvFecha = oneJuicio.FechaJuicio.ToShortDateString( );
//        //    string csvAuto = oneJuicio.Auto;
//        //    string csvJuzgado = oneJuicio.Juzgado.Nombre;
//        //    string csvEdicto = oneJuicio.Edicto;
//        //    string csvTipo = "";
//        //    string csvTitular = "";
//        //    if( Factory.Session.Idioma.Id == Factory.Session.Idioma.CAT ) {
//        //        csvTipo = oneJuicio.TipoJuicio.NombreCat;
//        //        csvTitular = oneJuicio.TitularCat;
//        //    }
//        //    else{
//        //        csvTipo = oneJuicio.TipoJuicio.NombreEsp;
//        //        csvTitular = oneJuicio.TitularEsp;

//        //    }
//        //    if( null == csvTitular ) {
//        //        csvTitular = "";
//        //    }
//        //    csvTitular  = System.Text.RegularExpressions.Regex.Replace( csvTitular, "<[^>]*>", string.Empty );
//        //    csvTitular = csvTitular.Replace( "\r\n", " " );

//        //    //sb.Append( csvFecha + ";" + csvAuto + ";" + csvTipo + ";" +  csvJuzgado + ";" + csvEdicto + ";" + csvTitular + "\n");
//        //    sb.Append( csvJuzgado + ";" + csvFecha + ";" + csvAuto + ";" + csvTipo + ";" + csvEdicto + ";" + csvTitular + "\n" );
//        //}

//        //Response.Clear( );
//        //Response.Buffer = true;
//        //Response.ContentType = "application/vnd.ms-excel";
//        //Response.AddHeader( "Content-Disposition", "attachment;filename=Concursos.csv" );
//        //Response.Charset = "UTF-8";
//        //Response.ContentEncoding = Encoding.Default;
//        //Response.Write( sb.ToString() );
//        //Response.End( );

//    }

