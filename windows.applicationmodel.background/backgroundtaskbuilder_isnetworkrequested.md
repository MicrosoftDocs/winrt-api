---
-api-id: P:Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested
-api-type: winrt property
---

<!-- Property syntax
public bool IsNetworkRequested { get;  set; }
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.IsNetworkRequested

## -description
Indicates whether the background task needs network connectivity in order to run.

Set [IsNetworkRequested](backgroundtaskbuilder_isnetworkrequested.md) to **true** to ensure that the network stays up while the background task runs. This tells the background task infrastructure to keep the network up while the task is executing, even if the device has entered Connected Standby mode (for example, when a phone's screen is turned off).

## -property-value
A value indicating whether the background task requests network connectivity.

## -remarks

## -examples

## -see-also
