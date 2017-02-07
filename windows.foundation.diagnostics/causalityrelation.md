---
-api-id: T:Windows.Foundation.Diagnostics.CausalityRelation
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.CausalityRelation : int
-->

# CausalityRelation

## -description
Tracks ways that synchronous work items may interact with asynchronous operations.

## -enum-fields
### -field AssignDelegate:0
Indicates that a synchronous work items has assigned a callback or continuation to be run by an asynchronous operation.

### -field Join:1
Indicates that a synchronous work item has satisfied part of a join asynchronous operation.

### -field Choice:2
Indicates that a synchronous work item has satisfied a choice asynchronous operation.

### -field Cancel:3
Indicates that a synchronous work item was canceled.

### -field Error:4
Indicates that a synchronous work item caused an error in an asynchronous operation.


## -remarks

## -examples

## -see-also
[CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [CausalityTraceLevel](causalitytracelevel.md)