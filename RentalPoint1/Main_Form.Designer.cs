namespace RentalPoint1
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientPaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsPopularityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsPopularityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableLabel = new System.Windows.Forms.Label();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.SortType_groupBox = new System.Windows.Forms.GroupBox();
            this.DESC_radioButton = new System.Windows.Forms.RadioButton();
            this.ASC_radioButton = new System.Windows.Forms.RadioButton();
            this.Client_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.Model_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.Brand_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.ModelType_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.Producer_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.Detail_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.Good_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.DiscountType_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.GridControls_groupBox = new System.Windows.Forms.GroupBox();
            this.attachmentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.AttachmentTableAdapter();
            this.brandTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.BrandTableAdapter();
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.discountTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DiscountTypeTableAdapter();
            this.goodTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.GoodTableAdapter();
            this.modelTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTableAdapter();
            this.modelTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTypeTableAdapter();
            this.orderTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.OrderTableAdapter();
            this.producerTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProducerTableAdapter();
            this.productTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProductTableAdapter();
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.setTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.SetTableAdapter();
            this.Set_button = new System.Windows.Forms.Button();
            this.Order_Sort_groupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            this.SortType_groupBox.SuspendLayout();
            this.GridControls_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.brandToolStripMenuItem,
            this.modelTypeToolStripMenuItem,
            this.producerToolStripMenuItem,
            this.productToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.discountTypeToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.dataToolStripMenuItem.Text = "Database";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clientsToolStripMenuItem.Text = "Client";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.brandToolStripMenuItem.Text = "Brand";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // modelTypeToolStripMenuItem
            // 
            this.modelTypeToolStripMenuItem.Name = "modelTypeToolStripMenuItem";
            this.modelTypeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.modelTypeToolStripMenuItem.Text = "ModelType";
            this.modelTypeToolStripMenuItem.Click += new System.EventHandler(this.modelTypeToolStripMenuItem_Click);
            // 
            // producerToolStripMenuItem
            // 
            this.producerToolStripMenuItem.Name = "producerToolStripMenuItem";
            this.producerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.producerToolStripMenuItem.Text = "Producer";
            this.producerToolStripMenuItem.Click += new System.EventHandler(this.producerToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.goodsToolStripMenuItem.Text = "Good";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // discountTypeToolStripMenuItem
            // 
            this.discountTypeToolStripMenuItem.Name = "discountTypeToolStripMenuItem";
            this.discountTypeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.discountTypeToolStripMenuItem.Text = "DiscountType";
            this.discountTypeToolStripMenuItem.Click += new System.EventHandler(this.discountTypeToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAnOrderToolStripMenuItem,
            this.makeAReturnToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // makeAnOrderToolStripMenuItem
            // 
            this.makeAnOrderToolStripMenuItem.Name = "makeAnOrderToolStripMenuItem";
            this.makeAnOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.makeAnOrderToolStripMenuItem.Text = "Make an order";
            this.makeAnOrderToolStripMenuItem.Click += new System.EventHandler(this.makeAnOrderToolStripMenuItem_Click);
            // 
            // makeAReturnToolStripMenuItem
            // 
            this.makeAReturnToolStripMenuItem.Name = "makeAReturnToolStripMenuItem";
            this.makeAReturnToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.makeAReturnToolStripMenuItem.Text = "Make a return";
            this.makeAReturnToolStripMenuItem.Click += new System.EventHandler(this.makeAReturnToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qeToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // qeToolStripMenuItem
            // 
            this.qeToolStripMenuItem.Name = "qeToolStripMenuItem";
            this.qeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.qeToolStripMenuItem.Text = "Query Edit";
            this.qeToolStripMenuItem.Click += new System.EventHandler(this.QueryEdit_ToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientActivityToolStripMenuItem,
            this.clientPaidToolStripMenuItem,
            this.detailsPopularityToolStripMenuItem,
            this.productsPopularityToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // clientActivityToolStripMenuItem
            // 
            this.clientActivityToolStripMenuItem.Name = "clientActivityToolStripMenuItem";
            this.clientActivityToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.clientActivityToolStripMenuItem.Text = "Client Activity";
            this.clientActivityToolStripMenuItem.Click += new System.EventHandler(this.clientActivityToolStripMenuItem_Click);
            // 
            // clientPaidToolStripMenuItem
            // 
            this.clientPaidToolStripMenuItem.Name = "clientPaidToolStripMenuItem";
            this.clientPaidToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.clientPaidToolStripMenuItem.Text = "Client Paid";
            this.clientPaidToolStripMenuItem.Click += new System.EventHandler(this.clientPaidToolStripMenuItem_Click);
            // 
            // detailsPopularityToolStripMenuItem
            // 
            this.detailsPopularityToolStripMenuItem.Name = "detailsPopularityToolStripMenuItem";
            this.detailsPopularityToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.detailsPopularityToolStripMenuItem.Text = "Details Popularity";
            this.detailsPopularityToolStripMenuItem.Click += new System.EventHandler(this.detailsPopularityToolStripMenuItem_Click);
            // 
            // productsPopularityToolStripMenuItem
            // 
            this.productsPopularityToolStripMenuItem.Name = "productsPopularityToolStripMenuItem";
            this.productsPopularityToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.productsPopularityToolStripMenuItem.Text = "Products Popularity";
            this.productsPopularityToolStripMenuItem.Click += new System.EventHandler(this.productsPopularityToolStripMenuItem_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(130, 170);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(244, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // FiltersGroupBox
            // 
            this.FiltersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FiltersGroupBox.Name = "FiltersGroupBox";
            this.FiltersGroupBox.Size = new System.Drawing.Size(200, 100);
            this.FiltersGroupBox.TabIndex = 0;
            this.FiltersGroupBox.TabStop = false;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "product_id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.Width = 125;
            // 
            // model_id
            // 
            this.model_id.DataPropertyName = "model_id";
            this.model_id.HeaderText = "model_id";
            this.model_id.MinimumWidth = 6;
            this.model_id.Name = "model_id";
            this.model_id.Width = 125;
            // 
            // producer_id
            // 
            this.producer_id.DataPropertyName = "producer_id";
            this.producer_id.HeaderText = "producer_id";
            this.producer_id.MinimumWidth = 6;
            this.producer_id.Name = "producer_id";
            this.producer_id.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(30, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(620, 300);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.TabStop = false;
            // 
            // TableLabel
            // 
            this.TableLabel.Location = new System.Drawing.Point(12, 48);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(100, 23);
            this.TableLabel.TabIndex = 7;
            // 
            // attachmentBindingSource
            // 
            this.attachmentBindingSource.DataMember = "Attachment";
            this.attachmentBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rentalPointDataSet;
            this.bindingSource1.Position = 0;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.bindingSource1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSource1;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.bindingSource1;
            // 
            // discountTypeBindingSource
            // 
            this.discountTypeBindingSource.DataMember = "DiscountType";
            this.discountTypeBindingSource.DataSource = this.bindingSource1;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.bindingSource1;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.bindingSource1;
            // 
            // modelTypeBindingSource
            // 
            this.modelTypeBindingSource.DataMember = "ModelType";
            this.modelTypeBindingSource.DataSource = this.bindingSource1;
            // 
            // modelTypeBindingSource1
            // 
            this.modelTypeBindingSource1.DataMember = "ModelType";
            this.modelTypeBindingSource1.DataSource = this.bindingSource1;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.bindingSource1;
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.bindingSource1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bindingSource1;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.bindingSource1;
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.bindingSource1;
            // 
            // Product_Sort_groupBox
            // 
            this.Product_Sort_groupBox.Location = new System.Drawing.Point(679, 503);
            this.Product_Sort_groupBox.Name = "Product_Sort_groupBox";
            this.Product_Sort_groupBox.Size = new System.Drawing.Size(236, 91);
            this.Product_Sort_groupBox.TabIndex = 35;
            this.Product_Sort_groupBox.TabStop = false;
            this.Product_Sort_groupBox.Text = "Select sort criteria";
            // 
            // SortType_groupBox
            // 
            this.SortType_groupBox.Controls.Add(this.DESC_radioButton);
            this.SortType_groupBox.Controls.Add(this.ASC_radioButton);
            this.SortType_groupBox.Location = new System.Drawing.Point(468, 88);
            this.SortType_groupBox.Name = "SortType_groupBox";
            this.SortType_groupBox.Size = new System.Drawing.Size(150, 91);
            this.SortType_groupBox.TabIndex = 36;
            this.SortType_groupBox.TabStop = false;
            this.SortType_groupBox.Text = "Select sort type";
            // 
            // DESC_radioButton
            // 
            this.DESC_radioButton.AutoSize = true;
            this.DESC_radioButton.Location = new System.Drawing.Point(35, 58);
            this.DESC_radioButton.Name = "DESC_radioButton";
            this.DESC_radioButton.Size = new System.Drawing.Size(66, 21);
            this.DESC_radioButton.TabIndex = 3;
            this.DESC_radioButton.Text = "DESC";
            this.DESC_radioButton.UseVisualStyleBackColor = true;
            // 
            // ASC_radioButton
            // 
            this.ASC_radioButton.AutoSize = true;
            this.ASC_radioButton.Checked = true;
            this.ASC_radioButton.Location = new System.Drawing.Point(35, 31);
            this.ASC_radioButton.Name = "ASC_radioButton";
            this.ASC_radioButton.Size = new System.Drawing.Size(56, 21);
            this.ASC_radioButton.TabIndex = 2;
            this.ASC_radioButton.TabStop = true;
            this.ASC_radioButton.Text = "ASC";
            this.ASC_radioButton.UseVisualStyleBackColor = true;
            this.ASC_radioButton.CheckedChanged += new System.EventHandler(this.ASC_radioButton_CheckedChanged);
            // 
            // Client_Sort_groupBox
            // 
            this.Client_Sort_groupBox.Location = new System.Drawing.Point(675, 12);
            this.Client_Sort_groupBox.Name = "Client_Sort_groupBox";
            this.Client_Sort_groupBox.Size = new System.Drawing.Size(236, 91);
            this.Client_Sort_groupBox.TabIndex = 37;
            this.Client_Sort_groupBox.TabStop = false;
            this.Client_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Model_Sort_groupBox
            // 
            this.Model_Sort_groupBox.Location = new System.Drawing.Point(675, 99);
            this.Model_Sort_groupBox.Name = "Model_Sort_groupBox";
            this.Model_Sort_groupBox.Size = new System.Drawing.Size(236, 91);
            this.Model_Sort_groupBox.TabIndex = 38;
            this.Model_Sort_groupBox.TabStop = false;
            this.Model_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Brand_Sort_groupBox
            // 
            this.Brand_Sort_groupBox.Location = new System.Drawing.Point(675, 200);
            this.Brand_Sort_groupBox.Name = "Brand_Sort_groupBox";
            this.Brand_Sort_groupBox.Size = new System.Drawing.Size(236, 91);
            this.Brand_Sort_groupBox.TabIndex = 39;
            this.Brand_Sort_groupBox.TabStop = false;
            this.Brand_Sort_groupBox.Text = "Select sort criteria";
            // 
            // ModelType_Sort_groupBox
            // 
            this.ModelType_Sort_groupBox.Location = new System.Drawing.Point(627, 297);
            this.ModelType_Sort_groupBox.Name = "ModelType_Sort_groupBox";
            this.ModelType_Sort_groupBox.Size = new System.Drawing.Size(295, 91);
            this.ModelType_Sort_groupBox.TabIndex = 40;
            this.ModelType_Sort_groupBox.TabStop = false;
            this.ModelType_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Producer_Sort_groupBox
            // 
            this.Producer_Sort_groupBox.Location = new System.Drawing.Point(649, 394);
            this.Producer_Sort_groupBox.Name = "Producer_Sort_groupBox";
            this.Producer_Sort_groupBox.Size = new System.Drawing.Size(266, 91);
            this.Producer_Sort_groupBox.TabIndex = 41;
            this.Producer_Sort_groupBox.TabStop = false;
            this.Producer_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Detail_Sort_groupBox
            // 
            this.Detail_Sort_groupBox.Location = new System.Drawing.Point(471, 530);
            this.Detail_Sort_groupBox.Name = "Detail_Sort_groupBox";
            this.Detail_Sort_groupBox.Size = new System.Drawing.Size(192, 91);
            this.Detail_Sort_groupBox.TabIndex = 42;
            this.Detail_Sort_groupBox.TabStop = false;
            this.Detail_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Good_Sort_groupBox
            // 
            this.Good_Sort_groupBox.Location = new System.Drawing.Point(51, 533);
            this.Good_Sort_groupBox.Name = "Good_Sort_groupBox";
            this.Good_Sort_groupBox.Size = new System.Drawing.Size(358, 91);
            this.Good_Sort_groupBox.TabIndex = 43;
            this.Good_Sort_groupBox.TabStop = false;
            this.Good_Sort_groupBox.Text = "Select sort criteria";
            // 
            // DiscountType_Sort_groupBox
            // 
            this.DiscountType_Sort_groupBox.Location = new System.Drawing.Point(12, 385);
            this.DiscountType_Sort_groupBox.Name = "DiscountType_Sort_groupBox";
            this.DiscountType_Sort_groupBox.Size = new System.Drawing.Size(324, 91);
            this.DiscountType_Sort_groupBox.TabIndex = 40;
            this.DiscountType_Sort_groupBox.TabStop = false;
            this.DiscountType_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Search_textBox
            // 
            this.Search_textBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_textBox.Location = new System.Drawing.Point(30, 42);
            this.Search_textBox.MaxLength = 30;
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(483, 28);
            this.Search_textBox.TabIndex = 37;
            this.Search_textBox.TabStop = false;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(510, 41);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(131, 29);
            this.Search_button.TabIndex = 38;
            this.Search_button.TabStop = false;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(408, 17);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(190, 34);
            this.Delete_button.TabIndex = 69;
            this.Delete_button.TabStop = false;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(212, 17);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(190, 34);
            this.Edit_button.TabIndex = 68;
            this.Edit_button.TabStop = false;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(16, 17);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(190, 34);
            this.Add_button.TabIndex = 67;
            this.Add_button.TabStop = false;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // GridControls_groupBox
            // 
            this.GridControls_groupBox.Controls.Add(this.Add_button);
            this.GridControls_groupBox.Controls.Add(this.Edit_button);
            this.GridControls_groupBox.Controls.Add(this.Delete_button);
            this.GridControls_groupBox.Location = new System.Drawing.Point(30, 506);
            this.GridControls_groupBox.Name = "GridControls_groupBox";
            this.GridControls_groupBox.Size = new System.Drawing.Size(620, 57);
            this.GridControls_groupBox.TabIndex = 70;
            this.GridControls_groupBox.TabStop = false;
            // 
            // attachmentTableAdapter
            // 
            this.attachmentTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // discountTypeTableAdapter
            // 
            this.discountTypeTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // modelTypeTableAdapter
            // 
            this.modelTypeTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // Set_button
            // 
            this.Set_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Set_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set_button.Location = new System.Drawing.Point(497, 209);
            this.Set_button.Name = "Set_button";
            this.Set_button.Size = new System.Drawing.Size(131, 38);
            this.Set_button.TabIndex = 71;
            this.Set_button.TabStop = false;
            this.Set_button.Text = "Configure sets";
            this.Set_button.UseVisualStyleBackColor = false;
            this.Set_button.Click += new System.EventHandler(this.Set_button_Click);
            // 
            // Order_Sort_groupBox
            // 
            this.Order_Sort_groupBox.Location = new System.Drawing.Point(400, 385);
            this.Order_Sort_groupBox.Name = "Order_Sort_groupBox";
            this.Order_Sort_groupBox.Size = new System.Drawing.Size(324, 91);
            this.Order_Sort_groupBox.TabIndex = 41;
            this.Order_Sort_groupBox.TabStop = false;
            this.Order_Sort_groupBox.Text = "Select sort criteria";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 633);
            this.Controls.Add(this.GridControls_groupBox);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.SortType_groupBox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Technical Equipment Rental Point";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            this.SortType_groupBox.ResumeLayout(false);
            this.SortType_groupBox.PerformLayout();
            this.GridControls_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox FiltersGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_id;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem discountTypeToolStripMenuItem;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private RentalPointDataSetTableAdapters.AttachmentTableAdapter attachmentTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private RentalPointDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.BindingSource discountTypeBindingSource;
        private RentalPointDataSetTableAdapters.DiscountTypeTableAdapter discountTypeTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private RentalPointDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private RentalPointDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource modelTypeBindingSource;
        private RentalPointDataSetTableAdapters.ModelTypeTableAdapter modelTypeTableAdapter;
        private System.Windows.Forms.BindingSource modelTypeBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RentalPointDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private RentalPointDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RentalPointDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.BindingSource setBindingSource;
        private RentalPointDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.GroupBox Product_Sort_groupBox;
        private MyRadioButton ProductPrice_radioButton;
        private MyRadioButton productId_radioButton;
        private System.Windows.Forms.GroupBox SortType_groupBox;
        private System.Windows.Forms.RadioButton DESC_radioButton;
        private System.Windows.Forms.RadioButton ASC_radioButton;
        private System.Windows.Forms.GroupBox Client_Sort_groupBox;
        private MyRadioButton LastName_radioButton;
        private MyRadioButton clientId_radioButton;
        private System.Windows.Forms.GroupBox Model_Sort_groupBox;
        private MyRadioButton ModelName_radioButton;
        private MyRadioButton modelId_radioButton;
        private System.Windows.Forms.GroupBox Brand_Sort_groupBox;
        private MyRadioButton BrandName_radioButton;
        private MyRadioButton brandID_radioButton;
        private System.Windows.Forms.GroupBox ModelType_Sort_groupBox;
        private MyRadioButton ModelTypeName_radioButton;
        private MyRadioButton ModelTypeId_radioButton;
        private MyRadioButton producerId_radioButton;
        private MyRadioButton ProducerName_radioButton;
        private System.Windows.Forms.GroupBox Producer_Sort_groupBox;
        private System.Windows.Forms.GroupBox Detail_Sort_groupBox;
        private MyRadioButton DetailPrice_radioButton;
        private MyRadioButton detailId_radioButton;
        private System.Windows.Forms.GroupBox Good_Sort_groupBox;
        private MyRadioButton UsingSince_radioButton;
        private MyRadioButton ProductionDate_radioButton;
        private MyRadioButton Condition_radioButton;
        private MyRadioButton GoodId_radioButton;
        private System.Windows.Forms.GroupBox DiscountType_Sort_groupBox;
        private MyRadioButton DiscountTypeName_radioButton;
        private MyRadioButton DidcountTypeId_radioButton;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.GroupBox GridControls_groupBox;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAnOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qeToolStripMenuItem;
        private System.Windows.Forms.Button Set_button;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.GroupBox Order_Sort_groupBox;
        private MyRadioButton orderDate_radioButton;
        private MyRadioButton orderId_radioButton;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientPaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsPopularityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsPopularityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAReturnToolStripMenuItem;
    }
}

