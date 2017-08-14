---
-api-id: P:Windows.System.AppResourceGroupMemoryReport.CommitUsageLimit
-api-type: winrt property
---

<!-- Property syntax.
public ulong CommitUsageLimit { get; }
-->

# Windows.System.AppResourceGroupMemoryReport.CommitUsageLimit

## -description
Gets the limit of the amount of memory that can be committed (allocated) by this resource group.

## -property-value
The maximum amount of memory that is available for allocation.

## -remarks
The commit limit is roughly the current pagefile size + the amount of RAM - the amount of RAM allocated to non-pageable memory.

## -see-also

## -examples

## -capabilities
appDiagnostics
