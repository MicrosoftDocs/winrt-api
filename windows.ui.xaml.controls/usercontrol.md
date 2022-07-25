---
-api-id: T:Windows.UI.Xaml.Controls.UserControl
-api-type: winrt class
---

<!-- Class syntax.
public class UserControl : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IUserControl
-->

# Windows.UI.Xaml.Controls.UserControl

## -description
Provides the base class for defining a new control that encapsulates related existing controls and provides its own logic.



## -xaml-syntax
```xaml
<UserControl ...>
  singleContentElement
</UserControl>
-or-
<UserControl .../>
```


## -remarks
Note that UserControl does not manifest the value of its  property in its control template. Instead, set the Background of the root element inside the UserControl. For more info, see Remarks in [Control.Background](control_background.md).

## -examples
The following examples demonstrate creating a UserControl and using it multiple times in an app. This first example creates a UserControl called `NameReporter` that asks for a name of a person, and reports it back to the user. `NameReporter` has several [TextBlock](textblock.md)  controls, two [TextBox](textbox.md) controls, and a [Button](button.md). The user enters a first and last name into the appropriate [TextBox](textbox.md), and then clicks the button. The control then displays a message box with the name that the user entered.

[!code-xaml[1](../windows.ui.xaml.controls.primitives/code/UserControlSnippets/csharp/NameReporter.xaml#Snippet1)]

[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/UserControlSnippets/csharp/NameReporter.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/UserControlSnippets/vbnet/NameReporter.xaml.vb#Snippet2)]

> [!NOTE]
> The `src` prefix in this XAML references the app itself and the `UserControlExample` code namespace within it. That is where the `NameReporter` control is defined. For more info on XAML prefixes, see [XAML namespaces and namespace mapping](/windows/uwp/xaml-platform/xaml-namespaces-and-namespace-mapping).

[!code-xaml[3](../windows.ui.xaml.controls.primitives/code/UserControlSnippets/csharp/Page.xaml#Snippet3)]

## -see-also
[Control](control.md)
