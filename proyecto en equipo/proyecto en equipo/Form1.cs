/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 26/11/2026
 * Hora: 09:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_en_equipo
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
			}
		
		void BtnArregloClick(object sender, EventArgs e)
		{
			Form2 k = new Form2();
			this.Hide();
			k.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form3 n = new Form3();
			this.Hide();
			n.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form4 j = new Form4();
			this.Hide();
			j.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Form5 l = new Form5();
			this.Hide();
			l.Show();
		}
	}
}
