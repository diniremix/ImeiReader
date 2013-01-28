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
		string sqlquery;
		int result=0;
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
			if(!checkdb()){
				MnuexitClick(sender,e);
			}
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
			MessageBox.Show("IMEIReader 0.1\nJorge Brunal Perez\ndiniremix@gmail.com","IMEIReader",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}		
		
		void BtnsaveClick(object sender, EventArgs e){
			string dia,mes,anio,fecha_act;
			dia=DateTime.Today.Day.ToString();			
			mes=DateTime.Today.Month.ToString();
			anio=DateTime.Today.Year.ToString();
			fecha_act=dia+"/"+mes+"/"+anio;
			
			if(textimei.Text!=""){
				try{
					SQLiteCommand cmd;				
					sqlquery = "INSERT INTO regimei(imeireg,fechareg) "+
						"VALUES  ("+ "'"+textimei.Text+"'"+",'"+fecha_act+"')";
					cmd = new SQLiteCommand(sqlquery, conexion);
					result = cmd.ExecuteNonQuery();
					textimei.Clear();					
				}catch (Exception ex){
					MessageBox.Show("Ocurrio un Error al guardar el IMEI en la Base de Datos\n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}			
			textimei.Focus();
		}
		
		void BtnfindClick(object sender, EventArgs e){
			//conexion.Close();
			fbusq.ShowDialog();
		}
		
		//database functions
		bool checkdb(){		
			if (!File.Exists("imeidb.sqlite")){
				try{
					// Creamos la conexion a la BD.
					// El Data Source contiene la ruta del archivo de la BD 				
					conexion = new SQLiteConnection("Data Source=imeidb.sqlite;Version=3;New=True;Compress=True;");
					conexion.Open();                  
					// Creamos la tabla regimei
					string sqlquery = "CREATE TABLE IF NOT EXISTS regimei "
					+"(id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, imeireg VARCHAR(30) NOT NULL, fechareg VARCHAR(10) NOT NULL)";
					SQLiteCommand cmd = new SQLiteCommand(sqlquery, conexion);
					result=cmd.ExecuteNonQuery();
					textimei.Text=result.ToString();
					if (result< 1){
						MessageBox.Show("Ocurrio un Error al crear la Base de Datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return false;
					}else{
						return true;
					}
				}catch (Exception ex){
					MessageBox.Show(ex.Message);
					return false;
				}
	        }else{
	            // Creamos la conexion a la BD. 
	            // El Data Source contiene la ruta del archivo de la BD 
	            try{
	            	conexion =new SQLiteConnection("Data Source=imeidb.sqlite;Version=3;New=False;Compress=True;");
		            conexion.Open();
		            return true;
	            }catch (Exception ex){
					MessageBox.Show(ex.Message);
					return false;
				}
	        }
		}
		
		void TextimeiTextChanged(object sender, EventArgs e){
			//onchange
		}
	}
}
