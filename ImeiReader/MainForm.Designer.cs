/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 26/01/2013
 * Hora: 11:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ImeiReader
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnsave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textimei = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnfind = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnusaveimei = new System.Windows.Forms.ToolStripMenuItem();
			this.mnufindimei = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuexit = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnubackupdb = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuabout = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(87, 177);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 1;
			this.btnsave.Text = "&Guardar";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.BtnsaveClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textimei);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 144);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Leer Codigo IMEI";
			// 
			// textimei
			// 
			this.textimei.Location = new System.Drawing.Point(116, 29);
			this.textimei.Name = "textimei";
			this.textimei.Size = new System.Drawing.Size(153, 20);
			this.textimei.TabIndex = 0;
			this.textimei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(68, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "IMEI:";
			// 
			// btnfind
			// 
			this.btnfind.Location = new System.Drawing.Point(181, 177);
			this.btnfind.Name = "btnfind";
			this.btnfind.Size = new System.Drawing.Size(75, 23);
			this.btnfind.TabIndex = 2;
			this.btnfind.Text = "&Buscar";
			this.btnfind.UseVisualStyleBackColor = true;
			this.btnfind.Click += new System.EventHandler(this.BtnfindClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.herramientasToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(380, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnusaveimei,
									this.mnufindimei,
									this.toolStripMenuItem1,
									this.mnuexit});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// mnusaveimei
			// 
			this.mnusaveimei.Image = ((System.Drawing.Image)(resources.GetObject("mnusaveimei.Image")));
			this.mnusaveimei.Name = "mnusaveimei";
			this.mnusaveimei.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.mnusaveimei.Size = new System.Drawing.Size(161, 22);
			this.mnusaveimei.Text = "&Guardar IMEI";
			this.mnusaveimei.Click += new System.EventHandler(this.MnusaveimeiClick);
			// 
			// mnufindimei
			// 
			this.mnufindimei.Image = ((System.Drawing.Image)(resources.GetObject("mnufindimei.Image")));
			this.mnufindimei.Name = "mnufindimei";
			this.mnufindimei.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.mnufindimei.Size = new System.Drawing.Size(161, 22);
			this.mnufindimei.Text = "&Buscar IMEI";
			this.mnufindimei.Click += new System.EventHandler(this.MnufindimeiClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
			// 
			// mnuexit
			// 
			this.mnuexit.Image = ((System.Drawing.Image)(resources.GetObject("mnuexit.Image")));
			this.mnuexit.Name = "mnuexit";
			this.mnuexit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.mnuexit.Size = new System.Drawing.Size(161, 22);
			this.mnuexit.Text = "&Salir";
			this.mnuexit.Click += new System.EventHandler(this.MnuexitClick);
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnubackupdb});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "&Herramientas";
			// 
			// mnubackupdb
			// 
			this.mnubackupdb.Image = ((System.Drawing.Image)(resources.GetObject("mnubackupdb.Image")));
			this.mnubackupdb.Name = "mnubackupdb";
			this.mnubackupdb.Size = new System.Drawing.Size(152, 22);
			this.mnubackupdb.Text = "&Backup";
			this.mnubackupdb.Click += new System.EventHandler(this.MnubackupdbClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuabout});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ay&uda";
			// 
			// mnuabout
			// 
			this.mnuabout.Image = ((System.Drawing.Image)(resources.GetObject("mnuabout.Image")));
			this.mnuabout.Name = "mnuabout";
			this.mnuabout.Size = new System.Drawing.Size(152, 22);
			this.mnuabout.Text = "&Acerca de";
			this.mnuabout.Click += new System.EventHandler(this.MnuaboutClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 212);
			this.Controls.Add(this.btnfind);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "ImeiReader";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem mnuabout;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnubackupdb;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuexit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnufindimei;
		private System.Windows.Forms.ToolStripMenuItem mnusaveimei;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button btnfind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textimei;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnsave;
	}
}
