//// ----------------------------------------------------------------------------
//// T�tulo:    ShowTweets
////
//// Fecha:     01/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//using System;
//using System.Collections;
//using System.Configuration;
//using System.Data;
//using System.Linq;
//using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
//using Atexsa.Terrassa.Data;
//using Atexsa.Terrassa.Entities;
//using System.Collections.Generic;
//using Atexsa.Factory;
//using Atexsa.Factory.Twitter;


//public partial class controls_noticiastwit : System.Web.UI.UserControl
//{

//    /// <summary>
//    /// Número de twits que se muestran en portada
//    /// </summary>
//    private int _NumTwitsAMostrar = 0;

//    // Autenticación
//    private OAuthenticationInfo  _Oauth = new OAuthenticationInfo( );

//    // Servidotr Tweeter
//    private TwitterServer srvTwiter = null;

//    /// <summary>
//    /// Lista de Twits a mostrar
//    /// </summary>
//    List<Tweet> _lstTwits = null;

//    /// <summary>
//    /// Load
//    /// </summary>
//    /// <param name="sender"></param>
//    /// <param name="e"></param>
//    protected void Page_Load( object sender, EventArgs e )
//    {
//        this._NumTwitsAMostrar = Factory.WebConfig.Twitter.GetNumTwitsPortadaVisibles( );
//        this.BindTwitter( );

//    }

//    /// <summary>
//    /// Inicializa nuestro servidor de Twitter
//    /// </summary>
//    private void InitTwitter( ) {
//        this._Oauth.AccessToken = Factory.WebConfig.Twitter.GetAccessToken( );
//        this._Oauth.AccessSecret = Factory.WebConfig.Twitter.GetAccessSecret( );

//        // Claver de nuestra aplicación  para acceder el servicio tweeter
//        this._Oauth.ConsumerKey = Factory.WebConfig.Twitter.GetConsumerKey( );
//        this._Oauth.ConsumerSecret = Factory.WebConfig.Twitter.GetConsumerSecret( );

//        this.srvTwiter = new TwitterServer( _Oauth );
//        if( !Factory.String.IsEmpty( this._Oauth.AccessToken ) ) {
//            this._lstTwits = this.srvTwiter.GetUserTimeline( null, this._NumTwitsAMostrar, true ).ToList( );
//        }
//        else {
//            this._lstTwits = new List<Tweet>( );
//        }
//    }

//    /// <summary>
//    /// Hace el binding de los Twits con la visualización
//    /// </summary>
//    private void BindTwitter(){
//        this.InitTwitter( );

//        string sTwit = "<table border='0' style='width:100%;font-size:14px;font-family:Arial' id='tbTwiter'>";
//        foreach( Tweet t in this._lstTwits ) {
//            sTwit += "<tr>";
//            sTwit += "<td style='width:10%;vertical-align:top;margin:0;'>";
//            sTwit +=    "<img src='Scripts/twitter_icon.png' width='48' height='48' style='margin:0;border:0px solid #FFF;'/>";
//            sTwit += "</td>";

//            sTwit += "<td style='width:80%;vertical-align:top;text-align:left;'>";

//            string sHeader = "<p style='margin-top:0;padding-top:0'><span style='font-weight:bold;'>" + t.UserName + "</span>&nbsp;&nbsp;&nbsp;<span style='font-size:14px;color:grey;'>@" + t.ScreenName + "</span><br />";

//            sTwit += sHeader + "<span class='textTwiter'>" + t.Text + "</span></p>";

//            if( !Factory.String.IsEmpty( t.MediaUrl ) ) {
//                sTwit += "<p style='position:relative;margin:0;'>";
//                sTwit +=    "<img width='14' height='12' src='Scripts/TwitPhoto.png' style='margin:1px;float:left;border:0px solid #FFF;' />&nbsp;";
//                sTwit +=    "<span style='padding-left:6px;margin:0;float:left;color:#0084B4;font-size:12px;'>";
//                sTwit += "<a href='#' id='verFoto" + t.Id.ToString( ) + "' onclick='showImgTweet(event, \"" + t.Id.ToString( ) + "\", true);' style='display:none'>Ver foto</a>";
//                sTwit +=        "<a href='#' id='ocultarFoto" + t.Id.ToString( ) + "' onclick='showImgTweet(event, \"" + t.Id.ToString( ) + "\", false);' >Ocultar foto</a>";
//                sTwit +=    "</span>";
//                sTwit += "</p>";

//                sTwit += "<div id='imgTwit" + t.Id.ToString( ) + "' style='margin-top:5px' >";
//                sTwit +=    "<img style='margin:0;border:0px solid #FFF;' src='" + t.MediaUrl + "' width='" + t.MediaWidth + "' height='" + t.MediaHeight + "' />";
//                sTwit += "</div>";
//            }

//            sTwit += "</td>";
//            sTwit += "<td style='width:10%;vertical-align:top;color:grey;'>" + t.SinceTo + "</td>";
//            sTwit += "</tr>";
//        }
//        sTwit += "</table>";
//        Factory.WebForm.SetValue( this.lblTwits, sTwit );
//    }



//}
