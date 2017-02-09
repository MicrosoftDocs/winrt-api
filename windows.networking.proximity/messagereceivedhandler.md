---
-api-id: T:Windows.Networking.Proximity.MessageReceivedHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void MessageReceivedHandler(Windows.Networking.Proximity.ProximityDevice sender, Windows.Networking.Proximity.ProximityMessage message)
-->
# Windows.Networking.Proximity.MessageReceivedHandler

## -description
Describes the method that will handle the event <?xm-insertion_mark_start author="v-shawja" time="20120125T143507-0800"?> that's fired<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120125T143509-0800" data="raised"?> when a message that has been subscribed to has been received.

## -parameters
### -param sender
The proximity device that received the message.

### -param message
The message and related data <?xm-insertion_mark_start author="v-shawja" time="20120125T144049-0800"?> that were <?xm-insertion_mark_end?> passed to the event handler.


## -remarks


## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-js[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[SubscribeForMessage](proximitydevice_subscribeformessage.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone]
