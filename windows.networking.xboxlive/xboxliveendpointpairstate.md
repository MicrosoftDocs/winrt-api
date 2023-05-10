---
-api-id: T:Windows.Networking.XboxLive.XboxLiveEndpointPairState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.XboxLive.XboxLiveEndpointPairState : int
-->

# XboxLiveEndpointPairState

## -description

Defines constants that specify the status of an **XboxLiveEndpointPair** instance.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -enum-fields

### -field Invalid:0

The endpoint pair is in an invalid state.

### -field CreatingOutbound:1

The endpoint pair is being created, initiated by this device.

### -field CreatingInbound:2

The endpoint pair is being created, initiated by a remote device.

### -field Ready:3

The endpoint pair is ready to be used.

### -field DeletingLocally:4

The endpoint pair is in the process of being deleted. Deletion was initiated locally.

### -field RemoteEndpointTerminating:5

The endpoint pair is in the process of being deleted because the remote endpoint initiated deletion.

### -field Deleted:6

The endpoint pair has been deleted.

## -remarks

## -examples

## -see-also
