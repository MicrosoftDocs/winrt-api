---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferCostPolicy
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.BackgroundTransfer.BackgroundTransferCostPolicy : int
-->

# BackgroundTransferCostPolicy

## -description
Defines values used to specify whether transfers can occur on metered networks.

## -enum-fields
### -field Default:0
Allow transfers on metered networks.

### -field UnrestrictedOnly:1
Do not allow transfers on metered networks.

### -field Always:2
Always download regardless of network cost. (e.g. even while a user is roaming)

> [!NOTE]
> This behavior is based only on network cost policy, and doesn't affect other app scenarios, like system suspension.


## -remarks

## -examples

## -see-also