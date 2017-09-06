---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InjectGamepadInput(Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo)
-api-type: winrt method
---

<!-- Method syntax.
public void InputInjector.InjectGamepadInput(InjectedInputGamepadInfo input)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InjectGamepadInput

## -description
Sends programmatically generated gamepad input to the system.

## -parameters
### -param input
The gamepad input specified by [InjectedInputGamepadInfo](injectedinputgamepadinfo.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also

