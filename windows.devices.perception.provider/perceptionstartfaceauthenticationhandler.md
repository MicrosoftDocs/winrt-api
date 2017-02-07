---
-api-id: T:Windows.Devices.Perception.Provider.PerceptionStartFaceAuthenticationHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate bool PerceptionStartFaceAuthenticationHandler(Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup sender)
-->
# Windows.Devices.Perception.Provider.PerceptionStartFaceAuthenticationHandler

## -description
Invoked when a PerceptionFaceAuthenticationGroup enters Face Authentication mode.

## -parameters
### -param sender
The associated PerceptionFaceAuthenticationGroup that was registered.

## -returns
True if the group is ready to preform Face Authentication; otherwise, false.

## -remarks
All members of the PerceptionFaceAuthenticationGroup are expected to adjust any settings to fully support Face Authentication such as contrast or exposure on the device underlying the IPerceptionFrameProvider members. The handler returns whether or not all members are ready to preform Face Authentication.

If the handler returns true, all members are expected to remain in this mode until the PerceptionStopFaceAuthenticationHandler associated with the group is invoked.

If the handler returns false, the IPerceptionFrameProvider(s) isn't used for face authentication.

## -examples

## -see-also