/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 26/01/2013
 * Hora: 11:40 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ImeiReader{
	/// <summary>
	/// Description of Frmbusq.
	/// </summary>
	public partial class Frmbusq : Form{
		static SQLiteConnection conn;
		DataSet dtset= new DataSet();
		public Frmbusq(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnbackClick(object sender, EventArgs e){
			textbimei.Clear();
			dtset.Clear();
			this.Close();
		}
		
		void loaddata(){
			string sqlquery;		
			if(textbimei.Text!=""){
				try{
		            conn =new SQLiteConnection("Data Source=imeidb.sqlite;Version=3;New=False;Compress=True;");
			        conn.Open();		            
		        }catch (Exception ex){
					MessageBox.Show(ex.Message);					
				}
				sqlquery="select imeireg as IMEI, fechareg as Fecha from regimei where imeireg="+"'"+textbimei.Text+"'";
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlquery, conn);
				adapter.Fill(dtset);
				resultGrid.DataSource = dtset.Tables[0].DefaultView;
				conn.Close();
			}else{
				textbimei.Focus();
			}
		}
		
		void TextbimeiTextChanged(object sender, EventArgs e){
			loaddata();
		}
	}
}
