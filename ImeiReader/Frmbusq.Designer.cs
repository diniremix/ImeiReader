/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 26/01/2013
 * Hora: 11:40 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ImeiReader
{
	partial class Frmbusq
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.resultGrid = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.textbimei = new System.Windows.Forms.TextBox();
			this.btnback = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.resultGrid);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textbimei);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(502, 269);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda por IMEI";
			// 
			// resultGrid
			// 
			this.resultGrid.DataMember = "";
			this.resultGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.resultGrid.Location = new System.Drawing.Point(6, 53);
			this.resultGrid.Name = "resultGrid";
			this.resultGrid.ReadOnly = true;
			this.resultGrid.Size = new System.Drawing.Size(490, 210);
			this.resultGrid.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "IMEI:";
			// 
			// textbimei
			// 
			this.textbimei.Location = new System.Drawing.Point(50, 27);
			this.textbimei.Name = "textbimei";
			this.textbimei.Size = new System.Drawing.Size(175, 20);
			this.textbimei.TabIndex = 0;
			this.textbimei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textbimei.TextChanged += new System.EventHandler(this.TextbimeiTextChanged);
			// 
			// btnback
			// 
			this.btnback.Location = new System.Drawing.Point(218, 287);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(75, 23);
			this.btnback.TabIndex = 1;
			this.btnback.Text = "&Regresar";
			this.btnback.UseVisualStyleBackColor = true;
			this.btnback.Click += new System.EventHandler(this.BtnbackClick);
			// 
			// Frmbusq
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 316);
			this.Controls.Add(this.btnback);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "Frmbusq";
			this.Text = "IMEIReader::Busqueda";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGrid resultGrid;
		private System.Windows.Forms.Button btnback;
		private System.Windows.Forms.TextBox textbimei;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
