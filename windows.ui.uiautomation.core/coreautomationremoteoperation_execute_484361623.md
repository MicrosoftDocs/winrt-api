---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.Execute(System.Byte[])
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.Execute(System.Byte[])

<!--
public Windows.UI.UIAutomation.Core.AutomationRemoteOperationResult Execute (byte[] bytecodeBuffer);
-->

## -description

Executes a [CoreAutomationRemoteOperation](coreautomationremoteoperation.md) on a virtual machine.

## -parameters

### -param bytecodeBuffer

A 32-bit unsigned integer (little-endian) representing a bytecode version, followed by a stream of bytecode instructions.

## -returns

The execution results (status and remote objects) of the [CoreAutomationRemoteOperation](coreautomationremoteoperation.md).

## -remarks

This method performs a blocking cross-process call. Do not call from UI or STA threads, as no messages will be pumped while waiting for the response.

If the operation evaluation encounters a failure at any time, objects that were computed (and were in operand registers requested by the client) will be available in the [AutomationRemoteOperationResult](automationremoteoperationresult.md) object.

Do not attempt to execute a remote operation that isn't bound to a process through [ImportElement](coreautomationremoteoperation_importelement_715571657.md) or [ImportTextRange](coreautomationremoteoperation_importtextrange_726237623.md).

## -see-also

## -examples
