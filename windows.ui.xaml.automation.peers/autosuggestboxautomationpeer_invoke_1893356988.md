---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer.Invoke
-api-type: winrt method
---

<!-- Method syntax.
public void AutoSuggestBoxAutomationPeer.Invoke()
-->

# Windows.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer.Invoke

## -description
Sends a request to submit the auto-suggest query to the [AutoSuggestBox](../windows.ui.xaml.controls/autosuggestbox.md) associated with the automation peer. 


## -remarks
Calls to **Invoke** should return immediately without blocking. However, this behavior is entirely dependent on the Microsoft UI Automation provider implementation. In scenarios where calling **Invoke** causes a blocking issue, such as a modal dialog, a separate helper thread may be required to call the method.  

## -see-also

## -examples

