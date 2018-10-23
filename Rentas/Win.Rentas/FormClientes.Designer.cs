namespace Win.Rentas
{
    partial class FormClientes
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label identidadLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoBL_ClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.iDTextBox1 = new System.Windows.Forms.TextBox();
            this.identidadTextBox1 = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.telefonoTextBox1 = new System.Windows.Forms.TextBox();
            this.mantenimientoBL_ClienteDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            activoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            identidadLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_ClienteBindingSource1BindingNavigator)).BeginInit();
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_ClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_ClienteDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.BackColor = System.Drawing.Color.Transparent;
            activoLabel.Location = new System.Drawing.Point(23, 203);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Location = new System.Drawing.Point(23, 180);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Location = new System.Drawing.Point(23, 76);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // identidadLabel
            // 
            identidadLabel.AutoSize = true;
            identidadLabel.BackColor = System.Drawing.Color.Transparent;
            identidadLabel.Location = new System.Drawing.Point(23, 128);
            identidadLabel.Name = "identidadLabel";
            identidadLabel.Size = new System.Drawing.Size(54, 13);
            identidadLabel.TabIndex = 7;
            identidadLabel.Text = "Identidad:";
            identidadLabel.Click += new System.EventHandler(this.identidadLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(23, 102);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.Location = new System.Drawing.Point(23, 154);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono:";
            // 
            // mantenimientoBL_ClienteBindingSource1BindingNavigator
            // 
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.AddNewItem = this.toolStripButton6;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.BindingSource = this.mantenimientoBL_ClienteBindingSource1;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.DeleteItem = this.toolStripButton7;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton6,
            this.toolStripButton7,
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton2;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton5;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton4;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton3;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.Name = "mantenimientoBL_ClienteBindingSource1BindingNavigator";
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.Size = new System.Drawing.Size(766, 25);
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.TabIndex = 0;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.Text = "bindingNavigator2";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Agregar nuevo";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // mantenimientoBL_ClienteBindingSource1
            // 
            this.mantenimientoBL_ClienteBindingSource1.DataSource = typeof(BLClintes.MantenimientoBL.Cliente);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de elementos";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Eliminar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Mover primero";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posición";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posición actual";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover siguiente";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem
            // 
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.Image")));
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.Name = "mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem";
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos";
            this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            // 
            // activoCheckBox1
            // 
            this.activoCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBL_ClienteBindingSource1, "Activo", true));
            this.activoCheckBox1.Location = new System.Drawing.Point(83, 203);
            this.activoCheckBox1.Name = "activoCheckBox1";
            this.activoCheckBox1.Size = new System.Drawing.Size(191, 21);
            this.activoCheckBox1.TabIndex = 5;
            this.activoCheckBox1.UseVisualStyleBackColor = false;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_ClienteBindingSource1, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(83, 177);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(191, 20);
            this.emailTextBox1.TabIndex = 4;
            // 
            // iDTextBox1
            // 
            this.iDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_ClienteBindingSource1, "ID", true));
            this.iDTextBox1.Enabled = false;
            this.iDTextBox1.Location = new System.Drawing.Point(83, 73);
            this.iDTextBox1.Name = "iDTextBox1";
            this.iDTextBox1.Size = new System.Drawing.Size(191, 20);
            this.iDTextBox1.TabIndex = 1;
            // 
            // identidadTextBox1
            // 
            this.identidadTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_ClienteBindingSource1, "Identidad", true));
            this.identidadTextBox1.Location = new System.Drawing.Point(83, 125);
            this.identidadTextBox1.Name = "identidadTextBox1";
            this.identidadTextBox1.Size = new System.Drawing.Size(191, 20);
            this.identidadTextBox1.TabIndex = 2;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_ClienteBindingSource1, "Nombre", true));
            this.nombreTextBox1.Location = new System.Drawing.Point(83, 99);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(191, 20);
            this.nombreTextBox1.TabIndex = 1;
            // 
            // telefonoTextBox1
            // 
            this.telefonoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_ClienteBindingSource1, "Telefono", true));
            this.telefonoTextBox1.Location = new System.Drawing.Point(83, 151);
            this.telefonoTextBox1.Name = "telefonoTextBox1";
            this.telefonoTextBox1.Size = new System.Drawing.Size(191, 20);
            this.telefonoTextBox1.TabIndex = 3;
            // 
            // mantenimientoBL_ClienteDataGridView1
            // 
            this.mantenimientoBL_ClienteDataGridView1.AutoGenerateColumns = false;
            this.mantenimientoBL_ClienteDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mantenimientoBL_ClienteDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.mantenimientoBL_ClienteDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mantenimientoBL_ClienteDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn2});
            this.mantenimientoBL_ClienteDataGridView1.DataSource = this.mantenimientoBL_ClienteBindingSource1;
            this.mantenimientoBL_ClienteDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mantenimientoBL_ClienteDataGridView1.Location = new System.Drawing.Point(0, 274);
            this.mantenimientoBL_ClienteDataGridView1.Name = "mantenimientoBL_ClienteDataGridView1";
            this.mantenimientoBL_ClienteDataGridView1.Size = new System.Drawing.Size(766, 366);
            this.mantenimientoBL_ClienteDataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Identidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Identidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn10.HeaderText = "Email";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // FormClientes
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 640);
            this.Controls.Add(this.mantenimientoBL_ClienteDataGridView1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox1);
            this.Controls.Add(identidadLabel);
            this.Controls.Add(this.identidadTextBox1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox1);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox1);
            this.Controls.Add(this.mantenimientoBL_ClienteBindingSource1BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientes";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_ClienteBindingSource1BindingNavigator)).EndInit();
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.ResumeLayout(false);
            this.mantenimientoBL_ClienteBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_ClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_ClienteDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listaClienteBindingSource;
        private System.Windows.Forms.BindingSource mantenimientoBL_ClienteBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView mantenimientoBL_ClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox identidadTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripButton guardarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ayudaToolStripButton;
        private System.Windows.Forms.BindingSource listaClienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource mantenimientoBL_ClienteBindingSource1;
        private System.Windows.Forms.BindingNavigator mantenimientoBL_ClienteBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox iDTextBox1;
        private System.Windows.Forms.TextBox identidadTextBox1;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox telefonoTextBox1;
        private System.Windows.Forms.DataGridView mantenimientoBL_ClienteDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}