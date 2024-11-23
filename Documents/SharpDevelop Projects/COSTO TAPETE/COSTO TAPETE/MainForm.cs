/*
 * Created by SharpDevelop.
 * User: CC2_PC12
 * Date: 20/11/2024
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace COSTO_TAPETE
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// Se almacena los datos en un string y con double para poder 
		// hacer la operación del precio del tapete.
		
		// El area
        string LARGO = "";
        double largo = 0;
        string ANCHO = "";
        double anchoo = 0;
        // kg de frutos secos
        string FRUTOSSEC = "";
        double frutossec = 0;
        // El precio del alimento de los trabajadores
        string PERSONASAL = "";
        double personasal = 0;
        // Bultos de aserrin 
        string BULTOSASE ="";
        double bultoase = 0;
        // Docena de flores
        string FLORESDOC = "";
        double floresdoc = 0;
        // Las horas de trabajo
        string HORATR = "";
        double horatr  = 0;
		// El litro de pintura
        string PINTURA = "";
        double pinturaa = 0;
		// Litro de agua
        string LIAGUA = "";
        double liagua = 0;
		// Costo de mano de obra
        string MANOOBRA = "";
        double manoobra = 0;
		// Se guarda la variable para después poder hacer el calculo del precio.
        double CALCULO;
        
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		// Lo que se hará al clickear el botón de calcular los precios
		void Button2Click(object sender, EventArgs e)
		{
			// Se conectan con las cajas de texto y se pasa de string a double con el double.Parse
			
			// Area del tapete
			LARGO = txtlargo.Text;
			largo = double.Parse(LARGO);
			ANCHO = txtancho.Text;
			anchoo = double.Parse(ANCHO);
			// Frutos secos
			FRUTOSSEC = txtkgfrutos.Text;
			frutossec = double.Parse(FRUTOSSEC);
			// Costo de los alimentos de los trabajadores
			PERSONASAL = txtpersonasalimen.Text;
			personasal = double.Parse(PERSONASAL);
			// Bultos de aserrín
			BULTOSASE = txtnumbulto.Text;
			bultoase = double.Parse(BULTOSASE);
			// Docena de flores
			FLORESDOC = txtdocenasflores.Text;
			floresdoc = double.Parse(FLORESDOC);
			// Las horas de trabajo
			HORATR = txtnumhora.Text;
			horatr = double.Parse(HORATR);
			// Litro de pintura
			PINTURA = txtlitropin.Text;
			pinturaa = double.Parse(PINTURA);
			// Litro de agua
			LIAGUA = txtlitroagua.Text;
			liagua = double.Parse(LIAGUA);
			// Mano de obra
			MANOOBRA = txtmanoobra.Text;
			manoobra = double.Parse(MANOOBRA);
			// La operación para calcular el precio
			CALCULO = ((largo+anchoo)*100)+(frutossec*30)+(personasal*140)+(bultoase*80)+(floresdoc*120)+(pinturaa*150)+(liagua*40)+((manoobra*horatr)*personasal);
			// Se muestra el precio del tapete en una ventana emergente
			MessageBox.Show("El precio del tapete en total fue:" + CALCULO.ToString()); 
		}
	}
}
