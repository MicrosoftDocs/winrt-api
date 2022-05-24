---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.ImportTextRange(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationTextRange)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.ImportTextRange(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationTextRange)

<!--
public void ImportTextRange (Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId operandId, Windows.UI.UIAutomation.AutomationTextRange textRange);
-->

## -description

Enables the ability to reference an existing text range in the context of a remote operation virtual machine.

## -parameters

### -param operandId

The ID of the operand to use in the remote operation.

### -param textRange

The UI Automation text range to use in the remote operation.

## -remarks

Do not attempt to import objects that belong to different processes into the same remote operation. Remote operations are bound to a single process.

## -see-also

## -examples
