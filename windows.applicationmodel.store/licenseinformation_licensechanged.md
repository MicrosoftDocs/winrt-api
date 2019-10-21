---
-api-id: E:Windows.ApplicationModel.Store.LicenseInformation.LicenseChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.ApplicationModel.Store.LicenseChangedEventHandler LicenseChanged
-->

# Windows.ApplicationModel.Store.LicenseInformation.LicenseChanged

## -description
Raises a notification event when the status of the app's license changes.

## -remarks
LicenseChanged events aren't always immediate. If you’ve registered for the event, the event should fire within an hour; if not, it should occur within 6 hours. Generally, it's recommended to wait up to 6 hours when testing with [CurrentApp](currentapp.md), knowing that it will most likely take less time if the app has registered the event.

### Windows Phone 8

This event is not raised on Windows Phone 8.

## -examples

## -see-also
