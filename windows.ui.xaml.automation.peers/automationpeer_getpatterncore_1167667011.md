---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetPatternCore(Windows.UI.Xaml.Automation.Peers.PatternInterface)
-api-type: winrt method
---

<!-- Method syntax
virtual protected object GetPatternCore(Windows.UI.Xaml.Automation.Peers.PatternInterface patternInterface)
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetPatternCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetPattern](automationpeer_getpattern_2046576749.md) or an equivalent Microsoft UI Automation client API.

## -parameters
### -param patternInterface
A value from the [PatternInterface](patterninterface.md) enumeration.

## -returns
The object that implements the pattern interface; **null** if the peer does not support this interface.

## -remarks
The standard implementation at the [AutomationPeer](automationpeer.md) level returns **null**, because the basic peer class doesn't support any patterns. The majority of existing Windows Runtime peer classes override this method to report the patterns that a particular peer supports.

Overriding this method to return the implementation of patterns that your peer class supports is one of the most common scenarios for implementing an automation peer. You can see sample code for this in the [XAML accessibility sample](http://go.microsoft.com/fwlink/p/?linkid=238570) (Scenario 3). You should also read the [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4) topic.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 466373-->
### Windows 8 behavior

Windows 8 peer-selection behavior is potentially impacted by whether the control is intended to display data as items. The automation logic for Windows 8 might select a dedicated data peer and use its patterns, even if there is a peer indicated for the overall control and that peer overrides [GetPatternCore](automationpeer_getpatterncore_1167667011.md). For example, you might have the [ListViewAutomationPeer](listviewautomationpeer.md) override for patterns, but in Windows 8 the acting patterns for data items might take precedence, for example the default implementation of [ListViewItemDataAutomationPeer](listviewitemdataautomationpeer.md) might be used and will handle the scrolling pattern when UI Automation looks for patterns in items. This is different starting with Windows 8.1; if there is pattern support indicated in a [GetPatternCore](automationpeer_getpatterncore_1167667011.md) implementation for the overall control, that implementation is used instead of internal item data peers.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it means that your items control pattern support may be used for data items too, and you might have to add behavior for item scrolling, for instance.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Control patterns and interfaces](http://msdn.microsoft.com/library/2091883c-5d0c-44ed-936a-709022926a42), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd), [XAML accessibility sample](http://go.microsoft.com/fwlink/p/?linkid=238570)