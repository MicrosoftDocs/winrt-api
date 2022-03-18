---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel.SendValueSetToParticipantsAsync(Windows.Foundation.Collections.ValueSet,Windows.Foundation.Collections.IIterable{Windows.System.RemoteSystems.RemoteSystemSessionParticipant})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> RemoteSystemSessionMessageChannel.SendValueSetToParticipantsAsync(ValueSet messageData, IIterable<RemoteSystemSessionParticipant> participants)
-->

# Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel.SendValueSetToParticipantsAsync

## -description
Sends a message to a specified set participants in this remote session messaging channel.

## -parameters

### -param messageData
A [ValueSet](/uwp/api/Windows.Foundation.Collections.ValueSet) object containing the data to be sent to the specified participants.

### -param participants
An iterable collection of [RemoteSystemSessionParticipant](RemoteSystemSessionParticipant.md) objects corresponding to the participants to which the message should be sent.

## -returns
An asynchronous operation containing a boolean value: **true** if the send operation was a success, otherwise **false**.

## -remarks

## -see-also

## -examples


## -capabilities
remoteSystem
