---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.TimeOffsetInMilliseconds
-api-type: winrt property
---

<!-- Property syntax
public uint TimeOffsetInMilliseconds { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.TimeOffsetInMilliseconds

## -description
Gets or sets the baseline, or reference value, for timed input events such as a double click/tap.

## -property-value
The reference value for timed input events in milliseconds. If TimeOffsetInMilliseconds is set to 0, the current tick count is used.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
