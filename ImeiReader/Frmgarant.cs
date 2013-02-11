/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 29/01/2013
 * Hora: 12:44 a.m.
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
	/// Description of Frmgarant.
	/// </summary>
	public partial class Frmgarant : Form{
		static SQLiteConnection conn;
		DataSet dtset= new DataSet();
		string update;
		public Frmgarant(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnbackClick(object sender, EventArgs e){
			this.Close();
		}
		
		void FrmgarantFormClosing(object sender, FormClosingEventArgs e){
			textbimei.Clear();
			dtset.Clear();
		}
		
		void loaddata(){
			string sqlquery="";	
			SQLiteCommand cmd;	
			if(textbimei.Text!=""){
				try{
		            conn =new SQLiteConnection("Data Source=imeidb.sqlite;Version=3;New=False;Compress=True;");
			        conn.Open();		            
		        }catch (Exception ex){
					MessageBox.Show(ex.Message);					
				}
				sqlquery="update regimei set fechagarant="+"'"+update+"'"+" where imeireg="+"'"+textbimei.Text+"'";
				cmd = new SQLiteCommand(sqlquery, conn);
				cmd.ExecuteNonQuery();
				sqlquery="select imeireg as IMEI, fechagarant as 'Fecha Garantia',nombre as Vendedor from regimei, usuarios user where imeireg="+"'"+textbimei.Text+"' and codvend=user.id";									
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlquery, conn);
				dtset.Clear();
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
		
		public void setfecha(string fecha){
			update=fecha;
		}
	}
}
