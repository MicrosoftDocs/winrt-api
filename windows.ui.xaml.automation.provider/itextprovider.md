---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITextProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITextProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ITextProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to controls that contain text. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Text](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
For more info on this pattern, see [Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange).

ITextProvider, [ITextProvider2](itextprovider2.md) and [ITextRangeProvider](itextrangeprovider.md) aren't implemented by any existing Windows Runtime automation peers using this definition of the interface. The text models supported by Windows Runtime text controls such as [TextBox](../windows.ui.xaml.controls/textbox.md) and [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) do implement some of these patterns, but do so at a native level that doesn't appear in the Windows Runtime definitions of the API surface. For more info, see the peer classes for the various Windows Runtime text controls.

The Microsoft UI Automation interfaces within the Windows Runtime API exist so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

The ITextProvider pattern doesn't have a Windows Runtime property identifier class.

## -examples

## -see-also
[Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange), [ITextProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itextprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
