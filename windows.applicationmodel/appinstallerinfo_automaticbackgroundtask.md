---
-api-id: P:Windows.ApplicationModel.AppInstallerInfo.AutomaticBackgroundTask
-api-type: winrt property
---

# Windows.ApplicationModel.AppInstallerInfo.AutomaticBackgroundTask

<!--
public bool AutomaticBackgroundTask { get; }
-->

## -description

Gets a boolean value indicating whether the deployment service checks for app updates in the background.

## -property-value

True if automatic background check is enabled; otherwise, false.

## -remarks

When this value is true, a check for updates is made every 8 hours independently of whether the user launched the app.  This type of update cannot show UI.

This property is equivalent to the [AutomaticBackgroundTask](/uwp/schemas/appinstallerschema/element-s4-automaticbackgroundtask) element of the App Installer file schema.

## -see-also

## -examples
