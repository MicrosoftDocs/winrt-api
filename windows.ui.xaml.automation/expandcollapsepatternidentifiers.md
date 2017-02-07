---
-api-id: T:Windows.UI.Xaml.Automation.ExpandCollapsePatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class ExpandCollapsePatternIdentifiers : Windows.UI.Xaml.Automation.IExpandCollapsePatternIdentifiers
-->

# Windows.UI.Xaml.Automation.ExpandCollapsePatternIdentifiers

## -description
Contains values used as identifiers by [IExpandCollapseProvider](../windows.ui.xaml.automation.provider/iexpandcollapseprovider.md).

## -remarks
Classes such as [ExpandCollapsePatternIdentifiers](expandcollapsepatternidentifiers.md) are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IExpandCollapseProvider](../windows.ui.xaml.automation.provider/iexpandcollapseprovider.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IExpandCollapseProvider](http://msdn.microsoft.com/library/59d91498-54f8-40df-8224-52ff8e45f6c3) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IExpandCollapseProvider](../windows.ui.xaml.automation.provider/iexpandcollapseprovider.md), [Control patterns and interfaces](http://msdn.microsoft.com/library/2091883c-5d0c-44ed-936a-709022926a42), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)