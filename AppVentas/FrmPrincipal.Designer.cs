namespace AppVentas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemListadoVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemNuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTipoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVentasDia = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemRepNuevoAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTotalTienda = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVentasDiaAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuItemCerrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.usuarioTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.usuarioTableAdapter();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuArchivo,
            this.MnuAlmacen,
            this.MnuVentas,
            this.MnuPersonas,
            this.MnuReportes,
            this.MnuVer,
            this.MnuVentanas,
            this.MnuHerramientas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.MnuVentanas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(644, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuArchivo
            // 
            this.MnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemSalir});
            this.MnuArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MnuArchivo.Name = "MnuArchivo";
            this.MnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.MnuArchivo.Text = "&Archivo";
            // 
            // MnuItemSalir
            // 
            this.MnuItemSalir.Name = "MnuItemSalir";
            this.MnuItemSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnuItemSalir.Size = new System.Drawing.Size(138, 22);
            this.MnuItemSalir.Text = "&Salir";
            this.MnuItemSalir.Click += new System.EventHandler(this.MnuItemSalir_Click);
            // 
            // MnuAlmacen
            // 
            this.MnuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCategorias,
            this.MnuItemProveedores,
            this.MnuItemProductos});
            this.MnuAlmacen.Name = "MnuAlmacen";
            this.MnuAlmacen.Size = new System.Drawing.Size(66, 20);
            this.MnuAlmacen.Text = "&Almacen";
            // 
            // MnuItemCategorias
            // 
            this.MnuItemCategorias.Name = "MnuItemCategorias";
            this.MnuItemCategorias.Size = new System.Drawing.Size(139, 22);
            this.MnuItemCategorias.Text = "&Categorías";
            this.MnuItemCategorias.Click += new System.EventHandler(this.MnuItemCategorias_Click);
            // 
            // MnuItemProveedores
            // 
            this.MnuItemProveedores.Name = "MnuItemProveedores";
            this.MnuItemProveedores.Size = new System.Drawing.Size(139, 22);
            this.MnuItemProveedores.Text = "&Proveedores";
            this.MnuItemProveedores.Click += new System.EventHandler(this.MnuItemProveedores_Click);
            // 
            // MnuItemProductos
            // 
            this.MnuItemProductos.Name = "MnuItemProductos";
            this.MnuItemProductos.Size = new System.Drawing.Size(139, 22);
            this.MnuItemProductos.Text = "Productos";
            this.MnuItemProductos.Click += new System.EventHandler(this.MnuItemProductos_Click);
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemListadoVentas,
            this.MnuItemNuevaVenta});
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Size = new System.Drawing.Size(53, 20);
            this.MnuVentas.Text = "&Ventas";
            // 
            // MnuItemListadoVentas
            // 
            this.MnuItemListadoVentas.Name = "MnuItemListadoVentas";
            this.MnuItemListadoVentas.Size = new System.Drawing.Size(165, 22);
            this.MnuItemListadoVentas.Text = "&Listado de Ventas";
            this.MnuItemListadoVentas.Click += new System.EventHandler(this.MnuItemListadoVentas_Click);
            // 
            // MnuItemNuevaVenta
            // 
            this.MnuItemNuevaVenta.Name = "MnuItemNuevaVenta";
            this.MnuItemNuevaVenta.Size = new System.Drawing.Size(165, 22);
            this.MnuItemNuevaVenta.Text = "&Nueva Venta";
            this.MnuItemNuevaVenta.Click += new System.EventHandler(this.MnuItemNuevaVenta_Click);
            // 
            // MnuPersonas
            // 
            this.MnuPersonas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemClientes,
            this.MnuItemUsuarios,
            this.MnuItemTipoCliente});
            this.MnuPersonas.Name = "MnuPersonas";
            this.MnuPersonas.Size = new System.Drawing.Size(66, 20);
            this.MnuPersonas.Text = "&Personas";
            // 
            // MnuItemClientes
            // 
            this.MnuItemClientes.Name = "MnuItemClientes";
            this.MnuItemClientes.Size = new System.Drawing.Size(154, 22);
            this.MnuItemClientes.Text = "&Clientes";
            this.MnuItemClientes.Click += new System.EventHandler(this.MnuItemClientes_Click);
            // 
            // MnuItemUsuarios
            // 
            this.MnuItemUsuarios.Name = "MnuItemUsuarios";
            this.MnuItemUsuarios.Size = new System.Drawing.Size(154, 22);
            this.MnuItemUsuarios.Text = "&Usuarios";
            this.MnuItemUsuarios.Click += new System.EventHandler(this.MnuItemUsuarios_Click);
            // 
            // MnuItemTipoCliente
            // 
            this.MnuItemTipoCliente.Name = "MnuItemTipoCliente";
            this.MnuItemTipoCliente.Size = new System.Drawing.Size(154, 22);
            this.MnuItemTipoCliente.Text = "&Tipo de Cliente";
            this.MnuItemTipoCliente.Click += new System.EventHandler(this.MnuItemTipoCliente_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemVentasDia,
            this.MnuItemRepNuevoAlmacen,
            this.MnuItemTotalTienda,
            this.MnuItemVentasDiaAdm});
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(65, 20);
            this.MnuReportes.Text = "&Reportes";
            // 
            // MnuItemVentasDia
            // 
            this.MnuItemVentasDia.Name = "MnuItemVentasDia";
            this.MnuItemVentasDia.Size = new System.Drawing.Size(237, 22);
            this.MnuItemVentasDia.Text = "&Ventas del Día";
            this.MnuItemVentasDia.Click += new System.EventHandler(this.ventasDelDíaToolStripMenuItem_Click);
            // 
            // MnuItemRepNuevoAlmacen
            // 
            this.MnuItemRepNuevoAlmacen.Name = "MnuItemRepNuevoAlmacen";
            this.MnuItemRepNuevoAlmacen.Size = new System.Drawing.Size(237, 22);
            this.MnuItemRepNuevoAlmacen.Text = "Nuevos Productos en Almacén";
            this.MnuItemRepNuevoAlmacen.Click += new System.EventHandler(this.MnuItemRepNuevoAlmacen_Click);
            // 
            // MnuItemTotalTienda
            // 
            this.MnuItemTotalTienda.Name = "MnuItemTotalTienda";
            this.MnuItemTotalTienda.Size = new System.Drawing.Size(237, 22);
            this.MnuItemTotalTienda.Text = "Precio Total Tienda";
            this.MnuItemTotalTienda.Click += new System.EventHandler(this.MnuItemTotalTienda_Click);
            // 
            // MnuItemVentasDiaAdm
            // 
            this.MnuItemVentasDiaAdm.Name = "MnuItemVentasDiaAdm";
            this.MnuItemVentasDiaAdm.Size = new System.Drawing.Size(237, 22);
            this.MnuItemVentasDiaAdm.Text = "Ventas del Día (Administrador)";
            this.MnuItemVentasDiaAdm.Click += new System.EventHandler(this.MnuItemVentasDiaAdm_Click);
            // 
            // MnuVer
            // 
            this.MnuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemHerramientas,
            this.MnuItemEstado});
            this.MnuVer.Name = "MnuVer";
            this.MnuVer.Size = new System.Drawing.Size(35, 20);
            this.MnuVer.Text = "&Ver";
            // 
            // MnuItemHerramientas
            // 
            this.MnuItemHerramientas.Checked = true;
            this.MnuItemHerramientas.CheckOnClick = true;
            this.MnuItemHerramientas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuItemHerramientas.Name = "MnuItemHerramientas";
            this.MnuItemHerramientas.Size = new System.Drawing.Size(189, 22);
            this.MnuItemHerramientas.Text = "&Barra de herramientas";
            this.MnuItemHerramientas.Click += new System.EventHandler(this.MnuItemHerramientas_Click);
            // 
            // MnuItemEstado
            // 
            this.MnuItemEstado.Checked = true;
            this.MnuItemEstado.CheckOnClick = true;
            this.MnuItemEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuItemEstado.Name = "MnuItemEstado";
            this.MnuItemEstado.Size = new System.Drawing.Size(189, 22);
            this.MnuItemEstado.Text = "&Barra de estado";
            this.MnuItemEstado.Click += new System.EventHandler(this.MnuItemEstado_Click);
            // 
            // MnuVentanas
            // 
            this.MnuVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCascada,
            this.MnuItemVertical,
            this.MnuItemHorizontal,
            this.toolStripSeparator3,
            this.MnuItemCerrarTodo});
            this.MnuVentanas.Name = "MnuVentanas";
            this.MnuVentanas.Size = new System.Drawing.Size(66, 20);
            this.MnuVentanas.Text = "&Ventanas";
            // 
            // MnuItemCascada
            // 
            this.MnuItemCascada.Name = "MnuItemCascada";
            this.MnuItemCascada.Size = new System.Drawing.Size(175, 22);
            this.MnuItemCascada.Text = "&Cascada";
            this.MnuItemCascada.Click += new System.EventHandler(this.MnuItemCascada_Click);
            // 
            // MnuItemVertical
            // 
            this.MnuItemVertical.Name = "MnuItemVertical";
            this.MnuItemVertical.Size = new System.Drawing.Size(175, 22);
            this.MnuItemVertical.Text = "Mosaico &vertical";
            this.MnuItemVertical.Click += new System.EventHandler(this.MnuItemVertical_Click);
            // 
            // MnuItemHorizontal
            // 
            this.MnuItemHorizontal.Name = "MnuItemHorizontal";
            this.MnuItemHorizontal.Size = new System.Drawing.Size(175, 22);
            this.MnuItemHorizontal.Text = "Mosaico &horizontal";
            this.MnuItemHorizontal.Click += new System.EventHandler(this.MnuItemHorizontal_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // MnuItemCerrarTodo
            // 
            this.MnuItemCerrarTodo.Name = "MnuItemCerrarTodo";
            this.MnuItemCerrarTodo.Size = new System.Drawing.Size(175, 22);
            this.MnuItemCerrarTodo.Text = "C&errar todo";
            this.MnuItemCerrarTodo.Click += new System.EventHandler(this.MnuItemCerrarTodo_Click);
            // 
            // MnuHerramientas
            // 
            this.MnuHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemConfiguracion});
            this.MnuHerramientas.Name = "MnuHerramientas";
            this.MnuHerramientas.Size = new System.Drawing.Size(90, 20);
            this.MnuHerramientas.Text = "Herramientas";
            // 
            // MnuItemConfiguracion
            // 
            this.MnuItemConfiguracion.Name = "MnuItemConfiguracion";
            this.MnuItemConfiguracion.Size = new System.Drawing.Size(150, 22);
            this.MnuItemConfiguracion.Text = "Configuración";
            this.MnuItemConfiguracion.Click += new System.EventHandler(this.MnuItemConfiguracion_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(644, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 379);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(644, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 401);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MnuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem MnuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuVer;
        private System.Windows.Forms.ToolStripMenuItem MnuItemHerramientas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemEstado;
        private System.Windows.Forms.ToolStripMenuItem MnuVentanas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCascada;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVertical;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCerrarTodo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MnuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCategorias;
        private System.Windows.Forms.ToolStripMenuItem MnuItemProveedores;
        private System.Windows.Forms.ToolStripMenuItem MnuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem MnuVentas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemListadoVentas;
        private System.Windows.Forms.ToolStripMenuItem MnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MnuItemNuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVentasDia;
        private dbsisventasDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem MnuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem MnuItemRepNuevoAlmacen;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTotalTienda;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVentasDiaAdm;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTipoCliente;
    }
}



