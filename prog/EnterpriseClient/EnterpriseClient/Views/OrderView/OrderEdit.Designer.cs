namespace EnterpriseClient.Views.OrderView
{
    partial class OrderEdit
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
            groupBox4 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonDelete = new Button();
            buttonBack = new Button();
            richTextBox1 = new RichTextBox();
            buttonEdit = new Button();
            label6 = new Label();
            tabControl = new TabControl();
            tabPageProducts = new TabPage();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            dateTimePicker = new DateTimePicker();
            label = new Label();
            labelDate = new Label();
            tabPageCustomer = new TabPage();
            flowLayoutPanelCustomer = new FlowLayoutPanel();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageProducts.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonBack);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tabControl);
            groupBox2.Controls.Add(dateTimePicker);
            groupBox2.Controls.Add(label);
            groupBox2.Controls.Add(labelDate);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 615);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(15, 312);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(282, 220);
            groupBox4.TabIndex = 35;
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
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(111, 559);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 50);
            buttonDelete.TabIndex = 34;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(9, 559);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 50);
            buttonBack.TabIndex = 33;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
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
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Aqua;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.ForeColor = SystemColors.ControlText;
            buttonEdit.Location = new Point(211, 559);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(90, 50);
            buttonEdit.TabIndex = 32;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
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
            // tabControl
            // 
            tabControl.Controls.Add(tabPageProducts);
            tabControl.Controls.Add(tabPageCustomer);
            tabControl.Font = new Font("Segoe UI", 12F);
            tabControl.Location = new Point(312, 19);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(362, 590);
            tabControl.TabIndex = 15;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(flowLayoutPanelProducts);
            tabPageProducts.Location = new Point(4, 30);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(354, 556);
            tabPageProducts.TabIndex = 0;
            tabPageProducts.Text = "Products";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(0, 0);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(354, 556);
            flowLayoutPanelProducts.TabIndex = 0;
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
            label.Size = new Size(138, 37);
            label.TabIndex = 0;
            label.Text = "Edit Order";
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
            // tabPageCustomer
            // 
            tabPageCustomer.Controls.Add(flowLayoutPanelCustomer);
            tabPageCustomer.Location = new Point(4, 30);
            tabPageCustomer.Name = "tabPageCustomer";
            tabPageCustomer.Padding = new Padding(3);
            tabPageCustomer.Size = new Size(354, 556);
            tabPageCustomer.TabIndex = 1;
            tabPageCustomer.Text = "Customers";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelCustomer
            // 
            flowLayoutPanelCustomer.AutoScroll = true;
            flowLayoutPanelCustomer.Location = new Point(0, 0);
            flowLayoutPanelCustomer.Name = "flowLayoutPanelCustomer";
            flowLayoutPanelCustomer.Size = new Size(354, 556);
            flowLayoutPanelCustomer.TabIndex = 1;
            // 
            // OrderEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox2);
            Name = "OrderEdit";
            Size = new Size(680, 615);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageProducts.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonDelete;
        private Button buttonBack;
        private RichTextBox richTextBox1;
        private Button buttonEdit;
        private Label label6;
        private TabControl tabControl;
        private TabPage tabPageProducts;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private DateTimePicker dateTimePicker;
        private Label label;
        private Label labelDate;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPageCustomer;
        private FlowLayoutPanel flowLayoutPanelCustomer;
    }
}
