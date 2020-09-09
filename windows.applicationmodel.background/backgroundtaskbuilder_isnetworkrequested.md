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

The WinMain application components in Desktop Bridge applications may not execute code in disconnected standby or connected standby. WinMain components using [COM background tasks](/windows/uwp/launch-resume/create-and-register-a-winmain-background-task) will not observe any behavioral differences when setting this flag.

## -examples

## -see-also
