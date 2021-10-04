---
-api-id: P:Windows.ApplicationModel.AppInstallerInfo.UpdateBlocksActivation
-api-type: winrt property
---

# Windows.ApplicationModel.AppInstallerInfo.UpdateBlocksActivation

<!--
public bool UpdateBlocksActivation { get; }
-->


## -description

Gets a boolean value specifying whether the deployment service will stop the user from launching the application until a pending update has been applied.

## -property-value

True if app activation is blocked by updates; otherwise, false.

## -remarks

When this property is true, on app launch the user is shown a dialog that will allow them to update or close the app. When this property is false, the user is shown a dialog that will allow them to update or launch the app. If the user launches the app, the update will be applied silently at an opportune time. 

This property is equivalent to the *UpdateBlocksActivation* attribute of the [OnLaunch](/uwp/schemas/appinstallerschema/element-onlaunch) element of the App Installer file schema.

## -see-also

## -examples


