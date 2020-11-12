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
The DataAsString property is available only if the binary data of the message contains only text (UTF8) characters. Otherwise, the DataAsString property returns unpredictable results. You should not attempt to use the DataAsString property unless you are certain the data was received as UTF8 encoded characters. You can send a message as UTF8 encoded characters using the [PublishMessage](proximitydevice_publishmessage_1881696512.md) method.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
