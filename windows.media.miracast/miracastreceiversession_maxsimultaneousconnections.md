---
-api-id: P:Windows.Media.Miracast.MiracastReceiverSession.MaxSimultaneousConnections
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public int MaxSimultaneousConnections { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverSession.MaxSimultaneousConnections

## -description

Specifies the maximum number of simultaneous connections that the app is willing to handle on the [MiracastReceiverSession](miracastreceiversession.md).

## -property-value

The maximum number of simultaneous connections that the app is willing to handle on the MiracastReceiverSession.

## -remarks

The app must set this property before invoking the [MiracastReceiverSession.Start](miracastreceiversession_start_1587696324.md) or [MiracastReceiverSession.StartAsync](miracastreceiversession_startasync_1931900819.md) method in order for the setting to take effect.

Not all Wi-Fi hardware supports multiple simultaneous connections. Use [MiracastReceiverStatus.MaxSimultaneousConnections](miracastreceiverstatus_maxsimultaneousconnections.md) to determine the maximum number of simultaneous connections supported by Wi-Fi.

## -see-also

[MiracastReceiverSession](miracastreceiversession.md)

## -examples

