---
-api-id: M:Windows.UI.ViewManagement.Core.UISettingsController.SetAdvancedEffectsEnabled(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public void UISettingsController.SetAdvancedEffectsEnabled(Boolean value)
-->

# Windows.UI.ViewManagement.Core.UISettingsController.SetAdvancedEffectsEnabled

## -description

Turn complex window display effects on or off through the **Accessibility** visual effects settings (Settings -> Accessibility -> Visual effects).

## -parameters

### -param value

True, if enabled. Otherwise, false.

## -remarks

> [!IMPORTANT]
> This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list.
>
> Add the following to the Package.appmanifest:
>
> - To `<Package>`
>   - `IgnorableNamespaces="iot"`
> - Under `<Capabilities>`
>   - `<iot:Capability Name="systemManagement"/>`

## -see-also

[RequestDefaultAsync](uisettingscontroller_requestdefaultasync_1291358283.md), [ViewManagement.UISettingsAnimationsEnabledChangedEventArgs](../windows.ui.viewmanagement/uisettingsanimationsenabledchangedeventargs.md), [ViewManagement.UISettingsMessageDurationChangedEventArgs](../windows.ui.viewmanagement/uisettingsmessagedurationchangedeventargs.md)

## -examples
