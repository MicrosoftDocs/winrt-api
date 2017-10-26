---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.PublishMessage(System.String,System.String,Windows.Networking.Proximity.MessageTransmittedHandler)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public long PublishMessage(System.String messageType, System.String message, Windows.Networking.Proximity.MessageTransmittedHandler messageTransmittedHandler)
-->

# Windows.Networking.Proximity.ProximityDevice.PublishMessage

## -description
Publishes a message to subscribers of the specified message type. The specified handler is called when the message has been transmitted.

## -parameters
### -param messageType
The type of message to deliver to subscribers.

### -param message
The message to deliver to subscribers.

### -param messageTransmittedHandler
The handler to call when the message has been transmitted.

## -returns
A unique publication ID for the published message.

## -remarks
You can subscribe to published messages by using the [SubscribeForMessage](proximitydevice_subscribeformessage.md) method.

Messages continue to be published until the [StopPublishingMessage](proximitydevice_stoppublishingmessage.md) method is called or the [ProximityDevice](proximitydevice.md) object is released.

Messages are delivered to all applications that have subscribed to the message type (as indicated by the *messageType* parameter). Message type values are case-sensitive strings that consist of two parts: the *protocol* and the subtype. The *protocol* is first, followed by a dot (.) and then the *subtype*. For the [PublishMessage](proximitydevice_publishmessage.md) method, the *protocol* must always be "Windows.". The *subtype* is a string of alphanumeric characters and the following additional characters: **. ( ) + , - : = @ ; $ _ ! * ’**. The *subtype* cannot exceed a length of 250 characters.

To publish messages by using another message type, like “WindowsMime.” or “NDEF:WriteTag”, you must use the [PublishBinaryMessage](proximitydevice_publishbinarymessage.md) method.

You can use the [PublishUriMessage](proximitydevice_publishurimessage.md) method to publish a Uniform Resource Identifier (URI) to a proximate computer.

Messages are converted to UTF-8 characters before they're transmitted.

For UWP apps, publications and subscriptions are active only if the calling app is in the foreground.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples


[!code-csharp[PublishSubscribe2](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe2)]

[!code-js[PublishSubscribe2](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetPublishSubscribe2)]

[!code-vb[PublishSubscribe2](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe2)]

## -see-also
[PublishMessage(String, String)](proximitydevice_publishmessage_1881696512.md), [PublishBinaryMessage](proximitydevice_publishbinarymessage.md), [PublishUriMessage](proximitydevice_publishurimessage.md), [StopPublishingMessage](proximitydevice_stoppublishingmessage.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
