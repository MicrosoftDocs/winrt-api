---
-api-id: T:Windows.UI.Xaml.Automation.SpreadsheetItemPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class SpreadsheetItemPatternIdentifiers : Windows.UI.Xaml.Automation.ISpreadsheetItemPatternIdentifiers
-->

# Windows.UI.Xaml.Automation.SpreadsheetItemPatternIdentifiers

## -description
Contains values used as automation property identifiers for properties of the [ISpreadsheetItemProvider](../windows.ui.xaml.automation.provider/ispreadsheetitemprovider.md) pattern.

## -remarks
Classes such as [SpreadsheetItemPatternIdentifiers](spreadsheetitempatternidentifiers.md) are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [ISpreadsheetItemProvider](../windows.ui.xaml.automation.provider/ispreadsheetitemprovider.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer_finditembyproperty_1997743353.md) in an items container peer. This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [ISpreadsheetItemProvider](http://msdn.microsoft.com/library/e6428fed-2bcc-4ad5-b612-a22899624538) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[ISpreadsheetItemProvider](../windows.ui.xaml.automation.provider/ispreadsheetitemprovider.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Control patterns and interfaces](http://msdn.microsoft.com/library/2091883c-5d0c-44ed-936a-709022926a42)