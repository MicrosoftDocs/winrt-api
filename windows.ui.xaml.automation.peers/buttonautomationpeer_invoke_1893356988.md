---
-api-id: M:Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer.Invoke
-api-type: winrt method
---

<!-- Method syntax.
public void ButtonAutomationPeer.Invoke()
-->

# Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer.Invoke


## -description

Sends a request to click the button associated with the automation peer.


## -remarks

Calls to **Invoke** should return immediately without blocking. However, this behavior is entirely dependent on the Microsoft UI Automation provider implementation. In scenarios where calling **Invoke** causes a blocking issue, such as a modal dialog, a separate helper thread may be required to call the method.

## -see-also

## -examples

