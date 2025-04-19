
namespace GIS.Forms
{
    partial class LS_AF
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
            System.Windows.Forms.Label type_LSLabel;
            System.Windows.Forms.Label number_JKYLabel;
            System.Windows.Forms.Label is_EmployerLabel;
            System.Windows.Forms.Label is_SplitedLabel;
            System.Windows.Forms.Label shareOfPaymentLabel;
            System.Windows.Forms.Label is_OpenLabel;
            System.Windows.Forms.Label eLSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LS_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.lSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSTableAdapter = new GIS.GISDataSetTableAdapters.LSTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.lSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.number_JKYTextBox = new System.Windows.Forms.TextBox();
            this.shareOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.eLSTextBox = new System.Windows.Forms.TextBox();
            this.viewAddressPremisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Address_PremisesTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_PremisesTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.viewOwnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.view_OwnerTableAdapter = new GIS.GISDataSetTableAdapters.View_OwnerTableAdapter();
            type_LSLabel = new System.Windows.Forms.Label();
            number_JKYLabel = new System.Windows.Forms.Label();
            is_EmployerLabel = new System.Windows.Forms.Label();
            is_SplitedLabel = new System.Windows.Forms.Label();
            shareOfPaymentLabel = new System.Windows.Forms.Label();
            is_OpenLabel = new System.Windows.Forms.Label();
            eLSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSBindingNavigator)).BeginInit();
            this.lSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOwnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // type_LSLabel
            // 
            type_LSLabel.AutoSize = true;
            type_LSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_LSLabel.Location = new System.Drawing.Point(69, 89);
            type_LSLabel.Name = "type_LSLabel";
            type_LSLabel.Size = new System.Drawing.Size(133, 17);
            type_LSLabel.TabIndex = 3;
            type_LSLabel.Text = "Тип лицевого счета:";
            // 
            // number_JKYLabel
            // 
            number_JKYLabel.AutoSize = true;
            number_JKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_JKYLabel.Location = new System.Drawing.Point(56, 131);
            number_JKYLabel.Name = "number_JKYLabel";
            number_JKYLabel.Size = new System.Drawing.Size(146, 17);
            number_JKYLabel.TabIndex = 7;
            number_JKYLabel.Text = "Идентификатор ЖКУ:";
            // 
            // is_EmployerLabel
            // 
            is_EmployerLabel.AutoSize = true;
            is_EmployerLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_EmployerLabel.Location = new System.Drawing.Point(45, 172);
            is_EmployerLabel.Name = "is_EmployerLabel";
            is_EmployerLabel.Size = new System.Drawing.Size(157, 17);
            is_EmployerLabel.TabIndex = 9;
            is_EmployerLabel.Text = "Является нанимателем:";
            // 
            // is_SplitedLabel
            // 
            is_SplitedLabel.AutoSize = true;
            is_SplitedLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_SplitedLabel.Location = new System.Drawing.Point(34, 199);
            is_SplitedLabel.Name = "is_SplitedLabel";
            is_SplitedLabel.Size = new System.Drawing.Size(168, 34);
            is_SplitedLabel.TabIndex = 11;
            is_SplitedLabel.Text = "Лицевые счета на \r\nпомещение(я) разделены:";
            // 
            // shareOfPaymentLabel
            // 
            shareOfPaymentLabel.AutoSize = true;
            shareOfPaymentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            shareOfPaymentLabel.Location = new System.Drawing.Point(56, 247);
            shareOfPaymentLabel.Name = "shareOfPaymentLabel";
            shareOfPaymentLabel.Size = new System.Drawing.Size(148, 34);
            shareOfPaymentLabel.TabIndex = 13;
            shareOfPaymentLabel.Text = "Доля внесения платы, \r\nразмер доли в %:";
            // 
            // is_OpenLabel
            // 
            is_OpenLabel.AutoSize = true;
            is_OpenLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_OpenLabel.Location = new System.Drawing.Point(57, 304);
            is_OpenLabel.Name = "is_OpenLabel";
            is_OpenLabel.Size = new System.Drawing.Size(145, 17);
            is_OpenLabel.TabIndex = 15;
            is_OpenLabel.Text = "Лицевой счет открыт:";
            // 
            // eLSLabel
            // 
            eLSLabel.AutoSize = true;
            eLSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            eLSLabel.Location = new System.Drawing.Point(159, 346);
            eLSLabel.Name = "eLSLabel";
            eLSLabel.Size = new System.Drawing.Size(40, 17);
            eLSLabel.TabIndex = 17;
            eLSLabel.Text = "ЕЛС:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lSBindingSource
            // 
            this.lSBindingSource.DataMember = "LS";
            this.lSBindingSource.DataSource = this.gISDataSet;
            // 
            // lSTableAdapter
            // 
            this.lSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Payment_DocumentTableAdapter = null;
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = null;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lSBindingNavigator
            // 
            this.lSBindingNavigator.AddNewItem = null;
            this.lSBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lSBindingNavigator.BindingSource = this.lSBindingSource;
            this.lSBindingNavigator.CountItem = null;
            this.lSBindingNavigator.DeleteItem = null;
            this.lSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lSBindingNavigatorSaveItem});
            this.lSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lSBindingNavigator.MoveFirstItem = null;
            this.lSBindingNavigator.MoveLastItem = null;
            this.lSBindingNavigator.MoveNextItem = null;
            this.lSBindingNavigator.MovePreviousItem = null;
            this.lSBindingNavigator.Name = "lSBindingNavigator";
            this.lSBindingNavigator.PositionItem = null;
            this.lSBindingNavigator.Size = new System.Drawing.Size(437, 25);
            this.lSBindingNavigator.TabIndex = 0;
            this.lSBindingNavigator.Text = "bindingNavigator1";
            // 
            // lSBindingNavigatorSaveItem
            // 
            this.lSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lSBindingNavigatorSaveItem.Image")));
            this.lSBindingNavigatorSaveItem.Name = "lSBindingNavigatorSaveItem";
            this.lSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lSBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.lSBindingNavigatorSaveItem.Click += new System.EventHandler(this.lSBindingNavigatorSaveItem_Click);
            // 
            // number_JKYTextBox
            // 
            this.number_JKYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lSBindingSource, "Number_JKY", true));
            this.number_JKYTextBox.Location = new System.Drawing.Point(205, 130);
            this.number_JKYTextBox.Name = "number_JKYTextBox";
            this.number_JKYTextBox.Size = new System.Drawing.Size(207, 20);
            this.number_JKYTextBox.TabIndex = 8;
            // 
            // shareOfPaymentTextBox
            // 
            this.shareOfPaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lSBindingSource, "ShareOfPayment", true));
            this.shareOfPaymentTextBox.Location = new System.Drawing.Point(205, 261);
            this.shareOfPaymentTextBox.Name = "shareOfPaymentTextBox";
            this.shareOfPaymentTextBox.Size = new System.Drawing.Size(207, 20);
            this.shareOfPaymentTextBox.TabIndex = 14;
            // 
            // eLSTextBox
            // 
            this.eLSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lSBindingSource, "ELS", true));
            this.eLSTextBox.Location = new System.Drawing.Point(205, 345);
            this.eLSTextBox.Name = "eLSTextBox";
            this.eLSTextBox.Size = new System.Drawing.Size(207, 20);
            this.eLSTextBox.TabIndex = 18;
            // 
            // viewAddressPremisesBindingSource
            // 
            this.viewAddressPremisesBindingSource.DataMember = "View_Address_Premises";
            this.viewAddressPremisesBindingSource.DataSource = this.gISDataSet;
            // 
            // view_Address_PremisesTableAdapter
            // 
            this.view_Address_PremisesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(205, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(205, 171);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(207, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(205, 215);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(207, 21);
            this.comboBox4.TabIndex = 22;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(205, 303);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(207, 21);
            this.comboBox5.TabIndex = 23;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lSBindingSource, "ID_Owner", true));
            this.comboBox6.DataSource = this.viewOwnerBindingSource;
            this.comboBox6.DisplayMember = "FIO";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(205, 53);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(207, 21);
            this.comboBox6.TabIndex = 24;
            this.comboBox6.ValueMember = "ID";
            // 
            // viewOwnerBindingSource
            // 
            this.viewOwnerBindingSource.DataMember = "View_Owner";
            this.viewOwnerBindingSource.DataSource = this.gISDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ФИО потребителя:";
            // 
            // view_OwnerTableAdapter
            // 
            this.view_OwnerTableAdapter.ClearBeforeFill = true;
            // 
            // LS_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(eLSLabel);
            this.Controls.Add(this.eLSTextBox);
            this.Controls.Add(is_OpenLabel);
            this.Controls.Add(shareOfPaymentLabel);
            this.Controls.Add(this.shareOfPaymentTextBox);
            this.Controls.Add(is_SplitedLabel);
            this.Controls.Add(is_EmployerLabel);
            this.Controls.Add(number_JKYLabel);
            this.Controls.Add(this.number_JKYTextBox);
            this.Controls.Add(type_LSLabel);
            this.Controls.Add(this.lSBindingNavigator);
            this.Name = "LS_AF";
            this.Text = "Добавление записи в таблицу: Лицевые счета";
            this.Load += new System.EventHandler(this.LS_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSBindingNavigator)).EndInit();
            this.lSBindingNavigator.ResumeLayout(false);
            this.lSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOwnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource lSBindingSource;
        private GISDataSetTableAdapters.LSTableAdapter lSTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lSBindingNavigator;
        private System.Windows.Forms.ToolStripButton lSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox number_JKYTextBox;
        private System.Windows.Forms.TextBox shareOfPaymentTextBox;
        private System.Windows.Forms.TextBox eLSTextBox;
        private System.Windows.Forms.BindingSource viewAddressPremisesBindingSource;
        private GISDataSetTableAdapters.View_Address_PremisesTableAdapter view_Address_PremisesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource viewOwnerBindingSource;
        private GISDataSetTableAdapters.View_OwnerTableAdapter view_OwnerTableAdapter;
    }
}