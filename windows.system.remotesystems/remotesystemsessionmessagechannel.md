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

Messages are delivered through a hub and spoke model: any message that a client sends to a participant or a set of participants is internally sent to the host device first, which then sends it to the target participant or participants.

## -see-also

## -examples


## -capabilities
remoteSystem
