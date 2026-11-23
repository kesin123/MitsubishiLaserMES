namespace MitsubishiLaserMES.WinForms.Forms
{
    partial class SettingsForm
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
            this.grpMqtt = new System.Windows.Forms.GroupBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtMqttServer = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.numMqttPort = new System.Windows.Forms.NumericUpDown();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblEqId = new System.Windows.Forms.Label();
            this.txtEqId = new System.Windows.Forms.TextBox();
            this.lblT1 = new System.Windows.Forms.Label();
            this.numTimeoutT1 = new System.Windows.Forms.NumericUpDown();
            this.lblHint = new System.Windows.Forms.Label();
            this.grpOpc = new System.Windows.Forms.GroupBox();
            this.chkUseVirtual = new System.Windows.Forms.CheckBox();
            this.lblEndpoint = new System.Windows.Forms.Label();
            this.txtOpcEndpoint = new System.Windows.Forms.TextBox();
            this.chkOpcSecurity = new System.Windows.Forms.CheckBox();
            this.lblRecipeDir = new System.Windows.Forms.Label();
            this.txtRecipeDir = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpMqtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMqttPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutT1)).BeginInit();
            this.grpOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMqtt
            // 
            this.grpMqtt.Controls.Add(this.lblServer);
            this.grpMqtt.Controls.Add(this.txtMqttServer);
            this.grpMqtt.Controls.Add(this.lblPort);
            this.grpMqtt.Controls.Add(this.numMqttPort);
            this.grpMqtt.Controls.Add(this.lblClient);
            this.grpMqtt.Controls.Add(this.txtClientId);
            this.grpMqtt.Controls.Add(this.lblFactory);
            this.grpMqtt.Controls.Add(this.txtFactory);
            this.grpMqtt.Controls.Add(this.lblFloor);
            this.grpMqtt.Controls.Add(this.txtFloor);
            this.grpMqtt.Controls.Add(this.lblArea);
            this.grpMqtt.Controls.Add(this.txtArea);
            this.grpMqtt.Controls.Add(this.lblEqId);
            this.grpMqtt.Controls.Add(this.txtEqId);
            this.grpMqtt.Controls.Add(this.lblT1);
            this.grpMqtt.Controls.Add(this.numTimeoutT1);
            this.grpMqtt.Controls.Add(this.lblHint);
            this.grpMqtt.Location = new System.Drawing.Point(15, 15);
            this.grpMqtt.Name = "grpMqtt";
            this.grpMqtt.Size = new System.Drawing.Size(495, 250);
            this.grpMqtt.TabIndex = 0;
            this.grpMqtt.TabStop = false;
            this.grpMqtt.Text = "上位 EAP 通訊設定 (MQTT)";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(15, 30);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(80, 17);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Broker 位址:";
            // 
            // txtMqttServer
            // 
            this.txtMqttServer.Location = new System.Drawing.Point(110, 27);
            this.txtMqttServer.Name = "txtMqttServer";
            this.txtMqttServer.Size = new System.Drawing.Size(180, 24);
            this.txtMqttServer.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(310, 30);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 17);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // numMqttPort
            // 
            this.numMqttPort.Location = new System.Drawing.Point(360, 27);
            this.numMqttPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            this.numMqttPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numMqttPort.Name = "numMqttPort";
            this.numMqttPort.Size = new System.Drawing.Size(110, 24);
            this.numMqttPort.TabIndex = 3;
            this.numMqttPort.Value = new decimal(new int[] { 1883, 0, 0, 0 });
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(15, 65);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(64, 17);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Client ID:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(110, 62);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(360, 24);
            this.txtClientId.TabIndex = 5;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(15, 100);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(89, 17);
            this.lblFactory.TabIndex = 6;
            this.lblFactory.Text = "廠區(Factory):";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(110, 97);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(120, 24);
            this.txtFactory.TabIndex = 7;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(255, 100);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(75, 17);
            this.lblFloor.TabIndex = 8;
            this.lblFloor.Text = "樓層(Floor):";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(350, 97);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(120, 24);
            this.txtFloor.TabIndex = 9;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(15, 135);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(73, 17);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "區域(Area):";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(110, 132);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(120, 24);
            this.txtArea.TabIndex = 11;
            // 
            // lblEqId
            // 
            this.lblEqId.AutoSize = true;
            this.lblEqId.Location = new System.Drawing.Point(255, 135);
            this.lblEqId.Name = "lblEqId";
            this.lblEqId.Size = new System.Drawing.Size(75, 17);
            this.lblEqId.TabIndex = 12;
            this.lblEqId.Text = "機台(EqID):";
            // 
            // txtEqId
            // 
            this.txtEqId.Location = new System.Drawing.Point(350, 132);
            this.txtEqId.Name = "txtEqId";
            this.txtEqId.Size = new System.Drawing.Size(120, 24);
            this.txtEqId.TabIndex = 13;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(15, 175);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(73, 17);
            this.lblT1.TabIndex = 14;
            this.lblT1.Text = "T1逾時(秒):";
            // 
            // numTimeoutT1
            // 
            this.numTimeoutT1.Location = new System.Drawing.Point(110, 172);
            this.numTimeoutT1.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.numTimeoutT1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numTimeoutT1.Name = "numTimeoutT1";
            this.numTimeoutT1.Size = new System.Drawing.Size(120, 24);
            this.numTimeoutT1.TabIndex = 15;
            this.numTimeoutT1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            //
            // lblHint
            //
            this.lblHint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHint.Location = new System.Drawing.Point(15, 205);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(465, 35);
            this.lblHint.TabIndex = 16;
            this.lblHint.Text = "發送Topic: {Factory}/{Floor}/{Area}/{EqID}/Report\r\n接收Topic: {Factory}/{Floor}/{Area}/{EqID}/Command";
            //
            // grpOpc
            //
            this.grpOpc.Controls.Add(this.chkUseVirtual);
            this.grpOpc.Controls.Add(this.lblEndpoint);
            this.grpOpc.Controls.Add(this.txtOpcEndpoint);
            this.grpOpc.Controls.Add(this.chkOpcSecurity);
            this.grpOpc.Controls.Add(this.lblRecipeDir);
            this.grpOpc.Controls.Add(this.txtRecipeDir);
            this.grpOpc.Location = new System.Drawing.Point(15, 275);
            this.grpOpc.Name = "grpOpc";
            this.grpOpc.Size = new System.Drawing.Size(495, 175);
            this.grpOpc.TabIndex = 1;
            this.grpOpc.TabStop = false;
            this.grpOpc.Text = "下位三菱雷射機通訊設定 (OPC UA)";
            //
            // chkUseVirtual
            //
            this.chkUseVirtual.AutoSize = true;
            this.chkUseVirtual.Font = new System.Drawing.Font("微軟正黑體", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkUseVirtual.Location = new System.Drawing.Point(15, 28);
            this.chkUseVirtual.Name = "chkUseVirtual";
            this.chkUseVirtual.Size = new System.Drawing.Size(371, 21);
            this.chkUseVirtual.TabIndex = 0;
            this.chkUseVirtual.Text = "啟用虛擬機台模擬器 (Virtual Simulator / 離線測試模式)";
            this.chkUseVirtual.UseVisualStyleBackColor = true;
            //
            // lblEndpoint
            //
            this.lblEndpoint.AutoSize = true;
            this.lblEndpoint.Location = new System.Drawing.Point(15, 65);
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(96, 17);
            this.lblEndpoint.TabIndex = 1;
            this.lblEndpoint.Text = "Endpoint URL:";
            //
            // txtOpcEndpoint
            //
            this.txtOpcEndpoint.Location = new System.Drawing.Point(125, 62);
            this.txtOpcEndpoint.Name = "txtOpcEndpoint";
            this.txtOpcEndpoint.Size = new System.Drawing.Size(345, 24);
            this.txtOpcEndpoint.TabIndex = 2;
            //
            // chkOpcSecurity
            //
            this.chkOpcSecurity.AutoSize = true;
            this.chkOpcSecurity.Location = new System.Drawing.Point(125, 96);
            this.chkOpcSecurity.Name = "chkOpcSecurity";
            this.chkOpcSecurity.Size = new System.Drawing.Size(212, 21);
            this.chkOpcSecurity.TabIndex = 3;
            this.chkOpcSecurity.Text = "使用安全加密連線 (Use Security)";
            this.chkOpcSecurity.UseVisualStyleBackColor = true;
            //
            // lblRecipeDir
            //
            this.lblRecipeDir.AutoSize = true;
            this.lblRecipeDir.Location = new System.Drawing.Point(15, 130);
            this.lblRecipeDir.Name = "lblRecipeDir";
            this.lblRecipeDir.Size = new System.Drawing.Size(89, 17);
            this.lblRecipeDir.TabIndex = 4;
            this.lblRecipeDir.Text = "配方存放路徑:";
            //
            // txtRecipeDir
            //
            this.txtRecipeDir.Location = new System.Drawing.Point(125, 127);
            this.txtRecipeDir.Name = "txtRecipeDir";
            this.txtRecipeDir.Size = new System.Drawing.Size(345, 24);
            this.txtRecipeDir.TabIndex = 5;
            //
            // btnSave
            //
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(150, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲存設定 (Save)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消 (Cancel)";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // SettingsForm
            //
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(524, 521);
            this.Controls.Add(this.grpMqtt);
            this.Controls.Add(this.grpOpc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MES 與機台通訊設定";
            this.grpMqtt.ResumeLayout(false);
            this.grpMqtt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMqttPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutT1)).EndInit();
            this.grpOpc.ResumeLayout(false);
            this.grpOpc.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox grpMqtt;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtMqttServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.NumericUpDown numMqttPort;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblEqId;
        private System.Windows.Forms.TextBox txtEqId;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.NumericUpDown numTimeoutT1;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.GroupBox grpOpc;
        private System.Windows.Forms.CheckBox chkUseVirtual;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.TextBox txtOpcEndpoint;
        private System.Windows.Forms.CheckBox chkOpcSecurity;
        private System.Windows.Forms.Label lblRecipeDir;
        private System.Windows.Forms.TextBox txtRecipeDir;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}