namespace EnterpriseClient.Views.OrderView
{
    partial class OrderRow
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
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(185, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 133);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(105, 96);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 5;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 96);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 4;
            label9.Text = "Phone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 64);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 3;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 64);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 2;
            label7.Text = "Surname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 33);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 1;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 33);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 0;
            label5.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(57, 19);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            // 
            // OrderRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "OrderRow";
            Size = new Size(530, 160);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}
