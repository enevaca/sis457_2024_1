namespace CpMinerva
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProveedores = new C1.Win.Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCVComparas = new C1.Win.Ribbon.RibbonButton();
            this.btnCVVentas = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCVArqueoDiario = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTab4 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAdUsuarios = new C1.Win.Ribbon.RibbonButton();
            this.btnAdMenus = new C1.Win.Ribbon.RibbonButton();
            this.btnAdRoles = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab5 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup6 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonButton9 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton10 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1053, 241);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab5);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Items.Add(this.btnCaProveedores);
            this.ribbonGroup1.Items.Add(this.btnCaClientes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Administración de Catálogoos";
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("AccessBackEnd", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 1));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // btnCaProveedores
            // 
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProveedores.IconSet")))));
            this.btnCaProveedores.Name = "btnCaProveedores";
            this.btnCaProveedores.Text = "Proveedores";
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaClientes.IconSet")))));
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.Text = "Clientes";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Groups.Add(this.ribbonGroup3);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Compras/Ventas";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnCVComparas);
            this.ribbonGroup2.Items.Add(this.btnCVVentas);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Registro de Compras y Ventas";
            // 
            // btnCVComparas
            // 
            this.btnCVComparas.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCVComparas.IconSet.Add(new C1.Framework.C1BitmapIcon("FromDatabase", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 104));
            this.btnCVComparas.Name = "btnCVComparas";
            this.btnCVComparas.Text = "Compras";
            // 
            // btnCVVentas
            // 
            this.btnCVVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCVVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("TopBottomRules", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 322));
            this.btnCVVentas.Name = "btnCVVentas";
            this.btnCVVentas.Text = "Ventas";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnCVArqueoDiario);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Arqueo";
            // 
            // btnCVArqueoDiario
            // 
            this.btnCVArqueoDiario.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCVArqueoDiario.IconSet.Add(new C1.Framework.C1BitmapIcon("SmartArt", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 289));
            this.btnCVArqueoDiario.Name = "btnCVArqueoDiario";
            this.btnCVArqueoDiario.Text = "Arqueo Diario";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup4);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Reportes";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Group";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup5);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Administración";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.btnAdUsuarios);
            this.ribbonGroup5.Items.Add(this.btnAdMenus);
            this.ribbonGroup5.Items.Add(this.btnAdRoles);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Gestión y Configuraciones";
            // 
            // btnAdUsuarios
            // 
            this.btnAdUsuarios.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdUsuarios.IconSet.Add(new C1.Framework.C1BitmapIcon("Users", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 332));
            this.btnAdUsuarios.Name = "btnAdUsuarios";
            this.btnAdUsuarios.Text = "Usuarios";
            // 
            // btnAdMenus
            // 
            this.btnAdMenus.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdMenus.IconSet.Add(new C1.Framework.C1BitmapIcon("OtherOptions", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 189));
            this.btnAdMenus.Name = "btnAdMenus";
            this.btnAdMenus.Text = "Menús";
            // 
            // btnAdRoles
            // 
            this.btnAdRoles.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdRoles.IconSet.Add(new C1.Framework.C1BitmapIcon("Send", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 275));
            this.btnAdRoles.Name = "btnAdRoles";
            this.btnAdRoles.Text = "Roles";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Groups.Add(this.ribbonGroup6);
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Text = "Ayuda";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.ribbonButton9);
            this.ribbonGroup6.Items.Add(this.ribbonButton10);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Acerca del Sistema";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton9.IconSet.Add(new C1.Framework.C1BitmapIcon("AddressBook", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 3));
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.Text = "Manual de Usuario";
            // 
            // ribbonButton10
            // 
            this.ribbonButton10.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton10.IconSet.Add(new C1.Framework.C1BitmapIcon("Info1", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 140));
            this.ribbonButton10.Name = "ribbonButton10";
            this.ribbonButton10.Text = "Acerca De...";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpMinerva.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 241);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Minerva - Principal :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonButton btnCaProveedores;
        private C1.Win.Ribbon.RibbonButton btnCaClientes;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnCVComparas;
        private C1.Win.Ribbon.RibbonButton btnCVVentas;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonButton btnCVArqueoDiario;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonTab ribbonTab4;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton btnAdUsuarios;
        private C1.Win.Ribbon.RibbonButton btnAdMenus;
        private C1.Win.Ribbon.RibbonButton btnAdRoles;
        private C1.Win.Ribbon.RibbonTab ribbonTab5;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup6;
        private C1.Win.Ribbon.RibbonButton ribbonButton9;
        private C1.Win.Ribbon.RibbonButton ribbonButton10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}