namespace EnterpriseClient.Views.CustomerView
{
    partial class CustomerAdd
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
            label = new Label();
            buttonBack = new Button();
            labelName = new Label();
            buttonAdd = new Button();
            labelSurname = new Label();
            textBoxAddres = new TextBox();
            labelPhone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPhone = new TextBox();
            labelAddres = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(labelSurname);
            groupBox1.Controls.Add(textBoxAddres);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(labelAddres);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 12);
            label.Name = "label";
            label.Size = new Size(187, 37);
            label.TabIndex = 13;
            label.Text = "Add Customer";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ControlLightLight;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(6, 552);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(23, 74);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 14;
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
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(23, 130);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 15;
            labelSurname.Text = "Surname:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(23, 322);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 29);
            textBoxAddres.TabIndex = 23;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(23, 186);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Phone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(23, 266);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 29);
            textBoxEmail.TabIndex = 22;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(23, 242);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 17;
            labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(23, 210);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(291, 29);
            textBoxPhone.TabIndex = 21;
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(23, 298);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 18;
            labelAddres.Text = "Addres:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(23, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 20;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(23, 154);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(291, 29);
            textBoxSurname.TabIndex = 19;
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "CustomerAdd";
            Size = new Size(340, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label;
        private Button buttonBack;
        private Label labelName;
        private Button buttonAdd;
        private Label labelSurname;
        private TextBox textBoxAddres;
        private Label labelPhone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxPhone;
        private Label labelAddres;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
    }
}
