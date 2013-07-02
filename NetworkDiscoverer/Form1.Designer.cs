namespace NetworkDiscoverer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LowestIPField = new System.Windows.Forms.TextBox();
            this.LowIPLabel = new System.Windows.Forms.Label();
            this.HiIPLabel = new System.Windows.Forms.Label();
            this.HighestIPField = new System.Windows.Forms.TextBox();
            this.NetmaskSelector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeviceResponseTextField = new System.Windows.Forms.TextBox();
            this.RunDiscoveryButton = new System.Windows.Forms.Button();
            this.ComunityStringsSelectionBox = new System.Windows.Forms.ListBox();
            this.AddCommunityString = new System.Windows.Forms.TextBox();
            this.CommunityLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswdLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oidField = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowestIPField
            // 
            this.LowestIPField.Location = new System.Drawing.Point(139, 23);
            this.LowestIPField.Name = "LowestIPField";
            this.LowestIPField.Size = new System.Drawing.Size(100, 20);
            this.LowestIPField.TabIndex = 0;
            // 
            // LowIPLabel
            // 
            this.LowIPLabel.AutoSize = true;
            this.LowIPLabel.Location = new System.Drawing.Point(6, 26);
            this.LowIPLabel.Name = "LowIPLabel";
            this.LowIPLabel.Size = new System.Drawing.Size(107, 13);
            this.LowIPLabel.TabIndex = 1;
            this.LowIPLabel.Text = "Lowest IP / Netmask";
            // 
            // HiIPLabel
            // 
            this.HiIPLabel.AutoSize = true;
            this.HiIPLabel.Location = new System.Drawing.Point(6, 52);
            this.HiIPLabel.Name = "HiIPLabel";
            this.HiIPLabel.Size = new System.Drawing.Size(102, 13);
            this.HiIPLabel.TabIndex = 4;
            this.HiIPLabel.Text = "Highest IP (optional)";
            // 
            // HighestIPField
            // 
            this.HighestIPField.Location = new System.Drawing.Point(139, 49);
            this.HighestIPField.Name = "HighestIPField";
            this.HighestIPField.Size = new System.Drawing.Size(100, 20);
            this.HighestIPField.TabIndex = 6;
            // 
            // NetmaskSelector
            // 
            this.NetmaskSelector.FormattingEnabled = true;
            this.NetmaskSelector.Items.AddRange(new object[] {
            "8",
            "16",
            "24"});
            this.NetmaskSelector.Location = new System.Drawing.Point(245, 23);
            this.NetmaskSelector.Name = "NetmaskSelector";
            this.NetmaskSelector.Size = new System.Drawing.Size(53, 21);
            this.NetmaskSelector.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NetmaskSelector);
            this.groupBox1.Controls.Add(this.LowIPLabel);
            this.groupBox1.Controls.Add(this.HighestIPField);
            this.groupBox1.Controls.Add(this.LowestIPField);
            this.groupBox1.Controls.Add(this.HiIPLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Netwok definition";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeviceResponseTextField);
            this.groupBox2.Location = new System.Drawing.Point(505, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 500);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug Aerea";
            // 
            // DeviceResponseTextField
            // 
            this.DeviceResponseTextField.Location = new System.Drawing.Point(6, 19);
            this.DeviceResponseTextField.Multiline = true;
            this.DeviceResponseTextField.Name = "DeviceResponseTextField";
            this.DeviceResponseTextField.ReadOnly = true;
            this.DeviceResponseTextField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeviceResponseTextField.Size = new System.Drawing.Size(603, 475);
            this.DeviceResponseTextField.TabIndex = 0;
            this.DeviceResponseTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeviceResponseTextField.WordWrap = false;
            // 
            // RunDiscoveryButton
            // 
            this.RunDiscoveryButton.Location = new System.Drawing.Point(6, 344);
            this.RunDiscoveryButton.Name = "RunDiscoveryButton";
            this.RunDiscoveryButton.Size = new System.Drawing.Size(468, 61);
            this.RunDiscoveryButton.TabIndex = 0;
            this.RunDiscoveryButton.Text = "Discover Netwok";
            this.RunDiscoveryButton.UseVisualStyleBackColor = true;
            this.RunDiscoveryButton.Click += new System.EventHandler(this.RunDiscoveryButton_Click);
            // 
            // ComunityStringsSelectionBox
            // 
            this.ComunityStringsSelectionBox.FormattingEnabled = true;
            this.ComunityStringsSelectionBox.Items.AddRange(new object[] {
            "public",
            "private"});
            this.ComunityStringsSelectionBox.Location = new System.Drawing.Point(332, 16);
            this.ComunityStringsSelectionBox.Name = "ComunityStringsSelectionBox";
            this.ComunityStringsSelectionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComunityStringsSelectionBox.Size = new System.Drawing.Size(149, 56);
            this.ComunityStringsSelectionBox.TabIndex = 0;
            this.ComunityStringsSelectionBox.Tag = "";
            // 
            // AddCommunityString
            // 
            this.AddCommunityString.Location = new System.Drawing.Point(139, 19);
            this.AddCommunityString.Name = "AddCommunityString";
            this.AddCommunityString.Size = new System.Drawing.Size(100, 20);
            this.AddCommunityString.TabIndex = 8;
            // 
            // CommunityLabel
            // 
            this.CommunityLabel.AutoSize = true;
            this.CommunityLabel.Location = new System.Drawing.Point(6, 22);
            this.CommunityLabel.Name = "CommunityLabel";
            this.CommunityLabel.Size = new System.Drawing.Size(134, 13);
            this.CommunityLabel.TabIndex = 8;
            this.CommunityLabel.Text = "Add community string to list";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(245, 16);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(81, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add >>";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(245, 44);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(81, 23);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove <<";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(139, 47);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 11;
            // 
            // PasswdLabel
            // 
            this.PasswdLabel.AutoSize = true;
            this.PasswdLabel.Location = new System.Drawing.Point(6, 50);
            this.PasswdLabel.Name = "PasswdLabel";
            this.PasswdLabel.Size = new System.Drawing.Size(99, 13);
            this.PasswdLabel.TabIndex = 12;
            this.PasswdLabel.Text = "Password (optional)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.oidField);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.PasswdLabel);
            this.groupBox4.Controls.Add(this.Password);
            this.groupBox4.Controls.Add(this.CommunityLabel);
            this.groupBox4.Controls.Add(this.RunDiscoveryButton);
            this.groupBox4.Controls.Add(this.ComunityStringsSelectionBox);
            this.groupBox4.Controls.Add(this.AddCommunityString);
            this.groupBox4.Controls.Add(this.AddButton);
            this.groupBox4.Controls.Add(this.RemoveButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 411);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SNMP Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "OID Will be removed. Only for testing";
            // 
            // oidField
            // 
            this.oidField.Location = new System.Drawing.Point(198, 116);
            this.oidField.Name = "oidField";
            this.oidField.Size = new System.Drawing.Size(146, 20);
            this.oidField.TabIndex = 14;
            this.oidField.Text = "1.3.6.1.2.1.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1126, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Network Discoverer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LowestIPField;
        private System.Windows.Forms.Label LowIPLabel;
        private System.Windows.Forms.Label HiIPLabel;
        private System.Windows.Forms.TextBox HighestIPField;
        private System.Windows.Forms.ComboBox NetmaskSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DeviceResponseTextField;
        private System.Windows.Forms.Button RunDiscoveryButton;
        private System.Windows.Forms.ListBox ComunityStringsSelectionBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CommunityLabel;
        private System.Windows.Forms.TextBox AddCommunityString;
        private System.Windows.Forms.Label PasswdLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox oidField;
        private System.Windows.Forms.Label label1;
    }
}

