/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 26/11/2026
 * Hora: 09:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_en_equipo
{
	partial class Form5
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.btnContador = new System.Windows.Forms.Button();
			this.lblVocales = new System.Windows.Forms.Label();
			this.lblConsonantes = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 52);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contador de Vocales y Consonantes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingrese una palabra:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(39, 98);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(200, 20);
			this.txtPalabra.TabIndex = 2;
			// 
			// btnContador
			// 
			this.btnContador.BackColor = System.Drawing.Color.DarkGray;
			this.btnContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnContador.Location = new System.Drawing.Point(65, 124);
			this.btnContador.Name = "btnContador";
			this.btnContador.Size = new System.Drawing.Size(157, 34);
			this.btnContador.TabIndex = 3;
			this.btnContador.Text = "CONTAR";
			this.btnContador.UseVisualStyleBackColor = false;
			this.btnContador.Click += new System.EventHandler(this.BtnContadorClick);
			// 
			// lblVocales
			// 
			this.lblVocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVocales.Location = new System.Drawing.Point(39, 166);
			this.lblVocales.Name = "lblVocales";
			this.lblVocales.Size = new System.Drawing.Size(200, 28);
			this.lblVocales.TabIndex = 4;
			this.lblVocales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblConsonantes
			// 
			this.lblConsonantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsonantes.Location = new System.Drawing.Point(39, 194);
			this.lblConsonantes.Name = "lblConsonantes";
			this.lblConsonantes.Size = new System.Drawing.Size(200, 27);
			this.lblConsonantes.TabIndex = 5;
			this.lblConsonantes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkGray;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(92, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "SALIR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblConsonantes);
			this.Controls.Add(this.lblVocales);
			this.Controls.Add(this.btnContador);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form5";
			this.Text = "Form5";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblConsonantes;
		private System.Windows.Forms.Label lblVocales;
		private System.Windows.Forms.Button btnContador;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
