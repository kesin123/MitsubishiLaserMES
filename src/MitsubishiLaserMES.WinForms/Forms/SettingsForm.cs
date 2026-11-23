using System;
using System.Windows.Forms;
using MitsubishiLaserMES.Core.Models.Config;

namespace MitsubishiLaserMES.WinForms.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly AppConfig _config;

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(AppConfig config) : this()
        {
            _config = config ?? new AppConfig();
            LoadConfigToUI();
        }

        private void LoadConfigToUI()
        {
            if (_config == null) return;

            txtMqttServer.Text = _config.Mqtt.Server;
            numMqttPort.Value = _config.Mqtt.Port;
            txtClientId.Text = _config.Mqtt.ClientId;
            txtFactory.Text = _config.Mqtt.Factory;
            txtFloor.Text = _config.Mqtt.Floor;
            txtArea.Text = _config.Mqtt.Area;
            txtEqId.Text = _config.Mqtt.EqID;
            numTimeoutT1.Value = _config.Mqtt.TimeoutT1Ms / 1000;

            chkUseVirtual.Checked = _config.Opc.UseVirtualSimulator;
            txtOpcEndpoint.Text = _config.Opc.EndpointUrl;
            chkOpcSecurity.Checked = _config.Opc.UseSecurity;
            txtRecipeDir.Text = _config.Opc.RecipeDirectory ?? @"c:\uPOL\muti-laser\";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_config == null) return;

            _config.Mqtt.Server = txtMqttServer.Text.Trim();
            _config.Mqtt.Port = (int)numMqttPort.Value;
            _config.Mqtt.ClientId = txtClientId.Text.Trim();
            _config.Mqtt.Factory = txtFactory.Text.Trim();
            _config.Mqtt.Floor = txtFloor.Text.Trim();
            _config.Mqtt.Area = txtArea.Text.Trim();
            _config.Mqtt.EqID = txtEqId.Text.Trim();
            _config.Mqtt.TimeoutT1Ms = (int)numTimeoutT1.Value * 1000;

            _config.Opc.UseVirtualSimulator = chkUseVirtual.Checked;
            _config.Opc.EndpointUrl = txtOpcEndpoint.Text.Trim();
            _config.Opc.UseSecurity = chkOpcSecurity.Checked;
            _config.Opc.RecipeDirectory = txtRecipeDir.Text.Trim();

            ConfigHelper.SaveConfig(_config);
            Close();
        }
    }
}
