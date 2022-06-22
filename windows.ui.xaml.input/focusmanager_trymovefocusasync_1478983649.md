---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.TryMoveFocusAsync(Windows.UI.Xaml.Input.FocusNavigationDirection,Windows.UI.Xaml.Input.FindNextElementOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<FocusMovementResult> FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)
-->

# Windows.UI.Xaml.Input.FocusManager.TryMoveFocusAsync

## -description

Asynchronously attempts to change focus from the current element with focus to the next focusable element in the specified direction and subject to the specified navigation options.



## -parameters

### -param focusNavigationDirection

The direction that focus moves from element to element within the app UI.

### -param focusNavigationOptions

The navigation options used to identify the focus candidate.

## -returns

The [FocusMovementResult](focusmovementresult.md) that indicates whether focus was successfully set.

## -remarks

- [TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)](focusmanager_trymovefocus_582274934.md) and [FocusManager.TryMoveFocus(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)](focusmanager_trymovefocus_1178810148.md) return true (success), before the focus change is complete.   
- [GetFocusedElement](focusmanager_getfocusedelement_1183614552.md) does not return the newly focused object until the asynchronous operation completes. 
- The control losing focus receives its [LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) event synchronously, but does not receive [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) until the asynchronous operation completes. 
- The control getting focus receieves its [GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md) event synchronously, but does not receive [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) until the asynchronous operation completes. 
 
[TryFocusAsync](focusmanager_tryfocusasync_1779533284.md) completes synchronously when called on an element running in the app process. 

You can also use either the [FindNextElement(FocusNavigationDirection, FindNextElementOptions)](focusmanager_findnextelement_918683319.md) method or the [FindNextElement(FocusNavigationDirection)](focusmanager_findnextelement_1379272417.md) method to programmatically move focus. These methods retrieve the element (as a [DependencyObject](../windows.ui.xaml/dependencyobject.md)) that will receive focus based on the specified navigation direction (directional navigation only, cannot be used to emulate tab navigation).

> [!NOTE]
> We recommend using the FindNextElement method instead of FindNextFocusableElement because FindNextFocusableElement retrieves a UIElement, which returns null if the next focusable element is not a UIElement (such as a [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) object).

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

[FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection)](focusmanager_trymovefocusasync_1020299191.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)
