
namespace GIS.EditForms
{
    partial class Penalties_Edit
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
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label reason_AccrualLabel;
            System.Windows.Forms.Label type_AccrualLabel;
            System.Windows.Forms.Label iD_PD_NumberLabel;
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.reason_AccrualTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            sumLabel = new System.Windows.Forms.Label();
            reason_AccrualLabel = new System.Windows.Forms.Label();
            type_AccrualLabel = new System.Windows.Forms.Label();
            iD_PD_NumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sumLabel.Location = new System.Drawing.Point(158, 194);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(55, 17);
            sumLabel.TabIndex = 23;
            sumLabel.Text = "Сумма:";
            // 
            // reason_AccrualLabel
            // 
            reason_AccrualLabel.AutoSize = true;
            reason_AccrualLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            reason_AccrualLabel.Location = new System.Drawing.Point(61, 140);
            reason_AccrualLabel.Name = "reason_AccrualLabel";
            reason_AccrualLabel.Size = new System.Drawing.Size(152, 17);
            reason_AccrualLabel.TabIndex = 22;
            reason_AccrualLabel.Text = "Основания начислений:";
            // 
            // type_AccrualLabel
            // 
            type_AccrualLabel.AutoSize = true;
            type_AccrualLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_AccrualLabel.Location = new System.Drawing.Point(103, 83);
            type_AccrualLabel.Name = "type_AccrualLabel";
            type_AccrualLabel.Size = new System.Drawing.Size(110, 17);
            type_AccrualLabel.TabIndex = 21;
            type_AccrualLabel.Text = "Вид начисления:";
            // 
            // iD_PD_NumberLabel
            // 
            iD_PD_NumberLabel.AutoSize = true;
            iD_PD_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_PD_NumberLabel.Location = new System.Drawing.Point(115, 31);
            iD_PD_NumberLabel.Name = "iD_PD_NumberLabel";
            iD_PD_NumberLabel.Size = new System.Drawing.Size(98, 17);
            iD_PD_NumberLabel.TabIndex = 20;
            iD_PD_NumberLabel.Text = "Номер записи:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(219, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(219, 194);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(184, 20);
            this.sumTextBox.TabIndex = 16;
            // 
            // reason_AccrualTextBox
            // 
            this.reason_AccrualTextBox.Location = new System.Drawing.Point(219, 139);
            this.reason_AccrualTextBox.Name = "reason_AccrualTextBox";
            this.reason_AccrualTextBox.Size = new System.Drawing.Size(184, 20);
            this.reason_AccrualTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(144, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Penalties_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 296);
            this.Controls.Add(sumLabel);
            this.Controls.Add(reason_AccrualLabel);
            this.Controls.Add(type_AccrualLabel);
            this.Controls.Add(iD_PD_NumberLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.reason_AccrualTextBox);
            this.Name = "Penalties_Edit";
            this.Opacity = 0.95D;
            this.Text = "Изменение записи в таблицу: Судебные неустойки";
            this.Load += new System.EventHandler(this.Penalties_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.TextBox reason_AccrualTextBox;
        private System.Windows.Forms.Button button1;
    }
}