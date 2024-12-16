namespace EnterpriseClient.Views.ProviderView
{
    partial class ProviderRow
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
            labelPhoneText = new Label();
            labelAddresText = new Label();
            labelPhone = new Label();
            labelAddres = new Label();
            labelContactPersonText = new Label();
            labelEmailText = new Label();
            labelContactPerson = new Label();
            labelCompanyText = new Label();
            labelEmail = new Label();
            labelCompany = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPhoneText);
            groupBox1.Controls.Add(labelAddresText);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelAddres);
            groupBox1.Controls.Add(labelContactPersonText);
            groupBox1.Controls.Add(labelEmailText);
            groupBox1.Controls.Add(labelContactPerson);
            groupBox1.Controls.Add(labelCompanyText);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelCompany);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // labelPhoneText
            // 
            labelPhoneText.AutoSize = true;
            labelPhoneText.Font = new Font("Segoe UI", 12F);
            labelPhoneText.Location = new Point(357, 19);
            labelPhoneText.Name = "labelPhoneText";
            labelPhoneText.Size = new Size(102, 21);
            labelPhoneText.TabIndex = 17;
            labelPhoneText.Text = "TEXT_PHONE";
            // 
            // labelAddresText
            // 
            labelAddresText.AutoSize = true;
            labelAddresText.Font = new Font("Segoe UI", 12F);
            labelAddresText.Location = new Point(681, 19);
            labelAddresText.Name = "labelAddresText";
            labelAddresText.Size = new Size(109, 21);
            labelAddresText.TabIndex = 21;
            labelAddresText.Text = "TEXT_ADDRES";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(302, 19);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Phone:";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(613, 19);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 20;
            labelAddres.Text = "Addres:";
            // 
            // labelContactPersonText
            // 
            labelContactPersonText.AutoSize = true;
            labelContactPersonText.Font = new Font("Segoe UI", 12F);
            labelContactPersonText.Location = new Point(88, 70);
            labelContactPersonText.Name = "labelContactPersonText";
            labelContactPersonText.Size = new Size(43, 21);
            labelContactPersonText.TabIndex = 15;
            labelContactPersonText.Text = "TEXT";
            // 
            // labelEmailText
            // 
            labelEmailText.AutoSize = true;
            labelEmailText.Font = new Font("Segoe UI", 12F);
            labelEmailText.Location = new Point(359, 49);
            labelEmailText.Name = "labelEmailText";
            labelEmailText.Size = new Size(94, 21);
            labelEmailText.TabIndex = 19;
            labelEmailText.Text = "TEXT_EMAIL";
            // 
            // labelContactPerson
            // 
            labelContactPerson.AutoSize = true;
            labelContactPerson.Font = new Font("Segoe UI", 12F);
            labelContactPerson.Location = new Point(6, 49);
            labelContactPerson.Name = "labelContactPerson";
            labelContactPerson.Size = new Size(63, 42);
            labelContactPerson.TabIndex = 13;
            labelContactPerson.Text = "Contact\nPerson:";
            // 
            // labelCompanyText
            // 
            labelCompanyText.AutoSize = true;
            labelCompanyText.Font = new Font("Segoe UI", 12F);
            labelCompanyText.Location = new Point(88, 19);
            labelCompanyText.Name = "labelCompanyText";
            labelCompanyText.Size = new Size(125, 21);
            labelCompanyText.TabIndex = 14;
            labelCompanyText.Text = "TEXT_COMPANY";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(302, 49);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 18;
            labelEmail.Text = "Email:";
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 12F);
            labelCompany.Location = new Point(6, 19);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(80, 21);
            labelCompany.TabIndex = 12;
            labelCompany.Text = "Company:";
            // 
            // ProviderRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ProviderRow";
            Size = new Size(873, 95);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPhoneText;
        private Label labelAddresText;
        private Label labelPhone;
        private Label labelAddres;
        private Label labelContactPersonText;
        private Label labelEmailText;
        private Label labelContactPerson;
        private Label labelCompanyText;
        private Label labelEmail;
        private Label labelCompany;
    }
}
