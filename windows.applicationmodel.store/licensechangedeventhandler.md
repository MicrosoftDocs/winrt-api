---
-api-id: T:Windows.ApplicationModel.Store.LicenseChangedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void LicenseChangedEventHandler()
-->
# Windows.ApplicationModel.Store.LicenseChangedEventHandler

## -description
Represents the method that will handle the [LicenseChanged](licenseinformation_licensechanged.md) event.


## -remarks
[LicenseChanged](licenseinformation_licensechanged.md) events occur when the state of an app's license changes while the app is running. You can decide how to respond to these changes. For example, you could have the app respond immediately to the change or you could ignore it until the next time the user opens the app.

When using this event with [CurrentAppSimulator](currentappsimulator.md), this event fires when you start up. When you run using the [CurrentApp](currentapp.md) class it will only fire when there is a change in the License information.

## -examples

## -see-also