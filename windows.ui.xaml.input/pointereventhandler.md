---
-api-id: T:Windows.UI.Xaml.Input.PointerEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void PointerEventHandler(System.Object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
-->
# Windows.UI.Xaml.Input.PointerEventHandler

## -description
Represents the method that will handle pointer message events such as [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md).



## -parameters
### -param sender
The object where the event handler is attached.

### -param e
Event data for the event.


## -remarks
This delegate is used for handling each of the following events:


+ [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md)
+ [PointerCanceled](../windows.ui.xaml/uielement_pointercanceled.md)
+ [PointerCaptureLost](../windows.ui.xaml/uielement_pointercapturelost.md)
+ [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md)
+ [PointerExited](../windows.ui.xaml/uielement_pointerexited.md)
+ [PointerMoved](../windows.ui.xaml/uielement_pointermoved.md)
+ [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md)
+ [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md)


## -examples
The following code example shows scenario 2 from the [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample). This code shows some usage patterns for direct manipulation using the [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md), [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md), [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md), [PointerExited](../windows.ui.xaml/uielement_pointerexited.md), and [PointerMoved](../windows.ui.xaml/uielement_pointermoved.md) events.



[!code-xaml[Scenario2Xaml](../windows.ui.xaml/code/input/csharp/Scenario2.xaml#SnippetScenario2Xaml)]

[!code-csharp[Scenario2Code](../windows.ui.xaml/code/input/csharp/Scenario2.xaml.cs#SnippetScenario2Code)]

[!code-vb[Scenario2Code](../windows.ui.xaml/code/input/vbnet/Scenario2.xaml.vb#SnippetScenario2Code)]


## -see-also
