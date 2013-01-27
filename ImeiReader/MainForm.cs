/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 26/01/2013
 * Hora: 11:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ImeiReader{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form{
		static SQLiteConnection conexion;
		Frmbusq fbusq= new Frmbusq();
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		
		void MainFormLoad(object sender, EventArgs e){
			textimei.Focus();
		}
		
		void MnusaveimeiClick(object sender, EventArgs e){
			//save
			BtnsaveClick(sender,e);
		}
		
		void MnufindimeiClick(object sender, EventArgs e){
			//buscar
			BtnfindClick(sender,e);
		}
		
		void MnuexitClick(object sender, EventArgs e){
			Application.Exit();
		}
		
		void MnubackupdbClick(object sender, EventArgs e){
			//backup
		}
		
		void MnuaboutClick(object sender, EventArgs e){
			//about
		}		
		
		void BtnsaveClick(object sender, EventArgs e){
			//save
			
		}
		
		void BtnfindClick(object sender, EventArgs e){
			fbusq.ShowDialog();
		}
		
		//database function
		bool checkdb(){
			
			return false;
		}
	}
}
