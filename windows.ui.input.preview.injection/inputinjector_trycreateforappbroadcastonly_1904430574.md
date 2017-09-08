---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.TryCreateForAppBroadcastOnly
-api-type: winrt method
---

<!-- Method syntax.
public InputInjector InputInjector.TryCreateForAppBroadcastOnly()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.TryCreateForAppBroadcastOnly

## -description
Attempts to create a new instance of the [InputInjector](inputinjector.md) class. 

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -returns
If successful, returns a new instance of the [InputInjector](inputinjector.md) class. Otherwise, returns null.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

This method differs from [TryCreate](inputinjector_trycreate_508033141.md) in that input injection is restricted to the process that is actively being captured for broadcast using an [App​Broadcast​Services](https://docs.microsoft.com/uwp/api/windows.media.capture.appbroadcastservices) object. Injected input is silently dropped when there is no such active process.


## -see-also

## -examples

