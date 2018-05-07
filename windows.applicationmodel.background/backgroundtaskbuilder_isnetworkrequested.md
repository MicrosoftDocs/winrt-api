---
-api-id: P:Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested
-api-type: winrt property
---

<!-- Property syntax
public bool IsNetworkRequested { get;  set; }
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested

## -description
Indicates whether to keep the network up while running the background task.

## -property-value
`True`: ensure that the network is up while running the background task. `False`, otherwise.

## -remarks
This property is applicable to desktops computers on which disconnected standby is implemented. Setting this property to `true` keeps the network up while the background task is executing, even if the device has entered Connected Standby mode.

## -examples

## -see-also
