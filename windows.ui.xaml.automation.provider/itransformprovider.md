---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITransformProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITransformProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ITransformProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls or elements that can be moved, resized, or rotated within a two-dimensional space. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Transform](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Transform Control Pattern](https://msdn.microsoft.com/library/e1d862a0-8085-42b4-9710-cf11e1a467cf).

[ITransformProvider](itransformprovider.md) isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use the [TransformPatternIdentifiers](../windows.ui.xaml.automation/transformpatternidentifiers.md) class if you want to reference the [ITransformProvider](itransformprovider.md) pattern properties from control code when you call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[TransformPatternIdentifiers](../windows.ui.xaml.automation/transformpatternidentifiers.md), [Transform Control Pattern](https://msdn.microsoft.com/library/e1d862a0-8085-42b4-9710-cf11e1a467cf), [ITransformProvider (COM interface)](https://msdn.microsoft.com/library/cdc2f81b-cf69-469f-9139-e9a73cf8c730), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
