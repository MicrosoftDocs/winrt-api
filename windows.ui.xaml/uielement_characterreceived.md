---
-api-id: E:Windows.UI.Xaml.UIElement.CharacterReceived
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler CharacterReceived<UIElement, CharacterReceivedRoutedEventArgs>
-->

# Windows.UI.Xaml.UIElement.CharacterReceived

## -description

Occurs when a single, composed character is received by the input queue.



## -xaml-syntax

```xaml
<uiElement CharacterReceived="eventhandler"/>
```

## -remarks

> [!NOTE]
> A composed character is a single visual object derived from a sequence of one or more other characters.

CharacterReceived is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](../windows.ui.xaml.input/characterreceivedroutedeventargs_handled.md) to true.

This event is useful for text input scenarios such as "typeahead find or search" (also known as incremental search, incremental find, or real-time suggestions) where, as the user types, the control progressively searches for and filters text based on the characters in the input queue.

The CharacterReceived event can occur at different times depending on the character entered, as the event is not fired until the composed character is registered in the input queue.

- User presses the W key (the character 'w' is received):
  - PreviewKeyDown for W
  - KeyDown for W
  - CharacterReceived
  - PreviewKeyUp for W
  - KeyUp for W
- User presses the Shift+W keys (the character 'W' is received):
  - PreviewKeyDown for Shift
  - KeyDown for Shift
  - PreviewKeyDown for W
  - KeyDown for W
  - CharacterReceived
  - PreviewKeyUp for W
  - KeyUp for W
  - PreviewKeyUp for Shift
  - KeyUp for Shift
- User presses Alt+164 using the NumPad (the character ‘ñ’ is received):
  - PreviewKeyDown for Alt
  - KeyDown for Alt
  - PreviewKeyDown for 1
  - KeyDown for 1
  - PreviewKeyUp for 1
  - KeyUp for 1
  - PreviewKeyDown for 6
  - KeyDown for 6
  - PreviewKeyUp for 6
  - KeyUp for 6
  - PreviewKeyDown for 4
  - KeyDown for 4
  - PreviewKeyUp for 4
  - KeyUp for 4
  - CharacterReceived
  - PreviewKeyUp for Alt
  - KeyUp for Alt

## -see-also

[CharacterReceivedRoutedEventArgs](../windows.ui.xaml.input/characterreceivedroutedeventargs.md), [ComboBox.IsTextSearchEnabled](../windows.ui.xaml.controls/combobox_istextsearchenabled.md)

## -examples
