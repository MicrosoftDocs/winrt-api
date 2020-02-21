---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.TryCreate
-api-type: winrt method
---

<!-- Method syntax.
public InputInjector InputInjector.TryCreate()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.TryCreate


## -description

Attempts to create a new instance of the [InputInjector](inputinjector.md) class.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -returns

If successful, returns a new instance of the [InputInjector](inputinjector.md) class. Otherwise, returns null.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

Use [TryCreateForAppBroadcastOnly](inputinjector_trycreateforappbroadcastonly_1904430574.md) when input injection should be restricted to the process that is actively being captured for broadcast using an [App​Broadcast​Services](https://docs.microsoft.com/uwp/api/windows.media.capture.appbroadcastservices) object.

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)

## -see-also

[Simulate user input through input injection](https://docs.microsoft.com/windows/uwp/design/input/input-injection)

