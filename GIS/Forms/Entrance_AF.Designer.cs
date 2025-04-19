
namespace GIS.Forms
{
    partial class Entrance_AF
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
            System.Windows.Forms.Label number_Of_FloorsLabel;
            System.Windows.Forms.Label year_Of_ConstructionLabel;
            System.Windows.Forms.Label is_Confirmed_SupplierLabel;
            System.Windows.Forms.Label entrance_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.entranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entranceTableAdapter = new GIS.GISDataSetTableAdapters.EntranceTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.entranceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.entranceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.number_Of_FloorsTextBox = new System.Windows.Forms.TextBox();
            this.entrance_NumberTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewAddressMKDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Address_MKDTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_MKDTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            iD_MKD_AddressLabel = new System.Windows.Forms.Label();
            number_Of_FloorsLabel = new System.Windows.Forms.Label();
            year_Of_ConstructionLabel = new System.Windows.Forms.Label();
            is_Confirmed_SupplierLabel = new System.Windows.Forms.Label();
            entrance_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingNavigator)).BeginInit();
            this.entranceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressMKDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MKD_AddressLabel
            // 
            iD_MKD_AddressLabel.AutoSize = true;
            iD_MKD_AddressLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_MKD_AddressLabel.Location = new System.Drawing.Point(213, 64);
            iD_MKD_AddressLabel.Name = "iD_MKD_AddressLabel";
            iD_MKD_AddressLabel.Size = new System.Drawing.Size(88, 17);
            iD_MKD_AddressLabel.TabIndex = 1;
            iD_MKD_AddressLabel.Text = "Адрес МКД:";
            // 
            // number_Of_FloorsLabel
            // 
            number_Of_FloorsLabel.AutoSize = true;
            number_Of_FloorsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_Of_FloorsLabel.Location = new System.Drawing.Point(221, 109);
            number_Of_FloorsLabel.Name = "number_Of_FloorsLabel";
            number_Of_FloorsLabel.Size = new System.Drawing.Size(80, 17);
            number_Of_FloorsLabel.TabIndex = 3;
            number_Of_FloorsLabel.Text = "Этажность:";
            // 
            // year_Of_ConstructionLabel
            // 
            year_Of_ConstructionLabel.AutoSize = true;
            year_Of_ConstructionLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            year_Of_ConstructionLabel.Location = new System.Drawing.Point(200, 153);
            year_Of_ConstructionLabel.Name = "year_Of_ConstructionLabel";
            year_Of_ConstructionLabel.Size = new System.Drawing.Size(101, 17);
            year_Of_ConstructionLabel.TabIndex = 5;
            year_Of_ConstructionLabel.Text = "Год постройки:";
            // 
            // is_Confirmed_SupplierLabel
            // 
            is_Confirmed_SupplierLabel.AutoSize = true;
            is_Confirmed_SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_Confirmed_SupplierLabel.Location = new System.Drawing.Point(35, 198);
            is_Confirmed_SupplierLabel.Name = "is_Confirmed_SupplierLabel";
            is_Confirmed_SupplierLabel.Size = new System.Drawing.Size(270, 17);
            is_Confirmed_SupplierLabel.TabIndex = 7;
            is_Confirmed_SupplierLabel.Text = "Информация подтверждена поставщиком:";
            // 
            // entrance_NumberLabel
            // 
            entrance_NumberLabel.AutoSize = true;
            entrance_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            entrance_NumberLabel.Location = new System.Drawing.Point(186, 245);
            entrance_NumberLabel.Name = "entrance_NumberLabel";
            entrance_NumberLabel.Size = new System.Drawing.Size(115, 17);
            entrance_NumberLabel.TabIndex = 9;
            entrance_NumberLabel.Text = "Номер подъезда:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entranceBindingSource
            // 
            this.entranceBindingSource.DataMember = "Entrance";
            this.entranceBindingSource.DataSource = this.gISDataSet;
            // 
            // entranceTableAdapter
            // 
            this.entranceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Address_BookTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Characteristic_MKDTableAdapter = null;
            this.tableAdapterManager.EntranceTableAdapter = this.entranceTableAdapter;
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
            // entranceBindingNavigator
            // 
            this.entranceBindingNavigator.AddNewItem = null;
            this.entranceBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.entranceBindingNavigator.BindingSource = this.entranceBindingSource;
            this.entranceBindingNavigator.CountItem = null;
            this.entranceBindingNavigator.DeleteItem = null;
            this.entranceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entranceBindingNavigatorSaveItem});
            this.entranceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entranceBindingNavigator.MoveFirstItem = null;
            this.entranceBindingNavigator.MoveLastItem = null;
            this.entranceBindingNavigator.MoveNextItem = null;
            this.entranceBindingNavigator.MovePreviousItem = null;
            this.entranceBindingNavigator.Name = "entranceBindingNavigator";
            this.entranceBindingNavigator.PositionItem = null;
            this.entranceBindingNavigator.Size = new System.Drawing.Size(540, 25);
            this.entranceBindingNavigator.TabIndex = 0;
            this.entranceBindingNavigator.Text = "bindingNavigator1";
            // 
            // entranceBindingNavigatorSaveItem
            // 
            this.entranceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entranceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entranceBindingNavigatorSaveItem.Image")));
            this.entranceBindingNavigatorSaveItem.Name = "entranceBindingNavigatorSaveItem";
            this.entranceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.entranceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.entranceBindingNavigatorSaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // number_Of_FloorsTextBox
            // 
            this.number_Of_FloorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entranceBindingSource, "Number_Of_Floors", true));
            this.number_Of_FloorsTextBox.Location = new System.Drawing.Point(307, 108);
            this.number_Of_FloorsTextBox.Name = "number_Of_FloorsTextBox";
            this.number_Of_FloorsTextBox.Size = new System.Drawing.Size(184, 20);
            this.number_Of_FloorsTextBox.TabIndex = 4;
            // 
            // entrance_NumberTextBox
            // 
            this.entrance_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entranceBindingSource, "Entrance_Number", true));
            this.entrance_NumberTextBox.Location = new System.Drawing.Point(307, 244);
            this.entrance_NumberTextBox.Name = "entrance_NumberTextBox";
            this.entrance_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.entrance_NumberTextBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.entranceBindingSource, "ID_MKD_Address", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(307, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 11;
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
            this.comboBox2.Location = new System.Drawing.Point(307, 197);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entranceBindingSource, "Year_Of_Construction", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(307, 152);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // Entrance_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 291);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(entrance_NumberLabel);
            this.Controls.Add(this.entrance_NumberTextBox);
            this.Controls.Add(is_Confirmed_SupplierLabel);
            this.Controls.Add(year_Of_ConstructionLabel);
            this.Controls.Add(number_Of_FloorsLabel);
            this.Controls.Add(this.number_Of_FloorsTextBox);
            this.Controls.Add(iD_MKD_AddressLabel);
            this.Controls.Add(this.entranceBindingNavigator);
            this.Name = "Entrance_AF";
            this.Opacity = 0.95D;
            this.Text = "Добавление записи в таблицу: Подъезды";
            this.Load += new System.EventHandler(this.Entrance_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingNavigator)).EndInit();
            this.entranceBindingNavigator.ResumeLayout(false);
            this.entranceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressMKDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource entranceBindingSource;
        private GISDataSetTableAdapters.EntranceTableAdapter entranceTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entranceBindingNavigator;
        private System.Windows.Forms.TextBox number_Of_FloorsTextBox;
        private System.Windows.Forms.TextBox entrance_NumberTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource viewAddressMKDBindingSource;
        private GISDataSetTableAdapters.View_Address_MKDTableAdapter view_Address_MKDTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.ToolStripButton entranceBindingNavigatorSaveItem;
    }
}