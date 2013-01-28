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
			BtnsaveClick(sender,e);
		}
		
		void MnufindimeiClick(object sender, EventArgs e){
			BtnfindClick(sender,e);
		}
		
		void MnuexitClick(object sender, EventArgs e){
			conexion.Close();
			Application.Exit();
		}
		
		void MnubackupdbClick(object sender, EventArgs e){
			MessageBox.Show("La función de Backup estará disponible en una futura versión.","IMEIReader",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void MnuaboutClick(object sender, EventArgs e){
			MessageBox.Show("IMEIReader 0.2\nJorge Brunal Perez (AKA Diniremix)\ndiniremix@gmail.com","IMEIReader",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}		
		
		void BtnsaveClick(object sender, EventArgs e){
			string fecha_act=getCurrentDate();
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
		
		string getCurrentDate(){
			string dia,mes,anio;
			dia=DateTime.Today.Day.ToString();			
			mes=DateTime.Today.Month.ToString();
			anio=DateTime.Today.Year.ToString();
			return dia+"/"+mes+"/"+anio;
		}
		
		void BtnfindClick(object sender, EventArgs e){
			fbusq.ShowDialog();
		}
		
		bool checkdb(){		
			if (!File.Exists("imeidb.sqlite")){
				try{
					conexion = new SQLiteConnection("Data Source=imeidb.sqlite;Version=3;New=True;Compress=True;");
					conexion.Open();                  
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
	}
}
