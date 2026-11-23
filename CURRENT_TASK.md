# 當前任務規格 (CURRENT_TASK.md)

## 1. 用戶目標
生成此專案（三菱 CO2 雷射加工機 MES 中繼系統 `MitsubishiLaserMES`）完整詳細的交接文件，並輸出至 `DOC/專案交接文件.md`。

## 2. 驗收標準
- 成功建立 `DOC/專案交接文件.md`，格式為標準 GitHub Flavored Markdown（正體中文，台灣科技習慣用語）。
- 內容完整涵蓋：
  1. 專案總覽、系統定位與 Mermaid 系統拓樸架構圖。
  2. 開發環境與技術棧（.NET 8、WinForms、MQTTnet、OPCFoundation.NetStandard.Opc.Ua、Newtonsoft.Json、Protocol.Core.dll）。
  3. 解決方案與目錄結構詳解（`MitsubishiLaserMES.Core`、`MitsubishiLaserMES.WinForms`、`MitsubishiLaser.Simulator`、`Dictionaries/DR0026.json`、`DOC/`）。
  4. 核心業務流程與交握時序圖（自動切換 `SEMI-AUTO` 模式、機台主動觸發 `GetRecipe.Req` 自動進站與等待 `PP_SELECT` 五步配方交握時序、三層配方路徑覆蓋優先權、防呆強制移除進站機制）。
  5. 上位 EAP (MQTT) 通訊協定實作細節（Topic 結構、信封格式、CMD 指令映射、TransactionID 配對、離線暫存補傳）。
  6. 下位三菱雷射機 (OPC UA) 通訊與節點規範（實機 DeviceXPlorer 1024-bit 憑證與設定相容性、完整 OPC UA 節點對照表）。
  7. 組態設定（`appsettings.json`）、本地資料持久化（`tracked_orders.json`、`offline_buffer.json`）、雙軌日誌與 CSV 稽核機制。
  8. 內建雷射機模擬器與調試工具說明。
  9. 建置部署指令與現場故障排除指南。
- 不影響現有專案程式碼與編譯狀態。

## 3. 修改邏輯
- 建立 `DOC/專案交接文件.md`，寫入完整詳細的專案交接文件內容。
