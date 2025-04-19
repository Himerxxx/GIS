
namespace GIS.Forms
{
    partial class Premises_LS_Relation_AF
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.premisesLSRelationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gISDataSet = new GIS.GISDataSet();
            this.viewLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viewAddressPremisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.view_Address_PremisesTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_PremisesTableAdapter();
            this.premises_LS_RelationsTableAdapter = new GIS.GISDataSetTableAdapters.Premises_LS_RelationsTableAdapter();
            this.view_LSTableAdapter = new GIS.GISDataSetTableAdapters.View_LSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.premisesLSRelationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.premisesLSRelationsBindingSource, "ID_LS", true));
            this.comboBox1.DataSource = this.viewLSBindingSource;
            this.comboBox1.DisplayMember = "FIO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // premisesLSRelationsBindingSource
            // 
            this.premisesLSRelationsBindingSource.DataMember = "Premises_LS_Relations";
            this.premisesLSRelationsBindingSource.DataSource = this.gISDataSet;
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewLSBindingSource
            // 
            this.viewLSBindingSource.DataMember = "View_LS";
            this.viewLSBindingSource.DataSource = this.gISDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.premisesLSRelationsBindingSource, "ID_Premises", true));
            this.comboBox2.DataSource = this.viewAddressPremisesBindingSource;
            this.comboBox2.DisplayMember = "Address";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID";
            // 
            // viewAddressPremisesBindingSource
            // 
            this.viewAddressPremisesBindingSource.DataMember = "View_Address_Premises";
            this.viewAddressPremisesBindingSource.DataSource = this.gISDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Владелец ЛС:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Помещение:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(109, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // view_Address_PremisesTableAdapter
            // 
            this.view_Address_PremisesTableAdapter.ClearBeforeFill = true;
            // 
            // premises_LS_RelationsTableAdapter
            // 
            this.premises_LS_RelationsTableAdapter.ClearBeforeFill = true;
            // 
            // view_LSTableAdapter
            // 
            this.view_LSTableAdapter.ClearBeforeFill = true;
            // 
            // Premises_LS_Relation_AF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Premises_LS_Relation_AF";
            this.Text = "Добавление записи в таблицу: Помещения и лицевые счета";
            this.Load += new System.EventHandler(this.Premises_LS_Relation_AF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premisesLSRelationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource viewAddressPremisesBindingSource;
        private GISDataSetTableAdapters.View_Address_PremisesTableAdapter view_Address_PremisesTableAdapter;
        private System.Windows.Forms.BindingSource premisesLSRelationsBindingSource;
        private GISDataSetTableAdapters.Premises_LS_RelationsTableAdapter premises_LS_RelationsTableAdapter;
        private System.Windows.Forms.BindingSource viewLSBindingSource;
        private GISDataSetTableAdapters.View_LSTableAdapter view_LSTableAdapter;
    }
}