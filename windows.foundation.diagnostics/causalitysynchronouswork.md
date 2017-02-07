---
-api-id: T:Windows.Foundation.Diagnostics.CausalitySynchronousWork
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.CausalitySynchronousWork : int
-->

# CausalitySynchronousWork

## -description
Indicates the relationship between a work item and an asynchronous operation.

## -enum-fields
### -field CompletionNotification:0
The work item being scheduled is running due to the completion of the asynchronous operation.

### -field ProgressNotification:1
The work item being scheduled is running due to reaching a milestone within the asynchronous operation.

### -field Execution:2
The work item being scheduled is part of the actual work of the asynchronous operation, like opening a file.


## -remarks

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalityTraceLevel](causalitytracelevel.md)