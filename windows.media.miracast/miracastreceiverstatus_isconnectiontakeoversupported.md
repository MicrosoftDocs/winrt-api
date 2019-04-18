---
-api-id: P:Windows.Media.Miracast.MiracastReceiverStatus.IsConnectionTakeoverSupported
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsConnectionTakeoverSupported { get; }
-->

# Windows.Media.Miracast.MiracastReceiverStatus.IsConnectionTakeoverSupported

## -description

Specifies if it is possible to let a new Miracast connection take over an in-progress Miracast connection.

## -property-value

True if it is possible to let a new Miracast connection take over an in-progress Miracast connection.

## -remarks

The value of this property is hardware-dependent.
If the property value is true, use to [MiracastReceiverSession.AllowConnectionTakeover](miracastreceiversession_allowconnectiontakeover.md) to control if connections for a given MiracastReceiverSession can be taken over.

## -see-also

[MiracastReceiverSession.AllowConnectionTakeover](miracastreceiversession_allowconnectiontakeover.md)

## -examples

