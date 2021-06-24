---
-api-id: T:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation
-api-type: winrt class
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation

<!--
public sealed class CoreAutomationRemoteOperation
-->

## -description

Represents an entry point for UI Automation (UIA) clients to use remote operations.

## -remarks

This class provides the ability to avoid excessive cross-process calls and reduce the overhead of cross-process communication latency.

The remote operation virtual machine accepts a 32-bit unsigned integer (little-endian) representing a bytecode version, followed by a stream of bytecode instructions.

Each bytecode instruction starts with a 32-bit opcode, with multi-byte types encoded using little-endian byte ordering.

The instruction can be followed by a set of parameters, depending on the instruction type. Parameters that refer to objects in an operand register are encoded as 32-bit (little-endian) values, with the relevant operand register referenced by ID. For non-register parameters, see the relevant instruction documentation.

The bytecode accepted by the virtual machine doesn’t expect padding between instructions (the opcode and any subsequent parameters). As such, each instruction has an associated 0-based index, depending on its location in the bytecode stream.

## -see-also

## -examples
