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
            this.MnuItemNuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemListadoVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProformas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemNuevaProforma = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemListadoProformas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTipoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVentasDia = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemRepNuevoAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTotalTienda = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVentasDiaAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemDeudasProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemBalanceDia = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MnuItemDeudaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCierreCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbProductos = new System.Windows.Forms.ToolStripButton();
            this.tsbProveedores = new System.Windows.Forms.ToolStripButton();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVenta = new System.Windows.Forms.ToolStripButton();
            this.tsbListadoVenta = new System.Windows.Forms.ToolStripButton();
            this.separador2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbProforma = new System.Windows.Forms.ToolStripButton();
            this.tsbListadoProforma = new System.Windows.Forms.ToolStripButton();
            this.separador3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbDeudaProveedor = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.usuarioTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.usuarioTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProforma = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuArchivo,
            this.MnuAlmacen,
            this.MnuVentas,
            this.MnuProformas,
            this.MnuPersonas,
            this.MnuReportes,
            this.MnuVer,
            this.MnuVentanas,
            this.MnuHerramientas,
            this.MnuCierreCaja});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.MnuVentanas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(792, 24);
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
            this.MnuItemSalir.Image = global::AppVentas.Properties.Resources.salir;
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
            this.MnuItemCategorias.Image = global::AppVentas.Properties.Resources.categoria;
            this.MnuItemCategorias.Name = "MnuItemCategorias";
            this.MnuItemCategorias.Size = new System.Drawing.Size(139, 22);
            this.MnuItemCategorias.Text = "&Categorías";
            this.MnuItemCategorias.Click += new System.EventHandler(this.MnuItemCategorias_Click);
            // 
            // MnuItemProveedores
            // 
            this.MnuItemProveedores.Image = global::AppVentas.Properties.Resources.proveedor;
            this.MnuItemProveedores.Name = "MnuItemProveedores";
            this.MnuItemProveedores.Size = new System.Drawing.Size(139, 22);
            this.MnuItemProveedores.Text = "&Proveedores";
            this.MnuItemProveedores.Click += new System.EventHandler(this.MnuItemProveedores_Click);
            // 
            // MnuItemProductos
            // 
            this.MnuItemProductos.Image = global::AppVentas.Properties.Resources.producto;
            this.MnuItemProductos.Name = "MnuItemProductos";
            this.MnuItemProductos.Size = new System.Drawing.Size(139, 22);
            this.MnuItemProductos.Text = "Productos";
            this.MnuItemProductos.Click += new System.EventHandler(this.MnuItemProductos_Click);
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemNuevaVenta,
            this.MnuItemListadoVentas});
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Size = new System.Drawing.Size(53, 20);
            this.MnuVentas.Text = "&Ventas";
            // 
            // MnuItemNuevaVenta
            // 
            this.MnuItemNuevaVenta.Image = global::AppVentas.Properties.Resources.venta__2_;
            this.MnuItemNuevaVenta.Name = "MnuItemNuevaVenta";
            this.MnuItemNuevaVenta.Size = new System.Drawing.Size(165, 22);
            this.MnuItemNuevaVenta.Text = "&Nueva Venta";
            this.MnuItemNuevaVenta.Click += new System.EventHandler(this.MnuItemNuevaVenta_Click);
            // 
            // MnuItemListadoVentas
            // 
            this.MnuItemListadoVentas.Image = global::AppVentas.Properties.Resources.listado_venta;
            this.MnuItemListadoVentas.Name = "MnuItemListadoVentas";
            this.MnuItemListadoVentas.Size = new System.Drawing.Size(165, 22);
            this.MnuItemListadoVentas.Text = "&Listado de Ventas";
            this.MnuItemListadoVentas.Click += new System.EventHandler(this.MnuItemListadoVentas_Click);
            // 
            // MnuProformas
            // 
            this.MnuProformas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemNuevaProforma,
            this.MnuItemListadoProformas});
            this.MnuProformas.Name = "MnuProformas";
            this.MnuProformas.Size = new System.Drawing.Size(74, 20);
            this.MnuProformas.Text = "P&roformas";
            // 
            // MnuItemNuevaProforma
            // 
            this.MnuItemNuevaProforma.Image = global::AppVentas.Properties.Resources.proforma;
            this.MnuItemNuevaProforma.Name = "MnuItemNuevaProforma";
            this.MnuItemNuevaProforma.Size = new System.Drawing.Size(186, 22);
            this.MnuItemNuevaProforma.Text = "&Nueva Proforma";
            this.MnuItemNuevaProforma.Click += new System.EventHandler(this.MnuItemNuevaProforma_Click);
            // 
            // MnuItemListadoProformas
            // 
            this.MnuItemListadoProformas.Image = global::AppVentas.Properties.Resources.listado_proforma;
            this.MnuItemListadoProformas.Name = "MnuItemListadoProformas";
            this.MnuItemListadoProformas.Size = new System.Drawing.Size(186, 22);
            this.MnuItemListadoProformas.Text = "&Listado de Proformas";
            this.MnuItemListadoProformas.Click += new System.EventHandler(this.MnuItemListadoProformas_Click);
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
            this.MnuItemClientes.Image = global::AppVentas.Properties.Resources.cliente;
            this.MnuItemClientes.Name = "MnuItemClientes";
            this.MnuItemClientes.Size = new System.Drawing.Size(154, 22);
            this.MnuItemClientes.Text = "&Clientes";
            this.MnuItemClientes.Click += new System.EventHandler(this.MnuItemClientes_Click);
            // 
            // MnuItemUsuarios
            // 
            this.MnuItemUsuarios.Image = global::AppVentas.Properties.Resources.usuario;
            this.MnuItemUsuarios.Name = "MnuItemUsuarios";
            this.MnuItemUsuarios.Size = new System.Drawing.Size(154, 22);
            this.MnuItemUsuarios.Text = "&Usuarios";
            this.MnuItemUsuarios.Click += new System.EventHandler(this.MnuItemUsuarios_Click);
            // 
            // MnuItemTipoCliente
            // 
            this.MnuItemTipoCliente.Image = global::AppVentas.Properties.Resources.tipo_cliente;
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
            this.MnuItemVentasDiaAdm,
            this.MnuItemDeudasProveedores,
            this.MnuItemBalanceDia});
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(65, 20);
            this.MnuReportes.Text = "&Reportes";
            // 
            // MnuItemVentasDia
            // 
            this.MnuItemVentasDia.Image = global::AppVentas.Properties.Resources.reporte__1_;
            this.MnuItemVentasDia.Name = "MnuItemVentasDia";
            this.MnuItemVentasDia.Size = new System.Drawing.Size(237, 22);
            this.MnuItemVentasDia.Text = "&Ventas del Día";
            this.MnuItemVentasDia.Click += new System.EventHandler(this.ventasDelDíaToolStripMenuItem_Click);
            // 
            // MnuItemRepNuevoAlmacen
            // 
            this.MnuItemRepNuevoAlmacen.Image = global::AppVentas.Properties.Resources.reporte__2_;
            this.MnuItemRepNuevoAlmacen.Name = "MnuItemRepNuevoAlmacen";
            this.MnuItemRepNuevoAlmacen.Size = new System.Drawing.Size(237, 22);
            this.MnuItemRepNuevoAlmacen.Text = "Nuevos Productos en Almacén";
            this.MnuItemRepNuevoAlmacen.Click += new System.EventHandler(this.MnuItemRepNuevoAlmacen_Click);
            // 
            // MnuItemTotalTienda
            // 
            this.MnuItemTotalTienda.Image = global::AppVentas.Properties.Resources.reporte__6_;
            this.MnuItemTotalTienda.Name = "MnuItemTotalTienda";
            this.MnuItemTotalTienda.Size = new System.Drawing.Size(237, 22);
            this.MnuItemTotalTienda.Text = "Precio Total Tienda";
            this.MnuItemTotalTienda.Click += new System.EventHandler(this.MnuItemTotalTienda_Click);
            // 
            // MnuItemVentasDiaAdm
            // 
            this.MnuItemVentasDiaAdm.Image = global::AppVentas.Properties.Resources.reporte__4_;
            this.MnuItemVentasDiaAdm.Name = "MnuItemVentasDiaAdm";
            this.MnuItemVentasDiaAdm.Size = new System.Drawing.Size(237, 22);
            this.MnuItemVentasDiaAdm.Text = "Ventas del Día (Administrador)";
            this.MnuItemVentasDiaAdm.Click += new System.EventHandler(this.MnuItemVentasDiaAdm_Click);
            // 
            // MnuItemDeudasProveedores
            // 
            this.MnuItemDeudasProveedores.Image = global::AppVentas.Properties.Resources.reporte__5_;
            this.MnuItemDeudasProveedores.Name = "MnuItemDeudasProveedores";
            this.MnuItemDeudasProveedores.Size = new System.Drawing.Size(237, 22);
            this.MnuItemDeudasProveedores.Text = "Deudas a Proveedores";
            this.MnuItemDeudasProveedores.Click += new System.EventHandler(this.MnuItemDeudasProveedores_Click);
            // 
            // MnuItemBalanceDia
            // 
            this.MnuItemBalanceDia.Image = global::AppVentas.Properties.Resources.reporte__3_;
            this.MnuItemBalanceDia.Name = "MnuItemBalanceDia";
            this.MnuItemBalanceDia.Size = new System.Drawing.Size(237, 22);
            this.MnuItemBalanceDia.Text = "Balance Final Día";
            this.MnuItemBalanceDia.Click += new System.EventHandler(this.MnuItemBalanceDia_Click);
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
            this.MnuItemConfiguracion,
            this.MnuItemDeudaProveedores});
            this.MnuHerramientas.Name = "MnuHerramientas";
            this.MnuHerramientas.Size = new System.Drawing.Size(90, 20);
            this.MnuHerramientas.Text = "Herramientas";
            // 
            // MnuItemConfiguracion
            // 
            this.MnuItemConfiguracion.Name = "MnuItemConfiguracion";
            this.MnuItemConfiguracion.Size = new System.Drawing.Size(180, 22);
            this.MnuItemConfiguracion.Text = "Configuración";
            this.MnuItemConfiguracion.Visible = false;
            this.MnuItemConfiguracion.Click += new System.EventHandler(this.MnuItemConfiguracion_Click);
            // 
            // MnuItemDeudaProveedores
            // 
            this.MnuItemDeudaProveedores.Image = global::AppVentas.Properties.Resources.deuda_proveedor;
            this.MnuItemDeudaProveedores.Name = "MnuItemDeudaProveedores";
            this.MnuItemDeudaProveedores.Size = new System.Drawing.Size(180, 22);
            this.MnuItemDeudaProveedores.Text = "Deuda Proveedores";
            this.MnuItemDeudaProveedores.Click += new System.EventHandler(this.MnuItemDeudaProveedores_Click);
            // 
            // MnuCierreCaja
            // 
            this.MnuCierreCaja.Image = global::AppVentas.Properties.Resources.cierre_caja;
            this.MnuCierreCaja.Name = "MnuCierreCaja";
            this.MnuCierreCaja.Size = new System.Drawing.Size(108, 20);
            this.MnuCierreCaja.Text = "&Cierre de Caja";
            this.MnuCierreCaja.Click += new System.EventHandler(this.MnuCierreCaja_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProductos,
            this.tsbProveedores,
            this.separador1,
            this.tsbVenta,
            this.tsbListadoVenta,
            this.separador2,
            this.tsbProforma,
            this.tsbListadoProforma,
            this.separador3,
            this.tsbClientes,
            this.tsbUsuarios,
            this.tsbDeudaProveedor});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsbProductos
            // 
            this.tsbProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProductos.Image = global::AppVentas.Properties.Resources.producto;
            this.tsbProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductos.Name = "tsbProductos";
            this.tsbProductos.Size = new System.Drawing.Size(23, 22);
            this.tsbProductos.Text = "Productos";
            this.tsbProductos.Click += new System.EventHandler(this.tsbProductos_Click);
            // 
            // tsbProveedores
            // 
            this.tsbProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProveedores.Image = global::AppVentas.Properties.Resources.proveedor;
            this.tsbProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProveedores.Name = "tsbProveedores";
            this.tsbProveedores.Size = new System.Drawing.Size(23, 22);
            this.tsbProveedores.Text = "Proveedores";
            this.tsbProveedores.Click += new System.EventHandler(this.tsbProveedores_Click);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbVenta
            // 
            this.tsbVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVenta.Image = global::AppVentas.Properties.Resources.venta__2_;
            this.tsbVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVenta.Name = "tsbVenta";
            this.tsbVenta.Size = new System.Drawing.Size(23, 22);
            this.tsbVenta.Text = "Nueva Venta";
            this.tsbVenta.Click += new System.EventHandler(this.tsbVenta_Click);
            // 
            // tsbListadoVenta
            // 
            this.tsbListadoVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListadoVenta.Image = global::AppVentas.Properties.Resources.listado_venta;
            this.tsbListadoVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListadoVenta.Name = "tsbListadoVenta";
            this.tsbListadoVenta.Size = new System.Drawing.Size(23, 22);
            this.tsbListadoVenta.Text = "Listado Ventas";
            this.tsbListadoVenta.Click += new System.EventHandler(this.tsbListadoVenta_Click);
            // 
            // separador2
            // 
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbProforma
            // 
            this.tsbProforma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProforma.Image = global::AppVentas.Properties.Resources.proforma;
            this.tsbProforma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProforma.Name = "tsbProforma";
            this.tsbProforma.Size = new System.Drawing.Size(23, 22);
            this.tsbProforma.Text = "Nueva Proforma";
            this.tsbProforma.Click += new System.EventHandler(this.tsbProforma_Click);
            // 
            // tsbListadoProforma
            // 
            this.tsbListadoProforma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListadoProforma.Image = global::AppVentas.Properties.Resources.listado_proforma;
            this.tsbListadoProforma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListadoProforma.Name = "tsbListadoProforma";
            this.tsbListadoProforma.Size = new System.Drawing.Size(23, 22);
            this.tsbListadoProforma.Text = "Listado Proformas";
            this.tsbListadoProforma.Click += new System.EventHandler(this.tsbListadoProforma_Click);
            // 
            // separador3
            // 
            this.separador3.Name = "separador3";
            this.separador3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClientes
            // 
            this.tsbClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClientes.Image = global::AppVentas.Properties.Resources.cliente;
            this.tsbClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClientes.Name = "tsbClientes";
            this.tsbClientes.Size = new System.Drawing.Size(23, 22);
            this.tsbClientes.Text = "Clientes";
            this.tsbClientes.Click += new System.EventHandler(this.tsbClientes_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuarios.Image = global::AppVentas.Properties.Resources.usuario;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(23, 22);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // tsbDeudaProveedor
            // 
            this.tsbDeudaProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeudaProveedor.Image = global::AppVentas.Properties.Resources.deuda_proveedor;
            this.tsbDeudaProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeudaProveedor.Name = "tsbDeudaProveedor";
            this.tsbDeudaProveedor.Size = new System.Drawing.Size(23, 22);
            this.tsbDeudaProveedor.Text = "Deuda Proveedores";
            this.tsbDeudaProveedor.Click += new System.EventHandler(this.tsbDeudaProveedor_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 432);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(792, 22);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProforma);
            this.panel1.Controls.Add(this.btnVenta);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(592, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 383);
            this.panel1.TabIndex = 5;
            // 
            // btnProforma
            // 
            this.btnProforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.btnProforma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProforma.FlatAppearance.BorderSize = 0;
            this.btnProforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProforma.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProforma.Location = new System.Drawing.Point(0, 260);
            this.btnProforma.Name = "btnProforma";
            this.btnProforma.Size = new System.Drawing.Size(200, 65);
            this.btnProforma.TabIndex = 4;
            this.btnProforma.Text = "Nueva Proforma";
            this.btnProforma.UseVisualStyleBackColor = false;
            this.btnProforma.Click += new System.EventHandler(this.btnProforma_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(205)))));
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(0, 195);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(200, 65);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Nueva Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(182)))), ((int)(((byte)(76)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(0, 130);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 65);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(0, 65);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(200, 65);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 65);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::AppVentas.Properties.Resources.Multimarket;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 383);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem MnuItemRepNuevoAlmacen;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTotalTienda;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVentasDiaAdm;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTipoCliente;
        private System.Windows.Forms.ToolStripMenuItem MnuProformas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemNuevaProforma;
        private System.Windows.Forms.ToolStripMenuItem MnuItemListadoProformas;
        private System.Windows.Forms.ToolStripMenuItem MnuCierreCaja;
        private System.Windows.Forms.ToolStripMenuItem MnuItemConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDeudaProveedores;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDeudasProveedores;
        private System.Windows.Forms.ToolStripMenuItem MnuItemBalanceDia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProforma;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.ToolStripButton tsbProductos;
        private System.Windows.Forms.ToolStripButton tsbProveedores;
        private System.Windows.Forms.ToolStripSeparator separador1;
        private System.Windows.Forms.ToolStripButton tsbVenta;
        private System.Windows.Forms.ToolStripButton tsbListadoVenta;
        private System.Windows.Forms.ToolStripSeparator separador2;
        private System.Windows.Forms.ToolStripButton tsbProforma;
        private System.Windows.Forms.ToolStripButton tsbListadoProforma;
        private System.Windows.Forms.ToolStripSeparator separador3;
        private System.Windows.Forms.ToolStripButton tsbClientes;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbDeudaProveedor;
    }
}



