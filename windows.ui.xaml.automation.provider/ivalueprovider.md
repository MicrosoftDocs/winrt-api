---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IValueProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IValueProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IValueProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that have an intrinsic value that does not span a range and that can be represented as a string. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) call and [PatternInterface.Value](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
The value string can be editable, depending on the control and its settings. This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Value Control Pattern](http://msdn.microsoft.com/library/6b11d281-aca7-4548-853c-e7322999825d).

[IValueProvider](ivalueprovider.md) is implemented by the existing Windows Runtime class [ComboBoxAutomationPeer](../windows.ui.xaml.automation.peers/comboboxautomationpeer.md).

The text models supported by Windows Runtime text controls such as [TextBox](../windows.ui.xaml.controls/textbox.md) and [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) don't use the [IValueProvider](ivalueprovider.md) pattern.

Use [ValuePatternIdentifiers](../windows.ui.xaml.automation/valuepatternidentifiers.md) if you want to reference the [IValueProvider](ivalueprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent.md).

## -examples

## -see-also
[ValuePatternIdentifiers](../windows.ui.xaml.automation/valuepatternidentifiers.md), [IValueProvider (COM interface)](http://msdn.microsoft.com/library/e6adbc23-dbfe-4dd2-82d9-66ce16de3338), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Value Control Pattern](http://msdn.microsoft.com/library/6b11d281-aca7-4548-853c-e7322999825d)