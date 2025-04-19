
namespace GIS.Forms
{
    partial class MKD_AF
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
            System.Windows.Forms.Label iD_AddressLabel;
            System.Windows.Forms.Label iD_FIASLabel;
            System.Windows.Forms.Label house_NumberLabel;
            System.Windows.Forms.Label oKTMOLabel;
            System.Windows.Forms.Label statysLabel;
            System.Windows.Forms.Label life_Cycle_StageLabel;
            System.Windows.Forms.Label total_Building_AreaLabel;
            System.Windows.Forms.Label year_Of_CommissioningLabel;
            System.Windows.Forms.Label count_floorsLabel;
            System.Windows.Forms.Label count_UnderfloorsLabel;
            System.Windows.Forms.Label olsonLabel;
            System.Windows.Forms.Label is_Cultural_LegacyLabel;
            System.Windows.Forms.Label cadastral_NumberLabel;
            System.Windows.Forms.Label payment_Account_SLabel;
            System.Windows.Forms.Label bIK_SLabel;
            System.Windows.Forms.Label payment_Account_RLabel;
            System.Windows.Forms.Label bIK_RLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKD_AF));
            this.characteristic_MKDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.characteristic_MKDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gISDataSet = new GIS.GISDataSet();
            this.characteristic_MKDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_FIASTextBox = new System.Windows.Forms.TextBox();
            this.total_Building_AreaTextBox = new System.Windows.Forms.TextBox();
            this.count_floorsTextBox = new System.Windows.Forms.TextBox();
            this.count_UnderfloorsTextBox = new System.Windows.Forms.TextBox();
            this.cadastral_NumberTextBox = new System.Windows.Forms.TextBox();
            this.payment_Account_STextBox = new System.Windows.Forms.TextBox();
            this.payment_Account_RTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewAddressBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characteristic_MKDTableAdapter = new GIS.GISDataSetTableAdapters.Characteristic_MKDTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.view_Address_BookTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_BookTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.house_NumberTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            iD_AddressLabel = new System.Windows.Forms.Label();
            iD_FIASLabel = new System.Windows.Forms.Label();
            house_NumberLabel = new System.Windows.Forms.Label();
            oKTMOLabel = new System.Windows.Forms.Label();
            statysLabel = new System.Windows.Forms.Label();
            life_Cycle_StageLabel = new System.Windows.Forms.Label();
            total_Building_AreaLabel = new System.Windows.Forms.Label();
            year_Of_CommissioningLabel = new System.Windows.Forms.Label();
            count_floorsLabel = new System.Windows.Forms.Label();
            count_UnderfloorsLabel = new System.Windows.Forms.Label();
            olsonLabel = new System.Windows.Forms.Label();
            is_Cultural_LegacyLabel = new System.Windows.Forms.Label();
            cadastral_NumberLabel = new System.Windows.Forms.Label();
            payment_Account_SLabel = new System.Windows.Forms.Label();
            bIK_SLabel = new System.Windows.Forms.Label();
            payment_Account_RLabel = new System.Windows.Forms.Label();
            bIK_RLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characteristic_MKDBindingNavigator)).BeginInit();
            this.characteristic_MKDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characteristic_MKDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_AddressLabel
            // 
            iD_AddressLabel.AutoSize = true;
            iD_AddressLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_AddressLabel.Location = new System.Drawing.Point(154, 63);
            iD_AddressLabel.Name = "iD_AddressLabel";
            iD_AddressLabel.Size = new System.Drawing.Size(87, 17);
            iD_AddressLabel.TabIndex = 1;
            iD_AddressLabel.Text = "Адрес дома:";
            // 
            // iD_FIASLabel
            // 
            iD_FIASLabel.AutoSize = true;
            iD_FIASLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_FIASLabel.Location = new System.Drawing.Point(32, 184);
            iD_FIASLabel.Name = "iD_FIASLabel";
            iD_FIASLabel.Size = new System.Drawing.Size(209, 17);
            iD_FIASLabel.TabIndex = 3;
            iD_FIASLabel.Text = "Идентификатор дома по ФИАС:";
            // 
            // house_NumberLabel
            // 
            house_NumberLabel.AutoSize = true;
            house_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            house_NumberLabel.Location = new System.Drawing.Point(152, 101);
            house_NumberLabel.Name = "house_NumberLabel";
            house_NumberLabel.Size = new System.Drawing.Size(89, 17);
            house_NumberLabel.TabIndex = 5;
            house_NumberLabel.Text = "Номер дома:";
            // 
            // oKTMOLabel
            // 
            oKTMOLabel.AutoSize = true;
            oKTMOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oKTMOLabel.Location = new System.Drawing.Point(176, 226);
            oKTMOLabel.Name = "oKTMOLabel";
            oKTMOLabel.Size = new System.Drawing.Size(65, 17);
            oKTMOLabel.TabIndex = 7;
            oKTMOLabel.Text = "ОКТМО:";
            // 
            // statysLabel
            // 
            statysLabel.AutoSize = true;
            statysLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statysLabel.Location = new System.Drawing.Point(164, 143);
            statysLabel.Name = "statysLabel";
            statysLabel.Size = new System.Drawing.Size(77, 17);
            statysLabel.TabIndex = 9;
            statysLabel.Text = "Состояние:";
            // 
            // life_Cycle_StageLabel
            // 
            life_Cycle_StageLabel.AutoSize = true;
            life_Cycle_StageLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            life_Cycle_StageLabel.Location = new System.Drawing.Point(70, 264);
            life_Cycle_StageLabel.Name = "life_Cycle_StageLabel";
            life_Cycle_StageLabel.Size = new System.Drawing.Size(171, 17);
            life_Cycle_StageLabel.TabIndex = 11;
            life_Cycle_StageLabel.Text = "Стадия жизненного цикла:";
            // 
            // total_Building_AreaLabel
            // 
            total_Building_AreaLabel.AutoSize = true;
            total_Building_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Building_AreaLabel.Location = new System.Drawing.Point(82, 307);
            total_Building_AreaLabel.Name = "total_Building_AreaLabel";
            total_Building_AreaLabel.Size = new System.Drawing.Size(159, 17);
            total_Building_AreaLabel.TabIndex = 13;
            total_Building_AreaLabel.Text = "Общая площадь здания:";
            // 
            // year_Of_CommissioningLabel
            // 
            year_Of_CommissioningLabel.AutoSize = true;
            year_Of_CommissioningLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            year_Of_CommissioningLabel.Location = new System.Drawing.Point(65, 351);
            year_Of_CommissioningLabel.Name = "year_Of_CommissioningLabel";
            year_Of_CommissioningLabel.Size = new System.Drawing.Size(176, 17);
            year_Of_CommissioningLabel.TabIndex = 15;
            year_Of_CommissioningLabel.Text = "Год ввода в эксплуатацию:";
            // 
            // count_floorsLabel
            // 
            count_floorsLabel.AutoSize = true;
            count_floorsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            count_floorsLabel.Location = new System.Drawing.Point(140, 395);
            count_floorsLabel.Name = "count_floorsLabel";
            count_floorsLabel.Size = new System.Drawing.Size(101, 17);
            count_floorsLabel.TabIndex = 17;
            count_floorsLabel.Text = "Кол-во этажей:";
            // 
            // count_UnderfloorsLabel
            // 
            count_UnderfloorsLabel.AutoSize = true;
            count_UnderfloorsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            count_UnderfloorsLabel.Location = new System.Drawing.Point(593, 63);
            count_UnderfloorsLabel.Name = "count_UnderfloorsLabel";
            count_UnderfloorsLabel.Size = new System.Drawing.Size(174, 17);
            count_UnderfloorsLabel.TabIndex = 19;
            count_UnderfloorsLabel.Text = "Кол-во подземных этажей:";
            // 
            // olsonLabel
            // 
            olsonLabel.AutoSize = true;
            olsonLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            olsonLabel.Location = new System.Drawing.Point(617, 145);
            olsonLabel.Name = "olsonLabel";
            olsonLabel.Size = new System.Drawing.Size(150, 17);
            olsonLabel.TabIndex = 21;
            olsonLabel.Text = "Часовая зона по Olson:";
            // 
            // is_Cultural_LegacyLabel
            // 
            is_Cultural_LegacyLabel.AutoSize = true;
            is_Cultural_LegacyLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_Cultural_LegacyLabel.Location = new System.Drawing.Point(455, 103);
            is_Cultural_LegacyLabel.Name = "is_Cultural_LegacyLabel";
            is_Cultural_LegacyLabel.Size = new System.Drawing.Size(312, 17);
            is_Cultural_LegacyLabel.TabIndex = 23;
            is_Cultural_LegacyLabel.Text = "Наличие статуса объекта культурного наследия:";
            // 
            // cadastral_NumberLabel
            // 
            cadastral_NumberLabel.AutoSize = true;
            cadastral_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cadastral_NumberLabel.Location = new System.Drawing.Point(630, 186);
            cadastral_NumberLabel.Name = "cadastral_NumberLabel";
            cadastral_NumberLabel.Size = new System.Drawing.Size(137, 17);
            cadastral_NumberLabel.TabIndex = 25;
            cadastral_NumberLabel.Text = "Кадастровый номер:";
            // 
            // payment_Account_SLabel
            // 
            payment_Account_SLabel.AutoSize = true;
            payment_Account_SLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            payment_Account_SLabel.Location = new System.Drawing.Point(590, 228);
            payment_Account_SLabel.Name = "payment_Account_SLabel";
            payment_Account_SLabel.Size = new System.Drawing.Size(177, 17);
            payment_Account_SLabel.TabIndex = 27;
            payment_Account_SLabel.Text = "Расчетный счет для услуг:";
            // 
            // bIK_SLabel
            // 
            bIK_SLabel.AutoSize = true;
            bIK_SLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bIK_SLabel.Location = new System.Drawing.Point(662, 268);
            bIK_SLabel.Name = "bIK_SLabel";
            bIK_SLabel.Size = new System.Drawing.Size(105, 17);
            bIK_SLabel.TabIndex = 29;
            bIK_SLabel.Text = "БИК для услуг:";
            // 
            // payment_Account_RLabel
            // 
            payment_Account_RLabel.AutoSize = true;
            payment_Account_RLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            payment_Account_RLabel.Location = new System.Drawing.Point(543, 310);
            payment_Account_RLabel.Name = "payment_Account_RLabel";
            payment_Account_RLabel.Size = new System.Drawing.Size(224, 17);
            payment_Account_RLabel.TabIndex = 31;
            payment_Account_RLabel.Text = "Расчетный счет для кап. ремонта:";
            // 
            // bIK_RLabel
            // 
            bIK_RLabel.AutoSize = true;
            bIK_RLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bIK_RLabel.Location = new System.Drawing.Point(612, 348);
            bIK_RLabel.Name = "bIK_RLabel";
            bIK_RLabel.Size = new System.Drawing.Size(152, 17);
            bIK_RLabel.TabIndex = 33;
            bIK_RLabel.Text = "БИК для кап. ремонта:";
            // 
            // characteristic_MKDBindingNavigator
            // 
            this.characteristic_MKDBindingNavigator.AddNewItem = null;
            this.characteristic_MKDBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.characteristic_MKDBindingNavigator.BindingSource = this.characteristic_MKDBindingSource;
            this.characteristic_MKDBindingNavigator.CountItem = null;
            this.characteristic_MKDBindingNavigator.DeleteItem = null;
            this.characteristic_MKDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characteristic_MKDBindingNavigatorSaveItem});
            this.characteristic_MKDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.characteristic_MKDBindingNavigator.MoveFirstItem = null;
            this.characteristic_MKDBindingNavigator.MoveLastItem = null;
            this.characteristic_MKDBindingNavigator.MoveNextItem = null;
            this.characteristic_MKDBindingNavigator.MovePreviousItem = null;
            this.characteristic_MKDBindingNavigator.Name = "characteristic_MKDBindingNavigator";
            this.characteristic_MKDBindingNavigator.PositionItem = null;
            this.characteristic_MKDBindingNavigator.Size = new System.Drawing.Size(998, 25);
            this.characteristic_MKDBindingNavigator.TabIndex = 0;
            this.characteristic_MKDBindingNavigator.Text = "bindingNavigator1";
            // 
            // characteristic_MKDBindingSource
            // 
            this.characteristic_MKDBindingSource.DataMember = "Characteristic_MKD";
            this.characteristic_MKDBindingSource.DataSource = this.gISDataSet;
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // characteristic_MKDBindingNavigatorSaveItem
            // 
            this.characteristic_MKDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.characteristic_MKDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("characteristic_MKDBindingNavigatorSaveItem.Image")));
            this.characteristic_MKDBindingNavigatorSaveItem.Name = "characteristic_MKDBindingNavigatorSaveItem";
            this.characteristic_MKDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.characteristic_MKDBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.characteristic_MKDBindingNavigatorSaveItem.Click += new System.EventHandler(this.characteristic_MKDBindingNavigatorSaveItem_Click);
            // 
            // iD_FIASTextBox
            // 
            this.iD_FIASTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "ID_FIAS", true));
            this.iD_FIASTextBox.Location = new System.Drawing.Point(247, 183);
            this.iD_FIASTextBox.Name = "iD_FIASTextBox";
            this.iD_FIASTextBox.Size = new System.Drawing.Size(184, 20);
            this.iD_FIASTextBox.TabIndex = 4;
            // 
            // total_Building_AreaTextBox
            // 
            this.total_Building_AreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Total_Building_Area", true));
            this.total_Building_AreaTextBox.Location = new System.Drawing.Point(247, 306);
            this.total_Building_AreaTextBox.Name = "total_Building_AreaTextBox";
            this.total_Building_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Building_AreaTextBox.TabIndex = 14;
            // 
            // count_floorsTextBox
            // 
            this.count_floorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Count_floors", true));
            this.count_floorsTextBox.Location = new System.Drawing.Point(247, 395);
            this.count_floorsTextBox.Name = "count_floorsTextBox";
            this.count_floorsTextBox.Size = new System.Drawing.Size(184, 20);
            this.count_floorsTextBox.TabIndex = 18;
            // 
            // count_UnderfloorsTextBox
            // 
            this.count_UnderfloorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Count_Underfloors", true));
            this.count_UnderfloorsTextBox.Location = new System.Drawing.Point(770, 62);
            this.count_UnderfloorsTextBox.Name = "count_UnderfloorsTextBox";
            this.count_UnderfloorsTextBox.Size = new System.Drawing.Size(184, 20);
            this.count_UnderfloorsTextBox.TabIndex = 20;
            // 
            // cadastral_NumberTextBox
            // 
            this.cadastral_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Cadastral_Number", true));
            this.cadastral_NumberTextBox.Location = new System.Drawing.Point(770, 184);
            this.cadastral_NumberTextBox.Name = "cadastral_NumberTextBox";
            this.cadastral_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.cadastral_NumberTextBox.TabIndex = 26;
            // 
            // payment_Account_STextBox
            // 
            this.payment_Account_STextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Payment_Account_S", true));
            this.payment_Account_STextBox.Location = new System.Drawing.Point(770, 227);
            this.payment_Account_STextBox.Name = "payment_Account_STextBox";
            this.payment_Account_STextBox.Size = new System.Drawing.Size(184, 20);
            this.payment_Account_STextBox.TabIndex = 28;
            // 
            // payment_Account_RTextBox
            // 
            this.payment_Account_RTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Payment_Account_R", true));
            this.payment_Account_RTextBox.Location = new System.Drawing.Point(770, 309);
            this.payment_Account_RTextBox.Name = "payment_Account_RTextBox";
            this.payment_Account_RTextBox.Size = new System.Drawing.Size(184, 20);
            this.payment_Account_RTextBox.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.characteristic_MKDBindingSource, "ID_Address", true));
            this.comboBox1.DataSource = this.viewAddressBookBindingSource;
            this.comboBox1.DisplayMember = "NameStreet";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "ID";
            // 
            // viewAddressBookBindingSource
            // 
            this.viewAddressBookBindingSource.DataMember = "View_Address_Book";
            this.viewAddressBookBindingSource.DataSource = this.gISDataSet;
            // 
            // characteristic_MKDTableAdapter
            // 
            this.characteristic_MKDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Address_BookTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Characteristic_MKDTableAdapter = this.characteristic_MKDTableAdapter;
            this.tableAdapterManager.EntranceTableAdapter = null;
            this.tableAdapterManager.General_Metering_DeviceTableAdapter = null;
            this.tableAdapterManager.LSTableAdapter = null;
            this.tableAdapterManager.Metering_DevicesTableAdapter = null;
            this.tableAdapterManager.MKD_PremisesTableAdapter = null;
            this.tableAdapterManager.Owner_LSTableAdapter = null;
            this.tableAdapterManager.Payment_DocumentTableAdapter = null;
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = null;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_Address_BookTableAdapter
            // 
            this.view_Address_BookTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(247, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(247, 263);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(184, 21);
            this.comboBox3.TabIndex = 37;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(770, 144);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(184, 21);
            this.comboBox4.TabIndex = 38;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(770, 102);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(184, 21);
            this.comboBox5.TabIndex = 39;
            // 
            // house_NumberTextBox
            // 
            this.house_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "House_Number", true));
            this.house_NumberTextBox.Location = new System.Drawing.Point(247, 101);
            this.house_NumberTextBox.Name = "house_NumberTextBox";
            this.house_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.house_NumberTextBox.TabIndex = 40;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "OKTMO", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(247, 225);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox1.TabIndex = 41;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "Year_Of_Commissioning", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(247, 350);
            this.maskedTextBox2.Mask = "0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox2.TabIndex = 42;
            this.maskedTextBox2.Click += new System.EventHandler(this.maskedTextBox2_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "BIK_S", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(770, 267);
            this.maskedTextBox3.Mask = "000000000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox3.TabIndex = 43;
            this.maskedTextBox3.Click += new System.EventHandler(this.maskedTextBox3_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characteristic_MKDBindingSource, "BIK_R", true));
            this.maskedTextBox4.Location = new System.Drawing.Point(770, 347);
            this.maskedTextBox4.Mask = "000000000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox4.TabIndex = 44;
            this.maskedTextBox4.Click += new System.EventHandler(this.maskedTextBox4_Click);
            // 
            // MKD_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 445);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.house_NumberTextBox);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(bIK_RLabel);
            this.Controls.Add(payment_Account_RLabel);
            this.Controls.Add(this.payment_Account_RTextBox);
            this.Controls.Add(bIK_SLabel);
            this.Controls.Add(payment_Account_SLabel);
            this.Controls.Add(this.payment_Account_STextBox);
            this.Controls.Add(cadastral_NumberLabel);
            this.Controls.Add(this.cadastral_NumberTextBox);
            this.Controls.Add(is_Cultural_LegacyLabel);
            this.Controls.Add(olsonLabel);
            this.Controls.Add(count_UnderfloorsLabel);
            this.Controls.Add(this.count_UnderfloorsTextBox);
            this.Controls.Add(count_floorsLabel);
            this.Controls.Add(this.count_floorsTextBox);
            this.Controls.Add(year_Of_CommissioningLabel);
            this.Controls.Add(total_Building_AreaLabel);
            this.Controls.Add(this.total_Building_AreaTextBox);
            this.Controls.Add(life_Cycle_StageLabel);
            this.Controls.Add(statysLabel);
            this.Controls.Add(oKTMOLabel);
            this.Controls.Add(house_NumberLabel);
            this.Controls.Add(iD_FIASLabel);
            this.Controls.Add(this.iD_FIASTextBox);
            this.Controls.Add(iD_AddressLabel);
            this.Controls.Add(this.characteristic_MKDBindingNavigator);
            this.Name = "MKD_AF";
            this.Opacity = 0.95D;
            this.Text = "Добавление записи в таблицу: Многоквартирные дома";
            this.Load += new System.EventHandler(this.MKD_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characteristic_MKDBindingNavigator)).EndInit();
            this.characteristic_MKDBindingNavigator.ResumeLayout(false);
            this.characteristic_MKDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characteristic_MKDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource characteristic_MKDBindingSource;
        private GISDataSetTableAdapters.Characteristic_MKDTableAdapter characteristic_MKDTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator characteristic_MKDBindingNavigator;
        private System.Windows.Forms.ToolStripButton characteristic_MKDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_FIASTextBox;
        private System.Windows.Forms.TextBox total_Building_AreaTextBox;
        private System.Windows.Forms.TextBox count_floorsTextBox;
        private System.Windows.Forms.TextBox count_UnderfloorsTextBox;
        private System.Windows.Forms.TextBox cadastral_NumberTextBox;
        private System.Windows.Forms.TextBox payment_Account_STextBox;
        private System.Windows.Forms.TextBox payment_Account_RTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource viewAddressBookBindingSource;
        private GISDataSetTableAdapters.View_Address_BookTableAdapter view_Address_BookTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox house_NumberTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
    }
}