/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 26/11/2026
 * Hora: 09:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_en_equipo
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnContadorClick(object sender, EventArgs e)
		{
			string palabra = txtPalabra.Text;

	    int vocales = 0;
	    int consonantes = 0;
	
	    for (int i = 0; i < palabra.Length; i++)
	    {
	        if (palabra[i] == 'a' || palabra[i] == 'e' ||
	            palabra[i] == 'i' || palabra[i] == 'o' ||
	            palabra[i] == 'u' || palabra[i] == 'A' ||
	            palabra[i] == 'E' || palabra[i] == 'I' ||
	            palabra[i] == 'O' || palabra[i] == 'U')
	        {
	            vocales++;
	        }
	        else if ((palabra[i] >= 'a' && palabra[i] <= 'z') ||
	                 (palabra[i] >= 'A' && palabra[i] <= 'Z'))
	        {
	            consonantes++;
	        }
	    }
	
	    lblVocales.Text = "Vocales: " + vocales;
	    lblConsonantes.Text = "Consonantes: " + consonantes;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
