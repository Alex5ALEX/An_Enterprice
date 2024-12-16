namespace EnterpriseClient.Views.EnterpriseView
{
    partial class EnterpriseAdd
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
            labelCompany = new Label();
            buttonAdd = new Button();
            labelContactPerson = new Label();
            textBoxAddres = new TextBox();
            labelPhone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPhone = new TextBox();
            labelAddres = new Label();
            textBoxCompany = new TextBox();
            textBoxContactPerson = new TextBox();
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
            groupBox1.Controls.Add(labelCompany);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(labelContactPerson);
            groupBox1.Controls.Add(textBoxAddres);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(labelAddres);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(textBoxContactPerson);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(26, 353);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(291, 155);
            richTextBoxDescription.TabIndex = 40;
            richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(26, 329);
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
            label.Size = new Size(191, 37);
            label.TabIndex = 26;
            label.Text = "Add Enterprise";
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
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 12F);
            labelCompany.Location = new Point(26, 49);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(80, 21);
            labelCompany.TabIndex = 27;
            labelCompany.Text = "Company:";
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
            // labelContactPerson
            // 
            labelContactPerson.AutoSize = true;
            labelContactPerson.Font = new Font("Segoe UI", 12F);
            labelContactPerson.Location = new Point(26, 105);
            labelContactPerson.Name = "labelContactPerson";
            labelContactPerson.Size = new Size(117, 21);
            labelContactPerson.TabIndex = 28;
            labelContactPerson.Text = "Contact Person:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(26, 297);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 29);
            textBoxAddres.TabIndex = 36;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(26, 161);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 29;
            labelPhone.Text = "Phone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(26, 241);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 29);
            textBoxEmail.TabIndex = 35;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(26, 217);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 30;
            labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(26, 185);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(291, 29);
            textBoxPhone.TabIndex = 34;
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(26, 273);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 31;
            labelAddres.Text = "Addres:";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Font = new Font("Segoe UI", 12F);
            textBoxCompany.Location = new Point(26, 73);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(291, 29);
            textBoxCompany.TabIndex = 33;
            // 
            // textBoxContactPerson
            // 
            textBoxContactPerson.Font = new Font("Segoe UI", 12F);
            textBoxContactPerson.Location = new Point(26, 129);
            textBoxContactPerson.Name = "textBoxContactPerson";
            textBoxContactPerson.Size = new Size(291, 29);
            textBoxContactPerson.TabIndex = 32;
            // 
            // EnterpriseAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "EnterpriseAdd";
            Size = new Size(340, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label;
        private Button buttonBack;
        private Label labelCompany;
        private Button buttonAdd;
        private Label labelContactPerson;
        private TextBox textBoxAddres;
        private Label labelPhone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxPhone;
        private Label labelAddres;
        private TextBox textBoxCompany;
        private TextBox textBoxContactPerson;
        private RichTextBox richTextBoxDescription;
        private Label labelDescription;
    }
}
