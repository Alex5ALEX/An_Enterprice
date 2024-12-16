namespace EnterpriseClient.Views.EmployeeView
{
    partial class EmployeeAdd
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
            buttonBack = new Button();
            buttonAdd = new Button();
            labelJobtitle = new Label();
            textBoxJobtitle = new TextBox();
            label = new Label();
            labelName = new Label();
            labelSurname = new Label();
            textBoxAddres = new TextBox();
            labelPhone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPhone = new TextBox();
            labelAddres = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(buttonBack);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Controls.Add(labelJobtitle);
            groupBox2.Controls.Add(textBoxJobtitle);
            groupBox2.Controls.Add(label);
            groupBox2.Controls.Add(labelName);
            groupBox2.Controls.Add(labelSurname);
            groupBox2.Controls.Add(textBoxAddres);
            groupBox2.Controls.Add(labelPhone);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(labelEmail);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(labelAddres);
            groupBox2.Controls.Add(textBoxName);
            groupBox2.Controls.Add(textBoxSurname);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 615);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ControlLightLight;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(9, 559);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 16;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SpringGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(237, 559);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 50);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelJobtitle
            // 
            labelJobtitle.AutoSize = true;
            labelJobtitle.Font = new Font("Segoe UI", 12F);
            labelJobtitle.Location = new Point(23, 188);
            labelJobtitle.Name = "labelJobtitle";
            labelJobtitle.Size = new Size(63, 21);
            labelJobtitle.TabIndex = 13;
            labelJobtitle.Text = "Jobtitle:";
            // 
            // textBoxJobtitle
            // 
            textBoxJobtitle.Font = new Font("Segoe UI", 12F);
            textBoxJobtitle.Location = new Point(23, 215);
            textBoxJobtitle.Name = "textBoxJobtitle";
            textBoxJobtitle.Size = new Size(291, 29);
            textBoxJobtitle.TabIndex = 14;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 19);
            label.Name = "label";
            label.Size = new Size(190, 37);
            label.TabIndex = 0;
            label.Text = "Add Employee";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(23, 76);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(23, 132);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(21, 383);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 29);
            textBoxAddres.TabIndex = 10;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(21, 247);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(21, 327);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 29);
            textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(23, 303);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(23, 271);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(291, 29);
            textBoxPhone.TabIndex = 8;
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(21, 359);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 5;
            labelAddres.Text = "Addres:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(23, 100);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(23, 156);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(291, 29);
            textBoxSurname.TabIndex = 6;
            // 
            // EmployeeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox2);
            Name = "EmployeeAdd";
            Size = new Size(340, 615);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonBack;
        private Button buttonAdd;
        private Label labelJobtitle;
        private TextBox textBoxJobtitle;
        private Label label;
        private Label labelName;
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
