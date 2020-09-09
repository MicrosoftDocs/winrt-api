---
-api-id: P:Windows.Foundation.Diagnostics.LoggingOptions.Opcode
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Diagnostics.LoggingOpcode Opcode { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingOptions.Opcode

## -description
Gets or sets the operation code value for an event.

## -property-value
The operation code.

## -remarks
This value corresponds to the Event Tracing for Windows (ETW) definition of an opcode. Most events should use the **Info** opcode.

The [LoggingActivity](loggingactivity.md) class will generate events with the **Opcode** set to **Start** and **Stop**.

## -examples

## -see-also
[LoggingOpcode enumeration](loggingopcode.md), [Defining Tasks and Opcodes](/windows/desktop/WES/defining-tasks-and-opcodes)
