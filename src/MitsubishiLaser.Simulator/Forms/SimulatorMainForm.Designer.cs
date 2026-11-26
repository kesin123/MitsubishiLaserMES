namespace MitsubishiLaser.Simulator.Forms
{
    partial class SimulatorMainForm
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
            grpDashboard = new GroupBox();
            pnlGreen = new Panel();
            lblGreen = new Label();
            pnlYellow = new Panel();
            lblYellow = new Label();
            pnlRed = new Panel();
            lblRed = new Label();
            lblStatusBadge = new Label();
            lblModeBadge = new Label();
            lblWatchDogTitle = new Label();
            chkWatchDogEnable = new CheckBox();
            btnFeedDog = new Button();
            pbWatchDog = new ProgressBar();
            lblWatchDogVal = new Label();
            grpRecipe = new GroupBox();
            lblLotInput = new Label();
            txtLotInput = new TextBox();
            btnInputLot = new Button();
            btnTriggerGetRecipeReq = new Button();
            lblGetRecipeReq = new Label();
            lblReqPrg = new Label();
            txtReqPrg = new TextBox();
            lblReqCnd = new Label();
            txtReqCnd = new TextBox();
            lblReqSheet = new Label();
            txtReqSheet = new TextBox();
            lblGetRecipeAck = new Label();
            txtGetRecipeAck = new TextBox();
            grpSchedule = new GroupBox();
            lblActivePrg = new Label();
            lblActiveLot = new Label();
            pbProcessing = new ProgressBar();
            lblCounts = new Label();
            lblLaserParams = new Label();
            btnStartRun = new Button();
            btnStopRun = new Button();
            btnSimFailTarget = new Button();
            grpMode = new GroupBox();
            btnSetOffline = new Button();
            btnSetLocal = new Button();
            btnSetSemiAuto = new Button();
            btnSetAuto = new Button();
            grpAlarm = new GroupBox();
            lblPreset = new Label();
            cboPresetAlarms = new ComboBox();
            txtCustomAlarmNo = new TextBox();
            txtCustomAlarmMsg = new TextBox();
            btnTriggerAlarm = new Button();
            btnAlReset = new Button();
            dgvAlarms = new DataGridView();
            colSlot = new DataGridViewTextBoxColumn();
            colAlarmNo = new DataGridViewTextBoxColumn();
            colAlarmMsg = new DataGridViewTextBoxColumn();
            colAlarmType = new DataGridViewTextBoxColumn();
            colTriggerTime = new DataGridViewTextBoxColumn();
            grpLog = new GroupBox();
            txtLog = new TextBox();
            btnClearLog = new Button();
            grpDashboard.SuspendLayout();
            grpRecipe.SuspendLayout();
            grpSchedule.SuspendLayout();
            grpMode.SuspendLayout();
            grpAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarms).BeginInit();
            grpLog.SuspendLayout();
            SuspendLayout();
            // 
            // grpDashboard
            // 
            grpDashboard.Controls.Add(pnlGreen);
            grpDashboard.Controls.Add(lblGreen);
            grpDashboard.Controls.Add(pnlYellow);
            grpDashboard.Controls.Add(lblYellow);
            grpDashboard.Controls.Add(pnlRed);
            grpDashboard.Controls.Add(lblRed);
            grpDashboard.Controls.Add(lblStatusBadge);
            grpDashboard.Controls.Add(lblModeBadge);
            grpDashboard.Controls.Add(lblWatchDogTitle);
            grpDashboard.Controls.Add(chkWatchDogEnable);
            grpDashboard.Controls.Add(btnFeedDog);
            grpDashboard.Controls.Add(pbWatchDog);
            grpDashboard.Controls.Add(lblWatchDogVal);
            grpDashboard.Location = new Point(12, 10);
            grpDashboard.Name = "grpDashboard";
            grpDashboard.Size = new Size(1140, 95);
            grpDashboard.TabIndex = 0;
            grpDashboard.TabStop = false;
            grpDashboard.Text = "機台即時狀態看板 (Dashboard)";
            // 
            // pnlGreen
            // 
            pnlGreen.BackColor = Color.DarkGreen;
            pnlGreen.BorderStyle = BorderStyle.FixedSingle;
            pnlGreen.Location = new Point(20, 30);
            pnlGreen.Name = "pnlGreen";
            pnlGreen.Size = new Size(26, 26);
            pnlGreen.TabIndex = 0;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(52, 35);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(81, 19);
            lblGreen.TabIndex = 1;
            lblGreen.Text = "綠燈 (Run)";
            // 
            // pnlYellow
            // 
            pnlYellow.BackColor = Color.DarkGoldenrod;
            pnlYellow.BorderStyle = BorderStyle.FixedSingle;
            pnlYellow.Location = new Point(139, 30);
            pnlYellow.Name = "pnlYellow";
            pnlYellow.Size = new Size(26, 26);
            pnlYellow.TabIndex = 2;
            // 
            // lblYellow
            // 
            lblYellow.AutoSize = true;
            lblYellow.Location = new Point(167, 35);
            lblYellow.Name = "lblYellow";
            lblYellow.Size = new Size(92, 19);
            lblYellow.TabIndex = 3;
            lblYellow.Text = "黃燈 (Beam)";
            // 
            // pnlRed
            // 
            pnlRed.BackColor = Color.DarkRed;
            pnlRed.BorderStyle = BorderStyle.FixedSingle;
            pnlRed.Location = new Point(273, 30);
            pnlRed.Name = "pnlRed";
            pnlRed.Size = new Size(26, 26);
            pnlRed.TabIndex = 4;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(305, 35);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(95, 19);
            lblRed.TabIndex = 5;
            lblRed.Text = "紅燈 (Alarm)";
            // 
            // lblStatusBadge
            // 
            lblStatusBadge.BackColor = Color.Gold;
            lblStatusBadge.BorderStyle = BorderStyle.FixedSingle;
            lblStatusBadge.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblStatusBadge.Location = new Point(369, 54);
            lblStatusBadge.Name = "lblStatusBadge";
            lblStatusBadge.Size = new Size(216, 30);
            lblStatusBadge.TabIndex = 6;
            lblStatusBadge.Text = "[3] Idle (待機)";
            lblStatusBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModeBadge
            // 
            lblModeBadge.BackColor = Color.LightSkyBlue;
            lblModeBadge.BorderStyle = BorderStyle.FixedSingle;
            lblModeBadge.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblModeBadge.Location = new Point(596, 54);
            lblModeBadge.Name = "lblModeBadge";
            lblModeBadge.Size = new Size(222, 31);
            lblModeBadge.TabIndex = 7;
            lblModeBadge.Text = "Mode: Online-Auto";
            lblModeBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWatchDogTitle
            // 
            lblWatchDogTitle.AutoSize = true;
            lblWatchDogTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblWatchDogTitle.Location = new Point(741, 24);
            lblWatchDogTitle.Name = "lblWatchDogTitle";
            lblWatchDogTitle.Size = new Size(195, 19);
            lblWatchDogTitle.TabIndex = 8;
            lblWatchDogTitle.Text = "Host WatchDog 心跳監控:";
            // 
            // chkWatchDogEnable
            // 
            chkWatchDogEnable.AutoSize = true;
            chkWatchDogEnable.Checked = true;
            chkWatchDogEnable.CheckState = CheckState.Checked;
            chkWatchDogEnable.Font = new Font("微軟正黑體", 9F);
            chkWatchDogEnable.Location = new Point(938, 21);
            chkWatchDogEnable.Name = "chkWatchDogEnable";
            chkWatchDogEnable.Size = new Size(91, 23);
            chkWatchDogEnable.TabIndex = 9;
            chkWatchDogEnable.Text = "啟用監控";
            chkWatchDogEnable.UseVisualStyleBackColor = true;
            // 
            // btnFeedDog
            // 
            btnFeedDog.Font = new Font("微軟正黑體", 8.5F);
            btnFeedDog.Location = new Point(1035, 19);
            btnFeedDog.Name = "btnFeedDog";
            btnFeedDog.Size = new Size(95, 25);
            btnFeedDog.TabIndex = 10;
            btnFeedDog.Text = "手動餵狗 (+1)";
            btnFeedDog.UseVisualStyleBackColor = true;
            // 
            // pbWatchDog
            // 
            pbWatchDog.Location = new Point(860, 69);
            pbWatchDog.Maximum = 10;
            pbWatchDog.Name = "pbWatchDog";
            pbWatchDog.Size = new Size(220, 20);
            pbWatchDog.TabIndex = 11;
            pbWatchDog.Value = 10;
            // 
            // lblWatchDogVal
            // 
            lblWatchDogVal.AutoSize = true;
            lblWatchDogVal.Font = new Font("Arial", 9.5F, FontStyle.Bold);
            lblWatchDogVal.Location = new Point(843, 47);
            lblWatchDogVal.Name = "lblWatchDogVal";
            lblWatchDogVal.Size = new Size(246, 19);
            lblWatchDogVal.TabIndex = 12;
            lblWatchDogVal.Text = "10s [待命中 (等待上位機連線...)]";
            // 
            // grpRecipe
            // 
            grpRecipe.Controls.Add(lblLotInput);
            grpRecipe.Controls.Add(txtLotInput);
            grpRecipe.Controls.Add(btnInputLot);
            grpRecipe.Controls.Add(btnTriggerGetRecipeReq);
            grpRecipe.Controls.Add(lblGetRecipeReq);
            grpRecipe.Controls.Add(lblReqPrg);
            grpRecipe.Controls.Add(txtReqPrg);
            grpRecipe.Controls.Add(lblReqCnd);
            grpRecipe.Controls.Add(txtReqCnd);
            grpRecipe.Controls.Add(lblReqSheet);
            grpRecipe.Controls.Add(txtReqSheet);
            grpRecipe.Controls.Add(lblGetRecipeAck);
            grpRecipe.Controls.Add(txtGetRecipeAck);
            grpRecipe.Location = new Point(12, 115);
            grpRecipe.Name = "grpRecipe";
            grpRecipe.Size = new Size(554, 230);
            grpRecipe.TabIndex = 1;
            grpRecipe.TabStop = false;
            grpRecipe.Text = "操作員條碼輸入與配方交握 (Recipe Handshake SPEC 4-4)";
            // 
            // lblLotInput
            // 
            lblLotInput.AutoSize = true;
            lblLotInput.Location = new Point(15, 30);
            lblLotInput.Name = "lblLotInput";
            lblLotInput.Size = new Size(93, 19);
            lblLotInput.TabIndex = 0;
            lblLotInput.Text = "批號 (LotID):";
            // 
            // txtLotInput
            // 
            txtLotInput.Location = new Point(115, 25);
            txtLotInput.Name = "txtLotInput";
            txtLotInput.Size = new Size(165, 27);
            txtLotInput.TabIndex = 1;
            txtLotInput.Text = "LOT20260916-01";
            // 
            // btnInputLot
            // 
            btnInputLot.BackColor = Color.LightSteelBlue;
            btnInputLot.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnInputLot.Location = new Point(284, 24);
            btnInputLot.Name = "btnInputLot";
            btnInputLot.Size = new Size(130, 29);
            btnInputLot.TabIndex = 2;
            btnInputLot.Text = "模擬操作員刷入";
            btnInputLot.UseVisualStyleBackColor = false;
            // 
            // btnTriggerGetRecipeReq
            // 
            btnTriggerGetRecipeReq.BackColor = Color.LightSkyBlue;
            btnTriggerGetRecipeReq.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnTriggerGetRecipeReq.Location = new Point(420, 23);
            btnTriggerGetRecipeReq.Name = "btnTriggerGetRecipeReq";
            btnTriggerGetRecipeReq.Size = new Size(120, 29);
            btnTriggerGetRecipeReq.TabIndex = 3;
            btnTriggerGetRecipeReq.Text = "發出 GetRecipe.Req";
            btnTriggerGetRecipeReq.UseVisualStyleBackColor = false;
            // 
            // lblGetRecipeReq
            // 
            lblGetRecipeReq.AutoSize = true;
            lblGetRecipeReq.Font = new Font("微軟正黑體", 9.5F, FontStyle.Bold);
            lblGetRecipeReq.ForeColor = Color.DarkSlateGray;
            lblGetRecipeReq.Location = new Point(15, 68);
            lblGetRecipeReq.Name = "lblGetRecipeReq";
            lblGetRecipeReq.Size = new Size(265, 21);
            lblGetRecipeReq.TabIndex = 3;
            lblGetRecipeReq.Text = "GetRecipe.Req: False (等待刷卡中)";
            // 
            // lblReqPrg
            // 
            lblReqPrg.AutoSize = true;
            lblReqPrg.Location = new Point(15, 105);
            lblReqPrg.Name = "lblReqPrg";
            lblReqPrg.Size = new Size(102, 19);
            lblReqPrg.TabIndex = 4;
            lblReqPrg.Text = "ProgramFile :";
            // 
            // txtReqPrg
            // 
            txtReqPrg.Location = new Point(130, 102);
            txtReqPrg.Name = "txtReqPrg";
            txtReqPrg.ReadOnly = true;
            txtReqPrg.Size = new Size(410, 27);
            txtReqPrg.TabIndex = 5;
            // 
            // lblReqCnd
            // 
            lblReqCnd.AutoSize = true;
            lblReqCnd.Location = new Point(15, 140);
            lblReqCnd.Name = "lblReqCnd";
            lblReqCnd.Size = new Size(109, 19);
            lblReqCnd.TabIndex = 6;
            lblReqCnd.Text = "ConditionFile :";
            // 
            // txtReqCnd
            // 
            txtReqCnd.Location = new Point(130, 137);
            txtReqCnd.Name = "txtReqCnd";
            txtReqCnd.ReadOnly = true;
            txtReqCnd.Size = new Size(410, 27);
            txtReqCnd.TabIndex = 7;
            // 
            // lblReqSheet
            // 
            lblReqSheet.AutoSize = true;
            lblReqSheet.Location = new Point(15, 175);
            lblReqSheet.Name = "lblReqSheet";
            lblReqSheet.Size = new Size(90, 19);
            lblReqSheet.TabIndex = 8;
            lblReqSheet.Text = "SheetNum :";
            // 
            // txtReqSheet
            // 
            txtReqSheet.Location = new Point(130, 172);
            txtReqSheet.Name = "txtReqSheet";
            txtReqSheet.ReadOnly = true;
            txtReqSheet.Size = new Size(144, 27);
            txtReqSheet.TabIndex = 9;
            // 
            // lblGetRecipeAck
            // 
            lblGetRecipeAck.AutoSize = true;
            lblGetRecipeAck.Location = new Point(280, 175);
            lblGetRecipeAck.Name = "lblGetRecipeAck";
            lblGetRecipeAck.Size = new Size(114, 19);
            lblGetRecipeAck.TabIndex = 10;
            lblGetRecipeAck.Text = "GetRecipe.Ack :";
            // 
            // txtGetRecipeAck
            // 
            txtGetRecipeAck.Location = new Point(394, 172);
            txtGetRecipeAck.Name = "txtGetRecipeAck";
            txtGetRecipeAck.ReadOnly = true;
            txtGetRecipeAck.Size = new Size(146, 27);
            txtGetRecipeAck.TabIndex = 11;
            // 
            // grpSchedule
            // 
            grpSchedule.Controls.Add(lblActivePrg);
            grpSchedule.Controls.Add(lblActiveLot);
            grpSchedule.Controls.Add(pbProcessing);
            grpSchedule.Controls.Add(lblCounts);
            grpSchedule.Controls.Add(lblLaserParams);
            grpSchedule.Controls.Add(btnStartRun);
            grpSchedule.Controls.Add(btnStopRun);
            grpSchedule.Controls.Add(btnSimFailTarget);
            grpSchedule.Location = new Point(576, 115);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Size = new Size(576, 230);
            grpSchedule.TabIndex = 2;
            grpSchedule.TabStop = false;
            grpSchedule.Text = "連續運轉與加工監控 (Schedule & Progress SPEC 4-5)";
            // 
            // lblActivePrg
            // 
            lblActivePrg.AutoSize = true;
            lblActivePrg.Font = new Font("微軟正黑體", 9.5F, FontStyle.Bold);
            lblActivePrg.Location = new Point(15, 28);
            lblActivePrg.Name = "lblActivePrg";
            lblActivePrg.Size = new Size(190, 21);
            lblActivePrg.TabIndex = 0;
            lblActivePrg.Text = "當前加工程式: (尚未載入)";
            // 
            // lblActiveLot
            // 
            lblActiveLot.AutoSize = true;
            lblActiveLot.Location = new Point(15, 55);
            lblActiveLot.Name = "lblActiveLot";
            lblActiveLot.Size = new Size(124, 19);
            lblActiveLot.TabIndex = 1;
            lblActiveLot.Text = "作用批號: (None)";
            // 
            // pbProcessing
            // 
            pbProcessing.Location = new Point(18, 85);
            pbProcessing.Name = "pbProcessing";
            pbProcessing.Size = new Size(548, 22);
            pbProcessing.TabIndex = 2;
            // 
            // lblCounts
            // 
            lblCounts.AutoSize = true;
            lblCounts.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCounts.Location = new Point(15, 120);
            lblCounts.Name = "lblCounts";
            lblCounts.Size = new Size(394, 22);
            lblCounts.TabIndex = 3;
            lblCounts.Text = "加工進度: Processed=0 / Scheduled=0 (失敗=0)";
            // 
            // lblLaserParams
            // 
            lblLaserParams.AutoSize = true;
            lblLaserParams.ForeColor = Color.DarkSlateGray;
            lblLaserParams.Location = new Point(15, 150);
            lblLaserParams.Name = "lblLaserParams";
            lblLaserParams.Size = new Size(470, 19);
            lblLaserParams.TabIndex = 4;
            lblLaserParams.Text = "雷射功率: 5500W | 頻率: 100Hz | 氣壓: -10.5kPa | 聚焦鏡溫度: 24.2℃";
            // 
            // btnStartRun
            // 
            btnStartRun.BackColor = Color.LightGreen;
            btnStartRun.Font = new Font("微軟正黑體", 9.5F, FontStyle.Bold);
            btnStartRun.Location = new Point(18, 180);
            btnStartRun.Name = "btnStartRun";
            btnStartRun.Size = new Size(160, 36);
            btnStartRun.TabIndex = 5;
            btnStartRun.Text = "手動啟動連續運轉";
            btnStartRun.UseVisualStyleBackColor = false;
            // 
            // btnStopRun
            // 
            btnStopRun.BackColor = Color.MistyRose;
            btnStopRun.Font = new Font("微軟正黑體", 9.5F);
            btnStopRun.Location = new Point(190, 180);
            btnStopRun.Name = "btnStopRun";
            btnStopRun.Size = new Size(120, 36);
            btnStopRun.TabIndex = 6;
            btnStopRun.Text = "暫停/停止運轉";
            btnStopRun.UseVisualStyleBackColor = false;
            // 
            // btnSimFailTarget
            // 
            btnSimFailTarget.Location = new Point(325, 180);
            btnSimFailTarget.Name = "btnSimFailTarget";
            btnSimFailTarget.Size = new Size(150, 36);
            btnSimFailTarget.TabIndex = 7;
            btnSimFailTarget.Text = "模擬靶位抓取失敗";
            btnSimFailTarget.UseVisualStyleBackColor = true;
            // 
            // grpMode
            // 
            grpMode.Controls.Add(btnSetOffline);
            grpMode.Controls.Add(btnSetLocal);
            grpMode.Controls.Add(btnSetSemiAuto);
            grpMode.Controls.Add(btnSetAuto);
            grpMode.Location = new Point(12, 355);
            grpMode.Name = "grpMode";
            grpMode.Size = new Size(554, 75);
            grpMode.TabIndex = 3;
            grpMode.TabStop = false;
            grpMode.Text = "機台操作盤模式切換 (SPEC 4-1，機台端手動切換)";
            // 
            // btnSetOffline
            // 
            btnSetOffline.Location = new Point(20, 25);
            btnSetOffline.Name = "btnSetOffline";
            btnSetOffline.Size = new Size(115, 34);
            btnSetOffline.TabIndex = 0;
            btnSetOffline.Text = "0: OFFLINE";
            btnSetOffline.UseVisualStyleBackColor = true;
            // 
            // btnSetLocal
            // 
            btnSetLocal.Location = new Point(150, 25);
            btnSetLocal.Name = "btnSetLocal";
            btnSetLocal.Size = new Size(115, 34);
            btnSetLocal.TabIndex = 1;
            btnSetLocal.Text = "1: LOCAL";
            btnSetLocal.UseVisualStyleBackColor = true;
            // 
            // btnSetSemiAuto
            // 
            btnSetSemiAuto.Location = new Point(280, 25);
            btnSetSemiAuto.Name = "btnSetSemiAuto";
            btnSetSemiAuto.Size = new Size(125, 34);
            btnSetSemiAuto.TabIndex = 2;
            btnSetSemiAuto.Text = "2: SEMI-AUTO";
            btnSetSemiAuto.UseVisualStyleBackColor = true;
            // 
            // btnSetAuto
            // 
            btnSetAuto.BackColor = Color.LightCyan;
            btnSetAuto.Location = new Point(420, 25);
            btnSetAuto.Name = "btnSetAuto";
            btnSetAuto.Size = new Size(120, 34);
            btnSetAuto.TabIndex = 3;
            btnSetAuto.Text = "3: AUTO";
            btnSetAuto.UseVisualStyleBackColor = false;
            // 
            // grpAlarm
            // 
            grpAlarm.Controls.Add(lblPreset);
            grpAlarm.Controls.Add(cboPresetAlarms);
            grpAlarm.Controls.Add(txtCustomAlarmNo);
            grpAlarm.Controls.Add(txtCustomAlarmMsg);
            grpAlarm.Controls.Add(btnTriggerAlarm);
            grpAlarm.Controls.Add(btnAlReset);
            grpAlarm.Controls.Add(dgvAlarms);
            grpAlarm.Location = new Point(12, 440);
            grpAlarm.Name = "grpAlarm";
            grpAlarm.Size = new Size(555, 320);
            grpAlarm.TabIndex = 4;
            grpAlarm.TabStop = false;
            grpAlarm.Text = "警報注入與 AL-RESET 復歸 (SPEC 4-7，10 組 Alarm Slot)";
            // 
            // lblPreset
            // 
            lblPreset.AutoSize = true;
            lblPreset.Location = new Point(15, 28);
            lblPreset.Name = "lblPreset";
            lblPreset.Size = new Size(72, 19);
            lblPreset.TabIndex = 0;
            lblPreset.Text = "預置警報:";
            // 
            // cboPresetAlarms
            // 
            cboPresetAlarms.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPresetAlarms.FormattingEnabled = true;
            cboPresetAlarms.Location = new Point(93, 25);
            cboPresetAlarms.Name = "cboPresetAlarms";
            cboPresetAlarms.Size = new Size(237, 27);
            cboPresetAlarms.TabIndex = 1;
            // 
            // txtCustomAlarmNo
            // 
            txtCustomAlarmNo.Location = new Point(340, 25);
            txtCustomAlarmNo.Name = "txtCustomAlarmNo";
            txtCustomAlarmNo.Size = new Size(60, 27);
            txtCustomAlarmNo.TabIndex = 2;
            txtCustomAlarmNo.Text = "0216";
            // 
            // txtCustomAlarmMsg
            // 
            txtCustomAlarmMsg.Location = new Point(405, 25);
            txtCustomAlarmMsg.Name = "txtCustomAlarmMsg";
            txtCustomAlarmMsg.Size = new Size(140, 27);
            txtCustomAlarmMsg.TabIndex = 3;
            txtCustomAlarmMsg.Text = "工件偏移異常";
            // 
            // btnTriggerAlarm
            // 
            btnTriggerAlarm.BackColor = Color.LightCoral;
            btnTriggerAlarm.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnTriggerAlarm.Location = new Point(15, 60);
            btnTriggerAlarm.Name = "btnTriggerAlarm";
            btnTriggerAlarm.Size = new Size(160, 32);
            btnTriggerAlarm.TabIndex = 4;
            btnTriggerAlarm.Text = "注入警報 (Trigger)";
            btnTriggerAlarm.UseVisualStyleBackColor = false;
            // 
            // btnAlReset
            // 
            btnAlReset.BackColor = Color.LightYellow;
            btnAlReset.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAlReset.Location = new Point(190, 60);
            btnAlReset.Name = "btnAlReset";
            btnAlReset.Size = new Size(215, 32);
            btnAlReset.TabIndex = 5;
            btnAlReset.Text = "機台 AL-RESET (警報復歸)";
            btnAlReset.UseVisualStyleBackColor = false;
            // 
            // dgvAlarms
            // 
            dgvAlarms.AllowUserToAddRows = false;
            dgvAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlarms.BackgroundColor = Color.White;
            dgvAlarms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlarms.Columns.AddRange(new DataGridViewColumn[] { colSlot, colAlarmNo, colAlarmMsg, colAlarmType, colTriggerTime });
            dgvAlarms.Location = new Point(15, 100);
            dgvAlarms.Name = "dgvAlarms";
            dgvAlarms.ReadOnly = true;
            dgvAlarms.RowHeadersWidth = 51;
            dgvAlarms.RowTemplate.Height = 25;
            dgvAlarms.Size = new Size(530, 205);
            dgvAlarms.TabIndex = 6;
            // 
            // colSlot
            // 
            colSlot.HeaderText = "Slot";
            colSlot.MinimumWidth = 6;
            colSlot.Name = "colSlot";
            colSlot.ReadOnly = true;
            // 
            // colAlarmNo
            // 
            colAlarmNo.HeaderText = "代碼";
            colAlarmNo.MinimumWidth = 6;
            colAlarmNo.Name = "colAlarmNo";
            colAlarmNo.ReadOnly = true;
            // 
            // colAlarmMsg
            // 
            colAlarmMsg.HeaderText = "警報訊息";
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
            // colTriggerTime
            // 
            colTriggerTime.HeaderText = "發生時間";
            colTriggerTime.MinimumWidth = 6;
            colTriggerTime.Name = "colTriggerTime";
            colTriggerTime.ReadOnly = true;
            // 
            // grpLog
            // 
            grpLog.Controls.Add(txtLog);
            grpLog.Controls.Add(btnClearLog);
            grpLog.Location = new Point(576, 355);
            grpLog.Name = "grpLog";
            grpLog.Size = new Size(576, 405);
            grpLog.TabIndex = 5;
            grpLog.TabStop = false;
            grpLog.Text = "機台事件與通訊日誌 (Event Log)";
            // 
            // txtLog
            // 
            txtLog.BackColor = Color.WhiteSmoke;
            txtLog.Dock = DockStyle.Top;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.Location = new Point(3, 23);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(570, 345);
            txtLog.TabIndex = 0;
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(440, 368);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(110, 30);
            btnClearLog.TabIndex = 1;
            btnClearLog.Text = "清空日誌";
            btnClearLog.UseVisualStyleBackColor = true;
            // 
            // SimulatorMainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 771);
            Controls.Add(grpDashboard);
            Controls.Add(grpRecipe);
            Controls.Add(grpSchedule);
            Controls.Add(grpMode);
            Controls.Add(grpAlarm);
            Controls.Add(grpLog);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SimulatorMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "三菱 CO2 雷射加工機 完整功能測試模擬器 (SPEC: S26888-C)";
            grpDashboard.ResumeLayout(false);
            grpDashboard.PerformLayout();
            grpRecipe.ResumeLayout(false);
            grpRecipe.PerformLayout();
            grpSchedule.ResumeLayout(false);
            grpSchedule.PerformLayout();
            grpMode.ResumeLayout(false);
            grpAlarm.ResumeLayout(false);
            grpAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarms).EndInit();
            grpLog.ResumeLayout(false);
            grpLog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDashboard;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.Label lblModeBadge;
        private System.Windows.Forms.Label lblWatchDogTitle;
        private System.Windows.Forms.CheckBox chkWatchDogEnable;
        private System.Windows.Forms.Button btnFeedDog;
        private System.Windows.Forms.ProgressBar pbWatchDog;
        private System.Windows.Forms.Label lblWatchDogVal;

        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblLotInput;
        private System.Windows.Forms.TextBox txtLotInput;
        private System.Windows.Forms.Button btnInputLot;
        private System.Windows.Forms.Button btnTriggerGetRecipeReq;
        private System.Windows.Forms.Label lblGetRecipeReq;
        private System.Windows.Forms.Label lblReqPrg;
        private System.Windows.Forms.TextBox txtReqPrg;
        private System.Windows.Forms.Label lblReqCnd;
        private System.Windows.Forms.TextBox txtReqCnd;
        private System.Windows.Forms.Label lblReqSheet;
        private System.Windows.Forms.TextBox txtReqSheet;
        private System.Windows.Forms.Label lblGetRecipeAck;
        private System.Windows.Forms.TextBox txtGetRecipeAck;

        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.Label lblActivePrg;
        private System.Windows.Forms.Label lblActiveLot;
        private System.Windows.Forms.ProgressBar pbProcessing;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.Label lblLaserParams;
        private System.Windows.Forms.Button btnStartRun;
        private System.Windows.Forms.Button btnStopRun;
        private System.Windows.Forms.Button btnSimFailTarget;

        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.Button btnSetOffline;
        private System.Windows.Forms.Button btnSetLocal;
        private System.Windows.Forms.Button btnSetSemiAuto;
        private System.Windows.Forms.Button btnSetAuto;

        private System.Windows.Forms.GroupBox grpAlarm;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ComboBox cboPresetAlarms;
        private System.Windows.Forms.TextBox txtCustomAlarmNo;
        private System.Windows.Forms.TextBox txtCustomAlarmMsg;
        private System.Windows.Forms.Button btnTriggerAlarm;
        private System.Windows.Forms.Button btnAlReset;
        private System.Windows.Forms.DataGridView dgvAlarms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTriggerTime;

        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;
    }
}
