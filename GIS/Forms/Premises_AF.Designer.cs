
namespace GIS.Forms
{
    partial class Premises_AF
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
            System.Windows.Forms.Label iD_MKD_AddressLabel;
            System.Windows.Forms.Label is_LivingLabel;
            System.Windows.Forms.Label premises_DescriptionLabel;
            System.Windows.Forms.Label total_AreaLabel;
            System.Windows.Forms.Label living_Total_AreaLabel;
            System.Windows.Forms.Label is_CommonLabel;
            System.Windows.Forms.Label cadastral_NumberLabel;
            System.Windows.Forms.Label is_Confirmed_SupplierLabel;
            System.Windows.Forms.Label infoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Premises_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.mKD_PremisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKD_PremisesTableAdapter = new GIS.GISDataSetTableAdapters.MKD_PremisesTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.mKD_PremisesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.mKD_PremisesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.total_AreaTextBox = new System.Windows.Forms.TextBox();
            this.living_Total_AreaTextBox = new System.Windows.Forms.TextBox();
            this.cadastral_NumberTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewAddressMKDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Address_MKDTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_MKDTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            iD_MKD_AddressLabel = new System.Windows.Forms.Label();
            is_LivingLabel = new System.Windows.Forms.Label();
            premises_DescriptionLabel = new System.Windows.Forms.Label();
            total_AreaLabel = new System.Windows.Forms.Label();
            living_Total_AreaLabel = new System.Windows.Forms.Label();
            is_CommonLabel = new System.Windows.Forms.Label();
            cadastral_NumberLabel = new System.Windows.Forms.Label();
            is_Confirmed_SupplierLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKD_PremisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKD_PremisesBindingNavigator)).BeginInit();
            this.mKD_PremisesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressMKDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MKD_AddressLabel
            // 
            iD_MKD_AddressLabel.AutoSize = true;
            iD_MKD_AddressLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_MKD_AddressLabel.Location = new System.Drawing.Point(153, 45);
            iD_MKD_AddressLabel.Name = "iD_MKD_AddressLabel";
            iD_MKD_AddressLabel.Size = new System.Drawing.Size(88, 17);
            iD_MKD_AddressLabel.TabIndex = 1;
            iD_MKD_AddressLabel.Text = "Адрес МКД:";
            // 
            // is_LivingLabel
            // 
            is_LivingLabel.AutoSize = true;
            is_LivingLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_LivingLabel.Location = new System.Drawing.Point(48, 120);
            is_LivingLabel.Name = "is_LivingLabel";
            is_LivingLabel.Size = new System.Drawing.Size(193, 17);
            is_LivingLabel.TabIndex = 3;
            is_LivingLabel.Text = "Помещение является жилым:";
            // 
            // premises_DescriptionLabel
            // 
            premises_DescriptionLabel.AutoSize = true;
            premises_DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            premises_DescriptionLabel.Location = new System.Drawing.Point(55, 163);
            premises_DescriptionLabel.Name = "premises_DescriptionLabel";
            premises_DescriptionLabel.Size = new System.Drawing.Size(186, 17);
            premises_DescriptionLabel.TabIndex = 5;
            premises_DescriptionLabel.Text = "Характеристика помещения:";
            // 
            // total_AreaLabel
            // 
            total_AreaLabel.AutoSize = true;
            total_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_AreaLabel.Location = new System.Drawing.Point(54, 208);
            total_AreaLabel.Name = "total_AreaLabel";
            total_AreaLabel.Size = new System.Drawing.Size(187, 17);
            total_AreaLabel.TabIndex = 7;
            total_AreaLabel.Text = "Общая площадь помещения:";
            // 
            // living_Total_AreaLabel
            // 
            living_Total_AreaLabel.AutoSize = true;
            living_Total_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            living_Total_AreaLabel.Location = new System.Drawing.Point(57, 249);
            living_Total_AreaLabel.Name = "living_Total_AreaLabel";
            living_Total_AreaLabel.Size = new System.Drawing.Size(184, 17);
            living_Total_AreaLabel.TabIndex = 9;
            living_Total_AreaLabel.Text = "Жилая площадь помещения:";
            // 
            // is_CommonLabel
            // 
            is_CommonLabel.AutoSize = true;
            is_CommonLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_CommonLabel.Location = new System.Drawing.Point(40, 294);
            is_CommonLabel.Name = "is_CommonLabel";
            is_CommonLabel.Size = new System.Drawing.Size(201, 17);
            is_CommonLabel.TabIndex = 11;
            is_CommonLabel.Text = "Является общим имуществом:";
            // 
            // cadastral_NumberLabel
            // 
            cadastral_NumberLabel.AutoSize = true;
            cadastral_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cadastral_NumberLabel.Location = new System.Drawing.Point(104, 336);
            cadastral_NumberLabel.Name = "cadastral_NumberLabel";
            cadastral_NumberLabel.Size = new System.Drawing.Size(137, 17);
            cadastral_NumberLabel.TabIndex = 13;
            cadastral_NumberLabel.Text = "Кадастровый номер:";
            // 
            // is_Confirmed_SupplierLabel
            // 
            is_Confirmed_SupplierLabel.AutoSize = true;
            is_Confirmed_SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_Confirmed_SupplierLabel.Location = new System.Drawing.Point(54, 369);
            is_Confirmed_SupplierLabel.Name = "is_Confirmed_SupplierLabel";
            is_Confirmed_SupplierLabel.Size = new System.Drawing.Size(187, 34);
            is_Confirmed_SupplierLabel.TabIndex = 15;
            is_Confirmed_SupplierLabel.Text = "Информация\r\nподтверждена поставщиком:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            infoLabel.Location = new System.Drawing.Point(125, 83);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(116, 17);
            infoLabel.TabIndex = 22;
            infoLabel.Text = "Номер квартиры:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mKD_PremisesBindingSource
            // 
            this.mKD_PremisesBindingSource.DataMember = "MKD_Premises";
            this.mKD_PremisesBindingSource.DataSource = this.gISDataSet;
            // 
            // mKD_PremisesTableAdapter
            // 
            this.mKD_PremisesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MKD_PremisesTableAdapter = this.mKD_PremisesTableAdapter;
            this.tableAdapterManager.Owner_LSTableAdapter = null;
            this.tableAdapterManager.Payment_DocumentTableAdapter = null;
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = null;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mKD_PremisesBindingNavigator
            // 
            this.mKD_PremisesBindingNavigator.AddNewItem = null;
            this.mKD_PremisesBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mKD_PremisesBindingNavigator.BindingSource = this.mKD_PremisesBindingSource;
            this.mKD_PremisesBindingNavigator.CountItem = null;
            this.mKD_PremisesBindingNavigator.DeleteItem = null;
            this.mKD_PremisesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKD_PremisesBindingNavigatorSaveItem});
            this.mKD_PremisesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mKD_PremisesBindingNavigator.MoveFirstItem = null;
            this.mKD_PremisesBindingNavigator.MoveLastItem = null;
            this.mKD_PremisesBindingNavigator.MoveNextItem = null;
            this.mKD_PremisesBindingNavigator.MovePreviousItem = null;
            this.mKD_PremisesBindingNavigator.Name = "mKD_PremisesBindingNavigator";
            this.mKD_PremisesBindingNavigator.PositionItem = null;
            this.mKD_PremisesBindingNavigator.Size = new System.Drawing.Size(460, 25);
            this.mKD_PremisesBindingNavigator.TabIndex = 0;
            this.mKD_PremisesBindingNavigator.Text = "bindingNavigator1";
            // 
            // mKD_PremisesBindingNavigatorSaveItem
            // 
            this.mKD_PremisesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mKD_PremisesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mKD_PremisesBindingNavigatorSaveItem.Image")));
            this.mKD_PremisesBindingNavigatorSaveItem.Name = "mKD_PremisesBindingNavigatorSaveItem";
            this.mKD_PremisesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mKD_PremisesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mKD_PremisesBindingNavigatorSaveItem.Click += new System.EventHandler(this.mKD_PremisesBindingNavigatorSaveItem_Click);
            // 
            // total_AreaTextBox
            // 
            this.total_AreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mKD_PremisesBindingSource, "Total_Area", true));
            this.total_AreaTextBox.Location = new System.Drawing.Point(247, 205);
            this.total_AreaTextBox.Name = "total_AreaTextBox";
            this.total_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_AreaTextBox.TabIndex = 8;
            // 
            // living_Total_AreaTextBox
            // 
            this.living_Total_AreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mKD_PremisesBindingSource, "Living_Total_Area", true));
            this.living_Total_AreaTextBox.Location = new System.Drawing.Point(247, 248);
            this.living_Total_AreaTextBox.Name = "living_Total_AreaTextBox";
            this.living_Total_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.living_Total_AreaTextBox.TabIndex = 10;
            // 
            // cadastral_NumberTextBox
            // 
            this.cadastral_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mKD_PremisesBindingSource, "Cadastral_Number", true));
            this.cadastral_NumberTextBox.Location = new System.Drawing.Point(247, 336);
            this.cadastral_NumberTextBox.Name = "cadastral_NumberTextBox";
            this.cadastral_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.cadastral_NumberTextBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mKD_PremisesBindingSource, "ID_MKD_Address", true));
            this.comboBox1.DataSource = this.viewAddressMKDBindingSource;
            this.comboBox1.DisplayMember = "Address";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ID";
            // 
            // viewAddressMKDBindingSource
            // 
            this.viewAddressMKDBindingSource.DataMember = "View_Address_MKD";
            this.viewAddressMKDBindingSource.DataSource = this.gISDataSet;
            // 
            // view_Address_MKDTableAdapter
            // 
            this.view_Address_MKDTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(247, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(247, 293);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(184, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(247, 384);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(184, 21);
            this.comboBox4.TabIndex = 21;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(247, 162);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(184, 21);
            this.comboBox5.TabIndex = 22;
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mKD_PremisesBindingSource, "Info", true));
            this.infoTextBox.Location = new System.Drawing.Point(247, 82);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(184, 20);
            this.infoTextBox.TabIndex = 23;
            // 
            // Premises_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 422);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(is_Confirmed_SupplierLabel);
            this.Controls.Add(cadastral_NumberLabel);
            this.Controls.Add(this.cadastral_NumberTextBox);
            this.Controls.Add(is_CommonLabel);
            this.Controls.Add(living_Total_AreaLabel);
            this.Controls.Add(this.living_Total_AreaTextBox);
            this.Controls.Add(total_AreaLabel);
            this.Controls.Add(this.total_AreaTextBox);
            this.Controls.Add(premises_DescriptionLabel);
            this.Controls.Add(is_LivingLabel);
            this.Controls.Add(iD_MKD_AddressLabel);
            this.Controls.Add(this.mKD_PremisesBindingNavigator);
            this.Name = "Premises_AF";
            this.Opacity = 0.95D;
            this.Text = "Добавление записи в таблицу: Помещения";
            this.Load += new System.EventHandler(this.Premises_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKD_PremisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKD_PremisesBindingNavigator)).EndInit();
            this.mKD_PremisesBindingNavigator.ResumeLayout(false);
            this.mKD_PremisesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressMKDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource mKD_PremisesBindingSource;
        private GISDataSetTableAdapters.MKD_PremisesTableAdapter mKD_PremisesTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mKD_PremisesBindingNavigator;
        private System.Windows.Forms.TextBox total_AreaTextBox;
        private System.Windows.Forms.TextBox living_Total_AreaTextBox;
        private System.Windows.Forms.TextBox cadastral_NumberTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource viewAddressMKDBindingSource;
        private GISDataSetTableAdapters.View_Address_MKDTableAdapter view_Address_MKDTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox infoTextBox;
        public System.Windows.Forms.ToolStripButton mKD_PremisesBindingNavigatorSaveItem;
    }
}