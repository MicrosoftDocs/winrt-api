---
-api-id: M:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions.DownloadLatestSettingsForNamespace(System.String,System.String,System.Boolean,System.Boolean,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public PlatformDiagnosticActionState PlatformDiagnosticActions.DownloadLatestSettingsForNamespace(String partner, String feature, Boolean isScenarioNamespace, Boolean downloadOverCostedNetwork, Boolean downloadOverBattery)
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions.DownloadLatestSettingsForNamespace


## -description

Downloads the settings that describes which diagnostic data is collected as part of the specified profile.

## -parameters

### -param partner

The name of the partner associated with this profile.

### -param feature

The name of the feature associated with this profile.

### -param isScenarioNamespace

*true* if this profile is associated with a scenario; *false* otherwise.

### -param downloadOverCostedNetwork

*true* to download settings even if the device only has access to a costed network connection; *false* otherwise.

### -param downloadOverBattery

*true* to download the settings even if the device is running on battery; *false*, otherwise.

## -returns

The result of trying to download the settings.

