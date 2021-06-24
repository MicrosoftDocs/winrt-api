---
-api-id: P:Windows.UI.UIAutomation.Core.ICoreAutomationConnectionBoundObjectProvider.IsComThreadingRequired
-api-type: winrt property
---

# Windows.UI.UIAutomation.Core.ICoreAutomationConnectionBoundObjectProvider.IsComThreadingRequired

<!--
public bool IsComThreadingRequired { get; }
-->

## -description

Gets whether a COM threading model is required by the [ICoreAutomationConnectionBoundObjectProvider](icoreautomationconnectionboundobjectprovider.md).

## -property-value

True, if a COM threading model is required. Otherwise, false.

If this property is true, then the connection-bound object will be bound to the apartment where the remote operation that first introduced the object was evaluated.

## -remarks

## -see-also

[AutomationConnectionBoundObject](../windows.ui.uiautomation/automationconnectionboundobject.md)

## -examples
