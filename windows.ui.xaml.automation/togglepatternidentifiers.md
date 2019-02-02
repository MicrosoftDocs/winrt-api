---
-api-id: T:Windows.UI.Xaml.Automation.TogglePatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class TogglePatternIdentifiers : Windows.UI.Xaml.Automation.ITogglePatternIdentifiers
-->

# Windows.UI.Xaml.Automation.TogglePatternIdentifiers

## -description
Contains values used as identifiers by [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md).

## -remarks
Classes such as [TogglePatternIdentifiers](togglepatternidentifiers.md) are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_1997743353.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IToggleProvider](https://msdn.microsoft.com/library/85da8225-31b8-4b4d-81f4-ad98871b8e31) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md), [Control patterns and interfaces](https://msdn.microsoft.com/library/2091883c-5d0c-44ed-936a-709022926a42), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
