# 當前任務規格 (CURRENT_TASK.md)

## 1. 用戶目標
將三菱 CO2 雷射加工機 MES 中繼系統（`MitsubishiLaserMES`）方案中的三個專案與 `Protocol.Core` 降版至 **.NET 6 (x86)**：
- `dll/Protocol.Core/Protocol.Core.csproj` → `net6.0`、`x86`（編譯並更新 `dll/Protocol.Core.dll`）
- `src/MitsubishiLaserMES.Core/MitsubishiLaserMES.Core.csproj` → `net6.0`、`x86`
- `src/MitsubishiLaserMES.WinForms/MitsubishiLaserMES.WinForms.csproj` → `net6.0-windows`、`x86`
- `src/MitsubishiLaser.Simulator/MitsubishiLaser.Simulator.csproj` → `net6.0-windows`、`x86`

## 2. 驗收標準
- 三個主方案專案與 `Protocol.Core` 的 `TargetFramework` 皆已降版為 `net6.0` / `net6.0-windows`，並明確設定 `<PlatformTarget>x86</PlatformTarget>` 與 `<Platforms>x86</Platforms>`。
- `MitsubishiLaserMES.sln` 的 `Debug|x86` 與 `Release|x86` 正確映射到三個專案的 `x86` 組態。
- `dll/Protocol.Core.dll` 已由 `net6.0` (x86) 重新編譯並覆蓋更新。
- 維持 `OPCFoundation.NetStandard.Opc.Ua 1.5.378.156` 以保留 `ITelemetryContext` API 相容性。
- 清除舊 `bin/` 與 `obj/` 後，`dotnet build MitsubishiLaserMES.sln -c Debug -p:Platform=x86` 與 `Release` 編譯皆成功（0 Error）。
- 驗證產出的 `*.runtimeconfig.json` 目標框架為 `net6.0`，且產出執行檔/DLL 之 PE 標頭為 32 位元（x86 / 32BITREQ）。

## 3. 修改邏輯
1. 還原工作區 `src/` 程式碼檔案（`git restore src/`）。
2. 更新三個 `.csproj` 檔案之 `TargetFramework`、`PlatformTarget` 與 `Platforms`。
3. 更新 `MitsubishiLaserMES.sln` 的專案平台映射設定。
4. 清理 `bin/` 與 `obj/`，執行 `dotnet restore` 驗證 NuGet 相容性。
5. 修改 `dll/Protocol.Core/Protocol.Core.csproj`（`TargetFramework=net6.0`、`Platforms=x86`、`PlatformTarget=x86`、移除 `LangVersion=14.0`、改用 `PackageReference` 參考 `Newtonsoft.Json 13.0.4`），以 `Release|x86` 編譯並覆蓋 `dll/Protocol.Core.dll`。
6. 執行主方案 Debug 與 Release (x86) 建置並驗證產出之 `runtimeconfig.json` 與 PE 位元架構。
