---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel.SendValueSetAsync(Windows.Foundation.Collections.ValueSet,Windows.System.RemoteSystems.RemoteSystemSessionParticipant)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> RemoteSystemSessionMessageChannel.SendValueSetAsync(ValueSet messageData, RemoteSystemSessionParticipant participant)
-->

# Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel.SendValueSetAsync

## -description
Sends a message to a participant in this remote session messaging channel.

## -parameters

### -param messageData
A [ValueSet](/uwp/api/Windows.Foundation.Collections.ValueSet) object containing the data to be sent to the specified participant.

### -param participant
A [RemoteSystemSessionParticipant](RemoteSystemSessionParticipant.md) object corresponding to the participant to which the message should be sent.

## -returns
An asynchronous operation containing a boolean value: **true** if the send operation was a success, otherwise **false**.

## -remarks

## -see-also

## -examples


## -capabilities
remoteSystem
