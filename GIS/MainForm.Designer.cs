
namespace GIS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мКДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подъездыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лицевыеСчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лицевойСчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.владельцыЛСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приборыУчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иПУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судебныеНеустойкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьПДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиПоказанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индивидуальныеПоказанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общедомовыеПоказанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 400);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.лицевыеСчетаToolStripMenuItem,
            this.приборыУчетаToolStripMenuItem,
            this.платежныеДокументыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.свернутьToolStripMenuItem,
            this.внестиПоказанияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мКДToolStripMenuItem,
            this.подъездыToolStripMenuItem,
            this.помещенияToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.справочникToolStripMenuItem.Text = "Справочник домов";
            this.справочникToolStripMenuItem.Click += new System.EventHandler(this.справочникToolStripMenuItem_Click);
            // 
            // мКДToolStripMenuItem
            // 
            this.мКДToolStripMenuItem.Name = "мКДToolStripMenuItem";
            this.мКДToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.мКДToolStripMenuItem.Text = "МКД";
            this.мКДToolStripMenuItem.Click += new System.EventHandler(this.мКДToolStripMenuItem_Click);
            // 
            // подъездыToolStripMenuItem
            // 
            this.подъездыToolStripMenuItem.Name = "подъездыToolStripMenuItem";
            this.подъездыToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.подъездыToolStripMenuItem.Text = "Подъезды";
            this.подъездыToolStripMenuItem.Click += new System.EventHandler(this.подъездыToolStripMenuItem_Click);
            // 
            // помещенияToolStripMenuItem
            // 
            this.помещенияToolStripMenuItem.Name = "помещенияToolStripMenuItem";
            this.помещенияToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.помещенияToolStripMenuItem.Text = "Помещения";
            this.помещенияToolStripMenuItem.Click += new System.EventHandler(this.помещенияToolStripMenuItem_Click);
            // 
            // лицевыеСчетаToolStripMenuItem
            // 
            this.лицевыеСчетаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лицевойСчетToolStripMenuItem,
            this.владельцыЛСToolStripMenuItem,
            this.лСToolStripMenuItem});
            this.лицевыеСчетаToolStripMenuItem.Name = "лицевыеСчетаToolStripMenuItem";
            this.лицевыеСчетаToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.лицевыеСчетаToolStripMenuItem.Text = "Лицевые счета";
            // 
            // лицевойСчетToolStripMenuItem
            // 
            this.лицевойСчетToolStripMenuItem.Name = "лицевойСчетToolStripMenuItem";
            this.лицевойСчетToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.лицевойСчетToolStripMenuItem.Text = "Лицевой счет";
            this.лицевойСчетToolStripMenuItem.Click += new System.EventHandler(this.лицевойСчетToolStripMenuItem_Click);
            // 
            // владельцыЛСToolStripMenuItem
            // 
            this.владельцыЛСToolStripMenuItem.Name = "владельцыЛСToolStripMenuItem";
            this.владельцыЛСToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.владельцыЛСToolStripMenuItem.Text = "Владельцы ЛС";
            this.владельцыЛСToolStripMenuItem.Click += new System.EventHandler(this.владельцыЛСToolStripMenuItem_Click);
            // 
            // лСToolStripMenuItem
            // 
            this.лСToolStripMenuItem.Name = "лСToolStripMenuItem";
            this.лСToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.лСToolStripMenuItem.Text = "Помещения и ЛС";
            this.лСToolStripMenuItem.Click += new System.EventHandler(this.лСToolStripMenuItem_Click);
            // 
            // приборыУчетаToolStripMenuItem
            // 
            this.приборыУчетаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иПУToolStripMenuItem,
            this.оПУToolStripMenuItem});
            this.приборыУчетаToolStripMenuItem.Name = "приборыУчетаToolStripMenuItem";
            this.приборыУчетаToolStripMenuItem.Size = new System.Drawing.Size(117, 21);
            this.приборыУчетаToolStripMenuItem.Text = "Приборы учета";
            // 
            // иПУToolStripMenuItem
            // 
            this.иПУToolStripMenuItem.Name = "иПУToolStripMenuItem";
            this.иПУToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.иПУToolStripMenuItem.Text = "ИПУ";
            this.иПУToolStripMenuItem.Click += new System.EventHandler(this.иПУToolStripMenuItem_Click);
            // 
            // оПУToolStripMenuItem
            // 
            this.оПУToolStripMenuItem.Name = "оПУToolStripMenuItem";
            this.оПУToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.оПУToolStripMenuItem.Text = "ОПУ";
            this.оПУToolStripMenuItem.Click += new System.EventHandler(this.оПУToolStripMenuItem_Click);
            // 
            // платежныеДокументыToolStripMenuItem
            // 
            this.платежныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пДToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.судебныеНеустойкиToolStripMenuItem,
            this.сформироватьПДToolStripMenuItem});
            this.платежныеДокументыToolStripMenuItem.Name = "платежныеДокументыToolStripMenuItem";
            this.платежныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(167, 21);
            this.платежныеДокументыToolStripMenuItem.Text = "Платежные документы";
            this.платежныеДокументыToolStripMenuItem.Click += new System.EventHandler(this.платежныеДокументыToolStripMenuItem_Click);
            // 
            // пДToolStripMenuItem
            // 
            this.пДToolStripMenuItem.Name = "пДToolStripMenuItem";
            this.пДToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.пДToolStripMenuItem.Text = "Данные платежного документа";
            this.пДToolStripMenuItem.Click += new System.EventHandler(this.пДToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.услугиToolStripMenuItem.Text = "Услуги за платежный период";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // судебныеНеустойкиToolStripMenuItem
            // 
            this.судебныеНеустойкиToolStripMenuItem.Name = "судебныеНеустойкиToolStripMenuItem";
            this.судебныеНеустойкиToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.судебныеНеустойкиToolStripMenuItem.Text = "Судебные неустойки";
            this.судебныеНеустойкиToolStripMenuItem.Click += new System.EventHandler(this.судебныеНеустойкиToolStripMenuItem_Click);
            // 
            // сформироватьПДToolStripMenuItem
            // 
            this.сформироватьПДToolStripMenuItem.Name = "сформироватьПДToolStripMenuItem";
            this.сформироватьПДToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.сформироватьПДToolStripMenuItem.Text = "Сформировать ПД";
            this.сформироватьПДToolStripMenuItem.Click += new System.EventHandler(this.сформироватьПДToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // свернутьToolStripMenuItem
            // 
            this.свернутьToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.свернутьToolStripMenuItem.Name = "свернутьToolStripMenuItem";
            this.свернутьToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.свернутьToolStripMenuItem.Text = "Свернуть";
            this.свернутьToolStripMenuItem.Click += new System.EventHandler(this.свернутьToolStripMenuItem_Click);
            // 
            // внестиПоказанияToolStripMenuItem
            // 
            this.внестиПоказанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.индивидуальныеПоказанияToolStripMenuItem,
            this.общедомовыеПоказанияToolStripMenuItem});
            this.внестиПоказанияToolStripMenuItem.Name = "внестиПоказанияToolStripMenuItem";
            this.внестиПоказанияToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.внестиПоказанияToolStripMenuItem.Text = "Внести показания";
            // 
            // индивидуальныеПоказанияToolStripMenuItem
            // 
            this.индивидуальныеПоказанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внестиToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.индивидуальныеПоказанияToolStripMenuItem.Name = "индивидуальныеПоказанияToolStripMenuItem";
            this.индивидуальныеПоказанияToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.индивидуальныеПоказанияToolStripMenuItem.Text = "Индивидуальные показания";
            this.индивидуальныеПоказанияToolStripMenuItem.Click += new System.EventHandler(this.индивидуальныеПоказанияToolStripMenuItem_Click);
            // 
            // внестиToolStripMenuItem
            // 
            this.внестиToolStripMenuItem.Name = "внестиToolStripMenuItem";
            this.внестиToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.внестиToolStripMenuItem.Text = "Внести";
            this.внестиToolStripMenuItem.Click += new System.EventHandler(this.внестиToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // общедомовыеПоказанияToolStripMenuItem
            // 
            this.общедомовыеПоказанияToolStripMenuItem.Name = "общедомовыеПоказанияToolStripMenuItem";
            this.общедомовыеПоказанияToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.общедомовыеПоказанияToolStripMenuItem.Text = "Общедомовые показания";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 436);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АС обмена данных управляющей компании с ГИС ЖКХ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мКДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подъездыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лицевыеСчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лицевойСчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem владельцыЛСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приборыУчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иПУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem судебныеНеустойкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьПДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиПоказанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индивидуальныеПоказанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общедомовыеПоказанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
    }
}

