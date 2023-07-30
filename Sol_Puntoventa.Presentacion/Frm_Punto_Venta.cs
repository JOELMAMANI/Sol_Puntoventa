using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
usin
using Sol_Puntoventa.Negocios;

namespace Sol_Puntoventa.Presentacion
{
    public partial class Frm_Punto_Venta : Form
    {
        public Frm_Punto_Venta()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis Metodos"
        private void Formato()
        {
            Dvg_Listado.Columns[0].with = 100;
            Dvg_Listado.Columns[0].HeaderText = "CODIGO_PV";
            Dvg_Listado.Columns[1].with = 350;
            Dvg_Listado.Columns[1].HederText = "PUNTO DE VENTA";
        }


        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_punto_venta.Listado_pv(cTexto);
                this.Formato_pv();
                Lbl_totalregistro.Text = "Total regsitros " + Convert.ToString( Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void Limpia_Texto()
        {

            Txt_descripcion.Text = "";


        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;

        }
        
        private void Estado_Texto(bool lEstado)
        {
            Txt_descripcion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_Guardar.Visible = Lestado;
            Btn_Retomar.Visible = Lestado;
        }
        
        
        #endregion
        private void Frm_Punto_Venta_Load(object sender, EventArgs e)
        {

            this.Listado_pv("%");


        }
       private void Btn_nuevo_Click(object sender, EventArgs e)
        {

            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.Limpia_Texto();
            this.Estado_Texto(true);
            Tbc_principal.SelectedIndex = 1;
            Txt_descripcion.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Limpia_Texto();
            this.Estado_Texto(false);
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tbc_principal.SelectedIndex = 0;
       }



        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            Tbc_principal.SelectedIndex = 0;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_descripcion.Text == string.Empty)
                {
                    MessageBox.Show("Falata ingresar datos requeridos (*)",
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation); 
                }
                else
                {
                    string Rpta = "";
                    E_Punto_Venta oPropiedad = new E_Punto_Venta();
                    oPropiedad.Codigo_pv = this.nCodigo;
                    oPropiedad.Descripcion_pv = Txt_descripcion.Text.Trim();
                    Rpta = N_punto_venta.Guardar_pv(this.Estadoguarda, oPropiedad);
                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente ",
                            "Avisos del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                        this.Limpia_Texto();
                        this.Estado_Texto(false);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_BotonesProcesos(false);
                        this.Estadoguarda = 0;
                        this.Listado_pv("%");
                        Tbc_principal.SelectedIndex = 0;




                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
