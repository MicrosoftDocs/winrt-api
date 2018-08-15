---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IAnnotationProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAnnotationProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IAnnotationProvider

## -description
Exposes the properties of an annotation in a document. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Annotation](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
The **Annotation** control pattern is used to expose the properties of an annotation in a document. One example is a comment balloon that is in the margin of a document and is connected to some document text or a spreadsheet cell. For more info on what this pattern is for, see [Annotation Control Pattern](http://msdn.microsoft.com/library/5a334991-66af-4a82-9a09-09d5bdaaa771).

[IAnnotationProvider](iannotationprovider.md) isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [AnnotationPatternIdentifiers](../windows.ui.xaml.automation/annotationpatternidentifiers.md) if you want to reference the [IAnnotationProvider](iannotationprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[AnnotationPatternIdentifiers](../windows.ui.xaml.automation/annotationpatternidentifiers.md), [IAnnotationProvider (COM)](http://msdn.microsoft.com/library/edd711f1-9d1b-4b6b-8052-e9258759f46e), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Annotation Control Pattern](http://msdn.microsoft.com/library/5a334991-66af-4a82-9a09-09d5bdaaa771)