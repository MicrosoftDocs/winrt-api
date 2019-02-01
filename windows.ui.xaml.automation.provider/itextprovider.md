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
For more info on this pattern, see [Text and TextRange Control Patterns](https://msdn.microsoft.com/library/4d541c31-11f7-4d7e-a0e0-9ed1da873d07).

[ITextProvider](itextprovider.md), [ITextProvider2](itextprovider2.md) and [ITextRangeProvider](itextrangeprovider.md) aren't implemented by any existing Windows Runtime automation peers using this definition of the interface. The text models supported by Windows Runtime text controls such as [TextBox](../windows.ui.xaml.controls/textbox.md) and [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) do implement some of these patterns, but do so at a native level that doesn't appear in the Windows Runtime definitions of the API surface. For more info, see the peer classes for the various Windows Runtime text controls.

The Microsoft UI Automation interfaces within the Windows Runtime API exist so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

The [ITextProvider](itextprovider.md) pattern doesn't have a Windows Runtime property identifier class.

## -examples

## -see-also
[Text and TextRange Control Patterns](https://msdn.microsoft.com/library/4d541c31-11f7-4d7e-a0e0-9ed1da873d07), [ITextProvider (COM interface)](https://msdn.microsoft.com/library/8bd53f1e-731f-420b-a529-ca3f6c3fd97c), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
