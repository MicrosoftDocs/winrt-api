---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.ImportConnectionBoundObject(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationConnectionBoundObject)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperation.ImportConnectionBoundObject(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationConnectionBoundObject)

<!--
public void ImportConnectionBoundObject (Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId operandId, Windows.UI.UIAutomation.AutomationConnectionBoundObject connectionBoundObject);
-->

## -description

Imports an [AutomationConnectionBoundObject](../windows.ui.uiautomation/automationconnectionboundobject.md) into this remote operation.

## -parameters

### -param operandId

Identifier that refers to an operand register of a [CoreAutomationRemoteOperation](coreautomationremoteoperation.md).

### -param connectionBoundObject

The connection details for a connection-bound object.

## -remarks

If the object being imported belongs to a different connection than the one already associated with the remote operation, an invalid argument error will occur.

## -see-also

## -examples
