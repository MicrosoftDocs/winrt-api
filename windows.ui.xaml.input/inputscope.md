---
-api-id: T:Windows.UI.Xaml.Input.InputScope
-api-type: winrt class
---

<!-- Class syntax.
public class InputScope : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Input.IInputScope
-->

# Windows.UI.Xaml.Input.InputScope

## -description

Represents information related to the data provided by an input method.



## -remarks

> [!NOTE]
> An input method (or Input Method Editor (IME)) specifies how data, such as keyboard strokes, mouse movements, or speech dictation is recognized as input. This provides users with the ability to specify characters and symbols that are not displayed on their input devices. For example, languages that have more graphemes (a unit of text displayed as a single character) than there are keys on the keyboard.

The input scope indicates the expected input so that the XAML framework can display an appropriately formatted touch keyboard (or Soft Input Panel (SIP)). The input scope does not perform any validation, and does not prevent the user from providing any input through a hardware keyboard or otherwise.

## -examples

## -see-also
[Windows.UI.Xaml.Input](windows_ui_xaml_input.md), [DependencyObject](../windows.ui.xaml/dependencyobject.md), [Use input scope to change the touch keyboard](/windows/uwp/design/input/use-input-scope-to-change-the-touch-keyboard)
