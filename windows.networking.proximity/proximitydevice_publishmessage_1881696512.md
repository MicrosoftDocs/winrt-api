---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.PublishMessage(System.String,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public long PublishMessage(System.String messageType, System.String message)
-->

# Windows.Networking.Proximity.ProximityDevice.PublishMessage

## -description
Publishes a message to subscribers of the specified message type.

## -parameters
### -param messageType
The type of message to deliver to subscribers.

### -param message
The message to deliver to subscribers.

## -returns
A unique publication ID for the published message. Pass this value to the [StopPublishingMessage](proximitydevice_stoppublishingmessage_1046474884.md) method to stop publishing the message.

## -remarks
You can subscribe to published messages by using the [SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md) method.

Messages continue to be published until the [StopPublishingMessage](proximitydevice_stoppublishingmessage_1046474884.md) method is called or the [ProximityDevice](proximitydevice.md) object is released.

Messages are delivered to all applications that have subscribed to the message type (as indicated by the *messageType* parameter). Message type values are case-sensitive strings that consist of two parts: the *protocol* and the subtype. The *protocol* is first, followed by a dot (.) and then the *subtype*. For the PublishMessage method, the *protocol* must always be "Windows.". The *subtype* is a string of alphanumeric characters and the following additional characters: **. ( ) + , - : = @ ; $ _ ! * '**. The *subtype* cannot exceed a length of 250 characters.

To publish messages by using another message type, like "WindowsMime." or "NDEF:WriteTag", you must use the [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md) method.

You can use the [PublishUriMessage](proximitydevice_publishurimessage_632953271.md) method to publish a Uniform Resource Identifier (URI) to a proximate computer.

Messages are converted to UTF-8 characters before they're transmitted.

For UWP apps, publications and subscriptions are active only if the calling app is in the foreground.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples

[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[PublishMessage(String, String, MessageTransmittedHandler)](proximitydevice_publishmessage_1989900324.md), [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md), [PublishUriMessage](proximitydevice_publishurimessage_632953271.md), [StopPublishingMessage](proximitydevice_stoppublishingmessage_1046474884.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
