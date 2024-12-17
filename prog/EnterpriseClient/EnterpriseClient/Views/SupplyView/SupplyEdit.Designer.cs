namespace EnterpriseClient.Views.SupplyView
{
    partial class SupplyEdit
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
            tabControl = new TabControl();
            tabPageMaterial = new TabPage();
            flowLayoutPanelMaterial = new FlowLayoutPanel();
            tabPageProvider = new TabPage();
            flowLayoutPanelProvider = new FlowLayoutPanel();
            dateTimePicker = new DateTimePicker();
            label = new Label();
            labelDate = new Label();
            buttonDelete = new Button();
            buttonBack = new Button();
            buttonEdit = new Button();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageMaterial.SuspendLayout();
            tabPageProvider.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonBack);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(groupBox4);
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
            // richTextBox1
            // 
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
            groupBox4.Text = "Provider";
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
            // tabControl
            // 
            tabControl.Controls.Add(tabPageMaterial);
            tabControl.Controls.Add(tabPageProvider);
            tabControl.Font = new Font("Segoe UI", 12F);
            tabControl.Location = new Point(312, 19);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(362, 590);
            tabControl.TabIndex = 15;
            // 
            // tabPageMaterial
            // 
            tabPageMaterial.Controls.Add(flowLayoutPanelMaterial);
            tabPageMaterial.Location = new Point(4, 30);
            tabPageMaterial.Name = "tabPageMaterial";
            tabPageMaterial.Padding = new Padding(3);
            tabPageMaterial.Size = new Size(354, 556);
            tabPageMaterial.TabIndex = 0;
            tabPageMaterial.Text = "Materials";
            tabPageMaterial.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMaterial
            // 
            flowLayoutPanelMaterial.AutoScroll = true;
            flowLayoutPanelMaterial.Location = new Point(0, 0);
            flowLayoutPanelMaterial.Name = "flowLayoutPanelMaterial";
            flowLayoutPanelMaterial.Size = new Size(354, 556);
            flowLayoutPanelMaterial.TabIndex = 0;
            // 
            // tabPageProvider
            // 
            tabPageProvider.Controls.Add(flowLayoutPanelProvider);
            tabPageProvider.Location = new Point(4, 30);
            tabPageProvider.Name = "tabPageProvider";
            tabPageProvider.Padding = new Padding(3);
            tabPageProvider.Size = new Size(354, 556);
            tabPageProvider.TabIndex = 1;
            tabPageProvider.Text = "Provider";
            tabPageProvider.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProvider
            // 
            flowLayoutPanelProvider.AutoScroll = true;
            flowLayoutPanelProvider.Location = new Point(0, 0);
            flowLayoutPanelProvider.Name = "flowLayoutPanelProvider";
            flowLayoutPanelProvider.Size = new Size(354, 556);
            flowLayoutPanelProvider.TabIndex = 0;
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
            label.Size = new Size(151, 37);
            label.TabIndex = 0;
            label.Text = "Edit Supply";
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
            // SupplyEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox2);
            Name = "SupplyEdit";
            Size = new Size(680, 615);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageMaterial.ResumeLayout(false);
            tabPageProvider.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonDelete;
        private Button buttonBack;
        private RichTextBox richTextBox1;
        private Button buttonEdit;
        private Label label6;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageMaterial;
        private FlowLayoutPanel flowLayoutPanelMaterial;
        private TabPage tabPageProvider;
        private FlowLayoutPanel flowLayoutPanelProvider;
        private DateTimePicker dateTimePicker;
        private Label label;
        private Label labelDate;
    }
}
