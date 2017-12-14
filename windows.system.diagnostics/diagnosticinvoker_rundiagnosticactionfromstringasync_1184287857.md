---
-api-id: M:Windows.System.Diagnostics.DiagnosticInvoker.RunDiagnosticActionFromStringAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<DiagnosticActionState> DiagnosticInvoker.RunDiagnosticActionFromStringAsync(String context)
-->

# Windows.System.Diagnostics.DiagnosticInvoker.RunDiagnosticActionFromStringAsync

## -description
Asynchronously runs the diagnostics invoker with the specified diagnostics context.

## -parameters
### -param context
A string containing the context for the diagnostics action.

## -returns
Returns an async operation object that indicates when the action has completed. A [DiagnosticActionState](diagnosticactionstate.md) enum value is in the result.

## -remarks
Converts the _context_ string to a JsonObject, then passes it in a call to [RunDiagnosticActionAsync](diagnosticinvoker_rundiagnosticactionasync_1910164149.md).

## -see-also

## -examples

