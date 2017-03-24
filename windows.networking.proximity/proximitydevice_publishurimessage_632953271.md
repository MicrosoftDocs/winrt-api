---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.PublishUriMessage(Windows.Foundation.Uri)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public long PublishUriMessage(Windows.Foundation.Uri message)
-->

# Windows.Networking.Proximity.ProximityDevice.PublishUriMessage

## -description
Publishes a Uniform Resource Identifier (URI) to a proximate device.

## -parameters
### -param message
The URI to publish.

## -returns
The publication ID of the message.

## -remarks
Only one URI can be published at a time for each proximity device.

You can stop publishing a URI by passing the publication ID returned by the [PublishUriMessage](proximitydevice_publishurimessage.md) method to the [StopPublishingMessage](proximitydevice_stoppublishingmessage.md) method.

Unlike the other publish methods for a proximity device, URI publishing is handled by the default protocol handler for the URI. A subscription to a URI message publication is not required. You can receive URI messages by registering a default handler for a URI protocol such as the HTTP protocol.

The PackageFamilyName value of the sending application is automatically sent along with the URI. If no handler is registered for the protocol of a URI, the PackageFamilyName value of the sending application is used to direct the receiving application to the application store.

You can use the [PublishMessage](proximitydevice_publishmessage.md) method to publish a text message to a proximate computer. You can use the [PublishBinaryMessage](proximitydevice_publishbinarymessage.md) method to publish non-text messages or messages that conform to the NDEF messaging standard.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples


[!code-csharp[Initialize](../windows.networking.proximity/code/Proximity_PublishUri/csharp/MainPage.xaml.cs#SnippetInitialize)]

[!code-js[Initialize](../windows.networking.proximity/code/Proximity_PublishUri/js/default.js#SnippetInitialize)]

[!code-vb[Initialize](../windows.networking.proximity/code/Proximity_PublishUri/vbnet/MainPage.xaml.vb#SnippetInitialize)]

[!code-csharp[Initialize](../windows.networking.proximity/code/Proximity_PublishUri/csharp/MainPage.xaml.cs#SnippetInitialize)]

[!code-js[Initialize](../windows.networking.proximity/code/Proximity_PublishUri/js/default.js#SnippetInitialize)]

[!code-vb[Initialize](../windows.networking.proximity/code/Proximity_PublishUri/vbnet/MainPage.xaml.vb#SnippetInitialize)]

[!code-csharp[PublishSubscribeUri](../windows.networking.proximity/code/Proximity_PublishUri/csharp/MainPage.xaml.cs#SnippetPublishSubscribeUri)]

[!code-js[PublishSubscribeUri](../windows.networking.proximity/code/Proximity_PublishUri/js/default.js#SnippetPublishSubscribeUri)]

[!code-vb[PublishSubscribeUri](../windows.networking.proximity/code/Proximity_PublishUri/vbnet/MainPage.xaml.vb#SnippetPublishSubscribeUri)]

[!code-csharp[PublishSubscribeUri](../windows.networking.proximity/code/Proximity_PublishUri/csharp/MainPage.xaml.cs#SnippetPublishSubscribeUri)]

[!code-js[PublishSubscribeUri](../windows.networking.proximity/code/Proximity_PublishUri/js/default.js#SnippetPublishSubscribeUri)]

[!code-vb[PublishSubscribeUri](../windows.networking.proximity/code/Proximity_PublishUri/vbnet/MainPage.xaml.vb#SnippetPublishSubscribeUri)]

## -see-also
[PublishUriMessage(Uri, MessageTransmittedHandler)](proximitydevice_publishurimessage_652448219.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)


## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone]
