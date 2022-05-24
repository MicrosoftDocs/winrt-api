---
-api-id: T:Windows.UI.UIAutomation.AutomationConnectionBoundObject
-api-type: winrt class
---

# Windows.UI.UIAutomation.AutomationConnectionBoundObject

<!--
public sealed class AutomationConnectionBoundObject
-->

## -description

Represents an object associated with a specific UI Automation provider connection.

## -remarks

A UI Automation (UIA) client imports a connection-bound object into a remote operation, and then either uses it as the target object when calling an extension, or passes it as an operand to an extension.

The provider-side extension handler always executes on the thread where the remote operation is evaluated. Whenever a provider sets an operand to a connection-bound object, the threading model of this object is determined by the value of the [IsComThreadingRequired](../windows.ui.uiautomation.core/icoreautomationconnectionboundobjectprovider_iscomthreadingrequired.md) property on the provider’s implementation of the [ICoreAutomationConnectionBoundObjectProvider](../windows.ui.uiautomation.core/icoreautomationconnectionboundobjectprovider.md) interface. If this property is true and the the connection-bound object is returned in the result of the remote operation, then the connection-bound object will be bound to the apartment where the remote operation that first introduced the object was evaluated.

This object wraps an [ICoreAutomationConnectionBoundObjectProvider](../windows.ui.uiautomation.core/icoreautomationconnectionboundobjectprovider.md), which is implemented by a UIA provider.

## -see-also

[ImportConnectionBoundObject(Windows.UI.UIAutomation.Core.AutomationRemoteOperationOperandId,Windows.UI.UIAutomation.AutomationConnectionBoundObject)](../windows.ui.uiautomation.core/coreautomationremoteoperation_importconnectionboundobject_1395641421.md)

## -examples
