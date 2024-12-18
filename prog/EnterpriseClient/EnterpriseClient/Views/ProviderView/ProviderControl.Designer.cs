namespace EnterpriseClient.Views.ProviderView
{
    partial class ProviderControl
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
            labelMenuName = new Label();
            buttonAdd = new Button();
            buttonEdit = new Button();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBoxAction = new GroupBox();
            buttonMenu = new Button();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Font = new Font("Segoe UI", 30F);
            labelMenuName.Location = new Point(89, 3);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(187, 54);
            labelMenuName.TabIndex = 15;
            labelMenuName.Text = "Providers";
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(1164, 9);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 50);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(1051, 9);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(80, 50);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(349, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(908, 615);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(9, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(896, 593);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxAction
            // 
            groupBoxAction.Font = new Font("Segoe UI", 9F);
            groupBoxAction.Location = new Point(3, 62);
            groupBoxAction.Name = "groupBoxAction";
            groupBoxAction.Size = new Size(340, 615);
            groupBoxAction.TabIndex = 12;
            groupBoxAction.TabStop = false;
            // 
            // buttonMenu
            // 
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(3, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(80, 55);
            buttonMenu.TabIndex = 10;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.provider;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // ProviderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(pictureBox1);
            Controls.Add(labelMenuName);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxAction);
            Controls.Add(buttonMenu);
            Name = "ProviderControl";
            Size = new Size(1280, 680);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuName;
        private Button buttonAdd;
        private Button buttonEdit;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBoxAction;
        private Button buttonMenu;
        private PictureBox pictureBox1;
    }
}
