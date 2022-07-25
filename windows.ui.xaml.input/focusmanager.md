---
-api-id: T:Windows.UI.Xaml.Input.FocusManager
-api-type: winrt class
---

<!-- Class syntax.
public class FocusManager : Windows.UI.Xaml.Input.IFocusManager
-->

# Windows.UI.Xaml.Input.FocusManager

## -description

A helper class that enables global management of focus actions and events across all elements in an application.



## -remarks

We recommend using the [UIElement](../windows.ui.xaml/uielement.md) focus routed events instead of FocusManager events whenever possible.

FocusManager is intended for advanced scenarios where specific elements in an application do not receive bubbled events from a [UIElement](../windows.ui.xaml/uielement.md). For example, visual "overlay" objects such as [Popup](../windows.ui.xaml.controls.primitives/popup.md), [Tooltip](../windows.ui.xaml.controls/tooltip.md), or [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md) that appear as part of the app UI but are actually their own focus scope and not part of the visual tree hierarchy. In the case of a [Popup](../windows.ui.xaml.controls.primitives/popup.md), this occurs when you programmatically set [IsOpen](../windows.ui.xaml.controls.primitives/popup_isopen.md) to true and focus moves in and out of the popup.

Here's some basic markup to illustrate the example:

``` xaml
<Page …>
    <Grid …>
        <Popup …>
            <StackPanel Name="StackPanel3" …>
                <TextBlock Text="StackPanel3" />
                <Button Content="Button5" …/>
            </StackPanel>
        </Popup>
        <TextBlock Text="Grid" … />
        <StackPanel Name="StackPanel1" …>
            <TextBlock Text="StackPanel1" …/>
            <Button Content="Button1" …/>
            <Button Content="Button2" … />
        </StackPanel>
        <StackPanel Name="StackPanel2" …>
            <TextBlock Text="StackPanel2" …/>
            <Button Content="Button3" … />
            <Button Content="Button4" … />
        </StackPanel>
    </Grid>
</Page>
```

In this case, a Popup contains StackPanel3, which, in turn, contains Button5. When [IsOpen](../windows.ui.xaml.controls.primitives/popup_isopen.md) is set to true and focus moves from Button1 to Button5, the LosingFocus and LostFocus events bubble up across the visual tree (StackPanel1, the Grid, and the Page get both these events). However, only StackPanel3 receives the subsequent GettingFocus and GotFocus events that bubble up from Button5 (Grid and Page do not, as they are not in a parent-child relationship with Popup).

An application can have multiple elements with logical focus (depending on the number of focus scopes). However, only one element in the application can have keyboard focus.

There can be multiple elements with logical focus, but only one element with logical focus per focus scope. An element with logical focus does not necessarily have keyboard focus, but an element with keyboard focus does have logical focus.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | FindFirstFocusableElement |
| 1703 | 15063 | FindLastFocusableElement |
| 1703 | 15063 | FindNextElement(FocusNavigationDirection) |
| 1703 | 15063 | FindNextElement(FocusNavigationDirection,FindNextElementOptions) |
| 1703 | 15063 | TryMoveFocus(FocusNavigationDirection,FindNextElementOptions) |
| 1803 | 17134 | TryFocusAsync |
| 1803 | 17134 | TryMoveFocusAsync(FocusNavigationDirection) |
| 1803 | 17134 | TryMoveFocusAsync(FocusNavigationDirection,FindNextElementOptions) |
| 1809 | 17763 | GettingFocus |
| 1809 | 17763 | GotFocus |
| 1809 | 17763 | LosingFocus |
| 1809 | 17763 | LostFocus |
| 1903 | 18362 | GetFocusedElement(XamlRoot) |

## -examples

Use [TryMoveFocus](/uwp/api/windows.ui.xaml.input.focusmanager.trymovefocus) to traverse between UI elements using the arrow keys.

```csharp
private void Page_KeyUp(object sender, KeyRoutedEventArgs e)
{
   if (e.Key == Windows.System.VirtualKey.Up)
   {
      // Mimic Shift+Tab when user hits up arrow key.
      FocusManager.TryMoveFocus(FocusNavigationDirection.Previous);
   }
   else if (e.Key == Windows.System.VirtualKey.Down)
   {
      // Mimic Tab when user hits down arrow key.
      FocusManager.TryMoveFocus(FocusNavigationDirection.Next);
   }
}
```

## -see-also

[Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)
