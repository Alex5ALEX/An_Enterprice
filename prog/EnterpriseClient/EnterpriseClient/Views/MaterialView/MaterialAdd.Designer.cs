namespace EnterpriseClient.Views.MaterialView
{
    partial class MaterialAdd
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
            groupBox1 = new GroupBox();
            richTextBoxDescription = new RichTextBox();
            labelDescription = new Label();
            label = new Label();
            buttonBack = new Button();
            labelName = new Label();
            buttonAdd = new Button();
            labelType = new Label();
            textBoxName = new TextBox();
            textBoxType = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(richTextBoxDescription);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(labelType);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxType);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 615);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(26, 185);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(291, 155);
            richTextBoxDescription.TabIndex = 40;
            richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(26, 161);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 21);
            labelDescription.TabIndex = 39;
            labelDescription.Text = "Description:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 12);
            label.Name = "label";
            label.Size = new Size(171, 37);
            label.TabIndex = 26;
            label.Text = "Add Material";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ControlLightLight;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(6, 552);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 38;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(26, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 27;
            labelName.Text = "Name:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SpringGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(234, 552);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 50);
            buttonAdd.TabIndex = 37;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F);
            labelType.Location = new Point(26, 105);
            labelType.Name = "labelType";
            labelType.Size = new Size(45, 21);
            labelType.TabIndex = 28;
            labelType.Text = "Type:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(26, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 33;
            // 
            // textBoxType
            // 
            textBoxType.Font = new Font("Segoe UI", 12F);
            textBoxType.Location = new Point(26, 129);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(291, 29);
            textBoxType.TabIndex = 32;
            // 
            // MaterialAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "MaterialAdd";
            Size = new Size(340, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox richTextBoxDescription;
        private Label labelDescription;
        private Label label;
        private Button buttonBack;
        private Label labelName;
        private Button buttonAdd;
        private Label labelType;
        private TextBox textBoxName;
        private TextBox textBoxType;
    }
}
