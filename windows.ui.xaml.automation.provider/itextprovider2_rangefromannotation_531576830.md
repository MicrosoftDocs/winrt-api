---
-api-id: M:Windows.UI.Xaml.Automation.Provider.ITextProvider2.RangeFromAnnotation(Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Automation.Provider.ITextRangeProvider RangeFromAnnotation(Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple annotationElement)
-->

# Windows.UI.Xaml.Automation.Provider.ITextProvider2.RangeFromAnnotation

## -description
Exposes a text range that contains the text that is the target of the annotation associated with the specified annotation element.



## -parameters
### -param annotationElement
The provider for an element that implements the [IAnnotationProvider](iannotationprovider.md) interface. The annotation element is a sibling of the element that implements the [ITextProvider2](itextprovider2.md) interface for the document. 
<!--Apparently the IAnnotationProvider is not a WinRT interface. Mandatory interop?-->

## -returns
A text range that contains the annotation target text.

## -remarks

## -examples

## -see-also
