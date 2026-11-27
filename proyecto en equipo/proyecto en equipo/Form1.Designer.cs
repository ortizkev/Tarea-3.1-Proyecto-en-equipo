/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 26/11/2026
 * Hora: 09:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_en_equipo
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnArreglo = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "MAIN MENU";
			// 
			// btnArreglo
			// 
			this.btnArreglo.Location = new System.Drawing.Point(12, 80);
			this.btnArreglo.Name = "btnArreglo";
			this.btnArreglo.Size = new System.Drawing.Size(90, 50);
			this.btnArreglo.TabIndex = 1;
			this.btnArreglo.Text = "Ordenar arreglos";
			this.btnArreglo.UseVisualStyleBackColor = true;
			this.btnArreglo.Click += new System.EventHandler(this.BtnArregloClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 157);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 50);
			this.button2.TabIndex = 2;
			this.button2.Text = "Mayor o Menor";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(166, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 50);
			this.button3.TabIndex = 3;
			this.button3.Text = "Palabra al revez";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(166, 157);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 50);
			this.button4.TabIndex = 4;
			this.button4.Text = "Contador de letras";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(87, 213);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(90, 50);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 293);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnArreglo);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnArreglo;
		private System.Windows.Forms.Label label1;
	}
}
