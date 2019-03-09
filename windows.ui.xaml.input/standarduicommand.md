---
-api-id: T:Windows.UI.Xaml.Input.StandardUICommand
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class StandardUICommand : UICommand, UICommand
-->

# Windows.UI.Xaml.Input.StandardUICommand

## -description

Derives from [XamlUICommand](xamluicommand.md), adding a set of standard platform commands with pre-defined properties.

## -remarks

[XamlUICommand](xamluicommand.md) implements the ICommand interface ([Windows.UI.Xaml.Input.ICommand](icommand.md) for C++ or [System.Windows.Input.ICommand](https://docs.microsoft.com/dotnet/api/system.windows.input.icommand) for C#), adding various UI properties, methods, and events.

The platform provides the following set of commands.

- Cut
- Copy
- Paste
- Select All
- Delete
- Share
- Save
- Open
- Close
- Pause
- Play
- Stop
- Forward
- Backward
- Undo
- Redo

## -see-also

[XamlUICommand](xamluicommand.md), [Command design basics](https://docs.microsoft.com/windows/uwp/layout/commanding-basics), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/commanding)

## -examples
