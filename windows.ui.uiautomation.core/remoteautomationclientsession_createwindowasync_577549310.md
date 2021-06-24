---
-api-id: M:Windows.UI.UIAutomation.Core.RemoteAutomationClientSession.CreateWindowAsync(System.UInt64,System.UInt32,System.Object)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.RemoteAutomationClientSession.CreateWindowAsync(System.UInt64,System.UInt32,System.Object)

<!--
public Windows.Foundation.IAsyncOperation<Windows.UI.UIAutomation.Core.RemoteAutomationWindow> CreateWindowAsync (ulong remoteWindowId, uint remoteProcessId, object parentAutomationElement);
-->

## -description

Creates a parent-child relationship between a parent AutomationElement and a child remote window.

## -parameters

### -param remoteWindowId

The unique identifier for the window.

### -param remoteProcessId

The unique process identifier for the window.

### -param parentAutomationElement

The parent element for the window.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks

## -see-also

## -examples
