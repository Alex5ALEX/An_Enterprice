namespace EnterpriseClient.Views.OrderView
{
    partial class OrderAdd
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonBack = new Button();
            buttonAdd = new Button();
            tabControl = new TabControl();
            tabPageProduct = new TabPage();
            flowLayoutPanelProduct = new FlowLayoutPanel();
            tabPageCustomers = new TabPage();
            flowLayoutPanelCustomers = new FlowLayoutPanel();
            dateTimePicker = new DateTimePicker();
            label = new Label();
            labelDate = new Label();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageProduct.SuspendLayout();
            tabPageCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(buttonBack);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Controls.Add(tabControl);
            groupBox2.Controls.Add(dateTimePicker);
            groupBox2.Controls.Add(label);
            groupBox2.Controls.Add(labelDate);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 615);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(15, 149);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 147);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(15, 125);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 19;
            label6.Text = "Desciption:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(15, 302);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(282, 220);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 177);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ControlLightLight;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(6, 559);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 17;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SpringGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(197, 559);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 50);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageProduct);
            tabControl.Controls.Add(tabPageCustomers);
            tabControl.Font = new Font("Segoe UI", 12F);
            tabControl.Location = new Point(312, 19);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(362, 590);
            tabControl.TabIndex = 15;
            // 
            // tabPageProduct
            // 
            tabPageProduct.Controls.Add(flowLayoutPanelProduct);
            tabPageProduct.Location = new Point(4, 30);
            tabPageProduct.Name = "tabPageProduct";
            tabPageProduct.Padding = new Padding(3);
            tabPageProduct.Size = new Size(354, 556);
            tabPageProduct.TabIndex = 0;
            tabPageProduct.Text = "Products";
            tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProduct
            // 
            flowLayoutPanelProduct.AutoScroll = true;
            flowLayoutPanelProduct.Location = new Point(0, 0);
            flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            flowLayoutPanelProduct.Size = new Size(354, 556);
            flowLayoutPanelProduct.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.Controls.Add(flowLayoutPanelCustomers);
            tabPageCustomers.Location = new Point(4, 30);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(354, 556);
            tabPageCustomers.TabIndex = 1;
            tabPageCustomers.Text = "Customers";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelCustomers
            // 
            flowLayoutPanelCustomers.AutoScroll = true;
            flowLayoutPanelCustomers.Location = new Point(0, 0);
            flowLayoutPanelCustomers.Name = "flowLayoutPanelCustomers";
            flowLayoutPanelCustomers.Size = new Size(354, 556);
            flowLayoutPanelCustomers.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker.Font = new Font("Segoe UI", 12F);
            dateTimePicker.Location = new Point(15, 93);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(282, 29);
            dateTimePicker.TabIndex = 14;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 19);
            label.Name = "label";
            label.Size = new Size(141, 37);
            label.TabIndex = 0;
            label.Text = "Add Order";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F);
            labelDate.Location = new Point(15, 69);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(45, 21);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date:";
            // 
            // OrderAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox2);
            Name = "OrderAdd";
            Size = new Size(680, 615);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageProduct.ResumeLayout(false);
            tabPageCustomers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button buttonBack;
        private Button buttonAdd;
        private TabControl tabControl;
        private TabPage tabPageProduct;
        private FlowLayoutPanel flowLayoutPanelProduct;
        private TabPage tabPageCustomers;
        private FlowLayoutPanel flowLayoutPanelCustomers;
        private DateTimePicker dateTimePicker;
        private Label label;
        private Label labelDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label6;
    }
}
