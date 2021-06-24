---
-api-id: M:Windows.UI.UIAutomation.Core.ICoreAutomationRemoteOperationExtensionProvider.IsExtensionSupported(System.Guid)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.ICoreAutomationRemoteOperationExtensionProvider.IsExtensionSupported(System.Guid)

<!--
public bool IsExtensionSupported (Guid extensionId);
-->

## -description

Implemented by a UIA provider to retrieve a value that indicates whether a pattern extension is supported by a UI Automation provider.

## -parameters

### -param extensionId

The unique identifier of the extension.

## -returns

True, if the extension is supported. Otherwise, false.

## -remarks

This property should return true for GUIDs that are supported by the UIA provider's implementation of [CallExtension(System.Guid,Windows.UI.UIAutomation.Core.CoreAutomationRemoteOperationContext,Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId[])].

## -see-also

## -examples
