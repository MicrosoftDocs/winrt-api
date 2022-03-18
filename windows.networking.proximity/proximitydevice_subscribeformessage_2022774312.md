---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.SubscribeForMessage(System.String,Windows.Networking.Proximity.MessageReceivedHandler)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public long SubscribeForMessage(System.String messageType, Windows.Networking.Proximity.MessageReceivedHandler messageReceivedHandler)
-->

# Windows.Networking.Proximity.ProximityDevice.SubscribeForMessage

## -description
Creates a subscription for a specified message type.

## -parameters
### -param messageType
The type of message to deliver to this subscription.

### -param messageReceivedHandler
The handler that the proximity provider will call when it delivers a message.

## -returns
A unique ID for the subscription.

## -remarks
After your app calls the SubscribeForMessage method, it will receive messages that are published with the same message type (as indicated by the *messageType* parameter) from any proximate devices. For details on the different message types, see the remarks in the [PublishBinaryMessage(String, IBuffer)](proximitydevice_publishbinarymessage_285088637.md) reference topic.

You can cancel a subscription by passing the subscription ID that's returned by the SubscribeForMessage method to the [StopSubscribingForMessage](proximitydevice_stopsubscribingformessage_728466472.md) method.

You can publish a message to a subscriber by using the [PublishMessage](proximitydevice_publishmessage_1881696512.md), [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md), or [PublishUriMessage](proximitydevice_publishurimessage_632953271.md) method.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
