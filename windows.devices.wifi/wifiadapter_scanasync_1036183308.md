---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.ScanAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ScanAsync()
-->

# Windows.Devices.WiFi.WiFiAdapter.ScanAsync

## -description
Directs this adapter to initiate an asynchronous network scan.

## -returns
An asynchronous scan operation. On successful completion, returns a list of networks scanned by this adapter.

## -remarks
You should call this API from a foreground app. If it is called from a background task, you will see an "Access Denied" error message or a similar message.

## -examples

## -see-also
