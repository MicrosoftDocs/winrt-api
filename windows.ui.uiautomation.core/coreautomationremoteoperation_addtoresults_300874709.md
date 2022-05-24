---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.AddToResults(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.AddToResults(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId)

<!--
public void AddToResults (Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId operandId);
-->

## -description

Specifies which operand registers to return after executing the remote operation.

## -parameters

### -param operandId

The ID of the operand to return from the remote operation.

## -remarks

Use [AutomationRemoteOperationResult](automationremoteoperationresult.md) to validate and obtain the local representation.

[AutomationRemoteOperationResult.HasOperand](automationremoteoperationresult_hasoperand_151552314.md) should be used to ensure an object is returned before accessing it.

## -see-also

## -examples
