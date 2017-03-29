---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.StopSubscribingForMessage(System.Int64)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StopSubscribingForMessage(System.Int64 subscriptionId)
-->

# Windows.Networking.Proximity.ProximityDevice.StopSubscribingForMessage

## -description
Cancels a message subscription.

## -parameters
### -param subscriptionId
The subscription ID for the message.

## -remarks
The subscription ID for a message subscription is returned from the [SubscribeForMessage](proximitydevice_subscribeformessage.md) method.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-js[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone]
 ID_CAP_PROXIMITY [Windows Phone]
