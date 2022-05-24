---
-api-id: P:Windows.Management.Deployment.AutoUpdateSettingsOptions.HoursBetweenUpdateChecks
-api-type: winrt property
---

# Windows.Management.Deployment.AutoUpdateSettingsOptions.HoursBetweenUpdateChecks

<!--
public uint HoursBetweenUpdateChecks { get; set; }
-->


## -description

Gets or sets an integer value specifying the frequency with which the the deployment service will check for an update to the App Installer file.

## -property-value

The number of hours between checks for updates.

## -remarks

When **HoursBetweenUpdateChecks** is set to 0, the deployment service will check for updates every time the application is launched. For other values, the deployment service will check for updates when the application is launched only if it hasn't previously checked within the last number of hours specified by HoursBetweenUpdateChecks. For example, if **HoursBetweenUpdateChecks** is set to 12, the deployments service will check for updates when the application is launched only if it hasn't already checked for updates in the previous 12 hours.

The allowed range for this property is 0 to 255. The default value is 24. 

This property is equivalent to the *HoursBetweenUpdateChecks* attribute of the [OnLaunch](/uwp/schemas/appinstallerschema/element-onlaunch) element of the App Installer file schema.

## -see-also

## -examples


