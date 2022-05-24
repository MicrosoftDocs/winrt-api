---
-api-id: P:Windows.UI.UIAutomation.Core.AutomationRemoteOperationResult.ErrorLocation
-api-type: winrt property
---

# Windows.UI.UIAutomation.Core.AutomationRemoteOperationResult.ErrorLocation

<!--
public int ErrorLocation { get; }
-->

## -description

Gets an reference to the instruction in the bytecode stream where the remote operation [Status](automationremoteoperationresult_status.md) does not return [Success](automationremoteoperationstatus.md).

## -property-value

## -remarks

ErrorLocation specifies the number of the malformed instruction if the remote operation [Status](automationremoteoperationresult_status.md) returns [MalformedBytecode](automationremoteoperationstatus.md). For example, if the very first instruction contains an invalid opcode, this property returns a value of 0. If the first 5 instructions have valid opcodes and parameters, but the 6th one doesn’t, this property returns a value of 5.

For [UnhandledException](automationremoteoperationstatus.md), this property returns the index of the instruction that raised the exception.

For [InstructionLimitExceeded](automationremoteoperationstatus.md), this property returns the very next instruction to be executed after the limit.

## -see-also

## -examples
