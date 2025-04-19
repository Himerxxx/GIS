
namespace GIS.EditForms
{
    partial class PD_Edit
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
            System.Windows.Forms.Label full_GIS_TotalLabel;
            System.Windows.Forms.Label total_Legal_ExpensesLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label total_PeriodLabel;
            System.Windows.Forms.Label pR_NumberLabel;
            System.Windows.Forms.Label total_Period_DebtLabel;
            System.Windows.Forms.Label social_SupportLabel;
            System.Windows.Forms.Label last_Payment_DateLabel;
            System.Windows.Forms.Label cash_PaidLabel;
            System.Windows.Forms.Label period_SumLabel;
            System.Windows.Forms.Label count_Livivng_PeopleLabel;
            System.Windows.Forms.Label heated_AreaLabel;
            System.Windows.Forms.Label living_AreaLabel;
            System.Windows.Forms.Label total_Area_LSLabel;
            System.Windows.Forms.Label calculation_PeriodLabel;
            System.Windows.Forms.Label type_PDLabel;
            System.Windows.Forms.Label iD_LSLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paymentDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gISDataSet = new GIS.GISDataSet();
            this.viewAddressPremisesForPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.full_GIS_TotalTextBox = new System.Windows.Forms.TextBox();
            this.total_Legal_ExpensesTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.total_PeriodTextBox = new System.Windows.Forms.TextBox();
            this.pR_NumberTextBox = new System.Windows.Forms.TextBox();
            this.total_Period_DebtTextBox = new System.Windows.Forms.TextBox();
            this.social_SupportTextBox = new System.Windows.Forms.TextBox();
            this.last_Payment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cash_PaidTextBox = new System.Windows.Forms.TextBox();
            this.period_SumTextBox = new System.Windows.Forms.TextBox();
            this.count_Livivng_PeopleTextBox = new System.Windows.Forms.TextBox();
            this.heated_AreaTextBox = new System.Windows.Forms.TextBox();
            this.living_AreaTextBox = new System.Windows.Forms.TextBox();
            this.total_Area_LSTextBox = new System.Windows.Forms.TextBox();
            this.calculation_PeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.view_Address_Premises_For_PDTableAdapter = new GIS.GISDataSetTableAdapters.View_Address_Premises_For_PDTableAdapter();
            this.payment_DocumentTableAdapter = new GIS.GISDataSetTableAdapters.Payment_DocumentTableAdapter();
            full_GIS_TotalLabel = new System.Windows.Forms.Label();
            total_Legal_ExpensesLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            total_PeriodLabel = new System.Windows.Forms.Label();
            pR_NumberLabel = new System.Windows.Forms.Label();
            total_Period_DebtLabel = new System.Windows.Forms.Label();
            social_SupportLabel = new System.Windows.Forms.Label();
            last_Payment_DateLabel = new System.Windows.Forms.Label();
            cash_PaidLabel = new System.Windows.Forms.Label();
            period_SumLabel = new System.Windows.Forms.Label();
            count_Livivng_PeopleLabel = new System.Windows.Forms.Label();
            heated_AreaLabel = new System.Windows.Forms.Label();
            living_AreaLabel = new System.Windows.Forms.Label();
            total_Area_LSLabel = new System.Windows.Forms.Label();
            calculation_PeriodLabel = new System.Windows.Forms.Label();
            type_PDLabel = new System.Windows.Forms.Label();
            iD_LSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesForPDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // full_GIS_TotalLabel
            // 
            full_GIS_TotalLabel.AutoSize = true;
            full_GIS_TotalLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            full_GIS_TotalLabel.Location = new System.Drawing.Point(602, 413);
            full_GIS_TotalLabel.Name = "full_GIS_TotalLabel";
            full_GIS_TotalLabel.Size = new System.Drawing.Size(181, 17);
            full_GIS_TotalLabel.TabIndex = 102;
            full_GIS_TotalLabel.Text = "РАССЧИТАНО ГИС ЖКХ:";
            // 
            // total_Legal_ExpensesLabel
            // 
            total_Legal_ExpensesLabel.AutoSize = true;
            total_Legal_ExpensesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Legal_ExpensesLabel.Location = new System.Drawing.Point(562, 343);
            total_Legal_ExpensesLabel.Name = "total_Legal_ExpensesLabel";
            total_Legal_ExpensesLabel.Size = new System.Drawing.Size(225, 34);
            total_Legal_ExpensesLabel.TabIndex = 100;
            total_Legal_ExpensesLabel.Text = "Итого к оплате по \r\nнеустойкам и судебным расходам:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalLabel.Location = new System.Drawing.Point(643, 310);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(140, 17);
            totalLabel.TabIndex = 98;
            totalLabel.Text = "ИТОГО К ОПЛАТЕ:";
            // 
            // total_PeriodLabel
            // 
            total_PeriodLabel.AutoSize = true;
            total_PeriodLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_PeriodLabel.Location = new System.Drawing.Point(546, 260);
            total_PeriodLabel.Name = "total_PeriodLabel";
            total_PeriodLabel.Size = new System.Drawing.Size(241, 17);
            total_PeriodLabel.TabIndex = 96;
            total_PeriodLabel.Text = "Итого к оплате за расчетный период:";
            // 
            // pR_NumberLabel
            // 
            pR_NumberLabel.AutoSize = true;
            pR_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pR_NumberLabel.Location = new System.Drawing.Point(549, 207);
            pR_NumberLabel.Name = "pR_NumberLabel";
            pR_NumberLabel.Size = new System.Drawing.Size(238, 17);
            pR_NumberLabel.TabIndex = 94;
            pR_NumberLabel.Text = "Номер платежного реквизита по ПД:";
            // 
            // total_Period_DebtLabel
            // 
            total_Period_DebtLabel.AutoSize = true;
            total_Period_DebtLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Period_DebtLabel.Location = new System.Drawing.Point(504, 136);
            total_Period_DebtLabel.Name = "total_Period_DebtLabel";
            total_Period_DebtLabel.Size = new System.Drawing.Size(283, 34);
            total_Period_DebtLabel.TabIndex = 92;
            total_Period_DebtLabel.Text = "Итого к оплате за расчетный \r\nпериод c учетом задолженности/переплаты:";
            // 
            // social_SupportLabel
            // 
            social_SupportLabel.AutoSize = true;
            social_SupportLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            social_SupportLabel.Location = new System.Drawing.Point(539, 81);
            social_SupportLabel.Name = "social_SupportLabel";
            social_SupportLabel.Size = new System.Drawing.Size(248, 34);
            social_SupportLabel.TabIndex = 90;
            social_SupportLabel.Text = "Субсидии, компенсации \r\nи иные меры соц. поддержки граждан:";
            // 
            // last_Payment_DateLabel
            // 
            last_Payment_DateLabel.AutoSize = true;
            last_Payment_DateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_Payment_DateLabel.Location = new System.Drawing.Point(539, 42);
            last_Payment_DateLabel.Name = "last_Payment_DateLabel";
            last_Payment_DateLabel.Size = new System.Drawing.Size(244, 17);
            last_Payment_DateLabel.TabIndex = 88;
            last_Payment_DateLabel.Text = "Дата последней поступившей оплаты:";
            // 
            // cash_PaidLabel
            // 
            cash_PaidLabel.AutoSize = true;
            cash_PaidLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cash_PaidLabel.Location = new System.Drawing.Point(84, 414);
            cash_PaidLabel.Name = "cash_PaidLabel";
            cash_PaidLabel.Size = new System.Drawing.Size(192, 17);
            cash_PaidLabel.TabIndex = 86;
            cash_PaidLabel.Text = "Оплачено денежных средств:";
            // 
            // period_SumLabel
            // 
            period_SumLabel.AutoSize = true;
            period_SumLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            period_SumLabel.Location = new System.Drawing.Point(29, 371);
            period_SumLabel.Name = "period_SumLabel";
            period_SumLabel.Size = new System.Drawing.Size(247, 17);
            period_SumLabel.TabIndex = 84;
            period_SumLabel.Text = "Сумма к оплате за расчетный период:";
            // 
            // count_Livivng_PeopleLabel
            // 
            count_Livivng_PeopleLabel.AutoSize = true;
            count_Livivng_PeopleLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            count_Livivng_PeopleLabel.Location = new System.Drawing.Point(100, 323);
            count_Livivng_PeopleLabel.Name = "count_Livivng_PeopleLabel";
            count_Livivng_PeopleLabel.Size = new System.Drawing.Size(176, 17);
            count_Livivng_PeopleLabel.TabIndex = 82;
            count_Livivng_PeopleLabel.Text = "Количество проживающих:";
            // 
            // heated_AreaLabel
            // 
            heated_AreaLabel.AutoSize = true;
            heated_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            heated_AreaLabel.Location = new System.Drawing.Point(116, 276);
            heated_AreaLabel.Name = "heated_AreaLabel";
            heated_AreaLabel.Size = new System.Drawing.Size(160, 17);
            heated_AreaLabel.TabIndex = 80;
            heated_AreaLabel.Text = "Отапливаемая площадь:";
            // 
            // living_AreaLabel
            // 
            living_AreaLabel.AutoSize = true;
            living_AreaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            living_AreaLabel.Location = new System.Drawing.Point(166, 231);
            living_AreaLabel.Name = "living_AreaLabel";
            living_AreaLabel.Size = new System.Drawing.Size(110, 17);
            living_AreaLabel.TabIndex = 78;
            living_AreaLabel.Text = "Жилая площадь:";
            // 
            // total_Area_LSLabel
            // 
            total_Area_LSLabel.AutoSize = true;
            total_Area_LSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            total_Area_LSLabel.Location = new System.Drawing.Point(113, 185);
            total_Area_LSLabel.Name = "total_Area_LSLabel";
            total_Area_LSLabel.Size = new System.Drawing.Size(163, 17);
            total_Area_LSLabel.TabIndex = 76;
            total_Area_LSLabel.Text = "Общая площадь для ЛС:";
            // 
            // calculation_PeriodLabel
            // 
            calculation_PeriodLabel.AutoSize = true;
            calculation_PeriodLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            calculation_PeriodLabel.Location = new System.Drawing.Point(149, 140);
            calculation_PeriodLabel.Name = "calculation_PeriodLabel";
            calculation_PeriodLabel.Size = new System.Drawing.Size(127, 17);
            calculation_PeriodLabel.TabIndex = 74;
            calculation_PeriodLabel.Text = "Расчетный период:";
            // 
            // type_PDLabel
            // 
            type_PDLabel.AutoSize = true;
            type_PDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_PDLabel.Location = new System.Drawing.Point(217, 93);
            type_PDLabel.Name = "type_PDLabel";
            type_PDLabel.Size = new System.Drawing.Size(59, 17);
            type_PDLabel.TabIndex = 73;
            type_PDLabel.Text = "Тип ПД:";
            // 
            // iD_LSLabel
            // 
            iD_LSLabel.AutoSize = true;
            iD_LSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_LSLabel.Location = new System.Drawing.Point(146, 42);
            iD_LSLabel.Name = "iD_LSLabel";
            iD_LSLabel.Size = new System.Drawing.Size(130, 17);
            iD_LSLabel.TabIndex = 72;
            iD_LSLabel.Text = "ФИО Потребителя:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(406, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 71;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(282, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 105;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentDocumentBindingSource, "ID_LS", true));
            this.comboBox1.DataSource = this.viewAddressPremisesForPDBindingSource;
            this.comboBox1.DisplayMember = "FIO_Address";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 104;
            this.comboBox1.ValueMember = "ID_LS";
            // 
            // paymentDocumentBindingSource
            // 
            this.paymentDocumentBindingSource.DataMember = "Payment_Document";
            this.paymentDocumentBindingSource.DataSource = this.gISDataSet;
            // 
            // gISDataSet
            // 
            this.gISDataSet.DataSetName = "GISDataSet";
            this.gISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAddressPremisesForPDBindingSource
            // 
            this.viewAddressPremisesForPDBindingSource.DataMember = "View_Address_Premises_For_PD";
            this.viewAddressPremisesForPDBindingSource.DataSource = this.gISDataSet;
            // 
            // full_GIS_TotalTextBox
            // 
            this.full_GIS_TotalTextBox.Location = new System.Drawing.Point(789, 413);
            this.full_GIS_TotalTextBox.Name = "full_GIS_TotalTextBox";
            this.full_GIS_TotalTextBox.Size = new System.Drawing.Size(184, 20);
            this.full_GIS_TotalTextBox.TabIndex = 103;
            // 
            // total_Legal_ExpensesTextBox
            // 
            this.total_Legal_ExpensesTextBox.Location = new System.Drawing.Point(789, 359);
            this.total_Legal_ExpensesTextBox.Name = "total_Legal_ExpensesTextBox";
            this.total_Legal_ExpensesTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Legal_ExpensesTextBox.TabIndex = 101;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(789, 309);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(184, 20);
            this.totalTextBox.TabIndex = 99;
            // 
            // total_PeriodTextBox
            // 
            this.total_PeriodTextBox.Location = new System.Drawing.Point(789, 259);
            this.total_PeriodTextBox.Name = "total_PeriodTextBox";
            this.total_PeriodTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_PeriodTextBox.TabIndex = 97;
            // 
            // pR_NumberTextBox
            // 
            this.pR_NumberTextBox.Location = new System.Drawing.Point(789, 206);
            this.pR_NumberTextBox.Name = "pR_NumberTextBox";
            this.pR_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.pR_NumberTextBox.TabIndex = 95;
            // 
            // total_Period_DebtTextBox
            // 
            this.total_Period_DebtTextBox.Location = new System.Drawing.Point(789, 153);
            this.total_Period_DebtTextBox.Name = "total_Period_DebtTextBox";
            this.total_Period_DebtTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Period_DebtTextBox.TabIndex = 93;
            // 
            // social_SupportTextBox
            // 
            this.social_SupportTextBox.Location = new System.Drawing.Point(789, 97);
            this.social_SupportTextBox.Name = "social_SupportTextBox";
            this.social_SupportTextBox.Size = new System.Drawing.Size(184, 20);
            this.social_SupportTextBox.TabIndex = 91;
            // 
            // last_Payment_DateDateTimePicker
            // 
            this.last_Payment_DateDateTimePicker.Location = new System.Drawing.Point(789, 39);
            this.last_Payment_DateDateTimePicker.Name = "last_Payment_DateDateTimePicker";
            this.last_Payment_DateDateTimePicker.ShowCheckBox = true;
            this.last_Payment_DateDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.last_Payment_DateDateTimePicker.TabIndex = 89;
            // 
            // cash_PaidTextBox
            // 
            this.cash_PaidTextBox.Location = new System.Drawing.Point(282, 413);
            this.cash_PaidTextBox.Name = "cash_PaidTextBox";
            this.cash_PaidTextBox.Size = new System.Drawing.Size(184, 20);
            this.cash_PaidTextBox.TabIndex = 87;
            // 
            // period_SumTextBox
            // 
            this.period_SumTextBox.Location = new System.Drawing.Point(282, 370);
            this.period_SumTextBox.Name = "period_SumTextBox";
            this.period_SumTextBox.Size = new System.Drawing.Size(184, 20);
            this.period_SumTextBox.TabIndex = 85;
            // 
            // count_Livivng_PeopleTextBox
            // 
            this.count_Livivng_PeopleTextBox.Location = new System.Drawing.Point(282, 322);
            this.count_Livivng_PeopleTextBox.Name = "count_Livivng_PeopleTextBox";
            this.count_Livivng_PeopleTextBox.Size = new System.Drawing.Size(184, 20);
            this.count_Livivng_PeopleTextBox.TabIndex = 83;
            // 
            // heated_AreaTextBox
            // 
            this.heated_AreaTextBox.Location = new System.Drawing.Point(282, 275);
            this.heated_AreaTextBox.Name = "heated_AreaTextBox";
            this.heated_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.heated_AreaTextBox.TabIndex = 81;
            // 
            // living_AreaTextBox
            // 
            this.living_AreaTextBox.Location = new System.Drawing.Point(282, 230);
            this.living_AreaTextBox.Name = "living_AreaTextBox";
            this.living_AreaTextBox.Size = new System.Drawing.Size(184, 20);
            this.living_AreaTextBox.TabIndex = 79;
            // 
            // total_Area_LSTextBox
            // 
            this.total_Area_LSTextBox.Location = new System.Drawing.Point(282, 184);
            this.total_Area_LSTextBox.Name = "total_Area_LSTextBox";
            this.total_Area_LSTextBox.Size = new System.Drawing.Size(184, 20);
            this.total_Area_LSTextBox.TabIndex = 77;
            // 
            // calculation_PeriodDateTimePicker
            // 
            this.calculation_PeriodDateTimePicker.Location = new System.Drawing.Point(282, 140);
            this.calculation_PeriodDateTimePicker.Name = "calculation_PeriodDateTimePicker";
            this.calculation_PeriodDateTimePicker.ShowCheckBox = true;
            this.calculation_PeriodDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.calculation_PeriodDateTimePicker.TabIndex = 75;
            // 
            // view_Address_Premises_For_PDTableAdapter
            // 
            this.view_Address_Premises_For_PDTableAdapter.ClearBeforeFill = true;
            // 
            // payment_DocumentTableAdapter
            // 
            this.payment_DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // PD_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 539);
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
            this.Controls.Add(this.button1);
            this.Name = "PD_Edit";
            this.Opacity = 0.95D;
            this.Text = "Изменение записи в таблицу: Данные платежного документа";
            this.Load += new System.EventHandler(this.PD_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddressPremisesForPDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox full_GIS_TotalTextBox;
        private System.Windows.Forms.TextBox total_Legal_ExpensesTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox total_PeriodTextBox;
        private System.Windows.Forms.TextBox pR_NumberTextBox;
        private System.Windows.Forms.TextBox total_Period_DebtTextBox;
        private System.Windows.Forms.TextBox social_SupportTextBox;
        private System.Windows.Forms.DateTimePicker last_Payment_DateDateTimePicker;
        private System.Windows.Forms.TextBox cash_PaidTextBox;
        private System.Windows.Forms.TextBox period_SumTextBox;
        private System.Windows.Forms.TextBox count_Livivng_PeopleTextBox;
        private System.Windows.Forms.TextBox heated_AreaTextBox;
        private System.Windows.Forms.TextBox living_AreaTextBox;
        private System.Windows.Forms.TextBox total_Area_LSTextBox;
        private System.Windows.Forms.DateTimePicker calculation_PeriodDateTimePicker;
        private GISDataSet gISDataSet;
        private System.Windows.Forms.BindingSource viewAddressPremisesForPDBindingSource;
        private GISDataSetTableAdapters.View_Address_Premises_For_PDTableAdapter view_Address_Premises_For_PDTableAdapter;
        private System.Windows.Forms.BindingSource paymentDocumentBindingSource;
        private GISDataSetTableAdapters.Payment_DocumentTableAdapter payment_DocumentTableAdapter;
    }
}