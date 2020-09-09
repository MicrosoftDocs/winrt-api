---
-api-id: P:Windows.Foundation.Diagnostics.LoggingOptions.Task
-api-type: winrt property
---

<!-- Property syntax
public short Task { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingOptions.Task

## -description
Gets or sets the user-defined value that identifies a larger unit of work within an application or component.

## -property-value
The task value.

## -remarks
This value corresponds to the Event Tracing for Windows (ETW) definition of a task. It is a user-defined value. A task is a larger unit of work within an application or component, i.e. it identifies a scope of work that is broader than an [Opcode](loggingopcode.md).

## -examples

## -see-also
[Defining Tasks and Opcodes](/windows/desktop/WES/defining-tasks-and-opcodes)
