---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITextProvider2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITextProvider2 : Windows.UI.Xaml.Automation.Provider.ITextProvider
-->

# Windows.UI.Xaml.Automation.Provider.ITextProvider2

## -description
Extends the [ITextProvider](itextprovider.md) interface to enable Microsoft UI Automation providers to expose textual content that is the target of an annotation or selection. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) call and [PatternInterface.Text2](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
For more info on this pattern, see [Text and TextRange Control Patterns](http://msdn.microsoft.com/library/4d541c31-11f7-4d7e-a0e0-9ed1da873d07).

[ITextProvider](itextprovider.md), [ITextProvider2](itextprovider2.md) and [ITextRangeProvider](itextrangeprovider.md) aren't implemented by any existing Windows Runtime automation peers using this definition of the interface. The text models supported by Windows Runtime text controls such as [TextBox](../windows.ui.xaml.controls/textbox.md) and [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) do implement some of these patterns, but do so at a native level that doesn't appear in the Windows Runtime definitions of the API surface. For more info, see the peer classes for the various Windows Runtime text controls.

The [ITextProvider2](itextprovider2.md) pattern doesn't have a Windows Runtime property identifier class.

### Interface inheritance

[ITextProvider2](itextprovider2.md) inherits [ITextProvider](itextprovider.md). Types that implement [ITextProvider2](itextprovider2.md) also implement the interface members of [ITextProvider](itextprovider.md).

## -examples

## -see-also
[Text and TextRange Control Patterns](http://msdn.microsoft.com/library/4d541c31-11f7-4d7e-a0e0-9ed1da873d07), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [ITextProvider2 (COM interface)](http://msdn.microsoft.com/library/cda6e93d-6e82-4ec4-8408-09554d039f49), [ITextProvider](itextprovider.md)