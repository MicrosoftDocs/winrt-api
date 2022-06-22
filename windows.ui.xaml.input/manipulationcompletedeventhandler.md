---
-api-id: T:Windows.UI.Xaml.Input.ManipulationCompletedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void ManipulationCompletedEventHandler(System.Object sender, Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
-->
# Windows.UI.Xaml.Input.ManipulationCompletedEventHandler

## -description
Represents the method that will handle [ManipulationCompleted](../windows.ui.xaml/uielement_manipulationcompleted.md) and related events.



## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


## -remarks

## -examples
The following code example shows scenario 4 from the [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample). This code shows some usage patterns for direct manipulation using the [ManipulationStarting](../windows.ui.xaml/uielement_manipulationstarting.md), [ManipulationStarted](../windows.ui.xaml/uielement_manipulationstarted.md), [ManipulationDelta](../windows.ui.xaml/uielement_manipulationdelta.md), [ManipulationInertiaStarting](../windows.ui.xaml/uielement_manipulationinertiastarting.md), and [ManipulationCompleted](../windows.ui.xaml/uielement_manipulationcompleted.md) events.



[!code-csharp[Scenario4Code](../windows.ui.xaml/code/input/csharp/Scenario4.xaml.cs#SnippetScenario4Code)]

[!code-vb[Scenario4Code](../windows.ui.xaml/code/input/vbnet/Scenario4.xaml.vb#SnippetScenario4Code)]


## -see-also
