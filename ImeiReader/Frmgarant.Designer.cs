/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 29/01/2013
 * Hora: 12:44 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ImeiReader
{
	partial class Frmgarant
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
			this.btnback = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.resultGrid = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textbimei = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btnback
			// 
			this.btnback.Location = new System.Drawing.Point(218, 287);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(75, 23);
			this.btnback.TabIndex = 3;
			this.btnback.Text = "&Regresar";
			this.btnback.UseVisualStyleBackColor = true;
			this.btnback.Click += new System.EventHandler(this.BtnbackClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.resultGrid);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textbimei);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(502, 269);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Consultar fecha de garantia del producto";
			// 
			// resultGrid
			// 
			this.resultGrid.AllowUserToAddRows = false;
			this.resultGrid.AllowUserToDeleteRows = false;
			this.resultGrid.AllowUserToResizeColumns = false;
			this.resultGrid.AllowUserToResizeRows = false;
			this.resultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.resultGrid.Location = new System.Drawing.Point(6, 53);
			this.resultGrid.Name = "resultGrid";
			this.resultGrid.ReadOnly = true;
			this.resultGrid.Size = new System.Drawing.Size(490, 210);
			this.resultGrid.TabIndex = 3;
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
			// Frmgarant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 315);
			this.Controls.Add(this.btnback);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "Frmgarant";
			this.Text = "IMEIReader::Garantia";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmgarantFormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox textbimei;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView resultGrid;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnback;
	}
}
