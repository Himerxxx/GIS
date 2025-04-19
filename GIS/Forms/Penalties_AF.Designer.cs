
namespace GIS.Forms
{
    partial class Penalties_AF
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
            System.Windows.Forms.Label type_AccrualLabel;
            System.Windows.Forms.Label reason_AccrualLabel;
            System.Windows.Forms.Label sumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalties_AF));
            this.gISDataSet = new GIS.GISDataSet();
            this.penalties_And_Court_CostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penalties_And_Court_CostsTableAdapter = new GIS.GISDataSetTableAdapters.Penalties_And_Court_CostsTableAdapter();
            this.tableAdapterManager = new GIS.GISDataSetTableAdapters.TableAdapterManager();
            this.payment_DocumentTableAdapter = new GIS.GISDataSetTableAdapters.Payment_DocumentTableAdapter();
            this.penalties_And_Court_CostsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.penalties_And_Court_CostsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reason_AccrualTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paymentDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            iD_PD_NumberLabel = new System.Windows.Forms.Label();
            type_AccrualLabel = new System.Windows.Forms.Label();
            reason_AccrualLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penalties_And_Court_CostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penalties_And_Court_CostsBindingNavigator)).BeginInit();
            this.penalties_And_Court_CostsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PD_NumberLabel
            // 
            iD_PD_NumberLabel.AutoSize = true;
            iD_PD_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_PD_NumberLabel.Location = new System.Drawing.Point(96, 64);
            iD_PD_NumberLabel.Name = "iD_PD_NumberLabel";
            iD_PD_NumberLabel.Size = new System.Drawing.Size(98, 17);
            iD_PD_NumberLabel.TabIndex = 1;
            iD_PD_NumberLabel.Text = "Номер записи:";
            // 
            // type_AccrualLabel
            // 
            type_AccrualLabel.AutoSize = true;
            type_AccrualLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_AccrualLabel.Location = new System.Drawing.Point(84, 117);
            type_AccrualLabel.Name = "type_AccrualLabel";
            type_AccrualLabel.Size = new System.Drawing.Size(110, 17);
            type_AccrualLabel.TabIndex = 3;
            type_AccrualLabel.Text = "Вид начисления:";
            // 
            // reason_AccrualLabel
            // 
            reason_AccrualLabel.AutoSize = true;
            reason_AccrualLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            reason_AccrualLabel.Location = new System.Drawing.Point(42, 173);
            reason_AccrualLabel.Name = "reason_AccrualLabel";
            reason_AccrualLabel.Size = new System.Drawing.Size(152, 17);
            reason_AccrualLabel.TabIndex = 5;
            reason_AccrualLabel.Text = "Основания начислений:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sumLabel.Location = new System.Drawing.Point(139, 228);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(55, 17);
            sumLabel.TabIndex = 7;
            sumLabel.Text = "Сумма:";
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penalties_And_Court_CostsBindingSource
            // 
            this.penalties_And_Court_CostsBindingSource.DataMember = "Penalties_And_Court_Costs";
            this.penalties_And_Court_CostsBindingSource.DataSource = this.gISDataSet;
            // 
            // penalties_And_Court_CostsTableAdapter
            // 
            this.penalties_And_Court_CostsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Penalties_And_Court_CostsTableAdapter = this.penalties_And_Court_CostsTableAdapter;
            this.tableAdapterManager.Premises_LS_RelationsTableAdapter = null;
            this.tableAdapterManager.Services_For_The_Payment_PeriodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIS.GISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // payment_DocumentTableAdapter
            // 
            this.payment_DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // penalties_And_Court_CostsBindingNavigator
            // 
            this.penalties_And_Court_CostsBindingNavigator.AddNewItem = null;
            this.penalties_And_Court_CostsBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.penalties_And_Court_CostsBindingNavigator.BindingSource = this.penalties_And_Court_CostsBindingSource;
            this.penalties_And_Court_CostsBindingNavigator.CountItem = null;
            this.penalties_And_Court_CostsBindingNavigator.DeleteItem = null;
            this.penalties_And_Court_CostsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penalties_And_Court_CostsBindingNavigatorSaveItem});
            this.penalties_And_Court_CostsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.penalties_And_Court_CostsBindingNavigator.MoveFirstItem = null;
            this.penalties_And_Court_CostsBindingNavigator.MoveLastItem = null;
            this.penalties_And_Court_CostsBindingNavigator.MoveNextItem = null;
            this.penalties_And_Court_CostsBindingNavigator.MovePreviousItem = null;
            this.penalties_And_Court_CostsBindingNavigator.Name = "penalties_And_Court_CostsBindingNavigator";
            this.penalties_And_Court_CostsBindingNavigator.PositionItem = null;
            this.penalties_And_Court_CostsBindingNavigator.Size = new System.Drawing.Size(474, 25);
            this.penalties_And_Court_CostsBindingNavigator.TabIndex = 0;
            this.penalties_And_Court_CostsBindingNavigator.Text = "bindingNavigator1";
            // 
            // penalties_And_Court_CostsBindingNavigatorSaveItem
            // 
            this.penalties_And_Court_CostsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penalties_And_Court_CostsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("penalties_And_Court_CostsBindingNavigatorSaveItem.Image")));
            this.penalties_And_Court_CostsBindingNavigatorSaveItem.Name = "penalties_And_Court_CostsBindingNavigatorSaveItem";
            this.penalties_And_Court_CostsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.penalties_And_Court_CostsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.penalties_And_Court_CostsBindingNavigatorSaveItem.Click += new System.EventHandler(this.penalties_And_Court_CostsBindingNavigatorSaveItem_Click);
            // 
            // reason_AccrualTextBox
            // 
            this.reason_AccrualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penalties_And_Court_CostsBindingSource, "Reason_Accrual", true));
            this.reason_AccrualTextBox.Location = new System.Drawing.Point(200, 172);
            this.reason_AccrualTextBox.Name = "reason_AccrualTextBox";
            this.reason_AccrualTextBox.Size = new System.Drawing.Size(184, 20);
            this.reason_AccrualTextBox.TabIndex = 6;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penalties_And_Court_CostsBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(200, 227);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(184, 20);
            this.sumTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.penalties_And_Court_CostsBindingSource, "ID_PD_Number", true));
            this.comboBox1.DataSource = this.paymentDocumentBindingSource;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 9;
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
            this.comboBox2.Location = new System.Drawing.Point(200, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // Penalties_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 277);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(reason_AccrualLabel);
            this.Controls.Add(this.reason_AccrualTextBox);
            this.Controls.Add(type_AccrualLabel);
            this.Controls.Add(iD_PD_NumberLabel);
            this.Controls.Add(this.penalties_And_Court_CostsBindingNavigator);
            this.Name = "Penalties_AF";
            this.Opacity = 0.95D;
            this.Text = "Добавление записи в таблицу: Судебные неустойки";
            this.Load += new System.EventHandler(this.Penalties_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penalties_And_Court_CostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penalties_And_Court_CostsBindingNavigator)).EndInit();
            this.penalties_And_Court_CostsBindingNavigator.ResumeLayout(false);
            this.penalties_And_Court_CostsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource penalties_And_Court_CostsBindingSource;
        private GISDataSetTableAdapters.Penalties_And_Court_CostsTableAdapter penalties_And_Court_CostsTableAdapter;
        private GISDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator penalties_And_Court_CostsBindingNavigator;
        private System.Windows.Forms.ToolStripButton penalties_And_Court_CostsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reason_AccrualTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private GISDataSetTableAdapters.Payment_DocumentTableAdapter payment_DocumentTableAdapter;
        private System.Windows.Forms.BindingSource paymentDocumentBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}