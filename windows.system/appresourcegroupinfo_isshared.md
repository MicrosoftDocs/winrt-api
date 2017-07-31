---
-api-id: P:Windows.System.AppResourceGroupInfo.IsShared
-api-type: winrt property
---

<!-- Property syntax.
public bool IsShared { get; }
-->

# Windows.System.AppResourceGroupInfo.IsShared

## -description
Indicates whether the group is part of a shared resource group. Being part of a shared resource group indicates that there are multiple apps in the package and that they share a common component.

## -property-value
**True** means the group is part of a shared resource group; **false**, otherwise.

## -remarks
When a resource group is shared, it will show up in the resource group collections reported by multiple apps if those apps that share this resource group are currently running.

## -see-also

## -examples

## -capabilities
appDiagnostics
