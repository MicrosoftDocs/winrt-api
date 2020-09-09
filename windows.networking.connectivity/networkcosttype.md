---
-api-id: T:Windows.Networking.Connectivity.NetworkCostType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkCostType : int
-->

# NetworkCostType

## -description
Defines the network cost types.

## -enum-fields
### -field Unknown:0
Cost information is not available.

### -field Unrestricted:1
The connection is unlimited and has unrestricted usage charges and capacity constraints.

### -field Fixed:2
The use of this connection is unrestricted up to a specific limit.

### -field Variable:3
The connection is costed on a per-byte basis.


## -remarks
For examples of how these values are used in cost-based connection scenarios, see [Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10)).

## -examples

## -see-also
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
