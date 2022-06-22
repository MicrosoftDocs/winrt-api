---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITextProvider2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITextProvider2 : Windows.UI.Xaml.Automation.Provider.ITextProvider
-->

# Windows.UI.Xaml.Automation.Provider.ITextProvider2

## -description
Extends the [ITextProvider](itextprovider.md) interface to enable Microsoft UI Automation providers to expose textual content that is the target of an annotation or selection. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Text2](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
For more info on this pattern, see [Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange).

[ITextProvider](itextprovider.md), ITextProvider2 and [ITextRangeProvider](itextrangeprovider.md) aren't implemented by any existing Windows Runtime automation peers using this definition of the interface. The text models supported by Windows Runtime text controls such as [TextBox](../windows.ui.xaml.controls/textbox.md) and [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) do implement some of these patterns, but do so at a native level that doesn't appear in the Windows Runtime definitions of the API surface. For more info, see the peer classes for the various Windows Runtime text controls.

The ITextProvider2 pattern doesn't have a Windows Runtime property identifier class.

### Interface inheritance

ITextProvider2 inherits [ITextProvider](itextprovider.md). Types that implement ITextProvider2 also implement the interface members of [ITextProvider](itextprovider.md).

## -examples

## -see-also
[Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [ITextProvider2 (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itextprovider2), [ITextProvider](itextprovider.md)
