---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.ImportElement(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationElement)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.ImportElement(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationElement)

<!--
public void ImportElement (Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId operandId, Windows.UI.UIAutomation.AutomationElement element);
-->

## -description

Enables the ability to reference an existing UI Automation element in the context of a remote operation virtual machine.

## -parameters

### -param operandId

The ID of the operand to use in the remote operation.

### -param element

The UI Automation element to use in the remote operation.

## -remarks

Do not attempt to import objects that belong to different processes into the same remote operation. Remote operations are bound to a single process.

## -see-also

## -examples
