---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.Contact
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.Preview.Injection.InjectedInputRectangle Contact { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo.Contact

## -description
Gets or sets the screen coordinates of the bounding box that represents the touch contact area.

## -property-value
The screen coordinates of the contact area in device-independent pixel (DIP). The default is a 0-by-0 rectangle, centered around the pointer [PixelLocation](injectedinputpointerinfo.md).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
