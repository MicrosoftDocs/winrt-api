---
-api-id: M:Windows.UI.ViewManagement.Core.UISettingsController.RequestDefaultAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<UISettingsController> UISettingsController.RequestDefaultAsync()
-->

# Windows.UI.ViewManagement.Core.UISettingsController.RequestDefaultAsync

## -description

Retrieves the default [UISettingsController](uisettingscontroller.md) with access to the **Accessibility** visual effects settings (Settings -> Accessibility -> Visual effects).

## -returns

An asynchronous operation that completes with a [UISettingsController](uisettingscontroller.md).

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

[ViewManagement.UISettingsAnimationsEnabledChangedEventArgs](../windows.ui.viewmanagement/uisettingsanimationsenabledchangedeventargs.md), [ViewManagement.UISettingsMessageDurationChangedEventArgs](../windows.ui.viewmanagement/uisettingsmessagedurationchangedeventargs.md)

## -examples
