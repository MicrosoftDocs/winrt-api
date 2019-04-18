---
-api-id: T:Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class MiracastReceiverConnectionCreatedEventArgs 
-->

# Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs

## -description

Provides data for the [MiracastReceiverSession.ConnectionCreated](miracastreceiversession_connectioncreated.md) event.

## -remarks

The new connection is considered accepted when the event handler returns, or when the deferral is completed. To reject an unwanted connection, invoke [MiracastReceiverConnection.Disconnect](miracastreceiverconnection_disconnect_1844911223.md).

## -see-also

[MiracastReceiverConnection.Disconnect](miracastreceiverconnection_disconnect_1844911223.md),
[MiracastReceiverSession.ConnectionCreated](miracastreceiversession_connectioncreated.md)

## -examples

