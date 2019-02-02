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
After your app calls the [SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md) method, it will receive messages that are published with the same message type (as indicated by the *messageType* parameter) from any proximate devices. For details on the different message types, see the remarks in the [PublishBinaryMessage(String, IBuffer)](proximitydevice_publishbinarymessage_285088637.md) reference topic.

You can cancel a subscription by passing the subscription ID that's returned by the [SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md) method to the [StopSubscribingForMessage](proximitydevice_stopsubscribingformessage_728466472.md) method.

You can publish a message to a subscriber by using the [PublishMessage](proximitydevice_publishmessage_1881696512.md), [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md), or [PublishUriMessage](proximitydevice_publishurimessage_632953271.md) method.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-js[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[Proximity and Tapping (JavaScript)](https://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](https://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
