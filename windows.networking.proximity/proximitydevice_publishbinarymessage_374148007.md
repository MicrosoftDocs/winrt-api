---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.PublishBinaryMessage(System.String,Windows.Storage.Streams.IBuffer,Windows.Networking.Proximity.MessageTransmittedHandler)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public long PublishBinaryMessage(System.String messageType, Windows.Storage.Streams.IBuffer message, Windows.Networking.Proximity.MessageTransmittedHandler messageTransmittedHandler)
-->

# Windows.Networking.Proximity.ProximityDevice.PublishBinaryMessage

## -description
Publishes a message that contains binary data to subscribers of the specified message type. The specified handler is called when the message has been transmitted.

## -parameters
### -param messageType
The type of message to deliver to subscribers.

### -param message
The binary message data to deliver to subscribers.

### -param messageTransmittedHandler
The handler to call when the message has been transmitted.

## -returns
A unique publication ID for the published message.

## -remarks
You can publish multiple messages of the same message type and each publication will have a unique ID associated with it.

You can stop publishing a message by passing the publication ID returned by the [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md) method to the [StopPublishingMessage](proximitydevice_stoppublishingmessage_1046474884.md) method.

Messages continue to be published until the [StopPublishingMessage](proximitydevice_stoppublishingmessage_1046474884.md) method is called or the [ProximityDevice](proximitydevice.md) is released.

You can subscribe to published messages using the [SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md) method.

You can use the [PublishMessage](proximitydevice_publishmessage_1881696512.md) method to publish a text message to a proximate computer. You can use the [PublishUriMessage](proximitydevice_publishurimessage_632953271.md) method to publish a Uniform Resource Identifier (URI) to a proximate computer.

> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

<!--Changing the content of this topic to try to force a snippet rebuild, for a code change for TFS 2412443-->

### Message Types

For details on the types of messages that you can publish with the [PublishBinaryMessage(String, IBuffer, MessageTransmittedHandler) method, see the remarks in the [PublishBinaryMessage(String, IBuffer)](proximitydevice_publishbinarymessage_285088637.md) topic.

## -examples

[!code-csharp[LaunchAppWriteTag1](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/csharp/MainPage.xaml.cs#SnippetLaunchAppWriteTag1)]

[!code-vb[LaunchAppWriteTag1](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/vbnet/MainPage.xaml.vb#SnippetLaunchAppWriteTag1)]

## -see-also
[PublishBinaryMessage(String, IBuffer)](proximitydevice_publishbinarymessage_285088637.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
