---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.VoipCallCoordinator GetDefault()
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.GetDefault

## -description
Retrieves the default instance of the [VoipCallCoordinator](voipcallcoordinator.md) class.

## -returns
The default call coordinator.

## -remarks
You can use this method to get the default instance of the [VoipCallCoordinator](voipcallcoordinator.md) class even if you do not define the required capability below. However, you will not be able to use the other methods of the [VoipCallCoordinator](voipcallcoordinator.md) object without defining the capability. The capability protects the service from running on the platform.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
