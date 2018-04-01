---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionMessageChannel 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel

## -description
Handles a dedicated data transfer channel within a remote session. This class owns the functionality for both sending and receiving.

## -remarks
Messages are sent and received over this channel asynchronously, so the chronological ordering of messages is not guaranteed.

Uses a hub and spoke model for sending messages: any message a client sends to a participant or a list of participants or all participants is internally sent to the host first, which then sends it to the target participants.

## -see-also

## -examples


## -capabilities
remoteSystem
