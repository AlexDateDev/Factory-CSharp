/**
*	Captcha
*	Se muestra una imagen como captcha
*
*	Fecha:	12/01/2013
*	Autor:	Alex
*/

using System;
using System.Web;
using System.Drawing;
using System.IO;
using System.Web.SessionState;
using System.Collections.Generic;
using System.Drawing.Text;

namespace Help.Captchas
{
	/// <summary>
	/// Captcha
	/// </summary>
	public class HelperCaptcha : IHttpHandler, IReadOnlySessionState
	{
		/// <summary>
		/// Genrador de una imagen para captcha
		/// </summary>
		/// <param fileName="context"></param>
		public void ProcessRequest( HttpContext context )
		{
			// Image
			int w = 200;
			int h = 50;
			Bitmap mapabit = new Bitmap( w, h );
			Graphics lienzo  = Graphics.FromImage( mapabit );

			// Random
			Random rnd = new Random( );

			int len = 6;
			string strGenerated = this.RandomString( len );

			// Guardamos en sessión el código generado
			////Factory.Session.Captcha.SetCode( strGenerated );

			// Fonts 
			InstalledFontCollection installedFontCollection = new InstalledFontCollection( );
			FontFamily[] fontFamilies;
			fontFamilies = installedFontCollection.Families;
			int count = fontFamilies.Length;

			FontFamily currentFont;
			bool IsRegular = false;
			do {
				int nFont = rnd.Next( 0, count );
				currentFont = fontFamilies[ nFont ];
				IsRegular = currentFont.IsStyleAvailable( FontStyle.Regular );
			} while( !IsRegular );
			Font fuente1 = new Font( currentFont.Name, 22 );

			// Para mostrar ponemos un espacio entre letras
			string strVisible = "";
			for( int n = 0; n < len; n++ ) {
				strVisible += strGenerated[ n ] + " ";
			}

			// Color
			SolidBrush pincel1 = new SolidBrush( Color.FromArgb( rnd.Next( 0, 128 ), rnd.Next( 0, 128 ), rnd.Next( 0, 128 ) ) );
			lienzo.DrawString( strVisible, fuente1, pincel1, 4, 4 );

			// Distorsion
			for( int i= 0; i < 20; i++ ) {
				int x1 = rnd.Next( 0, w );
				int y1 = rnd.Next( 0, h );
				int x2 = rnd.Next( 0, w );
				int y2 = rnd.Next( 0, h );

				Pen lapiz1 = new Pen( Color.FromArgb( rnd.Next( 0, 255 ), rnd.Next( 0, 255 ), rnd.Next( 0, 255 ) ) );
				lienzo.DrawLine( lapiz1, x1, y1, x2, y2 );
				if( i % 2 == 0 ) { // La mitad de elipses
					lienzo.DrawEllipse( lapiz1, x1 / 2, y1 / 2, x2 / 2, y2 / 2 );
				}
			}

			// Mostrar imagen
			MemoryStream ms = new MemoryStream( );
			mapabit.Save( ms, System.Drawing.Imaging.ImageFormat.Png );
			byte[] bmpBytes = ms.GetBuffer( );
			mapabit.Dispose( );
			ms.Close( );
			context.Response.BinaryWrite( bmpBytes );
			context.Response.End( );
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// Genera un string aleatorio de carácteres
		/// </summary>
		/// <param fileName="size"></param>
		/// <returns></returns>
		private string RandomString( int size )
		{
			System.Text.StringBuilder builder = null;
			Random random = null;

			builder = new System.Text.StringBuilder( size );
			random = new Random( ( int ) DateTime.Now.Ticks );

			char ch;
			for( int i = 0; i < size; i++ ) {
				ch = Convert.ToChar( Convert.ToInt32( Math.Floor( 26 * random.NextDouble( ) + 65 ) ) );
				builder.Append( ch );
			}

			return builder.ToString( );
		}
	}
}