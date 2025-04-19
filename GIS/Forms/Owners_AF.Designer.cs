
namespace GIS.Forms
{
    partial class Owners_AF
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label secondNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label sNILSLabel;
            System.Windows.Forms.Label passport_TypeLabel;
            System.Windows.Forms.Label passport_SeriesLabel;
            System.Windows.Forms.Label passport_NumberLabel;
            System.Windows.Forms.Label passport_DateLabel;
            System.Windows.Forms.Label oGRNLabel;
            System.Windows.Forms.Label nZALabel;
            System.Windows.Forms.Label kPPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owners_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.owner_LSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.owner_LSTableAdapter = new GIS.GISDataSetTableAdapters.Owner_LSTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.owner_LSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.owner_LSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passport_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oGRNTextBox = new System.Windows.Forms.TextBox();
            this.nZATextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            sNILSLabel = new System.Windows.Forms.Label();
            passport_TypeLabel = new System.Windows.Forms.Label();
            passport_SeriesLabel = new System.Windows.Forms.Label();
            passport_NumberLabel = new System.Windows.Forms.Label();
            passport_DateLabel = new System.Windows.Forms.Label();
            oGRNLabel = new System.Windows.Forms.Label();
            nZALabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.owner_LSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.owner_LSBindingNavigator)).BeginInit();
            this.owner_LSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(102, 97);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(121, 17);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Имя потребителя:";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            secondNameLabel.Location = new System.Drawing.Point(156, 60);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(67, 17);
            secondNameLabel.TabIndex = 3;
            secondNameLabel.Text = "Фамилия:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(151, 133);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(72, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Отчество:";
            // 
            // sNILSLabel
            // 
            sNILSLabel.AutoSize = true;
            sNILSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sNILSLabel.Location = new System.Drawing.Point(160, 171);
            sNILSLabel.Name = "sNILSLabel";
            sNILSLabel.Size = new System.Drawing.Size(63, 17);
            sNILSLabel.TabIndex = 7;
            sNILSLabel.Text = "СНИЛС:";
            // 
            // passport_TypeLabel
            // 
            passport_TypeLabel.AutoSize = true;
            passport_TypeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_TypeLabel.Location = new System.Drawing.Point(39, 190);
            passport_TypeLabel.Name = "passport_TypeLabel";
            passport_TypeLabel.Size = new System.Drawing.Size(184, 34);
            passport_TypeLabel.TabIndex = 9;
            passport_TypeLabel.Text = "Вид документа, \r\nудостоверяющего личность:";
            // 
            // passport_SeriesLabel
            // 
            passport_SeriesLabel.AutoSize = true;
            passport_SeriesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_SeriesLabel.Location = new System.Drawing.Point(103, 245);
            passport_SeriesLabel.Name = "passport_SeriesLabel";
            passport_SeriesLabel.Size = new System.Drawing.Size(120, 17);
            passport_SeriesLabel.TabIndex = 11;
            passport_SeriesLabel.Text = "Серия документа:";
            // 
            // passport_NumberLabel
            // 
            passport_NumberLabel.AutoSize = true;
            passport_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_NumberLabel.Location = new System.Drawing.Point(98, 282);
            passport_NumberLabel.Name = "passport_NumberLabel";
            passport_NumberLabel.Size = new System.Drawing.Size(124, 17);
            passport_NumberLabel.TabIndex = 13;
            passport_NumberLabel.Text = "Номер документа:";
            // 
            // passport_DateLabel
            // 
            passport_DateLabel.AutoSize = true;
            passport_DateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_DateLabel.Location = new System.Drawing.Point(42, 325);
            passport_DateLabel.Name = "passport_DateLabel";
            passport_DateLabel.Size = new System.Drawing.Size(181, 17);
            passport_DateLabel.TabIndex = 15;
            passport_DateLabel.Text = "Дата получения документа:";
            // 
            // oGRNLabel
            // 
            oGRNLabel.AutoSize = true;
            oGRNLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oGRNLabel.Location = new System.Drawing.Point(171, 365);
            oGRNLabel.Name = "oGRNLabel";
            oGRNLabel.Size = new System.Drawing.Size(51, 17);
            oGRNLabel.TabIndex = 17;
            oGRNLabel.Text = "ОГРН:";
            // 
            // nZALabel
            // 
            nZALabel.AutoSize = true;
            nZALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nZALabel.Location = new System.Drawing.Point(182, 402);
            nZALabel.Name = "nZALabel";
            nZALabel.Size = new System.Drawing.Size(41, 17);
            nZALabel.TabIndex = 19;
            nZALabel.Text = "НЗА:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(180, 444);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(43, 17);
            kPPLabel.TabIndex = 21;
            kPPLabel.Text = "КПП:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // owner_LSBindingSource
            // 
            this.owner_LSBindingSource.DataMember = "Owner_LS";
            this.owner_LSBindingSource.DataSource = this.gISDataSet;
            // 
            // owner_LSTableAdapter
            // 
            this.owner_LSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Owner_LSTableAdapter = this.owner_LSTableAdapter;
            this.tableAdapterManager.Payment_DocumentTableAdapter = null;
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = null;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // owner_LSBindingNavigator
            // 
            this.owner_LSBindingNavigator.AddNewItem = null;
            this.owner_LSBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.owner_LSBindingNavigator.BindingSource = this.owner_LSBindingSource;
            this.owner_LSBindingNavigator.CountItem = null;
            this.owner_LSBindingNavigator.DeleteItem = null;
            this.owner_LSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.owner_LSBindingNavigatorSaveItem});
            this.owner_LSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.owner_LSBindingNavigator.MoveFirstItem = null;
            this.owner_LSBindingNavigator.MoveLastItem = null;
            this.owner_LSBindingNavigator.MoveNextItem = null;
            this.owner_LSBindingNavigator.MovePreviousItem = null;
            this.owner_LSBindingNavigator.Name = "owner_LSBindingNavigator";
            this.owner_LSBindingNavigator.PositionItem = null;
            this.owner_LSBindingNavigator.Size = new System.Drawing.Size(450, 25);
            this.owner_LSBindingNavigator.TabIndex = 0;
            this.owner_LSBindingNavigator.Text = "bindingNavigator1";
            // 
            // owner_LSBindingNavigatorSaveItem
            // 
            this.owner_LSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.owner_LSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("owner_LSBindingNavigatorSaveItem.Image")));
            this.owner_LSBindingNavigatorSaveItem.Name = "owner_LSBindingNavigatorSaveItem";
            this.owner_LSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.owner_LSBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.owner_LSBindingNavigatorSaveItem.Click += new System.EventHandler(this.owner_LSBindingNavigatorSaveItem_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(225, 96);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "SecondName", true));
            this.secondNameTextBox.Location = new System.Drawing.Point(225, 59);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.secondNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(225, 132);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // passport_DateDateTimePicker
            // 
            this.passport_DateDateTimePicker.CustomFormat = "";
            this.passport_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.owner_LSBindingSource, "Passport_Date", true));
            this.passport_DateDateTimePicker.Location = new System.Drawing.Point(225, 323);
            this.passport_DateDateTimePicker.Name = "passport_DateDateTimePicker";
            this.passport_DateDateTimePicker.ShowCheckBox = true;
            this.passport_DateDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.passport_DateDateTimePicker.TabIndex = 16;
            // 
            // oGRNTextBox
            // 
            this.oGRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "OGRN", true));
            this.oGRNTextBox.Location = new System.Drawing.Point(225, 364);
            this.oGRNTextBox.Name = "oGRNTextBox";
            this.oGRNTextBox.Size = new System.Drawing.Size(184, 20);
            this.oGRNTextBox.TabIndex = 18;
            // 
            // nZATextBox
            // 
            this.nZATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "NZA", true));
            this.nZATextBox.Location = new System.Drawing.Point(225, 401);
            this.nZATextBox.Name = "nZATextBox";
            this.nZATextBox.Size = new System.Drawing.Size(184, 20);
            this.nZATextBox.TabIndex = 20;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(225, 443);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(184, 20);
            this.kPPTextBox.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "SNILS", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(225, 170);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "Passport_Series", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(225, 244);
            this.maskedTextBox2.Mask = "0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox2.TabIndex = 25;
            this.maskedTextBox2.Click += new System.EventHandler(this.maskedTextBox2_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.owner_LSBindingSource, "Passport_Number", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(225, 281);
            this.maskedTextBox3.Mask = "000000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox3.TabIndex = 26;
            this.maskedTextBox3.Click += new System.EventHandler(this.maskedTextBox3_Click);
            // 
            // Owners_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 493);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(nZALabel);
            this.Controls.Add(this.nZATextBox);
            this.Controls.Add(oGRNLabel);
            this.Controls.Add(this.oGRNTextBox);
            this.Controls.Add(passport_DateLabel);
            this.Controls.Add(this.passport_DateDateTimePicker);
            this.Controls.Add(passport_NumberLabel);
            this.Controls.Add(passport_SeriesLabel);
            this.Controls.Add(passport_TypeLabel);
            this.Controls.Add(sNILSLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(secondNameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.owner_LSBindingNavigator);
            this.Name = "Owners_AF";
            this.Text = "Добавление записи в таблицу: Владельцы лицевых счетов";
            this.Load += new System.EventHandler(this.Owners_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.owner_LSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.owner_LSBindingNavigator)).EndInit();
            this.owner_LSBindingNavigator.ResumeLayout(false);
            this.owner_LSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource owner_LSBindingSource;
        private GISDataSetTableAdapters.Owner_LSTableAdapter owner_LSTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator owner_LSBindingNavigator;
        private System.Windows.Forms.ToolStripButton owner_LSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker passport_DateDateTimePicker;
        private System.Windows.Forms.TextBox oGRNTextBox;
        private System.Windows.Forms.TextBox nZATextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}