---
-api-id: M:Windows.Devices.Radios.Radio.GetDeviceSelector
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.Radios.Radio.GetDeviceSelector

## -description
Returns an Advanced Query Syntax (AQS) string used to enumerate or monitor [Radio](radio.md) devices via
[DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) and related
enumeration APIs.

## -returns
An AQS device selector string for enumerating radio devices.

## -remarks
### Relationship to GetRadiosAsync
The selector produces the same set of radios that [GetRadiosAsync](radio_getradiosasync_548754145.md) returns at call time.

Use the selector when you need to:
- Combine radio enumeration with other device filters in a single query.
- Receive device arrival/removal events through standard device watcher patterns.
- Defer enumeration until a watcher signals changes.

### Usage pattern (C#)
```csharp
using Windows.Devices.Enumeration;
using Windows.Devices.Radios;

string selector = Radio.GetDeviceSelector();
var radios = await DeviceInformation.FindAllAsync(selector);
// App-specific: project DeviceInformation.Id values back to Radio via FromIdAsync if needed
```

> [!NOTE]
> The device selector is static; re-run the query to obtain updated results after hardware changes.

## -examples

## -see-also
[DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md),
[Radio](radio.md),
[Radio.FromIdAsync](radio_fromidasync_1322863552.md),
[Radio.GetRadiosAsync](radio_getradiosasync_548754145.md),
[Radio.StateChanged](radio_statechanged.md)
