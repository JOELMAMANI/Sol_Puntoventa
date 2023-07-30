namespace Sol_Puntoventa.Presentacion
{
    partial class Frm_Punto_Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Punto_Venta));
            this.Tbc_principal = new System.Windows.Forms.TabControl();
            this.Consultas = new System.Windows.Forms.TabPage();
            this.Mantenimiento = new System.Windows.Forms.TabPage();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Retomar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_totalregistro = new System.Windows.Forms.Label();
            this.Tbc_principal.SuspendLayout();
            this.Consultas.SuspendLayout();
            this.Mantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.Pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_principal
            // 
            this.Tbc_principal.Controls.Add(this.Consultas);
            this.Tbc_principal.Controls.Add(this.Mantenimiento);
            this.Tbc_principal.ItemSize = new System.Drawing.Size(100, 30);
            this.Tbc_principal.Location = new System.Drawing.Point(12, 47);
            this.Tbc_principal.Name = "Tbc_principal";
            this.Tbc_principal.SelectedIndex = 0;
            this.Tbc_principal.Size = new System.Drawing.Size(808, 434);
            this.Tbc_principal.TabIndex = 0;
            // 
            // Consultas
            // 
            this.Consultas.Controls.Add(this.Lbl_totalregistro);
            this.Consultas.Controls.Add(this.button1);
            this.Consultas.Controls.Add(this.Txt_buscar);
            this.Consultas.Controls.Add(this.label1);
            this.Consultas.Controls.Add(this.Dgv_Listado);
            this.Consultas.Location = new System.Drawing.Point(4, 34);
            this.Consultas.Name = "Consultas";
            this.Consultas.Padding = new System.Windows.Forms.Padding(3);
            this.Consultas.Size = new System.Drawing.Size(800, 396);
            this.Consultas.TabIndex = 0;
            this.Consultas.Text = "tabPage1";
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.Controls.Add(this.Btn_Retomar);
            this.Mantenimiento.Controls.Add(this.Btn_Guardar);
            this.Mantenimiento.Controls.Add(this.Btn_cancelar);
            this.Mantenimiento.Controls.Add(this.Txt_descripcion);
            this.Mantenimiento.Controls.Add(this.label2);
            this.Mantenimiento.Location = new System.Drawing.Point(4, 34);
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.Mantenimiento.Size = new System.Drawing.Size(800, 396);
            this.Mantenimiento.TabIndex = 1;
            this.Mantenimiento.Text = "tabPage2";
            this.Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Listado.Location = new System.Drawing.Point(27, 108);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.Size = new System.Drawing.Size(482, 171);
            this.Dgv_Listado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(112, 55);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(184, 20);
            this.Txt_buscar.TabIndex = 2;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(161)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(320, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de Venta:";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(145, 87);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(318, 20);
            this.Txt_descripcion.TabIndex = 1;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_cancelar.Location = new System.Drawing.Point(145, 141);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Guardar.Location = new System.Drawing.Point(258, 141);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Retomar
            // 
            this.Btn_Retomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.Btn_Retomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retomar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Retomar.Location = new System.Drawing.Point(366, 141);
            this.Btn_Retomar.Name = "Btn_Retomar";
            this.Btn_Retomar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Retomar.TabIndex = 4;
            this.Btn_Retomar.Text = "Retornar";
            this.Btn_Retomar.UseVisualStyleBackColor = false;
            this.Btn_Retomar.Click += new System.EventHandler(this.Btn_Retornar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(165)))), ((int)(((byte)(73)))));
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_nuevo.ImageKey = "nuevo.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(40, 495);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(75, 60);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(165)))), ((int)(((byte)(73)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_actualizar.ImageIndex = 1;
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(149, 495);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 60);
            this.Btn_actualizar.TabIndex = 2;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.Btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(165)))), ((int)(((byte)(73)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_eliminar.ImageKey = "eliminar.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(249, 495);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 60);
            this.Btn_eliminar.TabIndex = 3;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.Btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(165)))), ((int)(((byte)(73)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_reporte.ImageKey = "reporte.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(354, 495);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(75, 60);
            this.Btn_reporte.TabIndex = 4;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(165)))), ((int)(((byte)(73)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.ImageKey = "salir.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(450, 495);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 60);
            this.Btn_salir.TabIndex = 5;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            this.Pnl_titulo.Controls.Add(this.label3);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(984, 41);
            this.Pnl_titulo.TabIndex = 6;
            this.Pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Punto de Venta";
            // 
            // Lbl_totalregistro
            // 
            this.Lbl_totalregistro.AutoSize = true;
            this.Lbl_totalregistro.Location = new System.Drawing.Point(392, 310);
            this.Lbl_totalregistro.Name = "Lbl_totalregistro";
            this.Lbl_totalregistro.Size = new System.Drawing.Size(96, 13);
            this.Lbl_totalregistro.TabIndex = 4;
            this.Lbl_totalregistro.Text = "Total Registgros: 0";
            this.Lbl_totalregistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_totalregistro.Click += new System.EventHandler(this.label4_Click);
            // 
            // Frm_Punto_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Tbc_principal);
            this.Name = "Frm_Punto_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Punto_Venta";
            this.Load += new System.EventHandler(this.Frm_Punto_Venta_Load);
            this.Tbc_principal.ResumeLayout(false);
            this.Consultas.ResumeLayout(false);
            this.Consultas.PerformLayout();
            this.Mantenimiento.ResumeLayout(false);
            this.Mantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_principal;
        private System.Windows.Forms.TabPage Consultas;
        private System.Windows.Forms.TabPage Mantenimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.Button Btn_Retomar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_totalregistro;
    }
}