---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.TryMoveFocusAsync(Windows.UI.Xaml.Input.FocusNavigationDirection)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<FocusMovementResult> FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection)
-->

# Windows.UI.Xaml.Input.FocusManager.TryMoveFocusAsync

## -description
Asynchronously attempts to change focus from the current element with focus to the next focusable element in the specified direction.

## -parameters
### -param focusNavigationDirection
The direction that focus moves from element to element within the app UI.

## -returns
The [FocusMovementResult](focusmovementresult.md) that indicates whether focus was successfully set.

## -remarks
- [TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)](focusmanager_trymovefocus_582274934.md) and [FocusManager.TryMoveFocus(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)](focusmanager_trymovefocus_1178810148.md) return true (success), before the focus change is complete.   
- [GetFocusedElement](focusmanager_getfocusedelement_1183614552.md) does not return the newly focused object until the asynchronous operation completes. 
- The control losing focus receives its [LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) event synchronously, but does not receive [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) until the asynchronous operation completes. 
- The control getting focus receieves its [GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md) event synchronously, but does not receive [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) until the asynchronous operation completes. 
 
[TryFocusAsync](focusmanager_tryfocusasync_1779533284.md) completes synchronously when called on an element running in the app process. 
 
## -examples
Here, we show how to set focus on a WebView object, and, if that fails, restore focus to the original element. 
```csharp
async void MoveFocus(WebView webView)) 
{ 
    FocusMovementResult result; 
    result = await FocusManager.TryFocusAsync(webView, FocusState.Programmatic); 
    if (!result.Succeeded) 
    { 
        // Restore focus to original element. 
        this.Focus(FocusState.Programmatic); 
    } 
}
``` 

## -see-also
[FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)](focusmanager_trymovefocusasync_1478983649.md)

