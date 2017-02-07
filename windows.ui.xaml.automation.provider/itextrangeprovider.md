---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITextRangeProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITextRangeProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ITextRangeProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to a span of continuous text in a text container that implements [ITextProvider](itextprovider.md).

## -remarks
For more info on this pattern, see [Text and TextRange Control Patterns](http://msdn.microsoft.com/library/4d541c31-11f7-4d7e-a0e0-9ed1da873d07).

[ITextProvider](itextprovider.md), [ITextProvider2](itextprovider2.md) and [ITextRangeProvider](itextrangeprovider.md) aren't implemented by any existing Windows Runtime automation peers using this definition of the interface. The text models supported by Windows Runtime text controls such as [TextBox](../windows.ui.xaml.controls/textbox.md) and [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) do implement some of these patterns, but do so at a native level that doesn't appear in the Windows Runtime definitions of the API surface. For more info, see the peer classes for the various Windows Runtime text controls.

The [ITextRangeProvider](itextrangeprovider.md) pattern doesn't have a Windows Runtime property identifier class.

## -examples

## -see-also
[Text and TextRange Control Patterns](http://msdn.microsoft.com/library/4d541c31-11f7-4d7e-a0e0-9ed1da873d07), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [ITextRangeProvider (COM interface)](http://msdn.microsoft.com/library/dd14e608-1d21-4527-8b82-dba64ed04fda), [ITextProvider](itextprovider.md)