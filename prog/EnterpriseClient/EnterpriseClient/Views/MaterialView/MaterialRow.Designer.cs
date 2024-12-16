namespace EnterpriseClient.Views.MaterialView
{
    partial class MaterialRow
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
            labelTypeText = new Label();
            labelType = new Label();
            labelNameText = new Label();
            labelName = new Label();
            labelDescriptionText = new Label();
            labelDescription = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDescriptionText);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(labelTypeText);
            groupBox1.Controls.Add(labelType);
            groupBox1.Controls.Add(labelNameText);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // labelTypeText
            // 
            labelTypeText.AutoSize = true;
            labelTypeText.Font = new Font("Segoe UI", 12F);
            labelTypeText.Location = new Point(481, 19);
            labelTypeText.Name = "labelTypeText";
            labelTypeText.Size = new Size(43, 21);
            labelTypeText.TabIndex = 17;
            labelTypeText.Text = "TEXT";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F);
            labelType.Location = new Point(430, 19);
            labelType.Name = "labelType";
            labelType.Size = new Size(45, 21);
            labelType.TabIndex = 16;
            labelType.Text = "Type:";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 12F);
            labelNameText.Location = new Point(67, 19);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(43, 21);
            labelNameText.TabIndex = 14;
            labelNameText.Text = "TEXT";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(6, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 12;
            labelName.Text = "Name:";
            // 
            // labelDescriptionText
            // 
            labelDescriptionText.AutoSize = true;
            labelDescriptionText.Font = new Font("Segoe UI", 12F);
            labelDescriptionText.Location = new Point(104, 62);
            labelDescriptionText.Name = "labelDescriptionText";
            labelDescriptionText.Size = new Size(43, 21);
            labelDescriptionText.TabIndex = 19;
            labelDescriptionText.Text = "TEXT";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(6, 62);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 21);
            labelDescription.TabIndex = 18;
            labelDescription.Text = "Description:";
            // 
            // MaterialRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "MaterialRow";
            Size = new Size(873, 100);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelTypeText;
        private Label labelType;
        private Label labelNameText;
        private Label labelName;
        private Label labelDescriptionText;
        private Label labelDescription;
    }
}
