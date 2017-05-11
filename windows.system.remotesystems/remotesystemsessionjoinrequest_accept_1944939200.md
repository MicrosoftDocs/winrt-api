---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemSessionJoinRequest.Accept
-api-type: winrt method
---

<!-- Method syntax.
public void RemoteSystemSessionJoinRequest.Accept()
-->

# Windows.System.RemoteSystems.RemoteSystemSessionJoinRequest.Accept

## -description
Causes the app to accept the requesting device into the remote session it is controlling.

## -remarks
When this method is called, the device in question (described by the [RemoteSystemSessionJoinRequest.Participant](RemoteSystemSessionJoinRequest_Participant.md) property) will receive back a [RemoteSystemSessionJoinResult](RemoteSystemSessionJoinResult.md) object with a reference to the remote session that it attempted to join.

## -see-also

## -examples

