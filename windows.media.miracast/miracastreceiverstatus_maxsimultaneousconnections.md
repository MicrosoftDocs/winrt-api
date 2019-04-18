---
-api-id: P:Windows.Media.Miracast.MiracastReceiverStatus.MaxSimultaneousConnections
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public int MaxSimultaneousConnections { get; }
-->

# Windows.Media.Miracast.MiracastReceiverStatus.MaxSimultaneousConnections

## -description

Specifies the maximum number of simultaneous connections that the Miracast Receiver can handle.

## -property-value

The maximum number of simultaneous connections that the Miracast Receiver can handle.

## -remarks

The value of this property is hardware-dependent.
If the property value is greater than 1, use to [MiracastReceiverSession.MaxSimultaneousConnections](miracastreceiversession_maxsimultaneousconnections.md) to control the maximum number of simultaneous connections for a given MiracastReceiverSession.

## -see-also

## -examples

