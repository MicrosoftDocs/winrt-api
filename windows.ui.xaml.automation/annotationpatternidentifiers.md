---
-api-id: T:Windows.UI.Xaml.Automation.AnnotationPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class AnnotationPatternIdentifiers : Windows.UI.Xaml.Automation.IAnnotationPatternIdentifiers
-->

# Windows.UI.Xaml.Automation.AnnotationPatternIdentifiers

## -description
Contains values used as identifiers by [IAnnotationProvider](../windows.ui.xaml.automation.provider/iannotationprovider.md).

## -remarks
Classes such as [AnnotationPatternIdentifiers](annotationpatternidentifiers.md) are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IAnnotationProvider](../windows.ui.xaml.automation.provider/iannotationprovider.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IAnnotationProvider](http://msdn.microsoft.com/library/edd711f1-9d1b-4b6b-8052-e9258759f46e) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IAnnotationProvider](../windows.ui.xaml.automation.provider/iannotationprovider.md), [Control patterns and interfaces](http://msdn.microsoft.com/library/2091883c-5d0c-44ed-936a-709022926a42), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)