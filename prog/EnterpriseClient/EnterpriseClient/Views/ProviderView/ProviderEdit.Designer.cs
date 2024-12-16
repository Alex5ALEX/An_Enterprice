namespace EnterpriseClient.Views.ProviderView
{
    partial class ProviderEdit
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
            buttonDelete = new Button();
            buttonBack = new Button();
            buttonEdit = new Button();
            labelCompany = new Label();
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
            groupBox1.Controls.Add(labelCompany);
            groupBox1.Controls.Add(labelContactPerson);
            groupBox1.Controls.Add(textBoxAddres);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(labelAddres);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(textBoxContactPerson);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 615);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 12);
            label.Name = "label";
            label.Size = new Size(169, 37);
            label.TabIndex = 39;
            label.Text = "Edit Provider";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(120, 552);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 50);
            buttonDelete.TabIndex = 42;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(3, 552);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 41;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Aqua;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.ForeColor = SystemColors.ControlText;
            buttonEdit.Location = new Point(237, 552);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 50);
            buttonEdit.TabIndex = 40;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 12F);
            labelCompany.Location = new Point(23, 49);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(80, 21);
            labelCompany.TabIndex = 43;
            labelCompany.Text = "Company:";
            // 
            // labelContactPerson
            // 
            labelContactPerson.AutoSize = true;
            labelContactPerson.Font = new Font("Segoe UI", 12F);
            labelContactPerson.Location = new Point(23, 105);
            labelContactPerson.Name = "labelContactPerson";
            labelContactPerson.Size = new Size(117, 21);
            labelContactPerson.TabIndex = 44;
            labelContactPerson.Text = "Contact Person:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(23, 297);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 29);
            textBoxAddres.TabIndex = 52;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(23, 161);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 45;
            labelPhone.Text = "Phone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(23, 241);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 29);
            textBoxEmail.TabIndex = 51;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(23, 217);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 46;
            labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(23, 185);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(291, 29);
            textBoxPhone.TabIndex = 50;
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(23, 273);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 47;
            labelAddres.Text = "Addres:";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Font = new Font("Segoe UI", 12F);
            textBoxCompany.Location = new Point(23, 73);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(291, 29);
            textBoxCompany.TabIndex = 49;
            // 
            // textBoxContactPerson
            // 
            textBoxContactPerson.Font = new Font("Segoe UI", 12F);
            textBoxContactPerson.Location = new Point(23, 129);
            textBoxContactPerson.Name = "textBoxContactPerson";
            textBoxContactPerson.Size = new Size(291, 29);
            textBoxContactPerson.TabIndex = 48;
            // 
            // ProviderEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "ProviderEdit";
            Size = new Size(340, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label;
        private Button buttonDelete;
        private Button buttonBack;
        private Button buttonEdit;
        private Label labelCompany;
        private Label labelContactPerson;
        private TextBox textBoxAddres;
        private Label labelPhone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxPhone;
        private Label labelAddres;
        private TextBox textBoxCompany;
        private TextBox textBoxContactPerson;
    }
}
