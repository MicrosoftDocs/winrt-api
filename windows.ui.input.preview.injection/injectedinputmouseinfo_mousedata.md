---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.MouseData
-api-type: winrt property
---

<!-- Property syntax
public uint MouseData { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.MouseData

## -description

Gets or sets a value used by other properties (see [MouseOptions](injectedinputmouseinfo_mouseoptions.md)).

## -property-value

The value used by other properties.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) to be declared in the application manifest. For more information on app capability requirements, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

To use the input injection APIs, open the Package.appxmanifest file and add the following (the `rescap` namespace hosts the restricted capabilities, whuch lets you declare the `inputInjectionBrokered` capability in the `Capabilities` section).

- To `<Package>`
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities" IgnorableNamespaces="rescap"`
- In `<Capabilities>`
  - `<rescap:Capability Name="inputInjectionBrokered" />`

The value being set is dependent on the [MouseOptions](injectedinputmouseinfo_mouseoptions.md) flags specified. Some examples include:

- [HWheel](injectedinputmouseinfo_mousedata.md): the distance that a mouse wheel has rotated around the x-axis (horizontal). The mouse wheel button has discrete, evenly spaced notches or distance thresholds (also called detents). When you rotate or tilt the wheel, a wheel message is sent as each detent is encountered.

The windows constant, WHEEL_DELTA (defined as a value of 120), describes one detent. Each detent marks the threshold for a single increment of an associated action (for example, scrolling a line or page).

> [!NOTE]
> The delta was set to 120 to enable finer-resolution wheels (such as freely-rotating wheels with no notches) that send more messages per rotation, but with smaller values per message.

A positive value indicates that the wheel was rotated forward (away from the user) or tilted to the right; a negative value indicates that the wheel was rotated backward (toward the user) or tilted to the left.

> [!NOTE]
> [MouseData](injectedinputmouseinfo_mousedata.md) is of type `uint`, which doesn't support negative values. You must use an unchecked block or use a temporary local variable (see [InjectedInputMouseInfo](injectedinputmouseinfo.md) for an example).

- [XDown](injectedinputmouseinfo_mousedata.md) or [XUp](injectedinputmouseinfo_mousedata.md): 1 for XBUTTON1 or 2 for XBUTTON2XBUTTON1 and XBUTTON2 are additional buttons used on many mouse devices, often for forward and backward navigation in Web browsers. They return the same data as standard mouse buttons.

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[Simulate user input through input injection](/windows/uwp/design/input/input-injection)
