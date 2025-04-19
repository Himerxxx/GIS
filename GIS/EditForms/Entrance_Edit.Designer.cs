
namespace GIS.EditForms
{
    partial class Entrance_Edit
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
            System.Windows.Forms.Label entrance_NumberLabel;
            System.Windows.Forms.Label is_Confirmed_SupplierLabel;
            System.Windows.Forms.Label year_Of_ConstructionLabel;
            System.Windows.Forms.Label number_Of_FloorsLabel;
            System.Windows.Forms.Label iD_MKD_AddressLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.entrance_NumberTextBox = new System.Windows.Forms.TextBox();
            this.number_Of_FloorsTextBox = new System.Windows.Forms.TextBox();
            entrance_NumberLabel = new System.Windows.Forms.Label();
            is_Confirmed_SupplierLabel = new System.Windows.Forms.Label();
            year_Of_ConstructionLabel = new System.Windows.Forms.Label();
            number_Of_FloorsLabel = new System.Windows.Forms.Label();
            iD_MKD_AddressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entrance_NumberLabel
            // 
            entrance_NumberLabel.AutoSize = true;
            entrance_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            entrance_NumberLabel.Location = new System.Drawing.Point(186, 207);
            entrance_NumberLabel.Name = "entrance_NumberLabel";
            entrance_NumberLabel.Size = new System.Drawing.Size(115, 17);
            entrance_NumberLabel.TabIndex = 19;
            entrance_NumberLabel.Text = "Номер подъезда:";
            // 
            // is_Confirmed_SupplierLabel
            // 
            is_Confirmed_SupplierLabel.AutoSize = true;
            is_Confirmed_SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            is_Confirmed_SupplierLabel.Location = new System.Drawing.Point(35, 160);
            is_Confirmed_SupplierLabel.Name = "is_Confirmed_SupplierLabel";
            is_Confirmed_SupplierLabel.Size = new System.Drawing.Size(270, 17);
            is_Confirmed_SupplierLabel.TabIndex = 18;
            is_Confirmed_SupplierLabel.Text = "Информация подтверждена поставщиком:";
            // 
            // year_Of_ConstructionLabel
            // 
            year_Of_ConstructionLabel.AutoSize = true;
            year_Of_ConstructionLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            year_Of_ConstructionLabel.Location = new System.Drawing.Point(200, 115);
            year_Of_ConstructionLabel.Name = "year_Of_ConstructionLabel";
            year_Of_ConstructionLabel.Size = new System.Drawing.Size(101, 17);
            year_Of_ConstructionLabel.TabIndex = 17;
            year_Of_ConstructionLabel.Text = "Год постройки:";
            // 
            // number_Of_FloorsLabel
            // 
            number_Of_FloorsLabel.AutoSize = true;
            number_Of_FloorsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_Of_FloorsLabel.Location = new System.Drawing.Point(221, 71);
            number_Of_FloorsLabel.Name = "number_Of_FloorsLabel";
            number_Of_FloorsLabel.Size = new System.Drawing.Size(80, 17);
            number_Of_FloorsLabel.TabIndex = 15;
            number_Of_FloorsLabel.Text = "Этажность:";
            // 
            // iD_MKD_AddressLabel
            // 
            iD_MKD_AddressLabel.AutoSize = true;
            iD_MKD_AddressLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_MKD_AddressLabel.Location = new System.Drawing.Point(213, 26);
            iD_MKD_AddressLabel.Name = "iD_MKD_AddressLabel";
            iD_MKD_AddressLabel.Size = new System.Drawing.Size(88, 17);
            iD_MKD_AddressLabel.TabIndex = 14;
            iD_MKD_AddressLabel.Text = "Адрес МКД:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(168, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(307, 114);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 20);
            this.maskedTextBox1.TabIndex = 23;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(307, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Address";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(307, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "ID";
            // 
            // entrance_NumberTextBox
            // 
            this.entrance_NumberTextBox.Location = new System.Drawing.Point(307, 206);
            this.entrance_NumberTextBox.Name = "entrance_NumberTextBox";
            this.entrance_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.entrance_NumberTextBox.TabIndex = 20;
            // 
            // number_Of_FloorsTextBox
            // 
            this.number_Of_FloorsTextBox.Location = new System.Drawing.Point(307, 70);
            this.number_Of_FloorsTextBox.Name = "number_Of_FloorsTextBox";
            this.number_Of_FloorsTextBox.Size = new System.Drawing.Size(184, 20);
            this.number_Of_FloorsTextBox.TabIndex = 16;
            // 
            // Entrance_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 303);
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
            this.Controls.Add(this.button1);
            this.Name = "Entrance_Edit";
            this.Opacity = 0.95D;
            this.Text = "Изменение записи из таблицы: Подъезды";
            this.Load += new System.EventHandler(this.Entrance_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox entrance_NumberTextBox;
        private System.Windows.Forms.TextBox number_Of_FloorsTextBox;
    }
}