---
-api-id: T:Windows.UI.ViewManagement.Core.UISettingsController
-api-type: winrt class
---

<!-- Class syntax.
public class UISettingsController 
-->

# Windows.UI.ViewManagement.Core.UISettingsController

## -description

Provides access to the **Accessibility** visual effects settings (Settings -> Accessibility -> Visual effects).

## -remarks

The settings include persistent scrollbars, transparency effects, animation effects, and notification duration.

:::image type="content" source="images/accessibility-display-settings.png" alt-text="Screenshot of the Accessibility Visual effects settings dialog.":::

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
