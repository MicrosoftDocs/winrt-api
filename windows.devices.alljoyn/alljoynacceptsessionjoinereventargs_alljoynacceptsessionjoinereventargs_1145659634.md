---
-api-id: M:Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.#ctor(System.String,System.UInt16,Windows.Devices.AllJoyn.AllJoynTrafficType,System.Byte,Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoiner)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public AllJoynAcceptSessionJoinerEventArgs(System.String uniqueName, System.UInt16 sessionPort, Windows.Devices.AllJoyn.AllJoynTrafficType trafficType, System.Byte proximity, Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoiner acceptSessionJoiner)
-->

# Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.AllJoynAcceptSessionJoinerEventArgs

## -description
Generates an object containing information about the connection being accepted to the session and the method that completes the session join.

## -parameters
### -param uniqueName
The unique bus name.

### -param sessionPort
The session port used for the connection.

### -param trafficType
The type of traffic provided over the connection.

### -param proximity
Indicates network proximity.

### -param acceptSessionJoiner
The [IAllJoynAcceptSessionJoiner](ialljoynacceptsessionjoiner.md) object used to complete the session join.

## -remarks

## -examples

## -see-also


## -capabilities
allJoyn