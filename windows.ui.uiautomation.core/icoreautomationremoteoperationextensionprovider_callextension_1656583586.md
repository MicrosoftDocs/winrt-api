---
-api-id: M:Windows.UI.UIAutomation.Core.ICoreAutomationRemoteOperationExtensionProvider.CallExtension(System.Guid,Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperationContext,Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId[])
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.ICoreAutomationRemoteOperationExtensionProvider.CallExtension(System.Guid,Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperationContext,Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId[])

<!--
public void CallExtension (Guid extensionId, Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperationContext context, Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId[] operandIds);
-->

## -description

Implemented by a UI Automation (UIA) provider to inform the remote operation user which extension IDs this method supports.

## -parameters

### -param extensionId

The unique identifier of the extension.

### -param context

The execution context of the UIA provider extension.

### -param operandIds

The operands required by the extension.

## -remarks

Before calling this method, confirm that the extension is supported with [IsExtensionSupported(System.Guid)](icoreautomationremoteoperationextensionprovider_isextensionsupported_942618684.md).

## -see-also

## -examples
