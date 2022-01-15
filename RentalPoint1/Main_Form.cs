using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentalPoint1
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private GroupBox clientFilter;
        private GroupBox productFilter;
        private GroupBox detailFilter;
        private GroupBox goodFilter;
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(820, 600);
            FillDataSet();
            AddControls();
            CreateFilters();
            FillByClient();
        }
        private void AddControls()
        {
            CreateSortControls();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Size = new System.Drawing.Size(302, 27);
            this.bindingNavigator1.Location = new System.Drawing.Point(30, 190);
            //
            // Edit button
            Set_button.Location = new Point(400, 190);
            Set_button.Size = new Size(130, 30);
            // 
            //Edit_groupbox
            GridControls_groupBox.Location = new Point(50, 470);
            //
            // VewLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLabel.Location = new System.Drawing.Point(260, 70);
            this.TableLabel.Name = "VewLabel";
            this.TableLabel.Size = new System.Drawing.Size(57, 24);
            this.TableLabel.TabIndex = 4;
            this.TableLabel.Text = "Client";
            // 
            // Search
            // 
            Search_textBox.Location = new Point(10, 30);
            Search_textBox.Size = new Size(435, 50);
            Search_button.Location = new Point(445, 30);
            Search_button.Size = new Size(115, 24);
            //
            // Sort GroupBoxes
            //
            this.SortType_groupBox.Location = new Point(448, 90);

            clientId_radioButton.Location = new System.Drawing.Point(20, 30);
            LastName_radioButton.Location = new System.Drawing.Point(clientId_radioButton.Location.X + clientId_radioButton.Width, 30);
            
            this.Client_Sort_groupBox.Controls.Add(this.LastName_radioButton);
            this.Client_Sort_groupBox.Controls.Add(this.clientId_radioButton);
            this.Client_Sort_groupBox.Location = new Point(10, 90);
            this.Client_Sort_groupBox.Size = new Size (435, 75);
            //------------------------------------------------------------------
            modelId_radioButton.Location = new System.Drawing.Point(20, 30);
            ModelName_radioButton.Location = new System.Drawing.Point(modelId_radioButton.Location.X + modelId_radioButton.Width, 30);

            this.Model_Sort_groupBox.Controls.Add(this.ModelName_radioButton);
            this.Model_Sort_groupBox.Controls.Add(this.modelId_radioButton);
            this.Model_Sort_groupBox.Location = new Point(10, 90);
            this.Model_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            brandID_radioButton.Location = new Point(20, 30);
            BrandName_radioButton.Location = new Point(brandID_radioButton.Location.X + brandID_radioButton.Width, 30);

            this.Brand_Sort_groupBox.Controls.Add(this.BrandName_radioButton);
            this.Brand_Sort_groupBox.Controls.Add(this.brandID_radioButton);
            this.Brand_Sort_groupBox.Location = new Point(10, 90);
            this.Brand_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            this.ModelTypeId_radioButton.Location = new Point(20, 30);
            this.ModelTypeName_radioButton.Location = new Point(ModelTypeId_radioButton.Location.X + ModelTypeId_radioButton.Width, 30);

            this.ModelType_Sort_groupBox.Controls.Add(this.ModelTypeName_radioButton);
            this.ModelType_Sort_groupBox.Controls.Add(this.ModelTypeId_radioButton);
            this.ModelType_Sort_groupBox.Location = new Point(10, 90);
            this.ModelType_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            producerId_radioButton.Location = new Point(20, 30);
            ProducerName_radioButton.Location = new Point(producerId_radioButton.Location.X + producerId_radioButton.Width, 30);

            this.Producer_Sort_groupBox.Controls.Add(this.ProducerName_radioButton);
            this.Producer_Sort_groupBox.Controls.Add(this.producerId_radioButton);
            this.Producer_Sort_groupBox.Location = new Point(10, 90);
            this.Producer_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            productId_radioButton.Location = new Point(20, 30);
            ProductPrice_radioButton.Location = new Point(productId_radioButton.Location.X + productId_radioButton.Width, 30);

            this.Product_Sort_groupBox.Controls.Add(this.ProductPrice_radioButton);
            this.Product_Sort_groupBox.Controls.Add(this.productId_radioButton);
            this.Product_Sort_groupBox.Location = new Point(10, 90);
            this.Product_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            detailId_radioButton.Location = new Point(20, 30);
            DetailPrice_radioButton.Location = new Point(detailId_radioButton.Location.X + detailId_radioButton.Width, 30);

            this.Detail_Sort_groupBox.Controls.Add(this.DetailPrice_radioButton);
            this.Detail_Sort_groupBox.Controls.Add(this.detailId_radioButton);
            this.Detail_Sort_groupBox.Location = new Point(10, 90);
            this.Detail_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            GoodId_radioButton.Location = new Point(20, 30);
            Condition_radioButton.Location = new Point(GoodId_radioButton.Location.X + GoodId_radioButton.Width, 30);
            ProductionDate_radioButton.Location = new Point(Condition_radioButton.Location.X + Condition_radioButton.Width, 30);
            UsingSince_radioButton.Location = new Point(ProductionDate_radioButton.Location.X + ProductionDate_radioButton.Width, 30);

            this.Good_Sort_groupBox.Controls.Add(this.UsingSince_radioButton);
            this.Good_Sort_groupBox.Controls.Add(this.ProductionDate_radioButton);
            this.Good_Sort_groupBox.Controls.Add(this.Condition_radioButton);
            this.Good_Sort_groupBox.Controls.Add(this.GoodId_radioButton);
            this.Good_Sort_groupBox.Location = new Point(10, 90);
            this.Good_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            DidcountTypeId_radioButton.Location = new Point(20, 30);
            DiscountTypeName_radioButton.Location = new Point(DidcountTypeId_radioButton.Location.X + DidcountTypeId_radioButton.Width, 30);

            this.DiscountType_Sort_groupBox.Controls.Add(this.DiscountTypeName_radioButton);
            this.DiscountType_Sort_groupBox.Controls.Add(this.DidcountTypeId_radioButton);
            this.DiscountType_Sort_groupBox.Location = new Point(10, 90);
            this.DiscountType_Sort_groupBox.Size = new Size(435, 75);
            //------------------------------------------------------------------
            orderId_radioButton.Location = new Point(20, 30);
            orderDate_radioButton.Location = new Point(DidcountTypeId_radioButton.Location.X + DidcountTypeId_radioButton.Width, 30);

            this.Order_Sort_groupBox.Controls.Add(this.orderId_radioButton);
            this.Order_Sort_groupBox.Controls.Add(this.orderDate_radioButton);
            this.Order_Sort_groupBox.Location = new Point(10, 90);
            this.Order_Sort_groupBox.Size = new Size(435, 75);
        }
        private void CreateSortControls()
        {
            clientAsc = true;
            modelAsc = true;
            brandAsc = true;
            modelTypeAsc = true;
            producerAsc = true;
            productAsc = true;
            detailAsc = true;
            goodAsc = true;
            discountTypeAsc = true;
            orderAsc = true;
            // 
            // Client
            // 
            this.LastName_radioButton = new MyRadioButton("LastName");
            this.LastName_radioButton.AutoSize = true;
            this.LastName_radioButton.Location = new System.Drawing.Point(121, 40);
            this.LastName_radioButton.Name = "LastName_radioButton";
            this.LastName_radioButton.Size = new System.Drawing.Size(97, 21);
            this.LastName_radioButton.TabIndex = 1;
            this.LastName_radioButton.Text = "Last Name";
            this.LastName_radioButton.UseVisualStyleBackColor = true;
            this.LastName_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            //
            this.clientId_radioButton = new MyRadioButton("client_id");
            this.clientId_radioButton.AutoSize = true;
            this.clientId_radioButton.Checked = true;
            this.clientId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.clientId_radioButton.Name = "clientId_radioButton";
            this.clientId_radioButton.Size = new System.Drawing.Size(81, 21);
            this.clientId_radioButton.TabIndex = 0;
            this.clientId_radioButton.TabStop = true;
            this.clientId_radioButton.Text = "client_id";
            this.clientId_radioButton.UseVisualStyleBackColor = true;
            this.clientId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Model
            // 
            this.ModelName_radioButton = new MyRadioButton("ModelName");
            this.ModelName_radioButton.AutoSize = true;
            this.ModelName_radioButton.Location = new System.Drawing.Point(121, 40);
            this.ModelName_radioButton.Name = "ModelName_radioButton";
            this.ModelName_radioButton.Size = new System.Drawing.Size(108, 21);
            this.ModelName_radioButton.TabIndex = 1;
            this.ModelName_radioButton.Text = "Model Name";
            this.ModelName_radioButton.UseVisualStyleBackColor = true;
            this.ModelName_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.modelId_radioButton = new MyRadioButton("model_id");
            this.modelId_radioButton.AutoSize = true;
            this.modelId_radioButton.Checked = true;
            this.modelId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.modelId_radioButton.Name = "modelId_radioButton";
            this.modelId_radioButton.Size = new System.Drawing.Size(86, 21);
            this.modelId_radioButton.TabIndex = 0;
            this.modelId_radioButton.TabStop = true;
            this.modelId_radioButton.Text = "model_id";
            this.modelId_radioButton.UseVisualStyleBackColor = true;
            this.modelId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Brand
            // 
            this.BrandName_radioButton = new MyRadioButton("BrandName");
            this.BrandName_radioButton.AutoSize = true;
            this.BrandName_radioButton.Location = new System.Drawing.Point(121, 40);
            this.BrandName_radioButton.Name = "BrandName_radioButton";
            this.BrandName_radioButton.Size = new System.Drawing.Size(108, 21);
            this.BrandName_radioButton.TabIndex = 1;
            this.BrandName_radioButton.Text = "Brand Name";
            this.BrandName_radioButton.UseVisualStyleBackColor = true;
            this.BrandName_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.brandID_radioButton = new MyRadioButton("brand_id");
            this.brandID_radioButton.AutoSize = true;
            this.brandID_radioButton.Checked = true;
            this.brandID_radioButton.Location = new System.Drawing.Point(20, 40);
            this.brandID_radioButton.Name = "brandID_radioButton";
            this.brandID_radioButton.Size = new System.Drawing.Size(85, 21);
            this.brandID_radioButton.TabIndex = 0;
            this.brandID_radioButton.TabStop = true;
            this.brandID_radioButton.Text = "brand_id";
            this.brandID_radioButton.UseVisualStyleBackColor = true;
            this.brandID_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // ModelType
            // 
            this.ModelTypeName_radioButton = new MyRadioButton("ModelTypeName");
            this.ModelTypeName_radioButton.AutoSize = true;
            this.ModelTypeName_radioButton.Location = new System.Drawing.Point(144, 40);
            this.ModelTypeName_radioButton.Name = "ModelTypeName_radioButton";
            this.ModelTypeName_radioButton.Size = new System.Drawing.Size(144, 21);
            this.ModelTypeName_radioButton.TabIndex = 1;
            this.ModelTypeName_radioButton.Text = "Model Type Name";
            this.ModelTypeName_radioButton.UseVisualStyleBackColor = true;
            this.ModelTypeName_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.ModelTypeId_radioButton = new MyRadioButton("modelType_id");
            this.ModelTypeId_radioButton.AutoSize = true;
            this.ModelTypeId_radioButton.Checked = true;
            this.ModelTypeId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.ModelTypeId_radioButton.Name = "ModelTypeId_radioButton";
            this.ModelTypeId_radioButton.Size = new System.Drawing.Size(118, 21);
            this.ModelTypeId_radioButton.TabIndex = 0;
            this.ModelTypeId_radioButton.TabStop = true;
            this.ModelTypeId_radioButton.Text = "modelType_id";
            this.ModelTypeId_radioButton.UseVisualStyleBackColor = true;
            this.ModelTypeId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Producer
            // 
            this.producerId_radioButton = new MyRadioButton("producer_id");
            this.producerId_radioButton.AutoSize = true;
            this.producerId_radioButton.Checked = true;
            this.producerId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.producerId_radioButton.Name = "producerId_radioButton";
            this.producerId_radioButton.Size = new System.Drawing.Size(105, 21);
            this.producerId_radioButton.TabIndex = 0;
            this.producerId_radioButton.TabStop = true;
            this.producerId_radioButton.Text = "producer_id";
            this.producerId_radioButton.UseVisualStyleBackColor = true;
            this.producerId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.ProducerName_radioButton = new MyRadioButton("ProducerName");
            this.ProducerName_radioButton.AutoSize = true;
            this.ProducerName_radioButton.Location = new System.Drawing.Point(131, 40);
            this.ProducerName_radioButton.Name = "ProducerName_radioButton";
            this.ProducerName_radioButton.Size = new System.Drawing.Size(128, 21);
            this.ProducerName_radioButton.TabIndex = 1;
            this.ProducerName_radioButton.Text = "Producer Name";
            this.ProducerName_radioButton.UseVisualStyleBackColor = true;
            this.ProducerName_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Product
            // 
            this.ProductPrice_radioButton = new MyRadioButton("Price(UAH/day)");
            this.ProductPrice_radioButton.AutoSize = true;
            this.ProductPrice_radioButton.Location = new System.Drawing.Point(143, 40);
            this.ProductPrice_radioButton.Name = "Price_radioButton";
            this.ProductPrice_radioButton.Size = new System.Drawing.Size(61, 21);
            this.ProductPrice_radioButton.TabIndex = 1;
            this.ProductPrice_radioButton.Text = "Price";
            this.ProductPrice_radioButton.UseVisualStyleBackColor = true;
            this.ProductPrice_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.productId_radioButton = new MyRadioButton("product_id");
            this.productId_radioButton.AutoSize = true;
            this.productId_radioButton.Checked = true;
            this.productId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.productId_radioButton.Name = "productId_radioButton";
            this.productId_radioButton.Size = new System.Drawing.Size(96, 21);
            this.productId_radioButton.TabIndex = 0;
            this.productId_radioButton.TabStop = true;
            this.productId_radioButton.Text = "product_id";
            this.productId_radioButton.UseVisualStyleBackColor = true;
            this.productId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Detail
            // 
            this.DetailPrice_radioButton = new MyRadioButton("Price(UAH/day)");
            this.DetailPrice_radioButton.AutoSize = true;
            this.DetailPrice_radioButton.Location = new System.Drawing.Point(108, 40);
            this.DetailPrice_radioButton.Name = "DitailPrice_radioButton";
            this.DetailPrice_radioButton.Size = new System.Drawing.Size(61, 21);
            this.DetailPrice_radioButton.TabIndex = 1;
            this.DetailPrice_radioButton.Text = "Price";
            this.DetailPrice_radioButton.UseVisualStyleBackColor = true;
            this.DetailPrice_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.detailId_radioButton = new MyRadioButton("detail_id");
            this.detailId_radioButton.AutoSize = true;
            this.detailId_radioButton.Checked = true;
            this.detailId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.detailId_radioButton.Name = "detailId_radioButton";
            this.detailId_radioButton.Size = new System.Drawing.Size(82, 21);
            this.detailId_radioButton.TabIndex = 0;
            this.detailId_radioButton.TabStop = true;
            this.detailId_radioButton.Text = "detail_id";
            this.detailId_radioButton.UseVisualStyleBackColor = true;
            this.detailId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Good
            // 
            this.UsingSince_radioButton = new MyRadioButton("UsingSince");
            this.UsingSince_radioButton.AutoSize = true;
            this.UsingSince_radioButton.Location = new System.Drawing.Point(164, 58);
            this.UsingSince_radioButton.Name = "UsingSince_radioButton";
            this.UsingSince_radioButton.Size = new System.Drawing.Size(104, 21);
            this.UsingSince_radioButton.TabIndex = 3;
            this.UsingSince_radioButton.Text = "Using Since";
            this.UsingSince_radioButton.UseVisualStyleBackColor = true;
            this.UsingSince_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.ProductionDate_radioButton = new MyRadioButton("ProductionDate");
            this.ProductionDate_radioButton.AutoSize = true;
            this.ProductionDate_radioButton.Location = new System.Drawing.Point(164, 31);
            this.ProductionDate_radioButton.Name = "ProductionDate_radioButton";
            this.ProductionDate_radioButton.Size = new System.Drawing.Size(131, 21);
            this.ProductionDate_radioButton.TabIndex = 2;
            this.ProductionDate_radioButton.Text = "Production Date";
            this.ProductionDate_radioButton.UseVisualStyleBackColor = true;
            this.ProductionDate_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.Condition_radioButton = new MyRadioButton("Condition");
            this.Condition_radioButton.AutoSize = true;
            this.Condition_radioButton.Location = new System.Drawing.Point(27, 58);
            this.Condition_radioButton.Name = "Condition_radioButton";
            this.Condition_radioButton.Size = new System.Drawing.Size(88, 21);
            this.Condition_radioButton.TabIndex = 1;
            this.Condition_radioButton.Text = "Condition";
            this.Condition_radioButton.UseVisualStyleBackColor = true;
            this.Condition_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.GoodId_radioButton = new MyRadioButton("good_id");
            this.GoodId_radioButton.AutoSize = true;
            this.GoodId_radioButton.Checked = true;
            this.GoodId_radioButton.Location = new System.Drawing.Point(27, 31);
            this.GoodId_radioButton.Name = "GoodId_radioButton";
            this.GoodId_radioButton.Size = new System.Drawing.Size(80, 21);
            this.GoodId_radioButton.TabIndex = 0;
            this.GoodId_radioButton.TabStop = true;
            this.GoodId_radioButton.Text = "good_id";
            this.GoodId_radioButton.UseVisualStyleBackColor = true;
            this.GoodId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // DiscountType
            // 
            this.DiscountTypeName_radioButton = new MyRadioButton("DiscountTypeName");
            this.DiscountTypeName_radioButton.AutoSize = true;
            this.DiscountTypeName_radioButton.Location = new System.Drawing.Point(159, 40);
            this.DiscountTypeName_radioButton.Name = "DiscountTypeName_radioButton";
            this.DiscountTypeName_radioButton.Size = new System.Drawing.Size(161, 21);
            this.DiscountTypeName_radioButton.TabIndex = 1;
            this.DiscountTypeName_radioButton.Text = "Discount Type Name";
            this.DiscountTypeName_radioButton.UseVisualStyleBackColor = true;
            this.DiscountTypeName_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.DidcountTypeId_radioButton = new MyRadioButton("discountType_id");
            this.DidcountTypeId_radioButton.AutoSize = true;
            this.DidcountTypeId_radioButton.Checked = true;
            this.DidcountTypeId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.DidcountTypeId_radioButton.Name = "DidcountTypeId_radioButton";
            this.DidcountTypeId_radioButton.Size = new System.Drawing.Size(133, 21);
            this.DidcountTypeId_radioButton.TabIndex = 0;
            this.DidcountTypeId_radioButton.TabStop = true;
            this.DidcountTypeId_radioButton.Text = "discountType_id";
            this.DidcountTypeId_radioButton.UseVisualStyleBackColor = true;
            this.DidcountTypeId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            // Order
            // 
            this.orderDate_radioButton = new MyRadioButton("OrderDate");
            this.orderDate_radioButton.AutoSize = true;
            this.orderDate_radioButton.Location = new System.Drawing.Point(121, 40);
            this.orderDate_radioButton.Name = "orderDate_radioButton";
            this.orderDate_radioButton.Size = new System.Drawing.Size(108, 21);
            this.orderDate_radioButton.TabIndex = 1;
            this.orderDate_radioButton.Text = "Date";
            this.orderDate_radioButton.UseVisualStyleBackColor = true;
            this.orderDate_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
            // 
            this.orderId_radioButton = new MyRadioButton("order_id");
            this.orderId_radioButton.AutoSize = true;
            this.orderId_radioButton.Checked = true;
            this.orderId_radioButton.Location = new System.Drawing.Point(20, 40);
            this.orderId_radioButton.Name = "orderId_radioButton";
            this.orderId_radioButton.Size = new System.Drawing.Size(86, 21);
            this.orderId_radioButton.TabIndex = 0;
            this.orderId_radioButton.TabStop = true;
            this.orderId_radioButton.Text = "order_id";
            this.orderId_radioButton.UseVisualStyleBackColor = true;
            this.orderId_radioButton.CheckedChanged += new System.EventHandler(this.MyRadioButton_CheckedChanged);
        }
        private void CreateFilters()
        {
            clientFilter = CreateClientFilter();
            productFilter = CreateProductFilter();
            detailFilter = CreateDetailFilter();
            goodFilter = CreateGoodFilter();
        }
        private void FillByClient()
        {
            //dataGridView1.DataSource = null;
            //bindingNavigator1.BindingSource = clientBindingSource;
            //dataGridView1.DataSource = clientBindingSource;
            QueryEdit(Properties.Resources.ClientFill);
            TableLabel.Text = "Client";
            currentTableName = "Client";
            usingSpecialTable = true;
            this.Controls.Add(Client_Sort_groupBox);
            this.Controls.Add(clientFilter);
            Set_button.Text = "Rent history";
            this.Controls.Add(Set_button);
            CurrentSort();
        }
        private GroupBox CreateClientFilter()
        {
            GroupBox groupBox = new GroupBox
            {
                Location = new System.Drawing.Point(580, 40),
                Size = new System.Drawing.Size(200, 420),
                TabIndex = 3,
                TabStop = false,
                Text = "Filters",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
            };
            int i = 40;
            Label gender_label = new MyLabel(i, "Gender");
            CheckBox gender_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox gender_comboBox = new ComboBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 1,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            gender_comboBox.Items.AddRange(new object[] { "Male", "Female" });
            i += 40;
            Label discountType_label = new MyLabel(i, "Discount Type");
            CheckBox discountType_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox discountType_comboBox = new ComboBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                DataSource = this.discountTypeBindingSource,
                DisplayMember = "DiscountTypeName",
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 2,
                ValueMember = "discountType_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            i += 30;
            MyButton Apply_button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Apply_button",
                Size = new System.Drawing.Size(110, 36),
                TabIndex = 9,
                Text = "Apply",
                UseVisualStyleBackColor = false,
                ParentName = "Client",
                ParentObject = groupBox
            };
            Apply_button.Click += new System.EventHandler(Apply_button_Click);
            i += 40;
            MyButton Reset_Button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Reset_button",
                Size = new System.Drawing.Size(110, 28),
                TabIndex = 10,
                Text = "Reset",
                UseVisualStyleBackColor = true,
                ParentName = "Client",
                ParentObject = groupBox
            };
            Reset_Button.Click += new System.EventHandler(Reset_button_Click);

            groupBox.Controls.Add(gender_label);
            groupBox.Controls.Add(gender_checkBox);
            groupBox.Controls.Add(gender_comboBox);

            groupBox.Controls.Add(discountType_label);
            groupBox.Controls.Add(discountType_checkBox);
            groupBox.Controls.Add(discountType_comboBox);

            groupBox.Controls.Add(Apply_button);
            groupBox.Controls.Add(Reset_Button);
            return groupBox;
        }
        private GroupBox CreateProductFilter()
        {
            int i = 0;
            GroupBox groupBox = new GroupBox
            {
                Location = new System.Drawing.Point(580, 40),
                Size = new System.Drawing.Size(200, 420),
                TabIndex = 3,
                TabStop = false,
                Text = "Filters",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
            };
            i += 30;
            MyLabel brand_label = new MyLabel(i, "Brand");
            CheckBox brand_checkBox = new CheckBox { Location = new Point(5, i-3) };
            i += 30;
            ComboBox brand_comboBox = new ComboBox
            {
                DataSource = this.brandBindingSource,
                DisplayMember = "BrandName",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabStop = false,
                ValueMember = "brand_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            brand_comboBox.SelectedIndex = -1;
            i += 40;
            MyLabel model_label = new MyLabel(i, "Model");
            CheckBox model_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox model_comboBox = new ComboBox
            {
                DataSource = this.modelBindingSource,
                DisplayMember = "ModelName",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 5,
                ValueMember = "model_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            model_comboBox.SelectedIndex = -1;
            i += 40;
            MyLabel producer_label = new MyLabel(i, "Producer");
            CheckBox producer_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox producer_comboBox = new ComboBox
            {
                DataSource = this.producerBindingSource,
                DisplayMember = "ProducerName",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 5,
                ValueMember = "producer_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            producer_comboBox.SelectedIndex = -1;
            i += 40;
            MyLabel price_label = new MyLabel(i, "Price");
            CheckBox price_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            TextBox left_textBox = new TextBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(5, i),
                Size = new System.Drawing.Size(80, 26),
                TabIndex = 6
            };
            TextBox right_textBox = new TextBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(90, i),
                Size = new System.Drawing.Size(80, 26),
                TabIndex = 6
            };
            i += 30;
            MyButton Apply_button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Apply_button",
                Size = new System.Drawing.Size(110, 36),
                TabIndex = 9,
                Text = "Apply",
                UseVisualStyleBackColor = false,
                ParentName = "Product",
                ParentObject = groupBox
            };
            Apply_button.Click += new System.EventHandler(Apply_button_Click);

            i += 40;

            MyButton Reset_Button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Reset_button",
                Size = new System.Drawing.Size(110, 28),
                TabIndex = 10,
                Text = "Reset",
                UseVisualStyleBackColor = true,
                ParentName = "Product",
                ParentObject = groupBox
            };
            Reset_Button.Click += new System.EventHandler(Reset_button_Click);

            groupBox.Controls.Add(brand_label);
            groupBox.Controls.Add(brand_checkBox);
            groupBox.Controls.Add(brand_comboBox);

            groupBox.Controls.Add(model_label);
            groupBox.Controls.Add(model_checkBox);
            groupBox.Controls.Add(model_comboBox);

            groupBox.Controls.Add(producer_label);
            groupBox.Controls.Add(producer_checkBox);
            groupBox.Controls.Add(producer_comboBox);

            groupBox.Controls.Add(price_label);
            groupBox.Controls.Add(price_checkBox);
            groupBox.Controls.Add(left_textBox);
            groupBox.Controls.Add(right_textBox);

            groupBox.Controls.Add(Apply_button);
            groupBox.Controls.Add(Reset_Button);

            return groupBox;
        }
        private GroupBox CreateDetailFilter()
        {
            int i = 0;
            GroupBox groupBox = new GroupBox
            {
                Location = new System.Drawing.Point(580, 40),
                Size = new System.Drawing.Size(200, 420),
                TabIndex = 3,
                TabStop = false,
                Text = "Filters",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
            };
            i += 30;
            Label brand_label = new MyLabel(i, "Brand");
            CheckBox brand_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox brand_comboBox = new ComboBox
            {
                DataSource = this.brandBindingSource,
                DisplayMember = "BrandName",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 5,
                ValueMember = "brand_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            i += 40;
            Label model_label = new MyLabel(i, "Model");
            CheckBox model_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox model_comboBox = new ComboBox
            {
                DataSource = this.modelBindingSource,
                DisplayMember = "ModelName",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 5,
                ValueMember = "model_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            i += 40;
            Label producer_label = new MyLabel(i, "Producer");
            CheckBox producer_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox producer_comboBox = new ComboBox
            {
                DataSource = this.producerBindingSource,
                DisplayMember = "ProducerName",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 5,
                ValueMember = "producer_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            i += 40;
            //Magic Label
            MyLabel price_label = new MyLabel(i, Text = "Price");
            CheckBox price_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            TextBox left_textBox = new TextBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(5, i),
                Size = new System.Drawing.Size(80, 26),
                TabIndex = 6
            };
            TextBox right_textBox = new TextBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(90, i),
                Size = new System.Drawing.Size(80, 26),
                TabIndex = 6
            };
            i += 30;

            MyButton Apply_button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Apply_button",
                Size = new System.Drawing.Size(110, 36),
                TabIndex = 9,
                Text = "Apply",
                UseVisualStyleBackColor = false,
                ParentName = "Detail",
                ParentObject = groupBox
            };
            Apply_button.Click += new System.EventHandler(Apply_button_Click);

            i += 40;

            MyButton Reset_Button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Reset_button",
                Size = new System.Drawing.Size(110, 28),
                TabIndex = 10,
                Text = "Reset",
                UseVisualStyleBackColor = true,
                ParentName = "Detail",
                ParentObject = groupBox
            };
            Reset_Button.Click += new System.EventHandler(Reset_button_Click);

            groupBox.Controls.Add(brand_label);
            groupBox.Controls.Add(brand_checkBox);
            groupBox.Controls.Add(brand_comboBox);

            groupBox.Controls.Add(model_label);
            groupBox.Controls.Add(model_checkBox);
            groupBox.Controls.Add(model_comboBox);

            groupBox.Controls.Add(producer_label);
            groupBox.Controls.Add(producer_checkBox);
            groupBox.Controls.Add(producer_comboBox);

            groupBox.Controls.Add(price_label);
            groupBox.Controls.Add(price_checkBox);
            groupBox.Controls.Add(left_textBox);
            groupBox.Controls.Add(right_textBox);

            groupBox.Controls.Add(Apply_button);
            groupBox.Controls.Add(Reset_Button);

            return groupBox;
        }
        private GroupBox CreateGoodFilter()
        {
            int i = 0;
            GroupBox groupBox = new GroupBox
            {
                Location = new System.Drawing.Point(580, 40),
                Size = new System.Drawing.Size(200, 420),
                TabIndex = 3,
                TabStop = false,
                Text = "Filters",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
            };
            i += 30;
            Label product_label = new MyLabel(i, "Product");
            CheckBox product_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox product_comboBox = new ComboBox
            {
                DataSource = this.productBindingSource,
                DisplayMember = "product_id",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 9,
                ValueMember = "product_id",
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            i += 40;
            Label condition_label = new MyLabel(i, "Condition");
            CheckBox condition_checkBox = new CheckBox { Location = new Point(5, i - 3) };
            i += 30;
            ComboBox condition_comboBox = new ComboBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(10, i),
                Size = new System.Drawing.Size(180, 28),
                TabIndex = 0,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            condition_comboBox.Items.AddRange(new object[] { "Bad", "Good" });
            i += 30;

            MyButton Apply_button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Apply_button",
                Size = new System.Drawing.Size(110, 36),
                TabIndex = 9,
                Text = "Apply",
                UseVisualStyleBackColor = false,
                ParentName = "Good",
                ParentObject = groupBox
            };
            Apply_button.Click += new System.EventHandler(Apply_button_Click);

            i += 40;

            MyButton Reset_Button = new MyButton
            {
                Location = new System.Drawing.Point(45, i),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Name = "Reset_button",
                Size = new System.Drawing.Size(110, 28),
                TabIndex = 10,
                Text = "Reset",
                UseVisualStyleBackColor = true,
                ParentName = "Good",
                ParentObject = groupBox
            };
            Reset_Button.Click += new System.EventHandler(Reset_button_Click);

            groupBox.Controls.Add(product_label);
            groupBox.Controls.Add(product_checkBox);
            groupBox.Controls.Add(product_comboBox);

            groupBox.Controls.Add(condition_label);
            groupBox.Controls.Add(condition_checkBox);
            groupBox.Controls.Add(condition_comboBox);

            groupBox.Controls.Add(Apply_button);
            groupBox.Controls.Add(Reset_Button);

            return groupBox;
        }
        private void FillDataSet()
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.rentalPointDataSet.Set);
            rentalPointDataSet.Set.set_idColumn.AutoIncrement = true;
            rentalPointDataSet.Set.set_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Set.set_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(setTableAdapter.TheLastID());
            //rentalPointDataSet.Set.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
            rentalPointDataSet.Rent.rent_idColumn.AutoIncrement = true;
            rentalPointDataSet.Rent.rent_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Rent.rent_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(rentTableAdapter.TheLastID());
            //rentalPointDataSet.Rent.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.rentalPointDataSet.Product);
            rentalPointDataSet.Product.product_idColumn.AutoIncrement = true;
            rentalPointDataSet.Product.product_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Product.product_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(productTableAdapter.TheLastID());
            //rentalPointDataSet.Product.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.rentalPointDataSet.Producer);
            rentalPointDataSet.Producer.producer_idColumn.AutoIncrement = true;
            rentalPointDataSet.Producer.producer_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Producer.producer_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(producerTableAdapter.TheLastID());
            //rentalPointDataSet.Producer.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.rentalPointDataSet.Order);
            rentalPointDataSet.Order.order_idColumn.AutoIncrement = true;
            rentalPointDataSet.Order.order_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Order.order_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(orderTableAdapter.TheLastID());
            //rentalPointDataSet.Order.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.ModelType' table. You can move, or remove it, as needed.
            this.modelTypeTableAdapter.Fill(this.rentalPointDataSet.ModelType);
            rentalPointDataSet.ModelType.modelType_idColumn.AutoIncrement = true;
            rentalPointDataSet.ModelType.modelType_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.ModelType.modelType_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(modelTypeTableAdapter.TheLastID());
            //rentalPointDataSet.ModelType.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.rentalPointDataSet.Model);
            rentalPointDataSet.Model.model_idColumn.AutoIncrement = true;
            rentalPointDataSet.Model.model_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Model.model_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(modelTableAdapter.TheLastID());
            //rentalPointDataSet.Model.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.rentalPointDataSet.Good);
            rentalPointDataSet.Good.good_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Good.good_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(goodTableAdapter.TheLastID());
            rentalPointDataSet.Good.good_idColumn.AutoIncrement = true;
            //rentalPointDataSet.Good.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.DiscountType' table. You can move, or remove it, as needed.
            this.discountTypeTableAdapter.Fill(this.rentalPointDataSet.DiscountType);
            rentalPointDataSet.DiscountType.discountType_idColumn.AutoIncrement = true;
            rentalPointDataSet.DiscountType.discountType_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.DiscountType.discountType_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(discountTypeTableAdapter.TheLastID());
            //rentalPointDataSet.DiscountType.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            rentalPointDataSet.Detail.detail_idColumn.AutoIncrement = true;
            rentalPointDataSet.Detail.detail_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Detail.detail_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(detailTableAdapter.TheLastID());
            //rentalPointDataSet.Detail.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);
            rentalPointDataSet.Client.client_idColumn.AutoIncrement = true;
            rentalPointDataSet.Client.client_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Client.client_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(clientTableAdapter.TheLastID());
            //rentalPointDataSet.Client.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.rentalPointDataSet.Brand);
            rentalPointDataSet.Brand.brand_idColumn.AutoIncrement = true;
            rentalPointDataSet.Brand.brand_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Brand.brand_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(brandTableAdapter.TheLastID());
            //rentalPointDataSet.Brand.RowChanged += new DataRowChangeEventHandler(TableChanged);

            // TODO: This line of code loads data into the 'rentalPointDataSet.Attachment' table. You can move, or remove it, as needed.
            this.attachmentTableAdapter.Fill(this.rentalPointDataSet.Attachment);
            rentalPointDataSet.Attachment.attachment_idColumn.AutoIncrement = true;
            rentalPointDataSet.Attachment.attachment_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Attachment.attachment_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(attachmentTableAdapter.TheLastID());
            //rentalPointDataSet.Attachment.RowChanged += new DataRowChangeEventHandler(TableChanged);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll();
        }
        private void SaveAll()
        {
            try
            {
                clientTableAdapter.Update(rentalPointDataSet);
                modelTableAdapter.Update(rentalPointDataSet);
                brandTableAdapter.Update(rentalPointDataSet);
                modelTypeTableAdapter.Update(rentalPointDataSet);
                producerTableAdapter.Update(rentalPointDataSet);
                productTableAdapter.Update(rentalPointDataSet);
                detailTableAdapter.Update(rentalPointDataSet);
                goodTableAdapter.Update(rentalPointDataSet);
                setTableAdapter.Update(rentalPointDataSet);
                discountTypeTableAdapter.Update(rentalPointDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                clientTableAdapter.Fill(rentalPointDataSet.Client);
                modelTableAdapter.Fill(rentalPointDataSet.Model);
                brandTableAdapter.Fill(rentalPointDataSet.Brand);
                modelTypeTableAdapter.Fill(rentalPointDataSet.ModelType);
                producerTableAdapter.Fill(rentalPointDataSet.Producer);
                productTableAdapter.Fill(rentalPointDataSet.Product);
                detailTableAdapter.Fill(rentalPointDataSet.Detail);
                goodTableAdapter.Fill(rentalPointDataSet.Good);
                setTableAdapter.Fill(rentalPointDataSet.Set);
                discountTypeTableAdapter.Fill(rentalPointDataSet.DiscountType);
            }
        }
        string currentTableName;
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCientEditTab();
        }
        private void OpenCientEditTab()
        {
            if (currentTableName == "Client")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            //bindingNavigator1.BindingSource = clientBindingSource;
            //dataGridView1.DataSource = clientBindingSource;
            QueryEdit(Properties.Resources.ClientFill);
            currentTableName = "Client";
            TableLabel.Text = "Client";
            usingSpecialTable = true;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(820, 600);
            this.Controls.Add(Client_Sort_groupBox);
            this.Controls.Add(clientFilter);
            Set_button.Text = "Rent history";
            this.Controls.Add(Set_button);
            if (clientAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Model")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            //bindingNavigator1.BindingSource = modelBindingSource;
            //dataGridView1.DataSource = modelBindingSource;
            QueryEdit(Properties.Resources.ModelFill);
            currentTableName = "Model";
            TableLabel.Text = "Model";
            usingSpecialTable = true;
            //Delete old filter
            if(this.Controls[this.Controls.Count-1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(590, 600);
            this.Controls.Add(Model_Sort_groupBox);
            if (modelAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Brand")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            bindingNavigator1.BindingSource = brandBindingSource;
            dataGridView1.DataSource = brandBindingSource;
            currentTableName = "Brand";
            TableLabel.Text = "Brand";
            usingSpecialTable = false;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(590, 600);
            this.Controls.Add(Brand_Sort_groupBox);
            if (brandAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void modelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "ModelType")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            bindingNavigator1.BindingSource = modelTypeBindingSource;
            dataGridView1.DataSource = modelTypeBindingSource;
            currentTableName = "ModelType";
            TableLabel.Text = "Model Type";
            usingSpecialTable = false;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(590, 600);
            this.Controls.Add(ModelType_Sort_groupBox);
            if (modelTypeAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void producerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Producer")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            bindingNavigator1.BindingSource = producerBindingSource;
            dataGridView1.DataSource = producerBindingSource;
            currentTableName = "Producer";
            TableLabel.Text = "Producer";
            usingSpecialTable = false;
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(590, 600);
            this.Controls.Add(Producer_Sort_groupBox);
            if (producerAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Product")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            //bindingNavigator1.BindingSource = productBindingSource;
            //dataGridView1.DataSource = productBindingSource;
            QueryEdit(Properties.Resources.ProductFill);
            currentTableName = "Product";
            TableLabel.Text = "Product";
            usingSpecialTable = true;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(820, 600);
            this.Controls.Add(Product_Sort_groupBox);
            this.Controls.Add(productFilter);
            Set_button.Text = "Configure sets";
            this.Controls.Add(Set_button);
            if (productAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Detail")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            //bindingNavigator1.BindingSource = detailBindingSource;
            //dataGridView1.DataSource = detailBindingSource;
            QueryEdit(Properties.Resources.DetailFill);
            currentTableName = "Detail";
            TableLabel.Text = "Detail";
            usingSpecialTable = true;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(820, 600);
            this.Controls.Add(Detail_Sort_groupBox);
            this.Controls.Add(detailFilter);
            if (detailAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Good")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            bindingNavigator1.BindingSource = goodBindingSource;
            dataGridView1.DataSource = goodBindingSource;
            currentTableName = "Good";
            TableLabel.Text = "Good";
            usingSpecialTable = false;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(820, 600);
            this.Controls.Add(Good_Sort_groupBox);
            this.Controls.Add(goodFilter);
            if (goodAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void discountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "DiscountType")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            bindingNavigator1.BindingSource = discountTypeBindingSource;
            dataGridView1.DataSource = discountTypeBindingSource;
            currentTableName = "DiscountType";
            TableLabel.Text = "Discount Type";
            usingSpecialTable = false;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(590, 600);
            this.Controls.Add(DiscountType_Sort_groupBox);
            if (discountTypeAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            Delete_button.Visible = true;
        }
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Order")
                return;
            SaveAll();
            dataGridView1.DataSource = null;
            bindingNavigator1.BindingSource = orderBindingSource;
            dataGridView1.DataSource = orderBindingSource;
            currentTableName = "Order";
            TableLabel.Text = "Order";
            usingSpecialTable = false;
            //Delete old filter
            if (this.Controls[this.Controls.Count - 1] is Button)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            if (this.Controls[this.Controls.Count - 1] is GroupBox)
                this.Controls.RemoveAt(this.Controls.Count - 1);
            this.Size = new Size(590, 600);
            this.Controls.Add(Order_Sort_groupBox);
            Set_button.Text = "View Rents";
            this.Controls.Add(Set_button);
            if (orderAsc)
            {
                ASC_radioButton.Checked = true;
                DESC_radioButton.Checked = false;
            }
            else
            {
                ASC_radioButton.Checked = false;
                DESC_radioButton.Checked = true;
            }
            CurrentSort();
            GridControls_groupBox.Visible = true;
            //Delete_button.Visible = false;
        }
        private bool usingSpecialTable;
        private void Apply_button_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void ApplyFilter()
        {
            //MyButton s = sender as MyButton;
            //GroupBox parent = s.ParentObject;
            if (currentTableName == "Client")
            {
                try { clientTableAdapter.Update(rentalPointDataSet); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clientTableAdapter.Fill(rentalPointDataSet.Client);
                }
                var genderCheck = clientFilter.Controls[1] as CheckBox;
                var gender = clientFilter.Controls[2] as ComboBox;

                var discountTypeCheck = clientFilter.Controls[4] as CheckBox;
                var discountType = clientFilter.Controls[5] as ComboBox;

                char genderV;
                if ((string)gender.SelectedItem == "Male")
                    genderV = 'm';
                else if ((string)gender.SelectedItem == "Female")
                    genderV = 'f';
                else
                    genderV = 'n';
                string sqlText = Properties.Resources.ClientFill + "where";
                bool and = false;
                if (genderCheck.Checked && genderV != 'n')
                {
                    sqlText += $@" Gender = '{genderV}'";
                    and = true;
                }
                if (discountTypeCheck.Checked)
                {
                    if (and)
                        sqlText += $@" and Client.discountType_id = '{discountType.SelectedValue}'";
                    else
                        sqlText += $@" Client.discountType_id = '{discountType.SelectedValue}'";
                    and = true;
                }
                if (and)
                {
                    QueryEdit(sqlText);
                    usingSpecialTable = true;
                    CurrentSort();
                }
            }
            else if (currentTableName == "Product")
            {
                try { productTableAdapter.Update(rentalPointDataSet); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    productTableAdapter.Fill(rentalPointDataSet.Product);
                }
                var brandCheck = productFilter.Controls[1] as CheckBox;
                var brand = productFilter.Controls[2] as ComboBox;

                var modelCheck = productFilter.Controls[4] as CheckBox;
                var model = productFilter.Controls[5] as ComboBox;

                var producerCheck = productFilter.Controls[7] as CheckBox;
                var producer = productFilter.Controls[8] as ComboBox;

                var priceCheck = productFilter.Controls[10] as CheckBox;
                var left = productFilter.Controls[11] as TextBox;
                var right = productFilter.Controls[12] as TextBox;
                double leftV = -1;
                double rightV = -1;
                try
                {
                    if (left.Text != "")
                        leftV = Convert.ToDouble(left.Text);
                    if (right.Text != "")
                        rightV = Convert.ToDouble(right.Text);
                }
                catch { MessageBox.Show("Price can contain only numbers"); }

                bool and = false;
                string sqlText = Properties.Resources.ProductFill + "where";
                if (brandCheck.Checked)
                {
                    and = true;
                    sqlText += $@" model.brand_id = '{brand.SelectedValue}'";
                }
                if (modelCheck.Checked)
                {
                    if (and)
                        sqlText += $@" and product.model_id = '{model.SelectedValue}'";
                    else
                        sqlText += $@" product.model_id = '{model.SelectedValue}'";
                    and = true;

                }
                if (producerCheck.Checked)
                {
                    if (and)
                        sqlText += $@" and product.producer_id = '{producer.SelectedValue}'";
                    else
                        sqlText += $@" product.producer_id = '{producer.SelectedValue}'";
                    and = true;
                }
                if (priceCheck.Checked)
                {
                    if (leftV != -1)
                    {
                        if (and)
                            sqlText += " and";
                        sqlText += $" Product.[Price(UAH/day)] >= {leftV}";
                        and = true;
                    }
                    if (rightV != -1)
                    {
                        if (and)
                            sqlText += " and";
                        sqlText += $" Product.[Price(UAH/day)] <= {rightV}";
                        and = true;
                    }
                }
                if (and)
                {
                    QueryEdit(sqlText);
                    usingSpecialTable = true;
                    CurrentSort();
                }
            }
            else if (currentTableName == "Detail")
            {
                try { detailTableAdapter.Update(rentalPointDataSet); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    detailTableAdapter.Fill(rentalPointDataSet.Detail);
                }
                var brandCheck = detailFilter.Controls[1] as CheckBox;
                var brand = detailFilter.Controls[2] as ComboBox;

                var modelCheck = detailFilter.Controls[4] as CheckBox;
                var model = detailFilter.Controls[5] as ComboBox;

                var producerCheck = detailFilter.Controls[7] as CheckBox;
                var producer = detailFilter.Controls[8] as ComboBox;

                var priceCheck = detailFilter.Controls[10] as CheckBox;
                var left = detailFilter.Controls[11] as TextBox;
                var right = detailFilter.Controls[12] as TextBox;
                double leftV = -1;
                double rightV = -1;
                try
                {
                    if (left.Text != "")
                        leftV = Convert.ToDouble(left.Text);
                    if (right.Text != "")
                        rightV = Convert.ToDouble(right.Text);
                }
                catch { MessageBox.Show("Price can contain only numbers"); }

                bool and = false;
                string sqlText = Properties.Resources.DetailFill + "where";

                if (brandCheck.Checked)
                {
                    and = true;
                    sqlText += $@" model.brand_id = '{brand.SelectedValue}'";
                }
                if (modelCheck.Checked)
                {
                    if (and)
                        sqlText += " and";
                    sqlText += $@" detail.model_id = '{model.SelectedValue}'";
                    and = true;
                }
                if (producerCheck.Checked)
                {
                    if (and)
                        sqlText += " and";
                    sqlText += $@" product.producer_id = '{producer.SelectedValue}'";
                    and = true;
                }
                if (priceCheck.Checked)
                {
                    if (leftV != -1)
                    {
                        if (and)
                            sqlText += " and";
                        sqlText += $" Product.[Price(UAH/day)] >= {leftV}";
                        and = true;
                    }
                    if (rightV != -1)
                    {
                        if (and)
                            sqlText += " and";
                        sqlText += $" Product.[Price(UAH/day)] <= {rightV}";
                        and = true;
                    }
                }
                if (and)
                {
                    QueryEdit(sqlText);
                    usingSpecialTable = true;
                    CurrentSort();
                }
            }
            else if (currentTableName == "Good")
            {
                try { goodTableAdapter.Update(rentalPointDataSet.Good); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    goodTableAdapter.Fill(rentalPointDataSet.Good);
                }
                var productCheck = goodFilter.Controls[1] as CheckBox;
                var product = goodFilter.Controls[2] as ComboBox;

                var conditionCheck = goodFilter.Controls[4] as CheckBox;
                var condition = goodFilter.Controls[5] as ComboBox;
                string sqlText = $@"select * from Good where";
                bool and = false;
                if (productCheck.Checked)
                {
                    if (and)
                        sqlText += " and";
                    sqlText += $" product_id = '{product.SelectedValue}'";
                    and = true;
                }

                if (conditionCheck.Checked)
                {
                    if (and)
                        sqlText += " and";
                    sqlText += $" Condition = '{condition.SelectedIndex}'";
                    and = true;
                }
                if (and)
                {
                    QueryEdit(sqlText);
                    usingSpecialTable = true;
                    CurrentSort();
                }
            }
        }
        private void Reset_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MyButton s = sender as MyButton;
            usingSpecialTable = false;
            if (s.ParentName == "Client")
            {
                //clientTableAdapter.Fill(rentalPointDataSet.Client);
                //dataGridView1.DataSource = clientBindingSource;
                //bindingNavigator1.BindingSource = clientBindingSource;
                QueryEdit(Properties.Resources.ClientFill);
                foreach (var a in clientFilter.Controls)
                    if(a is CheckBox)
                    {
                        var box = a as CheckBox;
                        box.Checked = false;
                    }
                usingSpecialTable = true;
            }
            if(s.ParentName == "Product")
            {
                //productTableAdapter.Fill(rentalPointDataSet.Product);
                //dataGridView1.DataSource = productBindingSource;
                //bindingNavigator1.BindingSource = productBindingSource;
                QueryEdit(Properties.Resources.ProductFill);
                foreach (var a in productFilter.Controls)
                    if (a is CheckBox)
                    {
                        var box = a as CheckBox;
                        box.Checked = false;
                    }
                usingSpecialTable = true;
            }
            if(s.ParentName == "Detail")
            {
                //dataGridView1.DataSource = detailBindingSource;
                //detailTableAdapter.Fill(rentalPointDataSet.Detail);
                //bindingNavigator1.BindingSource = detailBindingSource;
                QueryEdit(Properties.Resources.DetailFill);
                foreach (var a in detailFilter.Controls)
                    if (a is CheckBox)
                    {
                        var box = a as CheckBox;
                        box.Checked = false;
                    }
                usingSpecialTable = true;
            }
            if(s.ParentName == "Good")
            {
                goodTableAdapter.Fill(rentalPointDataSet.Good);
                dataGridView1.DataSource = goodBindingSource;
                bindingNavigator1.BindingSource = goodBindingSource;
                foreach (var a in goodFilter.Controls)
                    if (a is CheckBox)
                    {
                        var box = a as CheckBox;
                        box.Checked = false;
                    }
            }
            CurrentSort();
        }
        DataTable Current_dataTable;
        private void QueryEdit(string sqlText)
        {
            var connectionStr = Properties.Settings.Default.RentalPointConnectionString;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionStr);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlText, sqlConnection);

                Current_dataTable = new DataTable();
                sqlDataAdapter.Fill(Current_dataTable);
                Current_dataTable.Columns[0].AutoIncrement = true;
                Current_dataTable.Columns[0].AutoIncrementStep = 1;

                if (currentTableName == "Client")
                    Current_dataTable.Columns[0].AutoIncrementSeed = 1 + Convert.ToInt32(clientTableAdapter.TheLastID());
                else if (currentTableName == "Product")
                    Current_dataTable.Columns[0].AutoIncrementSeed = 1 + Convert.ToInt32(productTableAdapter.TheLastID());
                else if(currentTableName == "Detail")
                    Current_dataTable.Columns[0].AutoIncrementSeed = 1 + Convert.ToInt32(detailTableAdapter.TheLastID());
                else if(currentTableName == "Good")
                    Current_dataTable.Columns[0].AutoIncrementSeed = 1 + Convert.ToInt32(goodTableAdapter.TheLastID());

                BindingSource bindingSourse = new BindingSource();
                bindingSourse.DataSource = Current_dataTable;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bindingSourse;
                bindingNavigator1.BindingSource = bindingSourse;
                sqlConnection.Close();

                //Filter_dataTable.RowChanged += new DataRowChangeEventHandler(FilteredTable_Changed);
                //Filter_dataTable.RowDeleting += new DataRowChangeEventHandler(FilteredTableRow_Deleted);
            }
            catch(Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
        private void FilteredTable_Changed(object sender, DataRowChangeEventArgs e)
        {
            if (currentTableName == "Client")
                try
                {
                    clientTableAdapter.DeleteQuery((int)e.Row[0]);
                    clientTableAdapter.Insert((int)e.Row[0], (int)e.Row[1], (int)e.Row[2], (string)e.Row[3], (string)e.Row[4], (string)e.Row[5], (string)e.Row[6], (string)e.Row[7], (string)e.Row[8], (string)e.Row[9], (int)e.Row[10], Convert.ToDateTime(e.Row[11]), (string)e.Row[12]);
                    //clientTableAdapter.Fill(rentalPointDataSet.Client);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            else if (currentTableName == "Product")
                try
                {
                    productTableAdapter.DeleteQuery((int)e.Row[0]);
                    productTableAdapter.Insert((int)e.Row[0], (int)e.Row[1], (int)e.Row[2], (decimal)e.Row[3], (int)e.Row[4], (decimal)e.Row[5], (string)e.Row[6]);
                    productTableAdapter.Fill(rentalPointDataSet.Product);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            else if (currentTableName == "Detail")
                try
                {
                    detailTableAdapter.DeleteQuery((int)e.Row[0]);
                    detailTableAdapter.Insert((int)e.Row[0], (int)e.Row[1], (int)e.Row[2], (decimal)e.Row[3], (int)e.Row[4], (bool)e.Row[5]);
                    detailTableAdapter.Fill(rentalPointDataSet.Detail);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            else if (currentTableName == "Good")
                try
                {
                    goodTableAdapter.DeleteQuery((int)e.Row[0]);
                    goodTableAdapter.Insert((int)e.Row[0], (int)e.Row[1], (bool)e.Row[2], Convert.ToDateTime(e.Row[3]), Convert.ToDateTime(e.Row[4]));
                    goodTableAdapter.Fill(rentalPointDataSet.Good);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FilteredTableRow_Deleted(object sender, DataRowChangeEventArgs e)
        {
            if(currentTableName == "Client")
                try { clientTableAdapter.DeleteQuery((int)e.Row[0]); }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            else if(currentTableName == "Product")
                try { productTableAdapter.DeleteQuery((int)e.Row[0]); }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            else if (currentTableName == "Detail")
                try { detailTableAdapter.DeleteQuery((int)e.Row[0]); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            else if (currentTableName == "Good")
                try { goodTableAdapter.DeleteQuery((int)e.Row[0]); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Sort(string field, bool acs)
        {
            if(usingSpecialTable)
            {
                DataTable dt = new DataTable();
                if (acs)
                {
                    var s = from row in Current_dataTable.AsEnumerable()
                             orderby row[field] ascending
                             select row;
                    //if (s. == 0)
                    //    return;
                    try { Current_dataTable = s.CopyToDataTable(); }
                    catch { }
                }
                else
                {
                    var s = from row in Current_dataTable.AsEnumerable()
                             orderby row[field] descending
                             select row;
                    //if (s == null)
                    //    return;
                    try { Current_dataTable = s.CopyToDataTable(); }
                    catch { }
                }
                BindingSource bindingSourse = new BindingSource();
                bindingSourse.DataSource = Current_dataTable;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bindingSourse;
                bindingNavigator1.BindingSource = bindingSourse;

                //Filter_dataTable.RowChanged += new DataRowChangeEventHandler(FilteredTable_Changed);
                //Filter_dataTable.RowDeleting += new DataRowChangeEventHandler(FilteredTableRow_Deleted);
            }
            else
            {
                if (currentTableName == "Client")
                {
                    if (field == "client_id")
                    {
                        if (acs)
                            clientTableAdapter.Sort_clientId_ACS(rentalPointDataSet.Client);
                        else
                            clientTableAdapter.Sort_clientId_DESC(rentalPointDataSet.Client);
                    }
                    else if (field == "LastName")
                    {
                        if (acs)
                            clientTableAdapter.Sort_LastName_ASC(rentalPointDataSet.Client);
                        else
                            clientTableAdapter.Sort_LastName_DESC(rentalPointDataSet.Client);
                    }
                }
                else if (currentTableName == "Model")
                {
                    if (field == "model_id")
                    {
                        if (acs)
                            modelTableAdapter.Sort_modelId_ASC(rentalPointDataSet.Model);
                        else
                            modelTableAdapter.Sort_modelId_DESC(rentalPointDataSet.Model);
                    }
                    else if (field == "ModelName")
                    {
                        if (acs)
                            modelTableAdapter.Sort_ModelName_ASC(rentalPointDataSet.Model);
                        else
                            modelTableAdapter.Sort_ModelName_DESC(rentalPointDataSet.Model);
                    }
                }
                else if (currentTableName == "Brand")
                {
                    if (field == "brand_id")
                    {
                        if (acs)
                            brandTableAdapter.Sort_BrandId_ASC(rentalPointDataSet.Brand);
                        else
                            brandTableAdapter.Sort_brandId_DESC(rentalPointDataSet.Brand);
                    }
                    else if (field == "BrandName")
                    {
                        if (acs)
                            brandTableAdapter.Sort_BrandId_ASC(rentalPointDataSet.Brand);
                        else
                            brandTableAdapter.Sort_brandId_DESC(rentalPointDataSet.Brand);
                    }
                }
                else if (currentTableName == "Producer")
                {
                    if (field == "producer_id")
                    {
                        if (acs)
                            producerTableAdapter.Sort_producerId_ASC(rentalPointDataSet.Producer);
                        else
                            producerTableAdapter.Sort_producerId_DESC(rentalPointDataSet.Producer);
                    }
                    else if (field == "ProducerName")
                    {
                        if (acs)
                            producerTableAdapter.Sort_ProducerName_ASC(rentalPointDataSet.Producer);
                        else
                            producerTableAdapter.Sort_ProducerName_DESC(rentalPointDataSet.Producer);
                    }
                }
                else if (currentTableName == "Product")
                {
                    if (field == "product_id")
                    {
                        if (acs)
                            productTableAdapter.Sort_product_id_ASC(rentalPointDataSet.Product);
                        else
                            productTableAdapter.Sort_product_id_DESC(rentalPointDataSet.Product);
                    }
                    else if (field == "Price")
                    {
                        if (acs)
                            productTableAdapter.Sort_Price_ASC(rentalPointDataSet.Product);
                        else
                            productTableAdapter.Sort_Price_DESC(rentalPointDataSet.Product);
                    }
                }
                else if (currentTableName == "Detail")
                {
                    if (field == "detail_id")
                    {
                        if (acs)
                            detailTableAdapter.Sort_detailId_ASC(rentalPointDataSet.Detail);
                        else
                            detailTableAdapter.Sort_detailId_DESC(rentalPointDataSet.Detail);
                    }
                    else if (field == "Price")
                    {
                        if (acs)
                            detailTableAdapter.Sort_Price_ACS(rentalPointDataSet.Detail);
                        else
                            detailTableAdapter.Sort_Price_DESC(rentalPointDataSet.Detail);
                    }
                }
                else if (currentTableName == "Good")
                {
                    if (field == "good_id")
                    {
                        if (acs)
                            goodTableAdapter.Sort_goodId_ACS(rentalPointDataSet.Good);
                        else
                            goodTableAdapter.Sort_goodId_DESC(rentalPointDataSet.Good);
                    }
                    else if (field == "Condition")
                    {
                        if (acs)
                            goodTableAdapter.Sort_Condition_ASC(rentalPointDataSet.Good);
                        else
                            goodTableAdapter.Sort_Condition_DESC(rentalPointDataSet.Good);
                    }
                    else if (field == "ProductionDate")
                    {
                        if (acs)
                            goodTableAdapter.Sort_ProductionDate_ASC(rentalPointDataSet.Good);
                        else
                            goodTableAdapter.Sort_ProductionDate_DESC(rentalPointDataSet.Good);
                    }
                    else if (field == "UsingSince")
                    {
                        if (acs)
                            goodTableAdapter.Sort_UsingSince_ASC(rentalPointDataSet.Good);
                        else
                            goodTableAdapter.Sort_UsingSince_DESC(rentalPointDataSet.Good);
                    }
                }
                else if (currentTableName == "DiscountType")
                {
                    if (field == "discountType_id")
                    {
                        if (acs)
                            discountTypeTableAdapter.Sort_discountTypeId_ACS(rentalPointDataSet.DiscountType);
                        else
                            discountTypeTableAdapter.Sort_discountTypeId_DESC(rentalPointDataSet.DiscountType);
                    }
                    else if (field == "DiscountTypeName")
                    {
                        if (acs)
                            discountTypeTableAdapter.Sort_DiscountTypeName_ASC(rentalPointDataSet.DiscountType);
                        else
                            discountTypeTableAdapter.Sort_DiscountTypeName_DESC(rentalPointDataSet.DiscountType);
                    }
                }
                else if (currentTableName == "Order")
                {
                    if (field == "order_id")
                    {
                        if (acs)
                            orderTableAdapter.Sort_orderId_ASC(rentalPointDataSet.Order);
                        else
                            orderTableAdapter.Sort_orderId_DESC(rentalPointDataSet.Order);
                    }
                    else if (field == "OrderDate")
                    {
                        if (acs)
                            orderTableAdapter.Sort_OrderDate_ASC(rentalPointDataSet.Order);
                        else
                            orderTableAdapter.Sort_OrderDate_DESC(rentalPointDataSet.Order);
                    }
                }
            }
        }
        private void MyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var fieldRadioButton = sender as MyRadioButton;
            if(fieldRadioButton.Checked)
                Sort(fieldRadioButton.Field, ASC_radioButton.Checked);
        }
        private void CurrentSort()
        {
            if(currentTableName == "Client")
            {
                foreach(var a in Client_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if(rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Model")
            {
                foreach (var a in Model_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Brand")
            {
                foreach (var a in Brand_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "ModelType")
            {
                foreach (var a in ModelType_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Producer")
            {
                foreach (var a in Producer_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Product")
            {
                foreach (var a in Product_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Detail")
            {
                foreach (var a in Detail_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Good")
            {
                foreach (var a in Good_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "DiscountType")
            {
                foreach (var a in DiscountType_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
            else if (currentTableName == "Order")
            {
                foreach (var a in Order_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, ASC_radioButton.Checked);
                        return;
                    }
                }
            }
        }
        private bool clientAsc;
        private bool modelAsc;
        private bool brandAsc;
        private bool modelTypeAsc;
        private bool producerAsc;
        private bool productAsc;
        private bool detailAsc;
        private bool goodAsc;
        private bool discountTypeAsc;
        private bool orderAsc;
        private void ASC_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            
            if(currentTableName == "Client")
            {
                foreach (var a in Client_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                clientAsc = radioButton.Checked;
            }
            else if (currentTableName == "Model")
            {
                foreach (var a in Model_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                modelAsc = radioButton.Checked;
            }
            else if (currentTableName == "Brand")
            {
                foreach (var a in Brand_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                brandAsc = radioButton.Checked;
            }
            else if (currentTableName == "ModelType")
            {
                foreach (var a in ModelType_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                modelTypeAsc = radioButton.Checked;
            }
            else if (currentTableName == "Producer")
            {
                foreach (var a in Producer_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                producerAsc = radioButton.Checked;
            }
            else if (currentTableName == "Product")
            {
                foreach (var a in Product_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                productAsc = radioButton.Checked;
            }
            else if (currentTableName == "Detail")
            {
                foreach(var a in Detail_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if(rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                detailAsc = radioButton.Checked;
            }
            else if (currentTableName == "Good")
            {
                foreach (var a in Good_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                goodAsc = radioButton.Checked;
            }
            else if (currentTableName == "DiscountType")
            {
                foreach (var a in DiscountType_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                discountTypeAsc = radioButton.Checked;
            }
            else if (currentTableName == "Order")
            {
                foreach (var a in Order_Sort_groupBox.Controls)
                {
                    var rb = a as MyRadioButton;
                    if (rb.Checked)
                    {
                        Sort(rb.Field, radioButton.Checked);
                        break;
                    }
                }
                orderAsc = radioButton.Checked;
            }
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            if (Search_textBox.Text == "")
                return;
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1[j, i].FormattedValue.ToString().ToLower().Trim().Contains(Search_textBox.Text.ToLower().Trim()))
                        dataGridView1.Rows[i].Selected = true;
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Brand")
            {
                var editForm = new EditBrand_Form();
                editForm.ShowDialog();
                brandTableAdapter.Fill(rentalPointDataSet.Brand);
            }
            else if(currentTableName == "Client")
            {
                var editForm = new EditClient_Form();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    clientTableAdapter.Fill(rentalPointDataSet.Client);
                    rentalPointDataSet.AcceptChanges();
                    //if (usingSpecialTable)
                    //{
                    //    int lastId = Convert.ToInt32(clientTableAdapter.TheLastID());
                    //    var rowsAdd = clientTableAdapter.WhereId(lastId);
                    //    var itemArr = rowsAdd[0].ItemArray;
                    //    Current_dataTable.Rows.Add(itemArr);
                    //}
                    QueryEdit(Properties.Resources.ClientFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "Detail")
            {
                var editForm = new EditDetail_Form();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    detailTableAdapter.Fill(rentalPointDataSet.Detail);
                    rentalPointDataSet.AcceptChanges();
                    //if (usingSpecialTable)
                    //{
                    //    int lastId = Convert.ToInt32(detailTableAdapter.TheLastID());
                    //    var rowsAdd = detailTableAdapter.WhereId(lastId);
                    //    var itemArr = rowsAdd[0].ItemArray;
                    //    Current_dataTable.Rows.Add(itemArr);
                    //}
                    QueryEdit(Properties.Resources.DetailFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "DiscountType")
            {
                var editForm = new EditDiscountType_Form();
                editForm.ShowDialog();
                discountTypeTableAdapter.Fill(rentalPointDataSet.DiscountType);
                rentalPointDataSet.AcceptChanges();
            }
            else if (currentTableName == "Good")
            {
                var editForm = new EditGood_Form();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    goodTableAdapter.Fill(rentalPointDataSet.Good);
                    rentalPointDataSet.AcceptChanges();
                    if (usingSpecialTable)
                    {
                        int lastId = Convert.ToInt32(goodTableAdapter.TheLastID());
                        var rowsAdd = goodTableAdapter.WhereId(lastId);
                        var itemArr = rowsAdd[0].ItemArray;
                        Current_dataTable.Rows.Add(itemArr);
                    }
                }
            }
            else if (currentTableName == "Model")
            {
                var editForm = new EditModel_Form();
                editForm.ShowDialog();
                modelTableAdapter.Fill(rentalPointDataSet.Model);
                rentalPointDataSet.AcceptChanges();
                QueryEdit(Properties.Resources.ModelFill);
                ApplyFilter();
                CurrentSort();
            }
            else if (currentTableName == "ModelType")
            {
                var editForm = new EditModelType_Form();
                editForm.ShowDialog();
                modelTypeTableAdapter.Fill(rentalPointDataSet.ModelType);
                rentalPointDataSet.AcceptChanges();
            }
            else if (currentTableName == "Producer")
            {
                var editForm = new EditProducer_Form();
                editForm.ShowDialog();
                producerTableAdapter.Fill(rentalPointDataSet.Producer);
                rentalPointDataSet.AcceptChanges();
            }
            else if (currentTableName == "Product")
            {
                var editForm = new EditProduct_Form();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    productTableAdapter.Fill(rentalPointDataSet.Product);
                    rentalPointDataSet.AcceptChanges();
                    //if (usingSpecialTable)
                    //{
                    //    int lastId = Convert.ToInt32(productTableAdapter.TheLastID());
                    //    var rowsAdd = productTableAdapter.WhereId(lastId);
                    //    var itemArr = rowsAdd[0].ItemArray;
                    //    Current_dataTable.Rows.Add(itemArr);
                    //}
                    QueryEdit(Properties.Resources.ProductFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "Order")
            {
                if (MessageBox.Show("To make an order go to Client Edit tab, select a client and press 'Make an order'. \nDo you want to go to 'Clients' now?", "Go to 'Clients'?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    OpenCientEditTab();
            }
            CurrentSort();
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            SaveAll();
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            if(currentTableName == "Brand")
            {
                var editForm = new EditBrand_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    clientTableAdapter.Fill(rentalPointDataSet.Client);
                    rentalPointDataSet.AcceptChanges();
                }
            }
            else if (currentTableName == "Client")
            {
                var editForm = new EditClient_Form(id);
                if(editForm.ShowDialog() == DialogResult.OK)
                {
                    clientTableAdapter.Fill(rentalPointDataSet.Client);
                    rentalPointDataSet.AcceptChanges();
                    //if(usingSpecialTable)
                    //{
                    //    var rows = clientTableAdapter.WhereId(id);
                    //    var row = rows[0].ItemArray;
                    //    EditFilter(row, id);
                    //    Current_dataTable.AcceptChanges();
                    //}
                    QueryEdit(Properties.Resources.ClientFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "Detail")
            {
                var editForm = new EditDetail_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    detailTableAdapter.Fill(rentalPointDataSet.Detail);
                    rentalPointDataSet.AcceptChanges();
                    //if (usingSpecialTable)
                    //{
                    //    var rows = detailTableAdapter.WhereId(id);
                    //    var row = rows[0].ItemArray;
                    //    EditFilter(row, id);
                    //}
                    QueryEdit(Properties.Resources.DetailFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "DiscountType")
            {
                var editForm = new EditDiscountType_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    discountTypeTableAdapter.Fill(rentalPointDataSet.DiscountType);
                    rentalPointDataSet.AcceptChanges();
                }
            }
            else if (currentTableName == "Good")
            {
                var editForm = new EditGood_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    goodTableAdapter.Fill(rentalPointDataSet.Good);
                    rentalPointDataSet.AcceptChanges();
                    if (usingSpecialTable)
                    {
                        var rows = detailTableAdapter.WhereId(id);
                        var row = rows[0].ItemArray;
                        EditFilter(row, id);
                    }
                }
            }
            else if (currentTableName == "Model")
            {
                var editForm = new EditModel_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    modelTableAdapter.Fill(rentalPointDataSet.Model);
                    rentalPointDataSet.AcceptChanges();
                    QueryEdit(Properties.Resources.ModelFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "ModelType")
            {
                var editForm = new EditModelType_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    modelTypeTableAdapter.Fill(rentalPointDataSet.ModelType);
                    rentalPointDataSet.AcceptChanges();
                }
            }
            else if (currentTableName == "Producer")
            {
                var editForm = new EditProducer_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    producerTableAdapter.Fill(rentalPointDataSet.Producer);
                    rentalPointDataSet.AcceptChanges();
                }
            }
            else if (currentTableName == "Product")
            {
                var editForm = new EditProduct_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    productTableAdapter.Fill(rentalPointDataSet.Product);
                    rentalPointDataSet.AcceptChanges();
                    //if (usingSpecialTable)
                    //{
                    //    var rows = productTableAdapter.WhereId(id);
                    //    var row = rows[0].ItemArray;
                    //    EditFilter(row, id);
                    //}
                    QueryEdit(Properties.Resources.ProductFill);
                    ApplyFilter();
                    CurrentSort();
                }
            }
            else if (currentTableName == "Order")
            {
                var editForm = new EditOrder_Form(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    productTableAdapter.Fill(rentalPointDataSet.Product);
                    rentalPointDataSet.AcceptChanges();
                }
            }
            CurrentSort();
        }
        private void EditFilter(object[] row, int id)
        {
            foreach (DataRow filterRow in Current_dataTable.Rows)
                if (Convert.ToInt32(filterRow[0]) == id)
                {
                    for (int i = 0; i < filterRow.ItemArray.Length; i++)
                        filterRow[i] = row[i];
                    break;
                }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            SaveAll();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //if (MessageBox.Show($"Do you realy want to delete row where id = {id}?", "Delete row", MessageBoxButtons.YesNo) == DialogResult.No)
            //    return;

            if (currentTableName == "Brand")
            {
                int countReferences = Convert.ToInt32(modelTableAdapter.CountBrandReferences(id));
                if (countReferences > 0)
                {
                    MessageBox.Show("There is some connected data in table 'Model'. Delete it before.");
                    return;
                }
                else
                {
                    brandTableAdapter.DeleteQuery(id);
                    brandTableAdapter.Fill(rentalPointDataSet.Brand);
                    rentalPointDataSet.AcceptChanges();
                }
            }
            else if (currentTableName == "Client")
            {
                try
                {
                    clientTableAdapter.DeleteQuery(id);
                    if (usingSpecialTable)
                        DeleteFromFilter(id);
                    clientTableAdapter.Fill(rentalPointDataSet.Client);
                    rentalPointDataSet.AcceptChanges();
                }
                catch
                {
                    MessageBox.Show("There is some connected data in table 'Order'. Delete it before.");
                    return;
                }
            }
            else if (currentTableName == "Detail")
            {
                try
                {
                    detailTableAdapter.DeleteQuery(id);
                    detailTableAdapter.Fill(rentalPointDataSet.Detail);
                    rentalPointDataSet.AcceptChanges();
                    if (usingSpecialTable)
                        DeleteFromFilter(id);
                }
                catch { MessageBox.Show("There is some connected data in table 'Set'. Go to table 'Product' and delete it in compatible details."); return; }

            }
            else if (currentTableName == "DiscountType")
            {
                try
                {
                    discountTypeTableAdapter.DeleteQuery(id);
                    discountTypeTableAdapter.Fill(rentalPointDataSet.DiscountType);
                    rentalPointDataSet.AcceptChanges();
                }
                catch { MessageBox.Show("There is some connected data in table 'Client'. Delete it before."); return; }
            }
            else if (currentTableName == "Good")
            {
                try
                {
                    goodTableAdapter.DeleteQuery(id);
                    goodTableAdapter.Fill(rentalPointDataSet.Good);
                    rentalPointDataSet.AcceptChanges();
                    if (usingSpecialTable)
                        DeleteFromFilter(id);
                }
                catch { MessageBox.Show("There is some connected data in table 'Order'. Delete it before."); return; }

            }
            else if (currentTableName == "Model")
            {
                try
                {
                    modelTableAdapter.DeleteQuery(id);
                    modelTableAdapter.Fill(rentalPointDataSet.Model);
                    rentalPointDataSet.AcceptChanges();
                }
                catch { MessageBox.Show("There is some connected data in table 'Product' or in table 'Detail'. Delete it before."); return; }
            }
            else if (currentTableName == "ModelType")
            {
                try
                {
                    modelTypeTableAdapter.DeleteQuery(id);
                    modelTypeTableAdapter.Fill(rentalPointDataSet.ModelType);
                    rentalPointDataSet.AcceptChanges();
                }
                catch { MessageBox.Show("There is some connected data in table 'Client'. Delete it before."); return; }
            }
            else if (currentTableName == "Producer")
            {
                try
                {
                    producerTableAdapter.DeleteQuery(id);
                    producerTableAdapter.Fill(rentalPointDataSet.Producer);
                    rentalPointDataSet.AcceptChanges();
                }
                catch { MessageBox.Show("There is some connected data in table 'Product' or in table 'Detail'. Delete it before."); return; }
            }
            else if (currentTableName == "Product")
            {
                try
                {
                    productTableAdapter.DeleteQuery(id);
                    productTableAdapter.Fill(rentalPointDataSet.Product);
                    rentalPointDataSet.AcceptChanges();
                    if (usingSpecialTable)
                        DeleteFromFilter(id);
                }
                catch { MessageBox.Show("There is some connected data in table 'Good' or in its compatible details. Delete it before."); return; }
            }
            else if (currentTableName == "Order")
            {
                DataTable attachments = new DataTable();
                SQLCommandParams par = new SQLCommandParams { FieldName = "order_id", Text = id.ToString() };
                Query(attachments, Properties.Resources.OrderAttachments, par);
                foreach (DataRow a in attachments.Rows)
                    ReturnDetails(Convert.ToInt32(a[0]));
                orderTableAdapter.DeleteQuery(id);
                orderTableAdapter.Fill(rentalPointDataSet.Order);
                rentalPointDataSet.AcceptChanges();
            }
            CurrentSort();
        }
        private void ReturnDetails(int attachment_id) //Returns details to datail table from attachment
        {
            var attachmentRow = attachmentTableAdapter.WhereId(attachment_id)[0];
            int attAmount = Convert.ToInt32(attachmentRow[3]);
            int[] detail = GetDetailByAttachment(attachment_id);
            detailTableAdapter.UpdateAmount(detail[1] + attAmount, detail[0]);
        }
        private int[] GetDetailByAttachment(int attachment_id)
        {
            var dataTable = new DataTable();
            SQLCommandParams par = new SQLCommandParams { FieldName = "attachment_id", Text = attachment_id.ToString() };
            Query(dataTable, Properties.Resources.GetDetailByAttachment, par);

            int[] arr;
            if (dataTable.Rows.Count == 0)
                return null;
            var oArr = dataTable.Rows[0].ItemArray;
            arr = new int[2];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(oArr[i]);
            return arr;
        }
        private DataTable Query(DataTable table, string commandText, params SQLCommandParams[] commandParams)
        {
            table = table ?? new DataTable();
            var connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = commandText;
                        foreach (var a in commandParams)
                            command.Parameters.AddWithValue(a.FieldName, a.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Oops... Something went wrong... Error: {ex.Message}.");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return table;
        }
        private void DeleteFromFilter(int id)
        {
            for (int i = 0; i < Current_dataTable.Rows.Count; i++)
                if (Convert.ToInt32(Current_dataTable.Rows[i].ItemArray[0]) == id)
                    Current_dataTable.Rows[i].Delete();
        }

        // The magic MyLabel initializing throws changes in this.Text
        private void MainForm_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Technical Equipment Rental Point";
        }
        private void makeAnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currentTableName != "Client")
            {
                if (MessageBox.Show("To make an order go to Client Edit tab, select a client and press 'Make an order'. \n Do you want to go to 'Clients' now?", "Go to 'Clients'?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    OpenCientEditTab();
            }
            else
            {
                DataGridViewRow row;
                if ((row = dataGridView1.SelectedRows[0]) == null)
                    MessageBox.Show("No Client selected. Please, select one.");
                else
                {
                    Order_Form orderForm = new Order_Form(Convert.ToInt32(row.Cells[0].Value));
                    orderForm.ShowDialog();
                    clientTableAdapter.Fill(rentalPointDataSet.Client);
                }
            }
        }
        private void QueryEdit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryEdit_Form queryEdit_Form = new QueryEdit_Form();
            queryEdit_Form.ShowDialog();
        }
        private void Set_button_Click(object sender, EventArgs e)
        {
            if (currentTableName == "Client")
            {
                if(dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No row selected. Please select one.");
                    return;
                }
                var row = dataGridView1.SelectedRows[0];
                var form = new ClientRentHistory_Form(Convert.ToInt32(row.Cells[0].Value));
                form.ShowDialog();
                rentTableAdapter.Fill(rentalPointDataSet.Rent);
                attachmentTableAdapter.Fill(rentalPointDataSet.Attachment);
            }
            else if (currentTableName == "Product")
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No row selected. Please select one.");
                    return;
                }
                var row = dataGridView1.SelectedRows[0];
                var form = new ProductCompatibleDetails_Form(Convert.ToInt32(row.Cells[0].Value));
                form.ShowDialog();
                setTableAdapter.Fill(rentalPointDataSet.Set);
            }
            if (currentTableName == "Order")
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No row selected. Please select one.");
                    return;
                }
                var row = dataGridView1.SelectedRows[0];
                var form = new OrderRents(Convert.ToInt32(row.Cells[0].Value));
                form.ShowDialog();
            }
            else
                return;
        }
        private void clientActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form("Client Activity");
            form.ShowDialog();
        }
        private void clientPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form("Client Paid");
            form.ShowDialog();
        }
        private void detailsPopularityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form("Detail Popularity");
            form.ShowDialog();
        }
        private void productsPopularityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics_Form form = new Statistics_Form("Product Popularity");
            form.ShowDialog();
        }
        private void makeAReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTableName != "Client")
            {
                if (MessageBox.Show("To make an order go to Client Edit tab, select a client and press 'Make an order'. \n Do you want to go to 'Clients' now?", "Go to 'Clients'?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    OpenCientEditTab();
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    MessageBox.Show("No Client selected. Please, select one.");
                else
                {
                    var row = dataGridView1.SelectedRows[0];
                    var form = new ClientRentHistory_Form(Convert.ToInt32(row.Cells[0].Value));
                    form.ShowDialog();
                    rentTableAdapter.Fill(rentalPointDataSet.Rent);
                    attachmentTableAdapter.Fill(rentalPointDataSet.Attachment);
                }
            }
        }
    }
}