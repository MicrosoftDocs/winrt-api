---
-api-id: P:Windows.Networking.Proximity.ProximityMessage.MessageType
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string MessageType { get; }
-->

# Windows.Networking.Proximity.ProximityMessage.MessageType

## -description
Gets the type of the message.

## -property-value
The type of the message.

## -remarks
Messages are delivered to all applications that have subscribed to the message type (as indicated by the *messageType* parameter). Message type values are case-sensitive strings that consist of two parts: the *protocol* and the subtype. The *protocol* is first, followed by a dot (.) and then the *subtype*. For the [PublishMessage](proximitydevice_publishmessage_1881696512.md) method, the *protocol* must always be "Windows.". The *subtype* is a string of alphanumeric characters and the following additional characters: **. ( ) + , - : = @ ; $ _ ! * ’**. The *subtype* cannot exceed a length of 250 characters.

## -examples

## -see-also
[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone]
