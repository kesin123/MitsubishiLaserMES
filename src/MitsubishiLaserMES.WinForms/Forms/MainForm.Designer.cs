namespace MitsubishiLaserMES.WinForms.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpCurrentOperator = new GroupBox();
            lblOpId = new Label();
            txtCurrentOpId = new TextBox();
            lblOpName = new Label();
            txtCurrentOpName = new TextBox();
            grpAuth = new GroupBox();
            lblBarcode = new Label();
            txtBarcode = new TextBox();
            btnUserAuth = new Button();
            lblUserId = new Label();
            txtLoginUserId = new TextBox();
            lblPassword = new Label();
            txtLoginPassword = new TextBox();
            btnClearAuth = new Button();
            btnSettings = new Button();
            btnConnectMes = new Button();
            btnToggleLang = new Button();
            btnDisconnectMes = new Button();
            pnlMqttLed = new Panel();
            lblMqttLed = new Label();
            btnRoleSwitch = new Button();
            tabMain = new TabControl();
            tabWorkOrder = new TabPage();
            grpOrderInfo = new GroupBox();
            lblWo = new Label();
            txtWorkOrder = new TextBox();
            lblBatchNo = new Label();
            txtBatchNo = new TextBox();
            lblPartNo = new Label();
            txtPartNo = new TextBox();
            lblProcessNo = new Label();
            txtProcessNo = new TextBox();
            lblProcessName = new Label();
            txtProcessName = new TextBox();
            lblTotalQty = new Label();
            txtTotalQty = new TextBox();
            lblRunQty = new Label();
            txtRunQty = new TextBox();
            lblCompletedQty = new Label();
            txtCompletedQty = new TextBox();
            lblRecipeId = new Label();
            txtRecipeId = new TextBox();
            lblConditionFile = new Label();
            txtConditionFile = new TextBox();
            lblIsTrackedIn = new Label();
            txtIsTrackedIn = new TextBox();
            lblComponentNo = new Label();
            txtComponentNo = new TextBox();
            grpTrackedInList = new GroupBox();
            dgvTrackedIn = new DataGridView();
            colWoNo = new DataGridViewTextBoxColumn();
            colOther1 = new DataGridViewTextBoxColumn();
            cmsTrackedIn = new ContextMenuStrip(components);
            tsmiRemoveTrackedIn = new ToolStripMenuItem();
            btnRemoveTrackedIn = new Button();
            grpOpcStatus = new GroupBox();
            lblOpcConn = new Label();
            lblMachineState = new Label();
            lblProgress = new Label();
            lblActivePrg = new Label();
            pnlLampGreen = new Panel();
            lblLampGreen = new Label();
            pnlLampYellow = new Panel();
            lblLampYellow = new Label();
            pnlLampRed = new Panel();
            lblLampRed = new Label();
            btnModeLocal = new Button();
            btnModeSemiAuto = new Button();
            btnModeAuto = new Button();
            btnStartSchedule = new Button();
            btnOpenSimulator = new Button();
            lblManualProgramPath = new Label();
            txtManualProgramPath = new TextBox();
            btnBrowseProgramPath = new Button();
            btnClearProgramPath = new Button();
            grpOrderActions = new GroupBox();
            btnTrackIn = new Button();
            btnTrackOut = new Button();
            btnChangeUser = new Button();
            btnClearOrder = new Button();
            tabEquipment = new TabPage();
            grpAlarmList = new GroupBox();
            dgvAlarms = new DataGridView();
            colAlarmCode = new DataGridViewTextBoxColumn();
            colAlarmMsg = new DataGridViewTextBoxColumn();
            colAlarmType = new DataGridViewTextBoxColumn();
            colAlarmTime = new DataGridViewTextBoxColumn();
            tabItTest = new TabPage();
            grpTestActions = new GroupBox();
            btnTestAlive = new Button();
            btnTestProcessData = new Button();
            btnTestAlarmStart = new Button();
            btnTestAlarmEnd = new Button();
            btnClearLogs = new Button();
            grpRecipeTest = new GroupBox();
            chkEnableTestRecipe = new CheckBox();
            btnTriggerHandshakeNow = new Button();
            btnClearTestRecipe = new Button();
            lblTestHandshakeStatus = new Label();
            lblTestPrg = new Label();
            txtTestPrg = new TextBox();
            btnBrowseTestPrg = new Button();
            lblTestCnd = new Label();
            txtTestCnd = new TextBox();
            lblTestSheet = new Label();
            nudTestSheet = new NumericUpDown();
            grpLog = new GroupBox();
            dgvMqttLogs = new DataGridView();
            colLogTime = new DataGridViewTextBoxColumn();
            colLogDir = new DataGridViewTextBoxColumn();
            colLogTopic = new DataGridViewTextBoxColumn();
            colLogPayload = new DataGridViewTextBoxColumn();
            grpResult = new GroupBox();
            lblResult = new Label();
            txtResult = new TextBox();
            lblResultCode = new Label();
            txtResultCode = new TextBox();
            lblResultMessage = new Label();
            txtResultMessage = new TextBox();
            grpCurrentOperator.SuspendLayout();
            grpAuth.SuspendLayout();
            tabMain.SuspendLayout();
            tabWorkOrder.SuspendLayout();
            grpOrderInfo.SuspendLayout();
            grpTrackedInList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrackedIn).BeginInit();
            cmsTrackedIn.SuspendLayout();
            grpOpcStatus.SuspendLayout();
            grpOrderActions.SuspendLayout();
            tabEquipment.SuspendLayout();
            grpAlarmList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarms).BeginInit();
            tabItTest.SuspendLayout();
            grpTestActions.SuspendLayout();
            grpRecipeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTestSheet).BeginInit();
            grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMqttLogs).BeginInit();
            grpResult.SuspendLayout();
            SuspendLayout();
            // 
            // grpCurrentOperator
            // 
            grpCurrentOperator.Controls.Add(lblOpId);
            grpCurrentOperator.Controls.Add(txtCurrentOpId);
            grpCurrentOperator.Controls.Add(lblOpName);
            grpCurrentOperator.Controls.Add(txtCurrentOpName);
            grpCurrentOperator.Location = new Point(12, 8);
            grpCurrentOperator.Name = "grpCurrentOperator";
            grpCurrentOperator.Size = new Size(260, 100);
            grpCurrentOperator.TabIndex = 0;
            grpCurrentOperator.TabStop = false;
            grpCurrentOperator.Text = "當前作業人員 :";
            // 
            // lblOpId
            // 
            lblOpId.AutoSize = true;
            lblOpId.Location = new Point(15, 28);
            lblOpId.Name = "lblOpId";
            lblOpId.Size = new Size(42, 19);
            lblOpId.TabIndex = 0;
            lblOpId.Text = "工號:";
            // 
            // txtCurrentOpId
            // 
            txtCurrentOpId.BackColor = Color.WhiteSmoke;
            txtCurrentOpId.Location = new Point(65, 25);
            txtCurrentOpId.Name = "txtCurrentOpId";
            txtCurrentOpId.ReadOnly = true;
            txtCurrentOpId.Size = new Size(180, 27);
            txtCurrentOpId.TabIndex = 1;
            // 
            // lblOpName
            // 
            lblOpName.AutoSize = true;
            lblOpName.Location = new Point(15, 62);
            lblOpName.Name = "lblOpName";
            lblOpName.Size = new Size(42, 19);
            lblOpName.TabIndex = 2;
            lblOpName.Text = "姓名:";
            // 
            // txtCurrentOpName
            // 
            txtCurrentOpName.BackColor = Color.WhiteSmoke;
            txtCurrentOpName.Location = new Point(65, 59);
            txtCurrentOpName.Name = "txtCurrentOpName";
            txtCurrentOpName.ReadOnly = true;
            txtCurrentOpName.Size = new Size(180, 27);
            txtCurrentOpName.TabIndex = 3;
            // 
            // grpAuth
            // 
            grpAuth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAuth.Controls.Add(lblBarcode);
            grpAuth.Controls.Add(txtBarcode);
            grpAuth.Controls.Add(btnUserAuth);
            grpAuth.Controls.Add(lblUserId);
            grpAuth.Controls.Add(txtLoginUserId);
            grpAuth.Controls.Add(lblPassword);
            grpAuth.Controls.Add(txtLoginPassword);
            grpAuth.Controls.Add(btnClearAuth);
            grpAuth.Location = new Point(280, 8);
            grpAuth.Name = "grpAuth";
            grpAuth.Size = new Size(540, 100);
            grpAuth.TabIndex = 1;
            grpAuth.TabStop = false;
            grpAuth.Text = "帳密驗證";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(12, 28);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(87, 19);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "工號二維碼:";
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBarcode.Location = new Point(105, 25);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(290, 27);
            txtBarcode.TabIndex = 1;
            // 
            // btnUserAuth
            // 
            btnUserAuth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUserAuth.Location = new Point(405, 23);
            btnUserAuth.Name = "btnUserAuth";
            btnUserAuth.Size = new Size(120, 28);
            btnUserAuth.TabIndex = 2;
            btnUserAuth.Text = "作業員帳號認證";
            btnUserAuth.UseVisualStyleBackColor = true;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(12, 62);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(42, 19);
            lblUserId.TabIndex = 3;
            lblUserId.Text = "工號:";
            // 
            // txtLoginUserId
            // 
            txtLoginUserId.Location = new Point(105, 59);
            txtLoginUserId.Name = "txtLoginUserId";
            txtLoginUserId.Size = new Size(110, 27);
            txtLoginUserId.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(225, 62);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "密碼:";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(270, 59);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(125, 27);
            txtLoginPassword.TabIndex = 6;
            // 
            // btnClearAuth
            // 
            btnClearAuth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearAuth.Location = new Point(405, 57);
            btnClearAuth.Name = "btnClearAuth";
            btnClearAuth.Size = new Size(120, 28);
            btnClearAuth.TabIndex = 7;
            btnClearAuth.Text = "清除";
            btnClearAuth.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSettings.Location = new Point(827, 25);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(110, 32);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "MES 設定";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnConnectMes
            // 
            btnConnectMes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnectMes.Location = new Point(942, 25);
            btnConnectMes.Name = "btnConnectMes";
            btnConnectMes.Size = new Size(110, 32);
            btnConnectMes.TabIndex = 3;
            btnConnectMes.Text = "MES 連線";
            btnConnectMes.UseVisualStyleBackColor = true;
            // 
            // btnToggleLang
            // 
            btnToggleLang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleLang.Location = new Point(827, 67);
            btnToggleLang.Name = "btnToggleLang";
            btnToggleLang.Size = new Size(110, 32);
            btnToggleLang.TabIndex = 4;
            btnToggleLang.Text = "中英切換";
            btnToggleLang.UseVisualStyleBackColor = true;
            // 
            // btnDisconnectMes
            // 
            btnDisconnectMes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisconnectMes.Location = new Point(942, 67);
            btnDisconnectMes.Name = "btnDisconnectMes";
            btnDisconnectMes.Size = new Size(110, 32);
            btnDisconnectMes.TabIndex = 5;
            btnDisconnectMes.Text = "MES 離線";
            btnDisconnectMes.UseVisualStyleBackColor = true;
            // 
            // pnlMqttLed
            // 
            pnlMqttLed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlMqttLed.BackColor = Color.LightGray;
            pnlMqttLed.BorderStyle = BorderStyle.FixedSingle;
            pnlMqttLed.Location = new Point(1099, 12);
            pnlMqttLed.Name = "pnlMqttLed";
            pnlMqttLed.Size = new Size(22, 22);
            pnlMqttLed.TabIndex = 6;
            // 
            // lblMqttLed
            // 
            lblMqttLed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMqttLed.AutoSize = true;
            lblMqttLed.Font = new Font("Arial", 8F, FontStyle.Bold);
            lblMqttLed.Location = new Point(1094, 39);
            lblMqttLed.Name = "lblMqttLed";
            lblMqttLed.Size = new Size(34, 16);
            lblMqttLed.TabIndex = 7;
            lblMqttLed.Text = "EAP";
            // 
            // btnRoleSwitch
            // 
            btnRoleSwitch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRoleSwitch.BackColor = Color.WhiteSmoke;
            btnRoleSwitch.FlatAppearance.BorderColor = Color.Silver;
            btnRoleSwitch.FlatStyle = FlatStyle.Flat;
            btnRoleSwitch.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRoleSwitch.ForeColor = Color.DimGray;
            btnRoleSwitch.Location = new Point(1058, 67);
            btnRoleSwitch.Name = "btnRoleSwitch";
            btnRoleSwitch.Size = new Size(102, 32);
            btnRoleSwitch.TabIndex = 10;
            btnRoleSwitch.Text = "OP 模式";
            btnRoleSwitch.UseVisualStyleBackColor = false;
            // 
            // tabMain
            // 
            tabMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabMain.Controls.Add(tabWorkOrder);
            tabMain.Controls.Add(tabEquipment);
            tabMain.Controls.Add(tabItTest);
            tabMain.Location = new Point(12, 115);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1140, 500);
            tabMain.TabIndex = 8;
            // 
            // tabWorkOrder
            // 
            tabWorkOrder.Controls.Add(grpOrderInfo);
            tabWorkOrder.Controls.Add(grpTrackedInList);
            tabWorkOrder.Controls.Add(grpOpcStatus);
            tabWorkOrder.Controls.Add(grpOrderActions);
            tabWorkOrder.Location = new Point(4, 28);
            tabWorkOrder.Name = "tabWorkOrder";
            tabWorkOrder.Padding = new Padding(3);
            tabWorkOrder.Size = new Size(1132, 468);
            tabWorkOrder.TabIndex = 0;
            tabWorkOrder.Text = "工單功能";
            tabWorkOrder.UseVisualStyleBackColor = true;
            // 
            // grpOrderInfo
            // 
            grpOrderInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpOrderInfo.Controls.Add(lblWo);
            grpOrderInfo.Controls.Add(txtWorkOrder);
            grpOrderInfo.Controls.Add(lblBatchNo);
            grpOrderInfo.Controls.Add(txtBatchNo);
            grpOrderInfo.Controls.Add(lblPartNo);
            grpOrderInfo.Controls.Add(txtPartNo);
            grpOrderInfo.Controls.Add(lblProcessNo);
            grpOrderInfo.Controls.Add(txtProcessNo);
            grpOrderInfo.Controls.Add(lblProcessName);
            grpOrderInfo.Controls.Add(txtProcessName);
            grpOrderInfo.Controls.Add(lblTotalQty);
            grpOrderInfo.Controls.Add(txtTotalQty);
            grpOrderInfo.Controls.Add(lblRunQty);
            grpOrderInfo.Controls.Add(txtRunQty);
            grpOrderInfo.Controls.Add(lblCompletedQty);
            grpOrderInfo.Controls.Add(txtCompletedQty);
            grpOrderInfo.Controls.Add(lblRecipeId);
            grpOrderInfo.Controls.Add(txtRecipeId);
            grpOrderInfo.Controls.Add(lblConditionFile);
            grpOrderInfo.Controls.Add(txtConditionFile);
            grpOrderInfo.Controls.Add(lblIsTrackedIn);
            grpOrderInfo.Controls.Add(txtIsTrackedIn);
            grpOrderInfo.Controls.Add(lblComponentNo);
            grpOrderInfo.Controls.Add(txtComponentNo);
            grpOrderInfo.Location = new Point(10, 10);
            grpOrderInfo.Name = "grpOrderInfo";
            grpOrderInfo.Size = new Size(630, 235);
            grpOrderInfo.TabIndex = 0;
            grpOrderInfo.TabStop = false;
            grpOrderInfo.Text = "工單訊息";
            // 
            // lblWo
            // 
            lblWo.AutoSize = true;
            lblWo.Location = new Point(15, 28);
            lblWo.Name = "lblWo";
            lblWo.Size = new Size(76, 19);
            lblWo.TabIndex = 0;
            lblWo.Text = "工單號碼 :";
            // 
            // txtWorkOrder
            // 
            txtWorkOrder.Location = new Point(128, 25);
            txtWorkOrder.Name = "txtWorkOrder";
            txtWorkOrder.Size = new Size(175, 27);
            txtWorkOrder.TabIndex = 1;
            // 
            // lblBatchNo
            // 
            lblBatchNo.AutoSize = true;
            lblBatchNo.Location = new Point(320, 28);
            lblBatchNo.Name = "lblBatchNo";
            lblBatchNo.Size = new Size(75, 19);
            lblBatchNo.TabIndex = 2;
            lblBatchNo.Text = "BatchNo :";
            // 
            // txtBatchNo
            // 
            txtBatchNo.Location = new Point(438, 25);
            txtBatchNo.Name = "txtBatchNo";
            txtBatchNo.Size = new Size(175, 27);
            txtBatchNo.TabIndex = 3;
            // 
            // lblPartNo
            // 
            lblPartNo.AutoSize = true;
            lblPartNo.Location = new Point(15, 58);
            lblPartNo.Name = "lblPartNo";
            lblPartNo.Size = new Size(46, 19);
            lblPartNo.TabIndex = 4;
            lblPartNo.Text = "料號 :";
            // 
            // txtPartNo
            // 
            txtPartNo.Location = new Point(128, 55);
            txtPartNo.Name = "txtPartNo";
            txtPartNo.Size = new Size(175, 27);
            txtPartNo.TabIndex = 5;
            // 
            // lblProcessNo
            // 
            lblProcessNo.AutoSize = true;
            lblProcessNo.Location = new Point(320, 58);
            lblProcessNo.Name = "lblProcessNo";
            lblProcessNo.Size = new Size(76, 19);
            lblProcessNo.TabIndex = 6;
            lblProcessNo.Text = "製程編號 :";
            // 
            // txtProcessNo
            // 
            txtProcessNo.Location = new Point(438, 55);
            txtProcessNo.Name = "txtProcessNo";
            txtProcessNo.Size = new Size(175, 27);
            txtProcessNo.TabIndex = 7;
            // 
            // lblProcessName
            // 
            lblProcessName.AutoSize = true;
            lblProcessName.Location = new Point(15, 88);
            lblProcessName.Name = "lblProcessName";
            lblProcessName.Size = new Size(76, 19);
            lblProcessName.TabIndex = 8;
            lblProcessName.Text = "製程名稱 :";
            // 
            // txtProcessName
            // 
            txtProcessName.Location = new Point(128, 85);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.Size = new Size(485, 27);
            txtProcessName.TabIndex = 9;
            // 
            // lblTotalQty
            // 
            lblTotalQty.AutoSize = true;
            lblTotalQty.Location = new Point(15, 118);
            lblTotalQty.Name = "lblTotalQty";
            lblTotalQty.Size = new Size(76, 19);
            lblTotalQty.TabIndex = 10;
            lblTotalQty.Text = "工單數量 :";
            // 
            // txtTotalQty
            // 
            txtTotalQty.Location = new Point(128, 115);
            txtTotalQty.Name = "txtTotalQty";
            txtTotalQty.Size = new Size(485, 27);
            txtTotalQty.TabIndex = 11;
            // 
            // lblRunQty
            // 
            lblRunQty.AutoSize = true;
            lblRunQty.Location = new Point(15, 148);
            lblRunQty.Name = "lblRunQty";
            lblRunQty.Size = new Size(106, 19);
            lblRunQty.TabIndex = 12;
            lblRunQty.Text = "工單跑貨片數 :";
            // 
            // txtRunQty
            // 
            txtRunQty.Location = new Point(128, 145);
            txtRunQty.Name = "txtRunQty";
            txtRunQty.Size = new Size(175, 27);
            txtRunQty.TabIndex = 13;
            // 
            // lblCompletedQty
            // 
            lblCompletedQty.AutoSize = true;
            lblCompletedQty.Location = new Point(320, 148);
            lblCompletedQty.Name = "lblCompletedQty";
            lblCompletedQty.Size = new Size(91, 19);
            lblCompletedQty.TabIndex = 14;
            lblCompletedQty.Text = "已完成片數 :";
            // 
            // txtCompletedQty
            // 
            txtCompletedQty.BackColor = Color.WhiteSmoke;
            txtCompletedQty.Location = new Point(438, 145);
            txtCompletedQty.Name = "txtCompletedQty";
            txtCompletedQty.ReadOnly = true;
            txtCompletedQty.Size = new Size(175, 27);
            txtCompletedQty.TabIndex = 15;
            // 
            // lblRecipeId
            // 
            lblRecipeId.AutoSize = true;
            lblRecipeId.Location = new Point(15, 178);
            lblRecipeId.Name = "lblRecipeId";
            lblRecipeId.Size = new Size(77, 19);
            lblRecipeId.TabIndex = 16;
            lblRecipeId.Text = "RecipeID :";
            // 
            // txtRecipeId
            // 
            txtRecipeId.Location = new Point(128, 175);
            txtRecipeId.Name = "txtRecipeId";
            txtRecipeId.Size = new Size(175, 27);
            txtRecipeId.TabIndex = 17;
            // 
            // lblConditionFile
            // 
            lblConditionFile.AutoSize = true;
            lblConditionFile.Location = new Point(320, 178);
            lblConditionFile.Name = "lblConditionFile";
            lblConditionFile.Size = new Size(76, 19);
            lblConditionFile.TabIndex = 18;
            lblConditionFile.Text = "條件檔名 :";
            // 
            // txtConditionFile
            // 
            txtConditionFile.Location = new Point(438, 175);
            txtConditionFile.Name = "txtConditionFile";
            txtConditionFile.Size = new Size(175, 27);
            txtConditionFile.TabIndex = 19;
            // 
            // lblIsTrackedIn
            // 
            lblIsTrackedIn.AutoSize = true;
            lblIsTrackedIn.Location = new Point(15, 206);
            lblIsTrackedIn.Name = "lblIsTrackedIn";
            lblIsTrackedIn.Size = new Size(91, 19);
            lblIsTrackedIn.TabIndex = 20;
            lblIsTrackedIn.Text = "是否已進站 :";
            // 
            // txtIsTrackedIn
            // 
            txtIsTrackedIn.BackColor = Color.WhiteSmoke;
            txtIsTrackedIn.Location = new Point(128, 203);
            txtIsTrackedIn.Name = "txtIsTrackedIn";
            txtIsTrackedIn.ReadOnly = true;
            txtIsTrackedIn.Size = new Size(175, 27);
            txtIsTrackedIn.TabIndex = 21;
            // 
            // lblComponentNo
            // 
            lblComponentNo.AutoSize = true;
            lblComponentNo.Location = new Point(320, 206);
            lblComponentNo.Name = "lblComponentNo";
            lblComponentNo.Size = new Size(119, 19);
            lblComponentNo.TabIndex = 22;
            lblComponentNo.Text = "ComponentNo :";
            // 
            // txtComponentNo
            // 
            txtComponentNo.Location = new Point(438, 203);
            txtComponentNo.Name = "txtComponentNo";
            txtComponentNo.Size = new Size(175, 27);
            txtComponentNo.TabIndex = 23;
            // 
            // grpTrackedInList
            // 
            grpTrackedInList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpTrackedInList.Controls.Add(dgvTrackedIn);
            grpTrackedInList.Controls.Add(btnRemoveTrackedIn);
            grpTrackedInList.Location = new Point(650, 10);
            grpTrackedInList.Name = "grpTrackedInList";
            grpTrackedInList.Size = new Size(295, 235);
            grpTrackedInList.TabIndex = 1;
            grpTrackedInList.TabStop = false;
            grpTrackedInList.Text = "已進站工單清單";
            // 
            // dgvTrackedIn
            // 
            dgvTrackedIn.AllowUserToAddRows = false;
            dgvTrackedIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTrackedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrackedIn.BackgroundColor = Color.White;
            dgvTrackedIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrackedIn.Columns.AddRange(new DataGridViewColumn[] { colWoNo, colOther1 });
            dgvTrackedIn.ContextMenuStrip = cmsTrackedIn;
            dgvTrackedIn.Location = new Point(6, 22);
            dgvTrackedIn.MultiSelect = false;
            dgvTrackedIn.Name = "dgvTrackedIn";
            dgvTrackedIn.ReadOnly = true;
            dgvTrackedIn.RowHeadersWidth = 51;
            dgvTrackedIn.RowTemplate.Height = 25;
            dgvTrackedIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrackedIn.Size = new Size(283, 171);
            dgvTrackedIn.TabIndex = 0;
            // 
            // colWoNo
            // 
            colWoNo.HeaderText = "工單號碼(WoNo)";
            colWoNo.MinimumWidth = 6;
            colWoNo.Name = "colWoNo";
            colWoNo.ReadOnly = true;
            // 
            // colOther1
            // 
            colOther1.HeaderText = "卡匣號碼(CassetteId)";
            colOther1.MinimumWidth = 6;
            colOther1.Name = "colOther1";
            colOther1.ReadOnly = true;
            // 
            // cmsTrackedIn
            // 
            cmsTrackedIn.ImageScalingSize = new Size(20, 20);
            cmsTrackedIn.Items.AddRange(new ToolStripItem[] { tsmiRemoveTrackedIn });
            cmsTrackedIn.Name = "cmsTrackedIn";
            cmsTrackedIn.Size = new Size(254, 28);
            // 
            // tsmiRemoveTrackedIn
            // 
            tsmiRemoveTrackedIn.Name = "tsmiRemoveTrackedIn";
            tsmiRemoveTrackedIn.Size = new Size(253, 24);
            tsmiRemoveTrackedIn.Text = "強制移除此工單(解除進站)";
            // 
            // btnRemoveTrackedIn
            // 
            btnRemoveTrackedIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveTrackedIn.Location = new Point(145, 199);
            btnRemoveTrackedIn.Name = "btnRemoveTrackedIn";
            btnRemoveTrackedIn.Size = new Size(144, 28);
            btnRemoveTrackedIn.TabIndex = 1;
            btnRemoveTrackedIn.Text = "移除選取工單";
            btnRemoveTrackedIn.UseVisualStyleBackColor = true;
            // 
            // grpOpcStatus
            // 
            grpOpcStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpOpcStatus.Controls.Add(lblOpcConn);
            grpOpcStatus.Controls.Add(lblMachineState);
            grpOpcStatus.Controls.Add(lblProgress);
            grpOpcStatus.Controls.Add(lblActivePrg);
            grpOpcStatus.Controls.Add(pnlLampGreen);
            grpOpcStatus.Controls.Add(lblLampGreen);
            grpOpcStatus.Controls.Add(pnlLampYellow);
            grpOpcStatus.Controls.Add(lblLampYellow);
            grpOpcStatus.Controls.Add(pnlLampRed);
            grpOpcStatus.Controls.Add(lblLampRed);
            grpOpcStatus.Controls.Add(btnModeLocal);
            grpOpcStatus.Controls.Add(btnModeSemiAuto);
            grpOpcStatus.Controls.Add(btnModeAuto);
            grpOpcStatus.Controls.Add(btnStartSchedule);
            grpOpcStatus.Controls.Add(btnOpenSimulator);
            grpOpcStatus.Controls.Add(lblManualProgramPath);
            grpOpcStatus.Controls.Add(txtManualProgramPath);
            grpOpcStatus.Controls.Add(btnBrowseProgramPath);
            grpOpcStatus.Controls.Add(btnClearProgramPath);
            grpOpcStatus.Location = new Point(10, 252);
            grpOpcStatus.Name = "grpOpcStatus";
            grpOpcStatus.Size = new Size(935, 210);
            grpOpcStatus.TabIndex = 2;
            grpOpcStatus.TabStop = false;
            grpOpcStatus.Text = "三菱雷射機狀態與控制 (OPC UA)";
            // 
            // lblOpcConn
            // 
            lblOpcConn.AutoSize = true;
            lblOpcConn.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblOpcConn.Location = new Point(20, 28);
            lblOpcConn.Name = "lblOpcConn";
            lblOpcConn.Size = new Size(143, 22);
            lblOpcConn.TabIndex = 0;
            lblOpcConn.Text = "OPC 連線: 離線中";
            // 
            // lblMachineState
            // 
            lblMachineState.AutoSize = true;
            lblMachineState.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblMachineState.Location = new Point(210, 28);
            lblMachineState.Name = "lblMachineState";
            lblMachineState.Size = new Size(177, 22);
            lblMachineState.TabIndex = 1;
            lblMachineState.Text = "機台狀態代碼: [3] Idle";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("微軟正黑體", 10F);
            lblProgress.Location = new Point(420, 28);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(121, 22);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "加工計數: 0 / 0";
            // 
            // lblActivePrg
            // 
            lblActivePrg.AutoSize = true;
            lblActivePrg.Location = new Point(590, 28);
            lblActivePrg.Name = "lblActivePrg";
            lblActivePrg.Size = new Size(121, 19);
            lblActivePrg.TabIndex = 3;
            lblActivePrg.Text = "目前加工程式: 無";
            // 
            // pnlLampGreen
            // 
            pnlLampGreen.BackColor = Color.DarkGreen;
            pnlLampGreen.BorderStyle = BorderStyle.FixedSingle;
            pnlLampGreen.Location = new Point(20, 72);
            pnlLampGreen.Name = "pnlLampGreen";
            pnlLampGreen.Size = new Size(24, 24);
            pnlLampGreen.TabIndex = 4;
            // 
            // lblLampGreen
            // 
            lblLampGreen.AutoSize = true;
            lblLampGreen.Location = new Point(50, 76);
            lblLampGreen.Name = "lblLampGreen";
            lblLampGreen.Size = new Size(143, 19);
            lblLampGreen.TabIndex = 5;
            lblLampGreen.Text = "綠燈 (伺服ON/運行)";
            // 
            // pnlLampYellow
            // 
            pnlLampYellow.BackColor = Color.DarkGoldenrod;
            pnlLampYellow.BorderStyle = BorderStyle.FixedSingle;
            pnlLampYellow.Location = new Point(210, 72);
            pnlLampYellow.Name = "pnlLampYellow";
            pnlLampYellow.Size = new Size(24, 24);
            pnlLampYellow.TabIndex = 6;
            // 
            // lblLampYellow
            // 
            lblLampYellow.AutoSize = true;
            lblLampYellow.Location = new Point(240, 76);
            lblLampYellow.Name = "lblLampYellow";
            lblLampYellow.Size = new Size(152, 19);
            lblLampYellow.TabIndex = 7;
            lblLampYellow.Text = "黃燈 (待機/BeamON)";
            // 
            // pnlLampRed
            // 
            pnlLampRed.BackColor = Color.DarkRed;
            pnlLampRed.BorderStyle = BorderStyle.FixedSingle;
            pnlLampRed.Location = new Point(420, 72);
            pnlLampRed.Name = "pnlLampRed";
            pnlLampRed.Size = new Size(24, 24);
            pnlLampRed.TabIndex = 8;
            // 
            // lblLampRed
            // 
            lblLampRed.AutoSize = true;
            lblLampRed.Location = new Point(450, 76);
            lblLampRed.Name = "lblLampRed";
            lblLampRed.Size = new Size(119, 19);
            lblLampRed.TabIndex = 9;
            lblLampRed.Text = "紅燈 (警報/異常)";
            // 
            // btnModeLocal
            // 
            btnModeLocal.Location = new Point(20, 115);
            btnModeLocal.Name = "btnModeLocal";
            btnModeLocal.Size = new Size(105, 36);
            btnModeLocal.TabIndex = 10;
            btnModeLocal.Text = "Local 模式";
            btnModeLocal.UseVisualStyleBackColor = true;
            // 
            // btnModeSemiAuto
            // 
            btnModeSemiAuto.Location = new Point(135, 115);
            btnModeSemiAuto.Name = "btnModeSemiAuto";
            btnModeSemiAuto.Size = new Size(125, 36);
            btnModeSemiAuto.TabIndex = 11;
            btnModeSemiAuto.Text = "Semi-Auto 模式";
            btnModeSemiAuto.UseVisualStyleBackColor = true;
            // 
            // btnModeAuto
            // 
            btnModeAuto.Location = new Point(270, 115);
            btnModeAuto.Name = "btnModeAuto";
            btnModeAuto.Size = new Size(105, 36);
            btnModeAuto.TabIndex = 12;
            btnModeAuto.Text = "Auto 模式";
            btnModeAuto.UseVisualStyleBackColor = true;
            // 
            // btnStartSchedule
            // 
            btnStartSchedule.BackColor = Color.PaleGreen;
            btnStartSchedule.Location = new Point(385, 115);
            btnStartSchedule.Name = "btnStartSchedule";
            btnStartSchedule.Size = new Size(135, 36);
            btnStartSchedule.TabIndex = 13;
            btnStartSchedule.Text = "啟動連續運轉";
            btnStartSchedule.UseVisualStyleBackColor = false;
            // 
            // btnOpenSimulator
            // 
            btnOpenSimulator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenSimulator.BackColor = Color.LightSkyBlue;
            btnOpenSimulator.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOpenSimulator.Location = new Point(750, 20);
            btnOpenSimulator.Name = "btnOpenSimulator";
            btnOpenSimulator.Size = new Size(165, 34);
            btnOpenSimulator.TabIndex = 14;
            btnOpenSimulator.Text = "開啟機台模擬器 (OPC)";
            btnOpenSimulator.UseVisualStyleBackColor = false;
            // 
            // lblManualProgramPath
            // 
            lblManualProgramPath.AutoSize = true;
            lblManualProgramPath.Location = new Point(20, 172);
            lblManualProgramPath.Name = "lblManualProgramPath";
            lblManualProgramPath.Size = new Size(136, 19);
            lblManualProgramPath.TabIndex = 15;
            lblManualProgramPath.Text = "手動加工程式路徑 :";
            // 
            // txtManualProgramPath
            // 
            txtManualProgramPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtManualProgramPath.Location = new Point(170, 169);
            txtManualProgramPath.Name = "txtManualProgramPath";
            txtManualProgramPath.Size = new Size(560, 27);
            txtManualProgramPath.TabIndex = 16;
            // 
            // btnBrowseProgramPath
            // 
            btnBrowseProgramPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseProgramPath.Location = new Point(740, 167);
            btnBrowseProgramPath.Name = "btnBrowseProgramPath";
            btnBrowseProgramPath.Size = new Size(80, 27);
            btnBrowseProgramPath.TabIndex = 17;
            btnBrowseProgramPath.Text = "瀏覽...";
            btnBrowseProgramPath.UseVisualStyleBackColor = true;
            // 
            // btnClearProgramPath
            // 
            btnClearProgramPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearProgramPath.Location = new Point(830, 167);
            btnClearProgramPath.Name = "btnClearProgramPath";
            btnClearProgramPath.Size = new Size(80, 27);
            btnClearProgramPath.TabIndex = 18;
            btnClearProgramPath.Text = "清除";
            btnClearProgramPath.UseVisualStyleBackColor = true;
            // 
            // grpOrderActions
            // 
            grpOrderActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpOrderActions.Controls.Add(btnTrackIn);
            grpOrderActions.Controls.Add(btnTrackOut);
            grpOrderActions.Controls.Add(btnChangeUser);
            grpOrderActions.Controls.Add(btnClearOrder);
            grpOrderActions.Location = new Point(955, 10);
            grpOrderActions.Name = "grpOrderActions";
            grpOrderActions.Size = new Size(165, 452);
            grpOrderActions.TabIndex = 4;
            grpOrderActions.TabStop = false;
            grpOrderActions.Text = "工單作業";
            // 
            // btnTrackIn
            // 
            btnTrackIn.BackColor = Color.LightSteelBlue;
            btnTrackIn.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnTrackIn.Location = new Point(15, 30);
            btnTrackIn.Name = "btnTrackIn";
            btnTrackIn.Size = new Size(135, 42);
            btnTrackIn.TabIndex = 0;
            btnTrackIn.Text = "工單進站";
            btnTrackIn.UseVisualStyleBackColor = false;
            // 
            // btnTrackOut
            // 
            btnTrackOut.BackColor = Color.LightSkyBlue;
            btnTrackOut.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnTrackOut.Location = new Point(15, 85);
            btnTrackOut.Name = "btnTrackOut";
            btnTrackOut.Size = new Size(135, 42);
            btnTrackOut.TabIndex = 1;
            btnTrackOut.Text = "工單出站";
            btnTrackOut.UseVisualStyleBackColor = false;
            // 
            // btnChangeUser
            // 
            btnChangeUser.Location = new Point(15, 160);
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.Size = new Size(135, 36);
            btnChangeUser.TabIndex = 2;
            btnChangeUser.Text = "更換人員";
            btnChangeUser.UseVisualStyleBackColor = true;
            // 
            // btnClearOrder
            // 
            btnClearOrder.Location = new Point(15, 205);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(135, 36);
            btnClearOrder.TabIndex = 3;
            btnClearOrder.Text = "清除";
            btnClearOrder.UseVisualStyleBackColor = true;
            // 
            // tabEquipment
            // 
            tabEquipment.Controls.Add(grpAlarmList);
            tabEquipment.Location = new Point(4, 28);
            tabEquipment.Name = "tabEquipment";
            tabEquipment.Padding = new Padding(3);
            tabEquipment.Size = new Size(1132, 468);
            tabEquipment.TabIndex = 1;
            tabEquipment.Text = "設備警報";
            tabEquipment.UseVisualStyleBackColor = true;
            // 
            // grpAlarmList
            // 
            grpAlarmList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAlarmList.Controls.Add(dgvAlarms);
            grpAlarmList.Location = new Point(15, 15);
            grpAlarmList.Name = "grpAlarmList";
            grpAlarmList.Size = new Size(1095, 440);
            grpAlarmList.TabIndex = 0;
            grpAlarmList.TabStop = false;
            grpAlarmList.Text = "當前活躍警報清單 (Active Alarms 000~009)";
            // 
            // dgvAlarms
            // 
            dgvAlarms.AllowUserToAddRows = false;
            dgvAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlarms.BackgroundColor = Color.White;
            dgvAlarms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlarms.Columns.AddRange(new DataGridViewColumn[] { colAlarmCode, colAlarmMsg, colAlarmType, colAlarmTime });
            dgvAlarms.Dock = DockStyle.Fill;
            dgvAlarms.Location = new Point(3, 23);
            dgvAlarms.Name = "dgvAlarms";
            dgvAlarms.ReadOnly = true;
            dgvAlarms.RowHeadersWidth = 51;
            dgvAlarms.RowTemplate.Height = 25;
            dgvAlarms.Size = new Size(1089, 414);
            dgvAlarms.TabIndex = 0;
            // 
            // colAlarmCode
            // 
            colAlarmCode.HeaderText = "警報代碼";
            colAlarmCode.MinimumWidth = 6;
            colAlarmCode.Name = "colAlarmCode";
            colAlarmCode.ReadOnly = true;
            // 
            // colAlarmMsg
            // 
            colAlarmMsg.HeaderText = "警報訊息內容";
            colAlarmMsg.MinimumWidth = 6;
            colAlarmMsg.Name = "colAlarmMsg";
            colAlarmMsg.ReadOnly = true;
            // 
            // colAlarmType
            // 
            colAlarmType.HeaderText = "等級";
            colAlarmType.MinimumWidth = 6;
            colAlarmType.Name = "colAlarmType";
            colAlarmType.ReadOnly = true;
            // 
            // colAlarmTime
            // 
            colAlarmTime.HeaderText = "偵測時間";
            colAlarmTime.MinimumWidth = 6;
            colAlarmTime.Name = "colAlarmTime";
            colAlarmTime.ReadOnly = true;
            // 
            // tabItTest
            // 
            tabItTest.Controls.Add(grpTestActions);
            tabItTest.Controls.Add(grpRecipeTest);
            tabItTest.Controls.Add(grpLog);
            tabItTest.Location = new Point(4, 28);
            tabItTest.Name = "tabItTest";
            tabItTest.Padding = new Padding(3);
            tabItTest.Size = new Size(1132, 468);
            tabItTest.TabIndex = 2;
            tabItTest.Text = "IT 測試";
            tabItTest.UseVisualStyleBackColor = true;
            // 
            // grpTestActions
            // 
            grpTestActions.Controls.Add(btnTestAlive);
            grpTestActions.Controls.Add(btnTestProcessData);
            grpTestActions.Controls.Add(btnTestAlarmStart);
            grpTestActions.Controls.Add(btnTestAlarmEnd);
            grpTestActions.Controls.Add(btnClearLogs);
            grpTestActions.Location = new Point(15, 8);
            grpTestActions.Name = "grpTestActions";
            grpTestActions.Size = new Size(1095, 62);
            grpTestActions.TabIndex = 0;
            grpTestActions.TabStop = false;
            grpTestActions.Text = "MQTT 通訊測試與模擬工具";
            // 
            // btnTestAlive
            // 
            btnTestAlive.Location = new Point(15, 20);
            btnTestAlive.Name = "btnTestAlive";
            btnTestAlive.Size = new Size(185, 30);
            btnTestAlive.TabIndex = 0;
            btnTestAlive.Text = "測試存活檢測 (AreYouThere)";
            btnTestAlive.UseVisualStyleBackColor = true;
            // 
            // btnTestProcessData
            // 
            btnTestProcessData.Location = new Point(210, 20);
            btnTestProcessData.Name = "btnTestProcessData";
            btnTestProcessData.Size = new Size(155, 30);
            btnTestProcessData.TabIndex = 1;
            btnTestProcessData.Text = "模擬製程資料上報";
            btnTestProcessData.UseVisualStyleBackColor = true;
            // 
            // btnTestAlarmStart
            // 
            btnTestAlarmStart.Location = new Point(375, 20);
            btnTestAlarmStart.Name = "btnTestAlarmStart";
            btnTestAlarmStart.Size = new Size(155, 30);
            btnTestAlarmStart.TabIndex = 2;
            btnTestAlarmStart.Text = "模擬警報發生 (Start)";
            btnTestAlarmStart.UseVisualStyleBackColor = true;
            // 
            // btnTestAlarmEnd
            // 
            btnTestAlarmEnd.Location = new Point(540, 20);
            btnTestAlarmEnd.Name = "btnTestAlarmEnd";
            btnTestAlarmEnd.Size = new Size(155, 30);
            btnTestAlarmEnd.TabIndex = 3;
            btnTestAlarmEnd.Text = "模擬警報解除 (End)";
            btnTestAlarmEnd.UseVisualStyleBackColor = true;
            // 
            // btnClearLogs
            // 
            btnClearLogs.Location = new Point(705, 20);
            btnClearLogs.Name = "btnClearLogs";
            btnClearLogs.Size = new Size(115, 30);
            btnClearLogs.TabIndex = 4;
            btnClearLogs.Text = "清空通訊日誌";
            btnClearLogs.UseVisualStyleBackColor = true;
            // 
            // grpRecipeTest
            // 
            grpRecipeTest.Controls.Add(chkEnableTestRecipe);
            grpRecipeTest.Controls.Add(btnTriggerHandshakeNow);
            grpRecipeTest.Controls.Add(btnClearTestRecipe);
            grpRecipeTest.Controls.Add(lblTestHandshakeStatus);
            grpRecipeTest.Controls.Add(lblTestPrg);
            grpRecipeTest.Controls.Add(txtTestPrg);
            grpRecipeTest.Controls.Add(btnBrowseTestPrg);
            grpRecipeTest.Controls.Add(lblTestCnd);
            grpRecipeTest.Controls.Add(txtTestCnd);
            grpRecipeTest.Controls.Add(lblTestSheet);
            grpRecipeTest.Controls.Add(nudTestSheet);
            grpRecipeTest.Location = new Point(15, 74);
            grpRecipeTest.Name = "grpRecipeTest";
            grpRecipeTest.Size = new Size(1095, 92);
            grpRecipeTest.TabIndex = 1;
            grpRecipeTest.TabStop = false;
            grpRecipeTest.Text = "雷射機原廠配方交握測試 (GetRecipe.Req 響應測試)";
            // 
            // chkEnableTestRecipe
            // 
            chkEnableTestRecipe.AutoSize = true;
            chkEnableTestRecipe.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            chkEnableTestRecipe.Location = new Point(15, 23);
            chkEnableTestRecipe.Name = "chkEnableTestRecipe";
            chkEnableTestRecipe.Size = new Size(522, 23);
            chkEnableTestRecipe.TabIndex = 0;
            chkEnableTestRecipe.Text = "啟用測試配方覆蓋 (當收到機台 GetRecipe.Req 時優先使用以下設定交握)";
            chkEnableTestRecipe.UseVisualStyleBackColor = true;
            // 
            // btnTriggerHandshakeNow
            // 
            btnTriggerHandshakeNow.BackColor = Color.LightSkyBlue;
            btnTriggerHandshakeNow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnTriggerHandshakeNow.Location = new Point(470, 18);
            btnTriggerHandshakeNow.Name = "btnTriggerHandshakeNow";
            btnTriggerHandshakeNow.Size = new Size(165, 28);
            btnTriggerHandshakeNow.TabIndex = 1;
            btnTriggerHandshakeNow.Text = "立即手動發送交握";
            btnTriggerHandshakeNow.UseVisualStyleBackColor = false;
            // 
            // btnClearTestRecipe
            // 
            btnClearTestRecipe.Location = new Point(645, 18);
            btnClearTestRecipe.Name = "btnClearTestRecipe";
            btnClearTestRecipe.Size = new Size(85, 28);
            btnClearTestRecipe.TabIndex = 2;
            btnClearTestRecipe.Text = "清除設定";
            btnClearTestRecipe.UseVisualStyleBackColor = true;
            // 
            // lblTestHandshakeStatus
            // 
            lblTestHandshakeStatus.AutoSize = true;
            lblTestHandshakeStatus.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblTestHandshakeStatus.ForeColor = Color.DarkSlateBlue;
            lblTestHandshakeStatus.Location = new Point(745, 24);
            lblTestHandshakeStatus.Name = "lblTestHandshakeStatus";
            lblTestHandshakeStatus.Size = new Size(199, 19);
            lblTestHandshakeStatus.TabIndex = 3;
            lblTestHandshakeStatus.Text = "交握狀態: 待命中 (等待 Req)";
            // 
            // lblTestPrg
            // 
            lblTestPrg.AutoSize = true;
            lblTestPrg.Location = new Point(15, 57);
            lblTestPrg.Name = "lblTestPrg";
            lblTestPrg.Size = new Size(108, 19);
            lblTestPrg.TabIndex = 4;
            lblTestPrg.Text = "程式檔名/路徑:";
            // 
            // txtTestPrg
            // 
            txtTestPrg.Location = new Point(115, 54);
            txtTestPrg.Name = "txtTestPrg";
            txtTestPrg.Size = new Size(260, 27);
            txtTestPrg.TabIndex = 5;
            txtTestPrg.Text = "5PCS_MHUN12AD01SG1-A-A0";
            // 
            // btnBrowseTestPrg
            // 
            btnBrowseTestPrg.Location = new Point(380, 52);
            btnBrowseTestPrg.Name = "btnBrowseTestPrg";
            btnBrowseTestPrg.Size = new Size(65, 27);
            btnBrowseTestPrg.TabIndex = 6;
            btnBrowseTestPrg.Text = "瀏覽...";
            btnBrowseTestPrg.UseVisualStyleBackColor = true;
            // 
            // lblTestCnd
            // 
            lblTestCnd.AutoSize = true;
            lblTestCnd.Location = new Point(460, 57);
            lblTestCnd.Name = "lblTestCnd";
            lblTestCnd.Size = new Size(87, 19);
            lblTestCnd.TabIndex = 7;
            lblTestCnd.Text = "加工條件檔:";
            // 
            // txtTestCnd
            // 
            txtTestCnd.Location = new Point(540, 54);
            txtTestCnd.Name = "txtTestCnd";
            txtTestCnd.Size = new Size(120, 27);
            txtTestCnd.TabIndex = 8;
            txtTestCnd.Text = "*****";
            // 
            // lblTestSheet
            // 
            lblTestSheet.AutoSize = true;
            lblTestSheet.Location = new Point(680, 57);
            lblTestSheet.Name = "lblTestSheet";
            lblTestSheet.Size = new Size(72, 19);
            lblTestSheet.TabIndex = 9;
            lblTestSheet.Text = "加工片數:";
            // 
            // nudTestSheet
            // 
            nudTestSheet.Location = new Point(748, 54);
            nudTestSheet.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudTestSheet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTestSheet.Name = "nudTestSheet";
            nudTestSheet.Size = new Size(70, 27);
            nudTestSheet.TabIndex = 10;
            nudTestSheet.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // grpLog
            // 
            grpLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpLog.Controls.Add(dgvMqttLogs);
            grpLog.Location = new Point(15, 172);
            grpLog.Name = "grpLog";
            grpLog.Size = new Size(1095, 292);
            grpLog.TabIndex = 2;
            grpLog.TabStop = false;
            grpLog.Text = "MQTT 即時封包監聽紀錄";
            // 
            // dgvMqttLogs
            // 
            dgvMqttLogs.AllowUserToAddRows = false;
            dgvMqttLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMqttLogs.BackgroundColor = Color.White;
            dgvMqttLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMqttLogs.Columns.AddRange(new DataGridViewColumn[] { colLogTime, colLogDir, colLogTopic, colLogPayload });
            dgvMqttLogs.Dock = DockStyle.Fill;
            dgvMqttLogs.Location = new Point(3, 23);
            dgvMqttLogs.Name = "dgvMqttLogs";
            dgvMqttLogs.ReadOnly = true;
            dgvMqttLogs.RowHeadersWidth = 51;
            dgvMqttLogs.RowTemplate.Height = 25;
            dgvMqttLogs.Size = new Size(1089, 266);
            dgvMqttLogs.TabIndex = 0;
            // 
            // colLogTime
            // 
            colLogTime.HeaderText = "時間";
            colLogTime.MinimumWidth = 6;
            colLogTime.Name = "colLogTime";
            colLogTime.ReadOnly = true;
            // 
            // colLogDir
            // 
            colLogDir.HeaderText = "方向";
            colLogDir.MinimumWidth = 6;
            colLogDir.Name = "colLogDir";
            colLogDir.ReadOnly = true;
            // 
            // colLogTopic
            // 
            colLogTopic.HeaderText = "主題 (Topic)";
            colLogTopic.MinimumWidth = 6;
            colLogTopic.Name = "colLogTopic";
            colLogTopic.ReadOnly = true;
            // 
            // colLogPayload
            // 
            colLogPayload.HeaderText = "訊息內文 (JSON Payload)";
            colLogPayload.MinimumWidth = 6;
            colLogPayload.Name = "colLogPayload";
            colLogPayload.ReadOnly = true;
            // 
            // grpResult
            // 
            grpResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpResult.Controls.Add(lblResult);
            grpResult.Controls.Add(txtResult);
            grpResult.Controls.Add(lblResultCode);
            grpResult.Controls.Add(txtResultCode);
            grpResult.Controls.Add(lblResultMessage);
            grpResult.Controls.Add(txtResultMessage);
            grpResult.Location = new Point(12, 620);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(1140, 130);
            grpResult.TabIndex = 9;
            grpResult.TabStop = false;
            grpResult.Text = "執行結果";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(15, 25);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 19);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result :";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("微軟正黑體", 9.5F, FontStyle.Bold);
            txtResult.Location = new Point(75, 22);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(120, 29);
            txtResult.TabIndex = 1;
            // 
            // lblResultCode
            // 
            lblResultCode.AutoSize = true;
            lblResultCode.Location = new Point(15, 58);
            lblResultCode.Name = "lblResultCode";
            lblResultCode.Size = new Size(96, 19);
            lblResultCode.TabIndex = 2;
            lblResultCode.Text = "ResultCode :";
            // 
            // txtResultCode
            // 
            txtResultCode.Location = new Point(95, 55);
            txtResultCode.Name = "txtResultCode";
            txtResultCode.ReadOnly = true;
            txtResultCode.Size = new Size(100, 27);
            txtResultCode.TabIndex = 3;
            // 
            // lblResultMessage
            // 
            lblResultMessage.AutoSize = true;
            lblResultMessage.Location = new Point(207, 25);
            lblResultMessage.Name = "lblResultMessage";
            lblResultMessage.Size = new Size(121, 19);
            lblResultMessage.TabIndex = 4;
            lblResultMessage.Text = "ResultMessage :";
            // 
            // txtResultMessage
            // 
            txtResultMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResultMessage.BackColor = Color.WhiteSmoke;
            txtResultMessage.Location = new Point(334, 22);
            txtResultMessage.Multiline = true;
            txtResultMessage.Name = "txtResultMessage";
            txtResultMessage.ReadOnly = true;
            txtResultMessage.ScrollBars = ScrollBars.Vertical;
            txtResultMessage.Size = new Size(791, 95);
            txtResultMessage.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 761);
            Controls.Add(btnRoleSwitch);
            Controls.Add(grpCurrentOperator);
            Controls.Add(grpAuth);
            Controls.Add(btnSettings);
            Controls.Add(btnConnectMes);
            Controls.Add(btnToggleLang);
            Controls.Add(btnDisconnectMes);
            Controls.Add(pnlMqttLed);
            Controls.Add(lblMqttLed);
            Controls.Add(tabMain);
            Controls.Add(grpResult);
            Font = new Font("微軟正黑體", 9F);
            MinimumSize = new Size(1180, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MES - 2026/09/16";
            grpCurrentOperator.ResumeLayout(false);
            grpCurrentOperator.PerformLayout();
            grpAuth.ResumeLayout(false);
            grpAuth.PerformLayout();
            tabMain.ResumeLayout(false);
            tabWorkOrder.ResumeLayout(false);
            grpOrderInfo.ResumeLayout(false);
            grpOrderInfo.PerformLayout();
            grpTrackedInList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrackedIn).EndInit();
            cmsTrackedIn.ResumeLayout(false);
            grpOpcStatus.ResumeLayout(false);
            grpOpcStatus.PerformLayout();
            grpOrderActions.ResumeLayout(false);
            tabEquipment.ResumeLayout(false);
            grpAlarmList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlarms).EndInit();
            tabItTest.ResumeLayout(false);
            grpTestActions.ResumeLayout(false);
            grpRecipeTest.ResumeLayout(false);
            grpRecipeTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTestSheet).EndInit();
            grpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMqttLogs).EndInit();
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.GroupBox grpCurrentOperator;
        private System.Windows.Forms.Label lblOpId;
        private System.Windows.Forms.TextBox txtCurrentOpId;
        private System.Windows.Forms.Label lblOpName;
        private System.Windows.Forms.TextBox txtCurrentOpName;
        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnUserAuth;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtLoginUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnClearAuth;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnConnectMes;
        private System.Windows.Forms.Button btnToggleLang;
        private System.Windows.Forms.Button btnDisconnectMes;
        private System.Windows.Forms.Panel pnlMqttLed;
        private System.Windows.Forms.Label lblMqttLed;
        private System.Windows.Forms.Button btnRoleSwitch;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabWorkOrder;
        private System.Windows.Forms.TabPage tabEquipment;
        private System.Windows.Forms.TabPage tabItTest;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblWo;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label lblProcessNo;
        private System.Windows.Forms.TextBox txtProcessNo;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label lblRunQty;
        private System.Windows.Forms.TextBox txtRunQty;
        private System.Windows.Forms.Label lblCompletedQty;
        private System.Windows.Forms.TextBox txtCompletedQty;
        private System.Windows.Forms.Label lblRecipeId;
        private System.Windows.Forms.TextBox txtRecipeId;
        private System.Windows.Forms.Label lblConditionFile;
        private System.Windows.Forms.TextBox txtConditionFile;
        private System.Windows.Forms.Label lblIsTrackedIn;
        private System.Windows.Forms.TextBox txtIsTrackedIn;
        private System.Windows.Forms.Label lblComponentNo;
        private System.Windows.Forms.TextBox txtComponentNo;
        private System.Windows.Forms.GroupBox grpTrackedInList;
        private System.Windows.Forms.DataGridView dgvTrackedIn;
        private System.Windows.Forms.Button btnRemoveTrackedIn;
        private System.Windows.Forms.ContextMenuStrip cmsTrackedIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveTrackedIn;
        private System.Windows.Forms.GroupBox grpOrderActions;
        private System.Windows.Forms.Button btnTrackIn;
        private System.Windows.Forms.Button btnTrackOut;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.GroupBox grpOpcStatus;
        private System.Windows.Forms.Label lblOpcConn;
        private System.Windows.Forms.Label lblMachineState;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblActivePrg;
        private System.Windows.Forms.Panel pnlLampGreen;
        private System.Windows.Forms.Label lblLampGreen;
        private System.Windows.Forms.Panel pnlLampYellow;
        private System.Windows.Forms.Label lblLampYellow;
        private System.Windows.Forms.Panel pnlLampRed;
        private System.Windows.Forms.Label lblLampRed;
        private System.Windows.Forms.Button btnModeLocal;
        private System.Windows.Forms.Button btnModeSemiAuto;
        private System.Windows.Forms.Button btnModeAuto;
        private System.Windows.Forms.Button btnStartSchedule;
        private System.Windows.Forms.Button btnOpenSimulator;
        private System.Windows.Forms.Label lblManualProgramPath;
        private System.Windows.Forms.TextBox txtManualProgramPath;
        private System.Windows.Forms.Button btnBrowseProgramPath;
        private System.Windows.Forms.Button btnClearProgramPath;
        private System.Windows.Forms.GroupBox grpAlarmList;
        private System.Windows.Forms.DataGridView dgvAlarms;
        private System.Windows.Forms.GroupBox grpTestActions;
        private System.Windows.Forms.Button btnTestAlive;
        private System.Windows.Forms.Button btnTestProcessData;
        private System.Windows.Forms.Button btnTestAlarmStart;
        private System.Windows.Forms.Button btnTestAlarmEnd;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.GroupBox grpRecipeTest;
        private System.Windows.Forms.CheckBox chkEnableTestRecipe;
        private System.Windows.Forms.Button btnTriggerHandshakeNow;
        private System.Windows.Forms.Button btnClearTestRecipe;
        private System.Windows.Forms.Label lblTestHandshakeStatus;
        private System.Windows.Forms.Label lblTestPrg;
        private System.Windows.Forms.TextBox txtTestPrg;
        private System.Windows.Forms.Button btnBrowseTestPrg;
        private System.Windows.Forms.Label lblTestCnd;
        private System.Windows.Forms.TextBox txtTestCnd;
        private System.Windows.Forms.Label lblTestSheet;
        private System.Windows.Forms.NumericUpDown nudTestSheet;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.DataGridView dgvMqttLogs;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResultCode;
        private System.Windows.Forms.TextBox txtResultCode;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.TextBox txtResultMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOther1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogPayload;
    }
}