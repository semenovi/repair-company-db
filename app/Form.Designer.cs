namespace RepairCompany
{
    partial class repairCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlPanel = new System.Windows.Forms.Panel();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.requestsPage = new System.Windows.Forms.TabPage();
            this.requestsPanel = new System.Windows.Forms.Panel();
            this.requestServicesGroup = new System.Windows.Forms.GroupBox();
            this.requestServicesPanel = new System.Windows.Forms.Panel();
            this.requestServicesAddButton = new System.Windows.Forms.Button();
            this.requestServicesSelectComboBox = new System.Windows.Forms.ComboBox();
            this.requestServicesSelectLabel = new System.Windows.Forms.Label();
            this.requestObjectInfoGroup = new System.Windows.Forms.GroupBox();
            this.requestObjectPanel = new System.Windows.Forms.Panel();
            this.requestAddressNumberText = new System.Windows.Forms.TextBox();
            this.requestAddressNumberLabel = new System.Windows.Forms.Label();
            this.requestAddressStreetText = new System.Windows.Forms.TextBox();
            this.requestAddressStreetLabel = new System.Windows.Forms.Label();
            this.requestAddressCityText = new System.Windows.Forms.TextBox();
            this.requestAddressCityLabel = new System.Windows.Forms.Label();
            this.smetiPage = new System.Windows.Forms.TabPage();
            this.printPage = new System.Windows.Forms.TabPage();
            this.requestServicesListLabel = new System.Windows.Forms.Label();
            this.requestServicesListBox = new System.Windows.Forms.ListBox();
            this.requestServicesSettingsLabel = new System.Windows.Forms.Label();
            this.requestServicesSettingsDomain = new System.Windows.Forms.DomainUpDown();
            this.requestDateGroup = new System.Windows.Forms.GroupBox();
            this.requestDatePanel = new System.Windows.Forms.Panel();
            this.requestDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.requestsPage.SuspendLayout();
            this.requestsPanel.SuspendLayout();
            this.requestServicesGroup.SuspendLayout();
            this.requestServicesPanel.SuspendLayout();
            this.requestObjectInfoGroup.SuspendLayout();
            this.requestObjectPanel.SuspendLayout();
            this.requestDateGroup.SuspendLayout();
            this.requestDatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.previousButton);
            this.controlPanel.Controls.Add(this.nextButton);
            this.controlPanel.Controls.Add(this.actionButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 581);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.controlPanel.Size = new System.Drawing.Size(317, 33);
            this.controlPanel.TabIndex = 1;
            // 
            // previousButton
            // 
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.previousButton.Location = new System.Drawing.Point(87, 5);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextButton.Location = new System.Drawing.Point(162, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            this.actionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionButton.Location = new System.Drawing.Point(237, 5);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "DA";
            this.actionButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainTabs);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(317, 581);
            this.mainPanel.TabIndex = 2;
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.requestsPage);
            this.mainTabs.Controls.Add(this.smetiPage);
            this.mainTabs.Controls.Add(this.printPage);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(317, 581);
            this.mainTabs.TabIndex = 0;
            // 
            // requestsPage
            // 
            this.requestsPage.Controls.Add(this.requestsPanel);
            this.requestsPage.Location = new System.Drawing.Point(4, 22);
            this.requestsPage.Name = "requestsPage";
            this.requestsPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestsPage.Size = new System.Drawing.Size(309, 555);
            this.requestsPage.TabIndex = 0;
            this.requestsPage.Text = "Заявки";
            this.requestsPage.UseVisualStyleBackColor = true;
            // 
            // requestsPanel
            // 
            this.requestsPanel.AutoScroll = true;
            this.requestsPanel.Controls.Add(this.requestDateGroup);
            this.requestsPanel.Controls.Add(this.requestServicesGroup);
            this.requestsPanel.Controls.Add(this.requestObjectInfoGroup);
            this.requestsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsPanel.Location = new System.Drawing.Point(3, 3);
            this.requestsPanel.Name = "requestsPanel";
            this.requestsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.requestsPanel.Size = new System.Drawing.Size(303, 549);
            this.requestsPanel.TabIndex = 0;
            // 
            // requestServicesGroup
            // 
            this.requestServicesGroup.AutoSize = true;
            this.requestServicesGroup.Controls.Add(this.requestServicesPanel);
            this.requestServicesGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesGroup.Location = new System.Drawing.Point(5, 142);
            this.requestServicesGroup.Name = "requestServicesGroup";
            this.requestServicesGroup.Size = new System.Drawing.Size(293, 210);
            this.requestServicesGroup.TabIndex = 1;
            this.requestServicesGroup.TabStop = false;
            this.requestServicesGroup.Text = "Желаемые услуги";
            // 
            // requestServicesPanel
            // 
            this.requestServicesPanel.AutoSize = true;
            this.requestServicesPanel.Controls.Add(this.requestServicesSettingsDomain);
            this.requestServicesPanel.Controls.Add(this.requestServicesSettingsLabel);
            this.requestServicesPanel.Controls.Add(this.requestServicesListBox);
            this.requestServicesPanel.Controls.Add(this.requestServicesListLabel);
            this.requestServicesPanel.Controls.Add(this.requestServicesAddButton);
            this.requestServicesPanel.Controls.Add(this.requestServicesSelectComboBox);
            this.requestServicesPanel.Controls.Add(this.requestServicesSelectLabel);
            this.requestServicesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestServicesPanel.Location = new System.Drawing.Point(3, 16);
            this.requestServicesPanel.Name = "requestServicesPanel";
            this.requestServicesPanel.Padding = new System.Windows.Forms.Padding(5);
            this.requestServicesPanel.Size = new System.Drawing.Size(287, 191);
            this.requestServicesPanel.TabIndex = 0;
            // 
            // requestServicesAddButton
            // 
            this.requestServicesAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesAddButton.Location = new System.Drawing.Point(5, 42);
            this.requestServicesAddButton.Name = "requestServicesAddButton";
            this.requestServicesAddButton.Size = new System.Drawing.Size(277, 23);
            this.requestServicesAddButton.TabIndex = 2;
            this.requestServicesAddButton.Text = "Добавить";
            this.requestServicesAddButton.UseVisualStyleBackColor = true;
            // 
            // requestServicesSelectComboBox
            // 
            this.requestServicesSelectComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesSelectComboBox.FormattingEnabled = true;
            this.requestServicesSelectComboBox.Location = new System.Drawing.Point(5, 21);
            this.requestServicesSelectComboBox.Name = "requestServicesSelectComboBox";
            this.requestServicesSelectComboBox.Size = new System.Drawing.Size(277, 21);
            this.requestServicesSelectComboBox.TabIndex = 0;
            // 
            // requestServicesSelectLabel
            // 
            this.requestServicesSelectLabel.AutoSize = true;
            this.requestServicesSelectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesSelectLabel.Location = new System.Drawing.Point(5, 5);
            this.requestServicesSelectLabel.Name = "requestServicesSelectLabel";
            this.requestServicesSelectLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestServicesSelectLabel.Size = new System.Drawing.Size(51, 16);
            this.requestServicesSelectLabel.TabIndex = 1;
            this.requestServicesSelectLabel.Text = "Выбрать";
            // 
            // requestObjectInfoGroup
            // 
            this.requestObjectInfoGroup.AutoSize = true;
            this.requestObjectInfoGroup.Controls.Add(this.requestObjectPanel);
            this.requestObjectInfoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestObjectInfoGroup.Location = new System.Drawing.Point(5, 5);
            this.requestObjectInfoGroup.Name = "requestObjectInfoGroup";
            this.requestObjectInfoGroup.Size = new System.Drawing.Size(293, 137);
            this.requestObjectInfoGroup.TabIndex = 0;
            this.requestObjectInfoGroup.TabStop = false;
            this.requestObjectInfoGroup.Text = "Информация об объекте";
            // 
            // requestObjectPanel
            // 
            this.requestObjectPanel.AutoSize = true;
            this.requestObjectPanel.Controls.Add(this.requestAddressNumberText);
            this.requestObjectPanel.Controls.Add(this.requestAddressNumberLabel);
            this.requestObjectPanel.Controls.Add(this.requestAddressStreetText);
            this.requestObjectPanel.Controls.Add(this.requestAddressStreetLabel);
            this.requestObjectPanel.Controls.Add(this.requestAddressCityText);
            this.requestObjectPanel.Controls.Add(this.requestAddressCityLabel);
            this.requestObjectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestObjectPanel.Location = new System.Drawing.Point(3, 16);
            this.requestObjectPanel.Name = "requestObjectPanel";
            this.requestObjectPanel.Padding = new System.Windows.Forms.Padding(5);
            this.requestObjectPanel.Size = new System.Drawing.Size(287, 118);
            this.requestObjectPanel.TabIndex = 1;
            // 
            // requestAddressNumberText
            // 
            this.requestAddressNumberText.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestAddressNumberText.Location = new System.Drawing.Point(5, 93);
            this.requestAddressNumberText.Name = "requestAddressNumberText";
            this.requestAddressNumberText.Size = new System.Drawing.Size(277, 20);
            this.requestAddressNumberText.TabIndex = 15;
            // 
            // requestAddressNumberLabel
            // 
            this.requestAddressNumberLabel.AutoSize = true;
            this.requestAddressNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestAddressNumberLabel.Location = new System.Drawing.Point(5, 77);
            this.requestAddressNumberLabel.Name = "requestAddressNumberLabel";
            this.requestAddressNumberLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestAddressNumberLabel.Size = new System.Drawing.Size(70, 16);
            this.requestAddressNumberLabel.TabIndex = 17;
            this.requestAddressNumberLabel.Text = "Номер дома";
            // 
            // requestAddressStreetText
            // 
            this.requestAddressStreetText.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestAddressStreetText.Location = new System.Drawing.Point(5, 57);
            this.requestAddressStreetText.Name = "requestAddressStreetText";
            this.requestAddressStreetText.Size = new System.Drawing.Size(277, 20);
            this.requestAddressStreetText.TabIndex = 14;
            // 
            // requestAddressStreetLabel
            // 
            this.requestAddressStreetLabel.AutoSize = true;
            this.requestAddressStreetLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestAddressStreetLabel.Location = new System.Drawing.Point(5, 41);
            this.requestAddressStreetLabel.Name = "requestAddressStreetLabel";
            this.requestAddressStreetLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestAddressStreetLabel.Size = new System.Drawing.Size(39, 16);
            this.requestAddressStreetLabel.TabIndex = 16;
            this.requestAddressStreetLabel.Text = "Улица";
            // 
            // requestAddressCityText
            // 
            this.requestAddressCityText.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestAddressCityText.Location = new System.Drawing.Point(5, 21);
            this.requestAddressCityText.Name = "requestAddressCityText";
            this.requestAddressCityText.Size = new System.Drawing.Size(277, 20);
            this.requestAddressCityText.TabIndex = 13;
            // 
            // requestAddressCityLabel
            // 
            this.requestAddressCityLabel.AutoSize = true;
            this.requestAddressCityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestAddressCityLabel.Location = new System.Drawing.Point(5, 5);
            this.requestAddressCityLabel.Name = "requestAddressCityLabel";
            this.requestAddressCityLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestAddressCityLabel.Size = new System.Drawing.Size(37, 16);
            this.requestAddressCityLabel.TabIndex = 12;
            this.requestAddressCityLabel.Text = "Город";
            // 
            // smetiPage
            // 
            this.smetiPage.Location = new System.Drawing.Point(4, 22);
            this.smetiPage.Name = "smetiPage";
            this.smetiPage.Padding = new System.Windows.Forms.Padding(3);
            this.smetiPage.Size = new System.Drawing.Size(309, 336);
            this.smetiPage.TabIndex = 1;
            this.smetiPage.Text = "Сметы";
            this.smetiPage.UseVisualStyleBackColor = true;
            // 
            // printPage
            // 
            this.printPage.Location = new System.Drawing.Point(4, 22);
            this.printPage.Name = "printPage";
            this.printPage.Size = new System.Drawing.Size(309, 336);
            this.printPage.TabIndex = 2;
            this.printPage.Text = "Печать";
            this.printPage.UseVisualStyleBackColor = true;
            // 
            // requestServicesListLabel
            // 
            this.requestServicesListLabel.AutoSize = true;
            this.requestServicesListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesListLabel.Location = new System.Drawing.Point(5, 65);
            this.requestServicesListLabel.Name = "requestServicesListLabel";
            this.requestServicesListLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestServicesListLabel.Size = new System.Drawing.Size(102, 16);
            this.requestServicesListLabel.TabIndex = 3;
            this.requestServicesListLabel.Text = "Выбранные услуги";
            // 
            // requestServicesListBox
            // 
            this.requestServicesListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesListBox.FormattingEnabled = true;
            this.requestServicesListBox.Location = new System.Drawing.Point(5, 81);
            this.requestServicesListBox.Name = "requestServicesListBox";
            this.requestServicesListBox.ScrollAlwaysVisible = true;
            this.requestServicesListBox.Size = new System.Drawing.Size(277, 69);
            this.requestServicesListBox.TabIndex = 4;
            // 
            // requestServicesSettingsLabel
            // 
            this.requestServicesSettingsLabel.AutoSize = true;
            this.requestServicesSettingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesSettingsLabel.Location = new System.Drawing.Point(5, 150);
            this.requestServicesSettingsLabel.Name = "requestServicesSettingsLabel";
            this.requestServicesSettingsLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestServicesSettingsLabel.Size = new System.Drawing.Size(156, 16);
            this.requestServicesSettingsLabel.TabIndex = 5;
            this.requestServicesSettingsLabel.Text = "Настроить выбранную услугу";
            // 
            // requestServicesSettingsDomain
            // 
            this.requestServicesSettingsDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestServicesSettingsDomain.Location = new System.Drawing.Point(5, 166);
            this.requestServicesSettingsDomain.Name = "requestServicesSettingsDomain";
            this.requestServicesSettingsDomain.Size = new System.Drawing.Size(277, 20);
            this.requestServicesSettingsDomain.TabIndex = 6;
            this.requestServicesSettingsDomain.Text = "domainUpDown1";
            // 
            // requestDateGroup
            // 
            this.requestDateGroup.AutoSize = true;
            this.requestDateGroup.Controls.Add(this.requestDatePanel);
            this.requestDateGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestDateGroup.Location = new System.Drawing.Point(5, 352);
            this.requestDateGroup.Name = "requestDateGroup";
            this.requestDateGroup.Size = new System.Drawing.Size(293, 65);
            this.requestDateGroup.TabIndex = 2;
            this.requestDateGroup.TabStop = false;
            this.requestDateGroup.Text = "Срок выполнения работ";
            // 
            // requestDatePanel
            // 
            this.requestDatePanel.AutoSize = true;
            this.requestDatePanel.Controls.Add(this.dateTimePicker1);
            this.requestDatePanel.Controls.Add(this.requestDateLabel);
            this.requestDatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestDatePanel.Location = new System.Drawing.Point(3, 16);
            this.requestDatePanel.Name = "requestDatePanel";
            this.requestDatePanel.Padding = new System.Windows.Forms.Padding(5);
            this.requestDatePanel.Size = new System.Drawing.Size(287, 46);
            this.requestDatePanel.TabIndex = 1;
            // 
            // requestDateLabel
            // 
            this.requestDateLabel.AutoSize = true;
            this.requestDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestDateLabel.Location = new System.Drawing.Point(5, 5);
            this.requestDateLabel.Name = "requestDateLabel";
            this.requestDateLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.requestDateLabel.Size = new System.Drawing.Size(33, 16);
            this.requestDateLabel.TabIndex = 12;
            this.requestDateLabel.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // repairCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 614);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.MinimumSize = new System.Drawing.Size(333, 434);
            this.Name = "repairCompany";
            this.Text = "Планирование ремонтных работ";
            this.controlPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.requestsPage.ResumeLayout(false);
            this.requestsPanel.ResumeLayout(false);
            this.requestsPanel.PerformLayout();
            this.requestServicesGroup.ResumeLayout(false);
            this.requestServicesGroup.PerformLayout();
            this.requestServicesPanel.ResumeLayout(false);
            this.requestServicesPanel.PerformLayout();
            this.requestObjectInfoGroup.ResumeLayout(false);
            this.requestObjectInfoGroup.PerformLayout();
            this.requestObjectPanel.ResumeLayout(false);
            this.requestObjectPanel.PerformLayout();
            this.requestDateGroup.ResumeLayout(false);
            this.requestDateGroup.PerformLayout();
            this.requestDatePanel.ResumeLayout(false);
            this.requestDatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage requestsPage;
        private System.Windows.Forms.TabPage smetiPage;
        private System.Windows.Forms.TabPage printPage;
        private System.Windows.Forms.Panel requestsPanel;
        private System.Windows.Forms.GroupBox requestObjectInfoGroup;
        private System.Windows.Forms.Panel requestObjectPanel;
        private System.Windows.Forms.TextBox requestAddressNumberText;
        private System.Windows.Forms.Label requestAddressNumberLabel;
        private System.Windows.Forms.TextBox requestAddressStreetText;
        private System.Windows.Forms.Label requestAddressStreetLabel;
        private System.Windows.Forms.TextBox requestAddressCityText;
        private System.Windows.Forms.Label requestAddressCityLabel;
        private System.Windows.Forms.GroupBox requestServicesGroup;
        private System.Windows.Forms.Panel requestServicesPanel;
        private System.Windows.Forms.Label requestServicesSelectLabel;
        private System.Windows.Forms.ComboBox requestServicesSelectComboBox;
        private System.Windows.Forms.Button requestServicesAddButton;
        private System.Windows.Forms.ListBox requestServicesListBox;
        private System.Windows.Forms.Label requestServicesListLabel;
        private System.Windows.Forms.Label requestServicesSettingsLabel;
        private System.Windows.Forms.DomainUpDown requestServicesSettingsDomain;
        private System.Windows.Forms.GroupBox requestDateGroup;
        private System.Windows.Forms.Panel requestDatePanel;
        private System.Windows.Forms.Label requestDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

