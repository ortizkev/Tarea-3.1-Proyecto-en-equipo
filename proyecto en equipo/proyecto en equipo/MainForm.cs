/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 26/11/2026
 * Hora: 09:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_en_equipo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (txtUsuario.Text=="ADMIN"){
				if (txtContraseña.Text=="1234"){
					Form1 f = new Form1();
					f.Show();
					this.Hide();
				}
				else{
					MessageBox.Show("Contrseña incorrecta");
				}
				
			}
			else{
					MessageBox.Show("Ususario Incorrecto");
				}
		}
	}
}
