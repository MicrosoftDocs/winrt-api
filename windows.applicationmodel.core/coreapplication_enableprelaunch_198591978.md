---
-api-id: M:Windows.ApplicationModel.Core.CoreApplication.EnablePrelaunch(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void EnablePrelaunch(System.Boolean value)
-->

# Windows.ApplicationModel.Core.CoreApplication.EnablePrelaunch

## -description
Enable or disable the operating system's ability to prelaunch your app.

## -parameters
### -param value
**True** to enable prelaunch for your app; **false**, otherwise.

## -remarks
When available system resources allow, the startup performance of Windows Store apps is improved by proactively launching the user’s most frequently used Windows Store apps in the background. A prelaunched app is put into the suspended state shortly after it is launched. When the user invokes the app, the app is resumed by bringing it from the suspended state to the running state--which is faster than launching the app cold.

Windows 10 automatically prelaunched Windows Store apps. In Windows 10, version 1607, Windows Store apps must opt-in to be prelaunched. You will typically make this call during the first run of your app although you may call the function multiple times and with different values without harm.

## -examples

## -see-also
