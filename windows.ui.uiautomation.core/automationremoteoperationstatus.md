---
-api-id: T:Windows.UI.UIAutomation.Core.AutomationRemoteOperationStatus
-api-type: winrt enum
---

# Windows.UI.UIAutomation.Core.AutomationRemoteOperationStatus

<!--
public enum AutomationRemoteOperationStatus
-->

## -description

Specifies the possible execution states of a [CoreAutomationRemoteOperation](coreautomationremoteoperation.md).

## -enum-fields

### -field ExecutionFailure

A generic execution failure.

Use the [AutomationRemoteOperationResult.ExtendedError](automationremoteoperationresult_extendederror.md) property to get additional information and diagnostics. For example, ExtendedError is set to UIA_E_TIMEOUT if the the target application is unresponsive and the operation times out.

### -field InstructionLimitExceeded

The operation exceeded the instruction limit imposed by the remote operation virtual machine.

A remote operation must not execute for so long that it takes over the UI thread of an application (UI Automation provider).

### -field MalformedBytecode

The bytecode specified in the [Execute](coreautomationremoteoperation_execute_484361623.md) method was malformed.

For example, the bytecode stream might contain fewer bytes than expected depending on the instruction opcodes parsed.

### -field Success

The operation completed successfully.

### -field UnhandledException

A single instruction in the remote operation failed and was not handled in a try-block.

For example, if a UI Automation provider returns an error such as UIA_E_ELEMENTNOTAVAILABLE, the instruction fails and, if left unhandled, an instruction evaluation failure occurs. Use the [AutomationRemoteOperationResult.ExtendedError](automationremoteoperationresult_extendederror.md) property to get additional information and diagnostics for the error that caused the failure.

## -remarks

## -see-also

[AutomationRemoteOperationResult.Status](automationremoteoperationresult_status.md), [AutomationRemoteOperationResult.ErrorLocation](automationremoteoperationresult_errorlocation.md) [CoreAutomationRemoteOperation](coreautomationremoteoperation.md)

## -examples
