
namespace GIS.Forms
{
    partial class PD_AF
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
            System.Windows.Forms.Label iD_LSLabel;
            System.Windows.Forms.Label type_PDLabel;
            System.Windows.Forms.Label calculation_PeriodLabel;
            System.Windows.Forms.Label total_Area_LSLabel;
            System.Windows.Forms.Label living_AreaLabel;
            System.Windows.Forms.Label heated_AreaLabel;
            System.Windows.Forms.Label count_Livivng_PeopleLabel;
            System.Windows.Forms.Label period_SumLabel;
            System.Windows.Forms.Label cash_PaidLabel;
            System.Windows.Forms.Label last_Payment_DateLabel;
            System.Windows.Forms.Label social_SupportLabel;
            System.Windows.Forms.Label total_Period_DebtLabel;
            System.Windows.Forms.Label pR_NumberLabel;
            System.Windows.Forms.Label total_PeriodLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label total_Legal_ExpensesLabel;
            System.Windows.Forms.Label full_GIS_TotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PD_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.payment_DocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payment_DocumentTableAdapter = new GIS.GISDataSetTableAdapters.Payment_DocumentTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.lSTableAdapter = new GIS.GISDataSetTableAdapters.LSTableAdapter();
            this.payment_DocumentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.payment_DocumentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.calculation_PeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.total_Area_LSTextBox = new System.Windows.Forms.TextBox();
            this.living_AreaTextBox = new System.Windows.Forms.TextBox();
            this.heated_AreaTextBox = new System.Windows.Forms.TextBox();
            this.count_Livivng_PeopleTextBox = new System.Windows.Forms.TextBox();
            this.period_SumTextBox = new System.Windows.Forms.TextBox();
            this.cash_PaidTextBox = new System.Windows.Forms.TextBox();
            this.last_Payment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.social_SupportTextBox = new System.Windows.Forms.TextBox();
            this.total_Period_DebtTextBox = new System.Windows.Forms.TextBox();
            this.pR_NumberTextBox = new System.Windows.Forms.TextBox();
            this.total_PeriodTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.total_Legal_ExpensesTextBox = new System.Windows.Forms.TextBox();
            this.full_GIS_TotalTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewAddressPremisesForPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.view_LSTableAdapter = new GIS.GISDataSetTableAdapters.View_LSTableAdapter();
            this.view_Address_Premises_For_PDTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_Premises_For_PDTableAdapter();
            iD_LSLabel = new System.Windows.Forms.Label();
            type_PDLabel = new System.Windows.Forms.Label();
            calculation_PeriodLabel = new System.Windows.Forms.Label();
            total_Area_LSLabel = new System.Windows.Forms.Label();
            living_AreaLabel = new System.Windows.Forms.Label();
            heated_AreaLabel = new System.Windows.Forms.Label();
            count_Livivng_PeopleLabel = new System.Windows.Forms.Label();
            period_SumLabel = new System.Windows.Forms.Label();
            cash_PaidLabel = new System.Windows.Forms.Label();
            last_Payment_DateLabel = new System.Windows.Forms.Label();
            social_SupportLabel = new System.Windows.Forms.Label();
            total_Period_DebtLabel = new System.Windows.Forms.Label();
            pR_NumberLabel = new System.Windows.Forms.Label();
            total_PeriodLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            total_Legal_ExpensesLabel = new System.Windows.Forms.Label();
            full_GIS_TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DocumentBindingNavigator)).BeginInit();
            this.payment_DocumentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesForPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_LSLabel
            // 
            iD_LSLabel.AutoSize = true;
            iD_LSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_LSLabel.Location = new System.Drawing.Point(132, 63);
            iD_LSLabel.Name = "iD_LSLabel";
            iD_LSLabel.Size = new System.Drawing.Size(130, 17);
            iD_LSLabel.TabIndex = 1;
            iD_LSLabel.Text = "ФИО Потребителя:";
            // 
            // type_PDLabel
            // 
            type_PDLabel.AutoSize = true;
            type_PDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_PDLabel.Location = new System.Drawing.Point(203, 114);
            type_PDLabel.Name = "type_PDLabel";
            type_PDLabel.Size = new System.Drawing.Size(59, 17);
            type_PDLabel.TabIndex = 3;
            type_PDLabel.Text = "Тип ПД:";
            // 
            // calculation_PeriodLabel
            // 
            calculation_PeriodLabel.AutoSize = true;
            calculation_PeriodLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            calculation_PeriodLabel.Location = new System.Drawing.Point(135, 161);
            calculation_PeriodLabel.Name = "calculation_PeriodLabel";
            calculation_PeriodLabel.Size = new System.Drawing.Size(127, 17);
            calculation_PeriodLabel.TabIndex = 5;
            calculation_PeriodLabel.Text = "Расчетный период:";
            // 
            // total_Area_LSLabel
            // 
            total_Area_LSLabel.AutoSize = true;
            total_Area_LSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Area_LSLabel.Location = new System.Drawing.Point(99, 206);
            total_Area_LSLabel.Name = "total_Area_LSLabel";
            total_Area_LSLabel.Size = new System.Drawing.Size(163, 17);
            total_Area_LSLabel.TabIndex = 7;
            total_Area_LSLabel.Text = "Общая площадь для ЛС:";
            // 
            // living_AreaLabel
            // 
            living_AreaLabel.AutoSize = true;
            living_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            living_AreaLabel.Location = new System.Drawing.Point(152, 252);
            living_AreaLabel.Name = "living_AreaLabel";
            living_AreaLabel.Size = new System.Drawing.Size(110, 17);
            living_AreaLabel.TabIndex = 9;
            living_AreaLabel.Text = "Жилая площадь:";
            // 
            // heated_AreaLabel
            // 
            heated_AreaLabel.AutoSize = true;
            heated_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            heated_AreaLabel.Location = new System.Drawing.Point(102, 297);
            heated_AreaLabel.Name = "heated_AreaLabel";
            heated_AreaLabel.Size = new System.Drawing.Size(160, 17);
            heated_AreaLabel.TabIndex = 11;
            heated_AreaLabel.Text = "Отапливаемая площадь:";
            // 
            // count_Livivng_PeopleLabel
            // 
            count_Livivng_PeopleLabel.AutoSize = true;
            count_Livivng_PeopleLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            count_Livivng_PeopleLabel.Location = new System.Drawing.Point(86, 344);
            count_Livivng_PeopleLabel.Name = "count_Livivng_PeopleLabel";
            count_Livivng_PeopleLabel.Size = new System.Drawing.Size(176, 17);
            count_Livivng_PeopleLabel.TabIndex = 13;
            count_Livivng_PeopleLabel.Text = "Количество проживающих:";
            // 
            // period_SumLabel
            // 
            period_SumLabel.AutoSize = true;
            period_SumLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            period_SumLabel.Location = new System.Drawing.Point(15, 392);
            period_SumLabel.Name = "period_SumLabel";
            period_SumLabel.Size = new System.Drawing.Size(247, 17);
            period_SumLabel.TabIndex = 15;
            period_SumLabel.Text = "Сумма к оплате за расчетный период:";
            // 
            // cash_PaidLabel
            // 
            cash_PaidLabel.AutoSize = true;
            cash_PaidLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cash_PaidLabel.Location = new System.Drawing.Point(70, 435);
            cash_PaidLabel.Name = "cash_PaidLabel";
            cash_PaidLabel.Size = new System.Drawing.Size(192, 17);
            cash_PaidLabel.TabIndex = 17;
            cash_PaidLabel.Text = "Оплачено денежных средств:";
            // 
            // last_Payment_DateLabel
            // 
            last_Payment_DateLabel.AutoSize = true;
            last_Payment_DateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_Payment_DateLabel.Location = new System.Drawing.Point(525, 63);
            last_Payment_DateLabel.Name = "last_Payment_DateLabel";
            last_Payment_DateLabel.Size = new System.Drawing.Size(244, 17);
            last_Payment_DateLabel.TabIndex = 19;
            last_Payment_DateLabel.Text = "Дата последней поступившей оплаты:";
            // 
            // social_SupportLabel
            // 
            social_SupportLabel.AutoSize = true;
            social_SupportLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            social_SupportLabel.Location = new System.Drawing.Point(525, 102);
            social_SupportLabel.Name = "social_SupportLabel";
            social_SupportLabel.Size = new System.Drawing.Size(248, 34);
            social_SupportLabel.TabIndex = 21;
            social_SupportLabel.Text = "Субсидии, компенсации \r\nи иные меры соц. поддержки граждан:";
            // 
            // total_Period_DebtLabel
            // 
            total_Period_DebtLabel.AutoSize = true;
            total_Period_DebtLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Period_DebtLabel.Location = new System.Drawing.Point(490, 157);
            total_Period_DebtLabel.Name = "total_Period_DebtLabel";
            total_Period_DebtLabel.Size = new System.Drawing.Size(283, 34);
            total_Period_DebtLabel.TabIndex = 23;
            total_Period_DebtLabel.Text = "Итого к оплате за расчетный \r\nпериод c учетом задолженности/переплаты:";
            // 
            // pR_NumberLabel
            // 
            pR_NumberLabel.AutoSize = true;
            pR_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pR_NumberLabel.Location = new System.Drawing.Point(535, 228);
            pR_NumberLabel.Name = "pR_NumberLabel";
            pR_NumberLabel.Size = new System.Drawing.Size(238, 17);
            pR_NumberLabel.TabIndex = 25;
            pR_NumberLabel.Text = "Номер платежного реквизита по ПД:";
            // 
            // total_PeriodLabel
            // 
            total_PeriodLabel.AutoSize = true;
            total_PeriodLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_PeriodLabel.Location = new System.Drawing.Point(532, 281);
            total_PeriodLabel.Name = "total_PeriodLabel";
            total_PeriodLabel.Size = new System.Drawing.Size(241, 17);
            total_PeriodLabel.TabIndex = 27;
            total_PeriodLabel.Text = "Итого к оплате за расчетный период:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalLabel.Location = new System.Drawing.Point(629, 331);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(140, 17);
            totalLabel.TabIndex = 29;
            totalLabel.Text = "ИТОГО К ОПЛАТЕ:";
            // 
            // total_Legal_ExpensesLabel
            // 
            total_Legal_ExpensesLabel.AutoSize = true;
            total_Legal_ExpensesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Legal_ExpensesLabel.Location = new System.Drawing.Point(548, 364);
            total_Legal_ExpensesLabel.Name = "total_Legal_ExpensesLabel";
            total_Legal_ExpensesLabel.Size = new System.Drawing.Size(225, 34);
            total_Legal_ExpensesLabel.TabIndex = 31;
            total_Legal_ExpensesLabel.Text = "Итого к оплате по \r\nнеустойкам и судебным расходам:";
            // 
            // full_GIS_TotalLabel
            // 
            full_GIS_TotalLabel.AutoSize = true;
            full_GIS_TotalLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            full_GIS_TotalLabel.Location = new System.Drawing.Point(588, 434);
            full_GIS_TotalLabel.Name = "full_GIS_TotalLabel";
            full_GIS_TotalLabel.Size = new System.Drawing.Size(181, 17);
            full_GIS_TotalLabel.TabIndex = 33;
            full_GIS_TotalLabel.Text = "РАССЧИТАНО ГИС ЖКХ:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payment_DocumentBindingSource
            // 
            this.payment_DocumentBindingSource.DataMember = "Payment_Document";
            this.payment_DocumentBindingSource.DataSource = this.gISDataSet;
            // 
            // payment_DocumentTableAdapter
            // 
            this.payment_DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Address_BookTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Characteristic_MKDTableAdapter = null;
            this.tableAdapterManager.EntranceTableAdapter = null;
            this.tableAdapterManager.General_Metering_DeviceTableAdapter = null;
            this.tableAdapterManager.LSTableAdapter = this.lSTableAdapter;
            this.tableAdapterManager.Metering_DevicesTableAdapter = null;
            this.tableAdapterManager.MKD_PremisesTableAdapter = null;
            this.tableAdapterManager.Owner_LSTableAdapter = null;
            this.tableAdapterManager.Payment_DocumentTableAdapter = this.payment_DocumentTableAdapter;
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = null;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lSTableAdapter
            // 
            this.lSTableAdapter.ClearBeforeFill = true;
            // 
            // payment_DocumentBindingNavigator
            // 
            this.payment_DocumentBindingNavigator.AddNewItem = null;
            this.payment_DocumentBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.payment_DocumentBindingNavigator.BindingSource = this.payment_DocumentBindingSource;
            this.payment_DocumentBindingNavigator.CountItem = null;
            this.payment_DocumentBindingNavigator.DeleteItem = null;
            this.payment_DocumentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payment_DocumentBindingNavigatorSaveItem});
            this.payment_DocumentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.payment_DocumentBindingNavigator.MoveFirstItem = null;
            this.payment_DocumentBindingNavigator.MoveLastItem = null;
            this.payment_DocumentBindingNavigator.MoveNextItem = null;
            this.payment_DocumentBindingNavigator.MovePreviousItem = null;
            this.payment_DocumentBindingNavigator.Name = "payment_DocumentBindingNavigator";
            this.payment_DocumentBindingNavigator.PositionItem = null;
            this.payment_DocumentBindingNavigator.Size = new System.Drawing.Size(991, 25);
            this.payment_DocumentBindingNavigator.TabIndex = 0;
            this.payment_DocumentBindingNavigator.Text = "bindingNavigator1";
            // 
            // payment_DocumentBindingNavigatorSaveItem
            // 
            this.payment_DocumentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.payment_DocumentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("payment_DocumentBindingNavigatorSaveItem.Image")));
            this.payment_DocumentBindingNavigatorSaveItem.Name = "payment_DocumentBindingNavigatorSaveItem";
            this.payment_DocumentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.payment_DocumentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.payment_DocumentBindingNavigatorSaveItem.Click += new System.EventHandler(this.payment_DocumentBindingNavigatorSaveItem_Click);
            // 
            // calculation_PeriodDateTimePicker
            // 
            this.calculation_PeriodDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payment_DocumentBindingSource, "Calculation_Period", true));
            this.calculation_PeriodDateTimePicker.Location = new System.Drawing.Point(268, 161);
            this.calculation_PeriodDateTimePicker.Name = "calculation_PeriodDateTimePicker";
            this.calculation_PeriodDateTimePicker.ShowCheckBox = true;
            this.calculation_PeriodDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.calculation_PeriodDateTimePicker.TabIndex = 6;
            // 
            // total_Area_LSTextBox
            // 
            this.total_Area_LSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Total_Area_LS", true));
            this.total_Area_LSTextBox.Location = new System.Drawing.Point(268, 205);
            this.total_Area_LSTextBox.Name = "total_Area_LSTextBox";
            this.total_Area_LSTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Area_LSTextBox.TabIndex = 8;
            // 
            // living_AreaTextBox
            // 
            this.living_AreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Living_Area", true));
            this.living_AreaTextBox.Location = new System.Drawing.Point(268, 251);
            this.living_AreaTextBox.Name = "living_AreaTextBox";
            this.living_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.living_AreaTextBox.TabIndex = 10;
            // 
            // heated_AreaTextBox
            // 
            this.heated_AreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Heated_Area", true));
            this.heated_AreaTextBox.Location = new System.Drawing.Point(268, 296);
            this.heated_AreaTextBox.Name = "heated_AreaTextBox";
            this.heated_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.heated_AreaTextBox.TabIndex = 12;
            // 
            // count_Livivng_PeopleTextBox
            // 
            this.count_Livivng_PeopleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Count_Livivng_People", true));
            this.count_Livivng_PeopleTextBox.Location = new System.Drawing.Point(268, 343);
            this.count_Livivng_PeopleTextBox.Name = "count_Livivng_PeopleTextBox";
            this.count_Livivng_PeopleTextBox.Size = new System.Drawing.Size(184, 20);
            this.count_Livivng_PeopleTextBox.TabIndex = 14;
            // 
            // period_SumTextBox
            // 
            this.period_SumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Period_Sum", true));
            this.period_SumTextBox.Location = new System.Drawing.Point(268, 391);
            this.period_SumTextBox.Name = "period_SumTextBox";
            this.period_SumTextBox.Size = new System.Drawing.Size(184, 20);
            this.period_SumTextBox.TabIndex = 16;
            // 
            // cash_PaidTextBox
            // 
            this.cash_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Cash_Paid", true));
            this.cash_PaidTextBox.Location = new System.Drawing.Point(268, 434);
            this.cash_PaidTextBox.Name = "cash_PaidTextBox";
            this.cash_PaidTextBox.Size = new System.Drawing.Size(184, 20);
            this.cash_PaidTextBox.TabIndex = 18;
            // 
            // last_Payment_DateDateTimePicker
            // 
            this.last_Payment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payment_DocumentBindingSource, "Last_Payment_Date", true));
            this.last_Payment_DateDateTimePicker.Location = new System.Drawing.Point(775, 60);
            this.last_Payment_DateDateTimePicker.Name = "last_Payment_DateDateTimePicker";
            this.last_Payment_DateDateTimePicker.ShowCheckBox = true;
            this.last_Payment_DateDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.last_Payment_DateDateTimePicker.TabIndex = 20;
            // 
            // social_SupportTextBox
            // 
            this.social_SupportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Social_Support", true));
            this.social_SupportTextBox.Location = new System.Drawing.Point(775, 118);
            this.social_SupportTextBox.Name = "social_SupportTextBox";
            this.social_SupportTextBox.Size = new System.Drawing.Size(184, 20);
            this.social_SupportTextBox.TabIndex = 22;
            // 
            // total_Period_DebtTextBox
            // 
            this.total_Period_DebtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Total_Period_Debt", true));
            this.total_Period_DebtTextBox.Location = new System.Drawing.Point(775, 174);
            this.total_Period_DebtTextBox.Name = "total_Period_DebtTextBox";
            this.total_Period_DebtTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Period_DebtTextBox.TabIndex = 24;
            // 
            // pR_NumberTextBox
            // 
            this.pR_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "PR_Number", true));
            this.pR_NumberTextBox.Location = new System.Drawing.Point(775, 227);
            this.pR_NumberTextBox.Name = "pR_NumberTextBox";
            this.pR_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.pR_NumberTextBox.TabIndex = 26;
            // 
            // total_PeriodTextBox
            // 
            this.total_PeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Total_Period", true));
            this.total_PeriodTextBox.Location = new System.Drawing.Point(775, 280);
            this.total_PeriodTextBox.Name = "total_PeriodTextBox";
            this.total_PeriodTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_PeriodTextBox.TabIndex = 28;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(775, 330);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(184, 20);
            this.totalTextBox.TabIndex = 30;
            // 
            // total_Legal_ExpensesTextBox
            // 
            this.total_Legal_ExpensesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Total_Legal_Expenses", true));
            this.total_Legal_ExpensesTextBox.Location = new System.Drawing.Point(775, 380);
            this.total_Legal_ExpensesTextBox.Name = "total_Legal_ExpensesTextBox";
            this.total_Legal_ExpensesTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Legal_ExpensesTextBox.TabIndex = 32;
            // 
            // full_GIS_TotalTextBox
            // 
            this.full_GIS_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_DocumentBindingSource, "Full_GIS_Total", true));
            this.full_GIS_TotalTextBox.Location = new System.Drawing.Point(775, 434);
            this.full_GIS_TotalTextBox.Name = "full_GIS_TotalTextBox";
            this.full_GIS_TotalTextBox.Size = new System.Drawing.Size(184, 20);
            this.full_GIS_TotalTextBox.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.payment_DocumentBindingSource, "ID_LS", true));
            this.comboBox1.DataSource = this.viewAddressPremisesForPDBindingSource;
            this.comboBox1.DisplayMember = "FIO_Address";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "ID_LS";
            // 
            // viewAddressPremisesForPDBindingSource
            // 
            this.viewAddressPremisesForPDBindingSource.DataMember = "View_Address_Premises_For_PD";
            this.viewAddressPremisesForPDBindingSource.DataSource = this.gISDataSet;
            // 
            // viewLSBindingSource
            // 
            this.viewLSBindingSource.DataMember = "View_LS";
            this.viewLSBindingSource.DataSource = this.gISDataSet;
            // 
            // lSBindingSource
            // 
            this.lSBindingSource.DataMember = "LS";
            this.lSBindingSource.DataSource = this.gISDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // view_LSTableAdapter
            // 
            this.view_LSTableAdapter.ClearBeforeFill = true;
            // 
            // view_Address_Premises_For_PDTableAdapter
            // 
            this.view_Address_Premises_For_PDTableAdapter.ClearBeforeFill = true;
            // 
            // PD_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 476);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(full_GIS_TotalLabel);
            this.Controls.Add(this.full_GIS_TotalTextBox);
            this.Controls.Add(total_Legal_ExpensesLabel);
            this.Controls.Add(this.total_Legal_ExpensesTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(total_PeriodLabel);
            this.Controls.Add(this.total_PeriodTextBox);
            this.Controls.Add(pR_NumberLabel);
            this.Controls.Add(this.pR_NumberTextBox);
            this.Controls.Add(total_Period_DebtLabel);
            this.Controls.Add(this.total_Period_DebtTextBox);
            this.Controls.Add(social_SupportLabel);
            this.Controls.Add(this.social_SupportTextBox);
            this.Controls.Add(last_Payment_DateLabel);
            this.Controls.Add(this.last_Payment_DateDateTimePicker);
            this.Controls.Add(cash_PaidLabel);
            this.Controls.Add(this.cash_PaidTextBox);
            this.Controls.Add(period_SumLabel);
            this.Controls.Add(this.period_SumTextBox);
            this.Controls.Add(count_Livivng_PeopleLabel);
            this.Controls.Add(this.count_Livivng_PeopleTextBox);
            this.Controls.Add(heated_AreaLabel);
            this.Controls.Add(this.heated_AreaTextBox);
            this.Controls.Add(living_AreaLabel);
            this.Controls.Add(this.living_AreaTextBox);
            this.Controls.Add(total_Area_LSLabel);
            this.Controls.Add(this.total_Area_LSTextBox);
            this.Controls.Add(calculation_PeriodLabel);
            this.Controls.Add(this.calculation_PeriodDateTimePicker);
            this.Controls.Add(type_PDLabel);
            this.Controls.Add(iD_LSLabel);
            this.Controls.Add(this.payment_DocumentBindingNavigator);
            this.Name = "PD_AF";
            this.Opacity = 0.95D;
            this.Text = "Добавление записи в таблицу: Данные платежного документа";
            this.Load += new System.EventHandler(this.PD_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DocumentBindingNavigator)).EndInit();
            this.payment_DocumentBindingNavigator.ResumeLayout(false);
            this.payment_DocumentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesForPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource payment_DocumentBindingSource;
        private GISDataSetTableAdapters.Payment_DocumentTableAdapter payment_DocumentTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator payment_DocumentBindingNavigator;
        private GISDataSetTableAdapters.LSTableAdapter lSTableAdapter;
        private System.Windows.Forms.DateTimePicker calculation_PeriodDateTimePicker;
        private System.Windows.Forms.TextBox total_Area_LSTextBox;
        private System.Windows.Forms.TextBox living_AreaTextBox;
        private System.Windows.Forms.TextBox heated_AreaTextBox;
        private System.Windows.Forms.TextBox count_Livivng_PeopleTextBox;
        private System.Windows.Forms.TextBox period_SumTextBox;
        private System.Windows.Forms.TextBox cash_PaidTextBox;
        private System.Windows.Forms.DateTimePicker last_Payment_DateDateTimePicker;
        private System.Windows.Forms.TextBox social_SupportTextBox;
        private System.Windows.Forms.TextBox total_Period_DebtTextBox;
        private System.Windows.Forms.TextBox pR_NumberTextBox;
        private System.Windows.Forms.TextBox total_PeriodTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox total_Legal_ExpensesTextBox;
        private System.Windows.Forms.TextBox full_GIS_TotalTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource lSBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource viewLSBindingSource;
        private GISDataSetTableAdapters.View_LSTableAdapter view_LSTableAdapter;
        private System.Windows.Forms.BindingSource viewAddressPremisesForPDBindingSource;
        private GISDataSetTableAdapters.View_Address_Premises_For_PDTableAdapter view_Address_Premises_For_PDTableAdapter;
        public System.Windows.Forms.ToolStripButton payment_DocumentBindingNavigatorSaveItem;
    }
}