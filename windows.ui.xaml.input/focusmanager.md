---
-api-id: T:Windows.UI.Xaml.Input.FocusManager
-api-type: winrt class
---

<!-- Class syntax.
public class FocusManager : Windows.UI.Xaml.Input.IFocusManager
-->

# Windows.UI.Xaml.Input.FocusManager

## -description
A helper class that enables getting and setting the UI element that has focus.

## -remarks

## -examples
Use [TryMoveFocus](focusmanager_trymovefocus.md) to traverse between UI elements using the arrow keys.

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