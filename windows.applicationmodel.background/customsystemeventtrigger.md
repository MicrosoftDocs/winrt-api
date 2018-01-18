---
-api-id: T:Windows.ApplicationModel.Background.CustomSystemEventTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class CustomSystemEventTrigger : IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.CustomSystemEventTrigger

## -description
This class allows you to specify a custom system trigger so that you can register it and respond when it is triggered by the system.

## -remarks
Use this class to define a trigger when the OS doesn't provide a system trigger that you need. Such as when a hardware driver and the UWP app both belong to 3rd party, and the hardware driver needs to raise a custom event that its app handles. For example, an audio card that needs to notify a user when an audio jack is plugged in.

## -see-also

## -examples
