---
-api-id: M:Windows.UI.ViewManagement.Core.UISettingsController.SetTextScaleFactor(System.Double)
-api-type: winrt method
---

<!-- Method syntax.
public void UISettingsController.SetTextScaleFactor(Double value)
-->

# Windows.UI.ViewManagement.Core.UISettingsController.SetTextScaleFactor

## -description

Set the text scale factor through the **Accessibility** visual effects settings (Settings -> Accessibility -> Visual effects).

## -parameters

### -param value

The text scale factor, in percent (100-225).

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
