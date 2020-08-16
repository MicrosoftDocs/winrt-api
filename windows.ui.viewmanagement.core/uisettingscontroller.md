---
-api-id: T:Windows.UI.ViewManagement.Core.UISettingsController
-api-type: winrt class
---

<!-- Class syntax.
public class UISettingsController 
-->

# Windows.UI.ViewManagement.Core.UISettingsController

## -description

Provides access to the **Ease of Access** display settings (Settings -> Ease of Access -> Display).

## -remarks

This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list.

Add the following to the Package.appmanifest:

- To `<Package>`
  - `IgnorableNamespaces="iot"`
- Under `<Capabilities>`
  - `<iot:Capability Name="systemManagement"/>`

## -see-also

## -examples
