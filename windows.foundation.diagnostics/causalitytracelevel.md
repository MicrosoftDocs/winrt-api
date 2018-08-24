---
-api-id: T:Windows.Foundation.Diagnostics.CausalityTraceLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.CausalityTraceLevel : int
-->

# CausalityTraceLevel

## -description
Specifies a logging level that listeners can use for trace filtering.

## -enum-fields
### -field Required:0
Indicates all operations that are necessary to construct a causality chain, including all operations for job creation and completion and work item creation and completion.

### -field Important:1
Tracks operations that are not necessary to construct a causality chain but are interesting for developers.

### -field Verbose:2
Indicates operations that influence causality but are likely to be less interesting for developers, including actions like registering progress delegates.


## -remarks

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [TraceOperationCreation](asynccausalitytracer_traceoperationcreation_1939304732.md)