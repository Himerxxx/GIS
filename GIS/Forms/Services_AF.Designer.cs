
namespace GIS.Forms
{
    partial class Services_AF
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
            System.Windows.Forms.Label iD_PD_NumberLabel;
            System.Windows.Forms.Label servicesLabel;
            System.Windows.Forms.Label metod_Det_V_ServiseLabel;
            System.Windows.Forms.Label v_S_Count_ServiseLabel;
            System.Windows.Forms.Label metod_Det_V_ResoursesLabel;
            System.Windows.Forms.Label v_S_Count_ResoursesLabel;
            System.Windows.Forms.Label tarifLabel;
            System.Windows.Forms.Label accrued_Pilling_PeriodLabel;
            System.Windows.Forms.Label total_PeriodLabel;
            System.Windows.Forms.Label increase_CoefLabel;
            System.Windows.Forms.Label value_Increase_PaymentLabel;
            System.Windows.Forms.Label benefitsLabel;
            System.Windows.Forms.Label order_PaymentLabel;
            System.Windows.Forms.Label debt_AvansLabel;
            System.Windows.Forms.Label penaltyLabel;
            System.Windows.Forms.Label penalty_ProviderLabel;
            System.Windows.Forms.Label state_DutiesLabel;
            System.Windows.Forms.Label jud_CostLabel;
            System.Windows.Forms.Label recalculationsLabel;
            System.Windows.Forms.Label sum_RecalculationsLabel;
            System.Windows.Forms.Label installment_Payment_ValueLabel;
            System.Windows.Forms.Label installment_Payment_PercentLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.services_For_The_Payment_PeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.services_For_The_Payment_PeriodTableAdapter = new GIS.GISDataSetTableAdapters.Services_For_The_Payment_PeriodTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.payment_DocumentTableAdapter = new GIS.GISDataSetTableAdapters.Payment_DocumentTableAdapter();
            this.services_For_The_Payment_PeriodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.v_S_Count_ServiseTextBox = new System.Windows.Forms.TextBox();
            this.v_S_Count_ResoursesTextBox = new System.Windows.Forms.TextBox();
            this.tarifTextBox = new System.Windows.Forms.TextBox();
            this.accrued_Pilling_PeriodTextBox = new System.Windows.Forms.TextBox();
            this.total_PeriodTextBox = new System.Windows.Forms.TextBox();
            this.increase_CoefTextBox = new System.Windows.Forms.TextBox();
            this.value_Increase_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.benefitsTextBox = new System.Windows.Forms.TextBox();
            this.order_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.debt_AvansTextBox = new System.Windows.Forms.TextBox();
            this.penaltyTextBox = new System.Windows.Forms.TextBox();
            this.penalty_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.state_DutiesTextBox = new System.Windows.Forms.TextBox();
            this.jud_CostTextBox = new System.Windows.Forms.TextBox();
            this.recalculationsTextBox = new System.Windows.Forms.TextBox();
            this.sum_RecalculationsTextBox = new System.Windows.Forms.TextBox();
            this.installment_Payment_ValueTextBox = new System.Windows.Forms.TextBox();
            this.installment_Payment_PercentTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paymentDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            iD_PD_NumberLabel = new System.Windows.Forms.Label();
            servicesLabel = new System.Windows.Forms.Label();
            metod_Det_V_ServiseLabel = new System.Windows.Forms.Label();
            v_S_Count_ServiseLabel = new System.Windows.Forms.Label();
            metod_Det_V_ResoursesLabel = new System.Windows.Forms.Label();
            v_S_Count_ResoursesLabel = new System.Windows.Forms.Label();
            tarifLabel = new System.Windows.Forms.Label();
            accrued_Pilling_PeriodLabel = new System.Windows.Forms.Label();
            total_PeriodLabel = new System.Windows.Forms.Label();
            increase_CoefLabel = new System.Windows.Forms.Label();
            value_Increase_PaymentLabel = new System.Windows.Forms.Label();
            benefitsLabel = new System.Windows.Forms.Label();
            order_PaymentLabel = new System.Windows.Forms.Label();
            debt_AvansLabel = new System.Windows.Forms.Label();
            penaltyLabel = new System.Windows.Forms.Label();
            penalty_ProviderLabel = new System.Windows.Forms.Label();
            state_DutiesLabel = new System.Windows.Forms.Label();
            jud_CostLabel = new System.Windows.Forms.Label();
            recalculationsLabel = new System.Windows.Forms.Label();
            sum_RecalculationsLabel = new System.Windows.Forms.Label();
            installment_Payment_ValueLabel = new System.Windows.Forms.Label();
            installment_Payment_PercentLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.services_For_The_Payment_PeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.services_For_The_Payment_PeriodBindingNavigator)).BeginInit();
            this.services_For_The_Payment_PeriodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PD_NumberLabel
            // 
            iD_PD_NumberLabel.AutoSize = true;
            iD_PD_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_PD_NumberLabel.Location = new System.Drawing.Point(169, 49);
            iD_PD_NumberLabel.Name = "iD_PD_NumberLabel";
            iD_PD_NumberLabel.Size = new System.Drawing.Size(98, 17);
            iD_PD_NumberLabel.TabIndex = 1;
            iD_PD_NumberLabel.Text = "Номер записи:";
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            servicesLabel.Location = new System.Drawing.Point(213, 93);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new System.Drawing.Size(54, 17);
            servicesLabel.TabIndex = 3;
            servicesLabel.Text = "Услуга:";
            // 
            // metod_Det_V_ServiseLabel
            // 
            metod_Det_V_ServiseLabel.AutoSize = true;
            metod_Det_V_ServiseLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            metod_Det_V_ServiseLabel.Location = new System.Drawing.Point(46, 136);
            metod_Det_V_ServiseLabel.Name = "metod_Det_V_ServiseLabel";
            metod_Det_V_ServiseLabel.Size = new System.Drawing.Size(221, 17);
            metod_Det_V_ServiseLabel.TabIndex = 5;
            metod_Det_V_ServiseLabel.Text = "Способ определения объемов КУ:";
            // 
            // v_S_Count_ServiseLabel
            // 
            v_S_Count_ServiseLabel.AutoSize = true;
            v_S_Count_ServiseLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            v_S_Count_ServiseLabel.Location = new System.Drawing.Point(74, 180);
            v_S_Count_ServiseLabel.Name = "v_S_Count_ServiseLabel";
            v_S_Count_ServiseLabel.Size = new System.Drawing.Size(193, 17);
            v_S_Count_ServiseLabel.TabIndex = 7;
            v_S_Count_ServiseLabel.Text = "Объем, площадь, количество:";
            // 
            // metod_Det_V_ResoursesLabel
            // 
            metod_Det_V_ResoursesLabel.AutoSize = true;
            metod_Det_V_ResoursesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            metod_Det_V_ResoursesLabel.Location = new System.Drawing.Point(46, 224);
            metod_Det_V_ResoursesLabel.Name = "metod_Det_V_ResoursesLabel";
            metod_Det_V_ResoursesLabel.Size = new System.Drawing.Size(221, 17);
            metod_Det_V_ResoursesLabel.TabIndex = 9;
            metod_Det_V_ResoursesLabel.Text = "Способ определения объемов КР:";
            // 
            // v_S_Count_ResoursesLabel
            // 
            v_S_Count_ResoursesLabel.AutoSize = true;
            v_S_Count_ResoursesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            v_S_Count_ResoursesLabel.Location = new System.Drawing.Point(74, 271);
            v_S_Count_ResoursesLabel.Name = "v_S_Count_ResoursesLabel";
            v_S_Count_ResoursesLabel.Size = new System.Drawing.Size(193, 17);
            v_S_Count_ResoursesLabel.TabIndex = 11;
            v_S_Count_ResoursesLabel.Text = "Объем, площадь, количество:";
            // 
            // tarifLabel
            // 
            tarifLabel.AutoSize = true;
            tarifLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tarifLabel.Location = new System.Drawing.Point(219, 317);
            tarifLabel.Name = "tarifLabel";
            tarifLabel.Size = new System.Drawing.Size(50, 17);
            tarifLabel.TabIndex = 13;
            tarifLabel.Text = "Тариф:";
            // 
            // accrued_Pilling_PeriodLabel
            // 
            accrued_Pilling_PeriodLabel.AutoSize = true;
            accrued_Pilling_PeriodLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            accrued_Pilling_PeriodLabel.Location = new System.Drawing.Point(56, 361);
            accrued_Pilling_PeriodLabel.Name = "accrued_Pilling_PeriodLabel";
            accrued_Pilling_PeriodLabel.Size = new System.Drawing.Size(213, 17);
            accrued_Pilling_PeriodLabel.TabIndex = 15;
            accrued_Pilling_PeriodLabel.Text = "Начислено за расчетный период:";
            // 
            // total_PeriodLabel
            // 
            total_PeriodLabel.AutoSize = true;
            total_PeriodLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_PeriodLabel.Location = new System.Drawing.Point(65, 406);
            total_PeriodLabel.Name = "total_PeriodLabel";
            total_PeriodLabel.Size = new System.Drawing.Size(202, 17);
            total_PeriodLabel.TabIndex = 17;
            total_PeriodLabel.Text = "К оплате за расчетный период:";
            // 
            // increase_CoefLabel
            // 
            increase_CoefLabel.AutoSize = true;
            increase_CoefLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            increase_CoefLabel.Location = new System.Drawing.Point(27, 451);
            increase_CoefLabel.Name = "increase_CoefLabel";
            increase_CoefLabel.Size = new System.Drawing.Size(242, 17);
            increase_CoefLabel.TabIndex = 19;
            increase_CoefLabel.Text = "Размер повышающего коэффициента:";
            // 
            // value_Increase_PaymentLabel
            // 
            value_Increase_PaymentLabel.AutoSize = true;
            value_Increase_PaymentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            value_Increase_PaymentLabel.Location = new System.Drawing.Point(87, 495);
            value_Increase_PaymentLabel.Name = "value_Increase_PaymentLabel";
            value_Increase_PaymentLabel.Size = new System.Drawing.Size(180, 17);
            value_Increase_PaymentLabel.TabIndex = 21;
            value_Increase_PaymentLabel.Text = "Размер превышения платы:";
            // 
            // benefitsLabel
            // 
            benefitsLabel.AutoSize = true;
            benefitsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            benefitsLabel.Location = new System.Drawing.Point(144, 538);
            benefitsLabel.Name = "benefitsLabel";
            benefitsLabel.Size = new System.Drawing.Size(123, 17);
            benefitsLabel.TabIndex = 23;
            benefitsLabel.Text = "Льготы, субсидии:";
            // 
            // order_PaymentLabel
            // 
            order_PaymentLabel.AutoSize = true;
            order_PaymentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_PaymentLabel.Location = new System.Drawing.Point(589, 51);
            order_PaymentLabel.Name = "order_PaymentLabel";
            order_PaymentLabel.Size = new System.Drawing.Size(126, 17);
            order_PaymentLabel.TabIndex = 25;
            order_PaymentLabel.Text = "Порядок расчетов:";
            // 
            // debt_AvansLabel
            // 
            debt_AvansLabel.AutoSize = true;
            debt_AvansLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            debt_AvansLabel.Location = new System.Drawing.Point(506, 102);
            debt_AvansLabel.Name = "debt_AvansLabel";
            debt_AvansLabel.Size = new System.Drawing.Size(208, 51);
            debt_AvansLabel.TabIndex = 27;
            debt_AvansLabel.Text = "Задолженность за предыдущие \r\nпериоды / Аванс \r\nна начало расчетного периода:";
            // 
            // penaltyLabel
            // 
            penaltyLabel.AutoSize = true;
            penaltyLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            penaltyLabel.Location = new System.Drawing.Point(637, 181);
            penaltyLabel.Name = "penaltyLabel";
            penaltyLabel.Size = new System.Drawing.Size(78, 17);
            penaltyLabel.TabIndex = 29;
            penaltyLabel.Text = "Неустойка:";
            // 
            // penalty_ProviderLabel
            // 
            penalty_ProviderLabel.AutoSize = true;
            penalty_ProviderLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            penalty_ProviderLabel.Location = new System.Drawing.Point(542, 225);
            penalty_ProviderLabel.Name = "penalty_ProviderLabel";
            penalty_ProviderLabel.Size = new System.Drawing.Size(177, 17);
            penalty_ProviderLabel.TabIndex = 31;
            penalty_ProviderLabel.Text = "Штраф исполнителя работ:";
            // 
            // state_DutiesLabel
            // 
            state_DutiesLabel.AutoSize = true;
            state_DutiesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            state_DutiesLabel.Location = new System.Drawing.Point(535, 272);
            state_DutiesLabel.Name = "state_DutiesLabel";
            state_DutiesLabel.Size = new System.Drawing.Size(180, 17);
            state_DutiesLabel.TabIndex = 33;
            state_DutiesLabel.Text = "Государственные пошлины:";
            // 
            // jud_CostLabel
            // 
            jud_CostLabel.AutoSize = true;
            jud_CostLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            jud_CostLabel.Location = new System.Drawing.Point(578, 318);
            jud_CostLabel.Name = "jud_CostLabel";
            jud_CostLabel.Size = new System.Drawing.Size(137, 17);
            jud_CostLabel.TabIndex = 35;
            jud_CostLabel.Text = "Судебные издержки:";
            // 
            // recalculationsLabel
            // 
            recalculationsLabel.AutoSize = true;
            recalculationsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            recalculationsLabel.Location = new System.Drawing.Point(548, 362);
            recalculationsLabel.Name = "recalculationsLabel";
            recalculationsLabel.Size = new System.Drawing.Size(167, 17);
            recalculationsLabel.TabIndex = 37;
            recalculationsLabel.Text = "Основания перерасчетов:";
            // 
            // sum_RecalculationsLabel
            // 
            sum_RecalculationsLabel.AutoSize = true;
            sum_RecalculationsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sum_RecalculationsLabel.Location = new System.Drawing.Point(571, 407);
            sum_RecalculationsLabel.Name = "sum_RecalculationsLabel";
            sum_RecalculationsLabel.Size = new System.Drawing.Size(144, 17);
            sum_RecalculationsLabel.TabIndex = 39;
            sum_RecalculationsLabel.Text = "Сумма перерасчетов:";
            // 
            // installment_Payment_ValueLabel
            // 
            installment_Payment_ValueLabel.AutoSize = true;
            installment_Payment_ValueLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            installment_Payment_ValueLabel.Location = new System.Drawing.Point(580, 452);
            installment_Payment_ValueLabel.Name = "installment_Payment_ValueLabel";
            installment_Payment_ValueLabel.Size = new System.Drawing.Size(135, 17);
            installment_Payment_ValueLabel.TabIndex = 41;
            installment_Payment_ValueLabel.Text = "Плата за рассрочку:";
            // 
            // installment_Payment_PercentLabel
            // 
            installment_Payment_PercentLabel.AutoSize = true;
            installment_Payment_PercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            installment_Payment_PercentLabel.Location = new System.Drawing.Point(566, 496);
            installment_Payment_PercentLabel.Name = "installment_Payment_PercentLabel";
            installment_Payment_PercentLabel.Size = new System.Drawing.Size(149, 17);
            installment_Payment_PercentLabel.TabIndex = 43;
            installment_Payment_PercentLabel.Text = "Процент за рассрочку:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalLabel.Location = new System.Drawing.Point(575, 539);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(140, 17);
            totalLabel.TabIndex = 45;
            totalLabel.Text = "ИТОГО К ОПЛАТЕ:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // services_For_The_Payment_PeriodBindingSource
            // 
            this.services_For_The_Payment_PeriodBindingSource.DataMember = "Services_For_The_Payment_Period";
            this.services_For_The_Payment_PeriodBindingSource.DataSource = this.gISDataSet;
            // 
            // services_For_The_Payment_PeriodTableAdapter
            // 
            this.services_For_The_Payment_PeriodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Address_BookTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Characteristic_MKDTableAdapter = null;
            this.tableAdapterManager.EntranceTableAdapter = null;
            this.tableAdapterManager.General_Metering_DeviceTableAdapter = null;
            this.tableAdapterManager.LSTableAdapter = null;
            this.tableAdapterManager.Metering_DevicesTableAdapter = null;
            this.tableAdapterManager.MKD_PremisesTableAdapter = null;
            this.tableAdapterManager.Owner_LSTableAdapter = null;
            this.tableAdapterManager.Payment_DocumentTableAdapter = this.payment_DocumentTableAdapter;
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = null;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = this.services_For_The_Payment_PeriodTableAdapter;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // payment_DocumentTableAdapter
            // 
            this.payment_DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // services_For_The_Payment_PeriodBindingNavigator
            // 
            this.services_For_The_Payment_PeriodBindingNavigator.AddNewItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.services_For_The_Payment_PeriodBindingNavigator.BindingSource = this.services_For_The_Payment_PeriodBindingSource;
            this.services_For_The_Payment_PeriodBindingNavigator.CountItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.DeleteItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem});
            this.services_For_The_Payment_PeriodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.services_For_The_Payment_PeriodBindingNavigator.MoveFirstItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.MoveLastItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.MoveNextItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.MovePreviousItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.Name = "services_For_The_Payment_PeriodBindingNavigator";
            this.services_For_The_Payment_PeriodBindingNavigator.PositionItem = null;
            this.services_For_The_Payment_PeriodBindingNavigator.Size = new System.Drawing.Size(942, 25);
            this.services_For_The_Payment_PeriodBindingNavigator.TabIndex = 0;
            this.services_For_The_Payment_PeriodBindingNavigator.Text = "bindingNavigator1";
            // 
            // services_For_The_Payment_PeriodBindingNavigatorSaveItem
            // 
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("services_For_The_Payment_PeriodBindingNavigatorSaveItem.Image")));
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Name = "services_For_The_Payment_PeriodBindingNavigatorSaveItem";
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.services_For_The_Payment_PeriodBindingNavigatorSaveItem.Click += new System.EventHandler(this.services_For_The_Payment_PeriodBindingNavigatorSaveItem_Click);
            // 
            // v_S_Count_ServiseTextBox
            // 
            this.v_S_Count_ServiseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "V_S_Count_Servise", true));
            this.v_S_Count_ServiseTextBox.Location = new System.Drawing.Point(273, 179);
            this.v_S_Count_ServiseTextBox.Name = "v_S_Count_ServiseTextBox";
            this.v_S_Count_ServiseTextBox.Size = new System.Drawing.Size(184, 20);
            this.v_S_Count_ServiseTextBox.TabIndex = 8;
            // 
            // v_S_Count_ResoursesTextBox
            // 
            this.v_S_Count_ResoursesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "V_S_Count_Resourses", true));
            this.v_S_Count_ResoursesTextBox.Location = new System.Drawing.Point(273, 270);
            this.v_S_Count_ResoursesTextBox.Name = "v_S_Count_ResoursesTextBox";
            this.v_S_Count_ResoursesTextBox.Size = new System.Drawing.Size(184, 20);
            this.v_S_Count_ResoursesTextBox.TabIndex = 12;
            // 
            // tarifTextBox
            // 
            this.tarifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Tarif", true));
            this.tarifTextBox.Location = new System.Drawing.Point(273, 316);
            this.tarifTextBox.Name = "tarifTextBox";
            this.tarifTextBox.Size = new System.Drawing.Size(184, 20);
            this.tarifTextBox.TabIndex = 14;
            // 
            // accrued_Pilling_PeriodTextBox
            // 
            this.accrued_Pilling_PeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Accrued_Pilling_Period", true));
            this.accrued_Pilling_PeriodTextBox.Location = new System.Drawing.Point(273, 360);
            this.accrued_Pilling_PeriodTextBox.Name = "accrued_Pilling_PeriodTextBox";
            this.accrued_Pilling_PeriodTextBox.Size = new System.Drawing.Size(184, 20);
            this.accrued_Pilling_PeriodTextBox.TabIndex = 16;
            // 
            // total_PeriodTextBox
            // 
            this.total_PeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Total_Period", true));
            this.total_PeriodTextBox.Location = new System.Drawing.Point(273, 405);
            this.total_PeriodTextBox.Name = "total_PeriodTextBox";
            this.total_PeriodTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_PeriodTextBox.TabIndex = 18;
            // 
            // increase_CoefTextBox
            // 
            this.increase_CoefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Increase_Coef", true));
            this.increase_CoefTextBox.Location = new System.Drawing.Point(273, 450);
            this.increase_CoefTextBox.Name = "increase_CoefTextBox";
            this.increase_CoefTextBox.Size = new System.Drawing.Size(184, 20);
            this.increase_CoefTextBox.TabIndex = 20;
            // 
            // value_Increase_PaymentTextBox
            // 
            this.value_Increase_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Value_Increase_Payment", true));
            this.value_Increase_PaymentTextBox.Location = new System.Drawing.Point(273, 494);
            this.value_Increase_PaymentTextBox.Name = "value_Increase_PaymentTextBox";
            this.value_Increase_PaymentTextBox.Size = new System.Drawing.Size(184, 20);
            this.value_Increase_PaymentTextBox.TabIndex = 22;
            // 
            // benefitsTextBox
            // 
            this.benefitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Benefits", true));
            this.benefitsTextBox.Location = new System.Drawing.Point(273, 537);
            this.benefitsTextBox.Name = "benefitsTextBox";
            this.benefitsTextBox.Size = new System.Drawing.Size(184, 20);
            this.benefitsTextBox.TabIndex = 24;
            // 
            // order_PaymentTextBox
            // 
            this.order_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Order_Payment", true));
            this.order_PaymentTextBox.Location = new System.Drawing.Point(720, 50);
            this.order_PaymentTextBox.Name = "order_PaymentTextBox";
            this.order_PaymentTextBox.Size = new System.Drawing.Size(184, 20);
            this.order_PaymentTextBox.TabIndex = 26;
            // 
            // debt_AvansTextBox
            // 
            this.debt_AvansTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Debt_Avans", true));
            this.debt_AvansTextBox.Location = new System.Drawing.Point(720, 120);
            this.debt_AvansTextBox.Name = "debt_AvansTextBox";
            this.debt_AvansTextBox.Size = new System.Drawing.Size(184, 20);
            this.debt_AvansTextBox.TabIndex = 28;
            // 
            // penaltyTextBox
            // 
            this.penaltyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Penalty", true));
            this.penaltyTextBox.Location = new System.Drawing.Point(720, 180);
            this.penaltyTextBox.Name = "penaltyTextBox";
            this.penaltyTextBox.Size = new System.Drawing.Size(184, 20);
            this.penaltyTextBox.TabIndex = 30;
            // 
            // penalty_ProviderTextBox
            // 
            this.penalty_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Penalty_Provider", true));
            this.penalty_ProviderTextBox.Location = new System.Drawing.Point(720, 224);
            this.penalty_ProviderTextBox.Name = "penalty_ProviderTextBox";
            this.penalty_ProviderTextBox.Size = new System.Drawing.Size(184, 20);
            this.penalty_ProviderTextBox.TabIndex = 32;
            // 
            // state_DutiesTextBox
            // 
            this.state_DutiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "State_Duties", true));
            this.state_DutiesTextBox.Location = new System.Drawing.Point(720, 271);
            this.state_DutiesTextBox.Name = "state_DutiesTextBox";
            this.state_DutiesTextBox.Size = new System.Drawing.Size(184, 20);
            this.state_DutiesTextBox.TabIndex = 34;
            // 
            // jud_CostTextBox
            // 
            this.jud_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Jud_Cost", true));
            this.jud_CostTextBox.Location = new System.Drawing.Point(720, 317);
            this.jud_CostTextBox.Name = "jud_CostTextBox";
            this.jud_CostTextBox.Size = new System.Drawing.Size(184, 20);
            this.jud_CostTextBox.TabIndex = 36;
            // 
            // recalculationsTextBox
            // 
            this.recalculationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Recalculations", true));
            this.recalculationsTextBox.Location = new System.Drawing.Point(720, 361);
            this.recalculationsTextBox.Name = "recalculationsTextBox";
            this.recalculationsTextBox.Size = new System.Drawing.Size(184, 20);
            this.recalculationsTextBox.TabIndex = 38;
            // 
            // sum_RecalculationsTextBox
            // 
            this.sum_RecalculationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Sum_Recalculations", true));
            this.sum_RecalculationsTextBox.Location = new System.Drawing.Point(720, 406);
            this.sum_RecalculationsTextBox.Name = "sum_RecalculationsTextBox";
            this.sum_RecalculationsTextBox.Size = new System.Drawing.Size(184, 20);
            this.sum_RecalculationsTextBox.TabIndex = 40;
            // 
            // installment_Payment_ValueTextBox
            // 
            this.installment_Payment_ValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Installment_Payment_Value", true));
            this.installment_Payment_ValueTextBox.Location = new System.Drawing.Point(720, 451);
            this.installment_Payment_ValueTextBox.Name = "installment_Payment_ValueTextBox";
            this.installment_Payment_ValueTextBox.Size = new System.Drawing.Size(184, 20);
            this.installment_Payment_ValueTextBox.TabIndex = 42;
            // 
            // installment_Payment_PercentTextBox
            // 
            this.installment_Payment_PercentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Installment_Payment_Percent", true));
            this.installment_Payment_PercentTextBox.Location = new System.Drawing.Point(720, 495);
            this.installment_Payment_PercentTextBox.Name = "installment_Payment_PercentTextBox";
            this.installment_Payment_PercentTextBox.Size = new System.Drawing.Size(184, 20);
            this.installment_Payment_PercentTextBox.TabIndex = 44;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.services_For_The_Payment_PeriodBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(720, 538);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(184, 20);
            this.totalTextBox.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.services_For_The_Payment_PeriodBindingSource, "ID_PD_Number", true));
            this.comboBox1.DataSource = this.paymentDocumentBindingSource;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.ValueMember = "ID";
            // 
            // paymentDocumentBindingSource
            // 
            this.paymentDocumentBindingSource.DataMember = "Payment_Document";
            this.paymentDocumentBindingSource.DataSource = this.gISDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(273, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 48;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(273, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(184, 21);
            this.comboBox3.TabIndex = 49;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(273, 223);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(184, 21);
            this.comboBox4.TabIndex = 50;
            // 
            // Services_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 575);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(installment_Payment_PercentLabel);
            this.Controls.Add(this.installment_Payment_PercentTextBox);
            this.Controls.Add(installment_Payment_ValueLabel);
            this.Controls.Add(this.installment_Payment_ValueTextBox);
            this.Controls.Add(sum_RecalculationsLabel);
            this.Controls.Add(this.sum_RecalculationsTextBox);
            this.Controls.Add(recalculationsLabel);
            this.Controls.Add(this.recalculationsTextBox);
            this.Controls.Add(jud_CostLabel);
            this.Controls.Add(this.jud_CostTextBox);
            this.Controls.Add(state_DutiesLabel);
            this.Controls.Add(this.state_DutiesTextBox);
            this.Controls.Add(penalty_ProviderLabel);
            this.Controls.Add(this.penalty_ProviderTextBox);
            this.Controls.Add(penaltyLabel);
            this.Controls.Add(this.penaltyTextBox);
            this.Controls.Add(debt_AvansLabel);
            this.Controls.Add(this.debt_AvansTextBox);
            this.Controls.Add(order_PaymentLabel);
            this.Controls.Add(this.order_PaymentTextBox);
            this.Controls.Add(benefitsLabel);
            this.Controls.Add(this.benefitsTextBox);
            this.Controls.Add(value_Increase_PaymentLabel);
            this.Controls.Add(this.value_Increase_PaymentTextBox);
            this.Controls.Add(increase_CoefLabel);
            this.Controls.Add(this.increase_CoefTextBox);
            this.Controls.Add(total_PeriodLabel);
            this.Controls.Add(this.total_PeriodTextBox);
            this.Controls.Add(accrued_Pilling_PeriodLabel);
            this.Controls.Add(this.accrued_Pilling_PeriodTextBox);
            this.Controls.Add(tarifLabel);
            this.Controls.Add(this.tarifTextBox);
            this.Controls.Add(v_S_Count_ResoursesLabel);
            this.Controls.Add(this.v_S_Count_ResoursesTextBox);
            this.Controls.Add(metod_Det_V_ResoursesLabel);
            this.Controls.Add(v_S_Count_ServiseLabel);
            this.Controls.Add(this.v_S_Count_ServiseTextBox);
            this.Controls.Add(metod_Det_V_ServiseLabel);
            this.Controls.Add(servicesLabel);
            this.Controls.Add(iD_PD_NumberLabel);
            this.Controls.Add(this.services_For_The_Payment_PeriodBindingNavigator);
            this.Name = "Services_AF";
            this.Opacity = 0.95D;
            this.Text = "Добавление записи в таблицу: Услуги за расчетный период";
            this.Load += new System.EventHandler(this.Services_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.services_For_The_Payment_PeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.services_For_The_Payment_PeriodBindingNavigator)).EndInit();
            this.services_For_The_Payment_PeriodBindingNavigator.ResumeLayout(false);
            this.services_For_The_Payment_PeriodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource services_For_The_Payment_PeriodBindingSource;
        private GISDataSetTableAdapters.Services_For_The_Payment_PeriodTableAdapter services_For_The_Payment_PeriodTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator services_For_The_Payment_PeriodBindingNavigator;
        private System.Windows.Forms.TextBox v_S_Count_ServiseTextBox;
        private System.Windows.Forms.TextBox v_S_Count_ResoursesTextBox;
        private System.Windows.Forms.TextBox tarifTextBox;
        private System.Windows.Forms.TextBox accrued_Pilling_PeriodTextBox;
        private System.Windows.Forms.TextBox total_PeriodTextBox;
        private System.Windows.Forms.TextBox increase_CoefTextBox;
        private System.Windows.Forms.TextBox value_Increase_PaymentTextBox;
        private System.Windows.Forms.TextBox benefitsTextBox;
        private System.Windows.Forms.TextBox order_PaymentTextBox;
        private System.Windows.Forms.TextBox debt_AvansTextBox;
        private System.Windows.Forms.TextBox penaltyTextBox;
        private System.Windows.Forms.TextBox penalty_ProviderTextBox;
        private System.Windows.Forms.TextBox state_DutiesTextBox;
        private System.Windows.Forms.TextBox jud_CostTextBox;
        private System.Windows.Forms.TextBox recalculationsTextBox;
        private System.Windows.Forms.TextBox sum_RecalculationsTextBox;
        private System.Windows.Forms.TextBox installment_Payment_ValueTextBox;
        private System.Windows.Forms.TextBox installment_Payment_PercentTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private GISDataSetTableAdapters.Payment_DocumentTableAdapter payment_DocumentTableAdapter;
        private System.Windows.Forms.BindingSource paymentDocumentBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.ToolStripButton services_For_The_Payment_PeriodBindingNavigatorSaveItem;
    }
}