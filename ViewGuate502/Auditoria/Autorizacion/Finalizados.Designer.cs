﻿namespace ViewGuate502.Auditoria
{
    partial class Finalizados
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnaprobar = new DevExpress.XtraEditors.SimpleButton();
            this.btndetalle = new DevExpress.XtraEditors.SimpleButton();
            this.gclistadopendientes = new DevExpress.XtraGrid.GridControl();
            this.auditoriapendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.gvlistadopendientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_venta_enc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenerado_por = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautorizador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_cuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_enganche = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_financiamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaprobaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautorizado_ok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbltitulo = new DevExpress.XtraEditors.LabelControl();
            this.auditoria_pendientesTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.Auditoria_pendientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadopendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriapendientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadopendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnaprobar);
            this.groupControl1.Controls.Add(this.btndetalle);
            this.groupControl1.Controls.Add(this.gclistadopendientes);
            this.groupControl1.Controls.Add(this.lbltitulo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1762, 728);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Finalizados";
            // 
            // btnaprobar
            // 
            this.btnaprobar.Location = new System.Drawing.Point(1525, 618);
            this.btnaprobar.Name = "btnaprobar";
            this.btnaprobar.Size = new System.Drawing.Size(112, 29);
            this.btnaprobar.TabIndex = 4;
            this.btnaprobar.Text = "Info aprobación";
            this.btnaprobar.Click += new System.EventHandler(this.btnaprobar_Click);
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(1643, 618);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(94, 29);
            this.btndetalle.TabIndex = 3;
            this.btndetalle.Text = "Ver detalle";
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // gclistadopendientes
            // 
            this.gclistadopendientes.DataSource = this.auditoriapendientesBindingSource;
            this.gclistadopendientes.Location = new System.Drawing.Point(22, 110);
            this.gclistadopendientes.MainView = this.gvlistadopendientes;
            this.gclistadopendientes.Name = "gclistadopendientes";
            this.gclistadopendientes.Size = new System.Drawing.Size(1715, 485);
            this.gclistadopendientes.TabIndex = 2;
            this.gclistadopendientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadopendientes});
            // 
            // auditoriapendientesBindingSource
            // 
            this.auditoriapendientesBindingSource.DataMember = "Auditoria_pendientes";
            this.auditoriapendientesBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvlistadopendientes
            // 
            this.gvlistadopendientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_venta_enc,
            this.colfecha_creacion,
            this.colenvio,
            this.coltienda,
            this.colgenerado_por,
            this.colvendedor,
            this.colautorizador,
            this.coltotal,
            this.colcantidad_cuotas,
            this.colmonto_enganche,
            this.colmonto_financiamiento,
            this.colaprobaciones,
            this.colautorizado_ok});
            this.gvlistadopendientes.GridControl = this.gclistadopendientes;
            this.gvlistadopendientes.Name = "gvlistadopendientes";
            this.gvlistadopendientes.OptionsBehavior.Editable = false;
            this.gvlistadopendientes.OptionsFind.AlwaysVisible = true;
            this.gvlistadopendientes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadopendientes.OptionsView.ColumnAutoWidth = false;
            this.gvlistadopendientes.OptionsView.ShowGroupPanel = false;
            // 
            // colid_venta_enc
            // 
            this.colid_venta_enc.Caption = "Aprobaciones";
            this.colid_venta_enc.FieldName = "id_venta_enc";
            this.colid_venta_enc.Name = "colid_venta_enc";
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha creación";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 0;
            // 
            // colenvio
            // 
            this.colenvio.Caption = "No- Envío";
            this.colenvio.FieldName = "envio";
            this.colenvio.Name = "colenvio";
            this.colenvio.Visible = true;
            this.colenvio.VisibleIndex = 1;
            // 
            // coltienda
            // 
            this.coltienda.Caption = "Tienda";
            this.coltienda.FieldName = "tienda";
            this.coltienda.Name = "coltienda";
            this.coltienda.Visible = true;
            this.coltienda.VisibleIndex = 2;
            // 
            // colgenerado_por
            // 
            this.colgenerado_por.Caption = "Generado por";
            this.colgenerado_por.FieldName = "generado_por";
            this.colgenerado_por.Name = "colgenerado_por";
            this.colgenerado_por.Visible = true;
            this.colgenerado_por.VisibleIndex = 3;
            // 
            // colvendedor
            // 
            this.colvendedor.Caption = "Vendedor";
            this.colvendedor.FieldName = "vendedor";
            this.colvendedor.Name = "colvendedor";
            this.colvendedor.Visible = true;
            this.colvendedor.VisibleIndex = 4;
            // 
            // colautorizador
            // 
            this.colautorizador.Caption = "Autorizador";
            this.colautorizador.FieldName = "autorizador";
            this.colautorizador.Name = "colautorizador";
            this.colautorizador.Visible = true;
            this.colautorizador.VisibleIndex = 5;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            // 
            // colcantidad_cuotas
            // 
            this.colcantidad_cuotas.Caption = "Cantidad de cuotas";
            this.colcantidad_cuotas.FieldName = "cantidad_cuotas";
            this.colcantidad_cuotas.Name = "colcantidad_cuotas";
            this.colcantidad_cuotas.Visible = true;
            this.colcantidad_cuotas.VisibleIndex = 7;
            // 
            // colmonto_enganche
            // 
            this.colmonto_enganche.Caption = "Enganche";
            this.colmonto_enganche.FieldName = "monto_enganche";
            this.colmonto_enganche.Name = "colmonto_enganche";
            this.colmonto_enganche.Visible = true;
            this.colmonto_enganche.VisibleIndex = 8;
            this.colmonto_enganche.Width = 122;
            // 
            // colmonto_financiamiento
            // 
            this.colmonto_financiamiento.Caption = "Financiamiento";
            this.colmonto_financiamiento.FieldName = "monto_financiamiento";
            this.colmonto_financiamiento.Name = "colmonto_financiamiento";
            this.colmonto_financiamiento.Visible = true;
            this.colmonto_financiamiento.VisibleIndex = 9;
            this.colmonto_financiamiento.Width = 124;
            // 
            // colaprobaciones
            // 
            this.colaprobaciones.Caption = "Aprobaciones";
            this.colaprobaciones.FieldName = "aprobaciones";
            this.colaprobaciones.Name = "colaprobaciones";
            this.colaprobaciones.Visible = true;
            this.colaprobaciones.VisibleIndex = 10;
            this.colaprobaciones.Width = 929;
            // 
            // colautorizado_ok
            // 
            this.colautorizado_ok.Caption = "¿Autorizado correctamente?";
            this.colautorizado_ok.FieldName = "autorizado_ok";
            this.colautorizado_ok.Name = "colautorizado_ok";
            this.colautorizado_ok.Visible = true;
            this.colautorizado_ok.VisibleIndex = 11;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbltitulo.Appearance.Options.UseFont = true;
            this.lbltitulo.Location = new System.Drawing.Point(22, 56);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(367, 36);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Listado de envíos auditados";
            // 
            // auditoria_pendientesTableAdapter
            // 
            this.auditoria_pendientesTableAdapter.ClearBeforeFill = true;
            // 
            // Finalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 728);
            this.Controls.Add(this.groupControl1);
            this.Name = "Finalizados";
            this.Text = "Finalizados";
            this.Load += new System.EventHandler(this.Finalizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadopendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriapendientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadopendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraGrid.GridControl gclistadopendientes;
        public DevExpress.XtraGrid.Views.Grid.GridView gvlistadopendientes;
        private DevExpress.XtraGrid.Columns.GridColumn colid_venta_enc;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colenvio;
        private DevExpress.XtraGrid.Columns.GridColumn coltienda;
        private DevExpress.XtraGrid.Columns.GridColumn colgenerado_por;
        private DevExpress.XtraGrid.Columns.GridColumn colvendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colautorizador;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_cuotas;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_enganche;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_financiamiento;
        private DevExpress.XtraEditors.LabelControl lbltitulo;
        private System.Windows.Forms.BindingSource auditoriapendientesBindingSource;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private dbSoftwareGTDataSetTableAdapters.Auditoria_pendientesTableAdapter auditoria_pendientesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btndetalle;
        private DevExpress.XtraEditors.SimpleButton btnaprobar;
        private DevExpress.XtraGrid.Columns.GridColumn colaprobaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colautorizado_ok;
    }
}