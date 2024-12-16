namespace EnterpriseClient.Views.EmployeeView
{
    partial class EmployeeEdit
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
            buttonDelete = new Button();
            buttonBack = new Button();
            buttonEdit = new Button();
            labelJobtitle = new Label();
            textBoxJobtitle = new TextBox();
            label = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelAddres = new Label();
            textBoxAddres = new TextBox();
            textBoxSurname = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonBack);
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(labelJobtitle);
            groupBox2.Controls.Add(textBoxJobtitle);
            groupBox2.Controls.Add(label);
            groupBox2.Controls.Add(labelName);
            groupBox2.Controls.Add(labelSurname);
            groupBox2.Controls.Add(labelPhone);
            groupBox2.Controls.Add(labelEmail);
            groupBox2.Controls.Add(labelAddres);
            groupBox2.Controls.Add(textBoxAddres);
            groupBox2.Controls.Add(textBoxSurname);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxName);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 615);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(120, 559);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 50);
            buttonDelete.TabIndex = 34;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(3, 559);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 33;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Aqua;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(237, 559);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 50);
            buttonEdit.TabIndex = 32;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // labelJobtitle
            // 
            labelJobtitle.AutoSize = true;
            labelJobtitle.Font = new Font("Segoe UI", 12F);
            labelJobtitle.Location = new Point(24, 189);
            labelJobtitle.Name = "labelJobtitle";
            labelJobtitle.Size = new Size(63, 21);
            labelJobtitle.TabIndex = 30;
            labelJobtitle.Text = "Jobttile:";
            // 
            // textBoxJobtitle
            // 
            textBoxJobtitle.Font = new Font("Segoe UI", 12F);
            textBoxJobtitle.Location = new Point(25, 213);
            textBoxJobtitle.Name = "textBoxJobtitle";
            textBoxJobtitle.Size = new Size(290, 29);
            textBoxJobtitle.TabIndex = 31;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 19);
            label.Name = "label";
            label.Size = new Size(187, 37);
            label.TabIndex = 13;
            label.Text = "Edit Employee";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(24, 77);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 14;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(24, 133);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 15;
            labelSurname.Text = "Surname:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(24, 245);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(24, 301);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 17;
            labelEmail.Text = "Email:";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(25, 357);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 18;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(25, 381);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 29);
            textBoxAddres.TabIndex = 23;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(25, 157);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(290, 29);
            textBoxSurname.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(25, 325);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(290, 29);
            textBoxEmail.TabIndex = 22;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(24, 101);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 20;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(25, 269);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(290, 29);
            textBoxPhone.TabIndex = 21;
            // 
            // EmployeeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "EmployeeEdit";
            Size = new Size(340, 615);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonDelete;
        private Button buttonBack;
        private Button buttonEdit;
        private Label labelJobtitle;
        private TextBox textBoxJobtitle;
        private Label label;
        private Label labelName;
        private Label labelSurname;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelAddres;
        private TextBox textBoxAddres;
        private TextBox textBoxSurname;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
    }
}
