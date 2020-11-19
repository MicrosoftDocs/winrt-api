---
-api-id: P:Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs.Socket
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Networking.Sockets.StreamSocket Socket { get; }
-->

# Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs.Socket

## -description
Gets the [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) instance for the connection.

## -property-value
The [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) instance for the connection.

## -remarks
The Socket property is null until a successful connection has been completed. When a successful connection is completed, [State](triggeredconnectionstatechangedeventargs_state.md) equals **Completed**.

## -examples


[!code-csharp[Connect](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetConnect)]

[!code-vb[Connect](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetConnect)]

## -see-also
[TriggeredConnectionStateChanged](peerfinder_triggeredconnectionstatechanged.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
