---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.IsOpcodeSupported(System.UInt32)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.IsOpcodeSupported(System.UInt32)

<!--
public bool IsOpcodeSupported (uint opcode);
-->

## -description

Retrieves a value that indicates whether the specified opcode is supported by the [CoreAutomationRemoteOperation](coreautomationremoteoperation.md) virtual machine.

## -parameters

### -param opcode

The opcode being tested.

## -returns

## -remarks

Passing unsupported opcodes in the bytecode to the [Execute)](coreautomationremoteoperation_execute_484361623.md) method results in a [AutomationRemoteOperationResult.Status](automationremoteoperationresult_status.md) of [MalformedByteCode](automationremoteoperationstatus.md).

> [!NOTE]
> As the Remote Operations virtual machine is found in the provider process, support for an instruction depends on the provider process that executes the remote operation. Therefore, call this method after the operation is bound to a process through [ImportElement](coreautomationremoteoperation_importelement_715571657.md) or [ImportTextRange](coreautomationremoteoperation_importtextrange_726237623.md).

## -see-also

## -examples
