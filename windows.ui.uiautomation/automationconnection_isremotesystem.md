---
-api-id: P:Windows.UI.UIAutomation.AutomationConnection.IsRemoteSystem
-api-type: winrt property
---

# Windows.UI.UIAutomation.AutomationConnection.IsRemoteSystem

<!--
public bool IsRemoteSystem { get; }
-->

## -description

Gets whether the connection is to a UI Automation provider that is not hosted natively on the user's local machine.

## -property-value

True, if the connection is to a remote system. Otherwise, false.

## -remarks

For UIA, a remote system is any UI that is not hosted natively on the user's local machine but instead resides either in a container or on a different machine accessed via network.

## -see-also

[Windows.UI.UIAutomation.AutomationConnectionBoundObject.Connection](automationconnectionboundobject_connection.md)

## -examples
