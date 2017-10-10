---
-api-id: P:Windows.Networking.Proximity.ProximityMessage.DataAsString
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DataAsString { get; }
-->

# Windows.Networking.Proximity.ProximityMessage.DataAsString

## -description
Gets the message data as text.

## -property-value
The message data as text.

## -remarks
The [DataAsString](proximitymessage_dataasstring.md) property is available only if the binary data of the message contains only text (UTF8) characters. Otherwise, the [DataAsString](proximitymessage_dataasstring.md) property returns unpredictable results. You should not attempt to use the [DataAsString](proximitymessage_dataasstring.md) property unless you are certain the data was received as UTF8 encoded characters. You can send a message as UTF8 encoded characters using the [PublishMessage](proximitydevice_publishmessage.md) method.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-js[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
