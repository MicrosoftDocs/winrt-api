---
-api-id: T:Windows.UI.Xaml.Input.StandardUICommand
-api-type: winrt class
---

<!-- Class syntax.
public class StandardUICommand : UICommand, UICommand
-->

# Windows.UI.Xaml.Input.StandardUICommand

## -description

Derives from [XamlUICommand](xamluicommand.md), adding a set of standard platform commands with pre-defined properties.


## -remarks

[XamlUICommand](xamluicommand.md) implements the ICommand interface ([Windows.UI.Xaml.Input.ICommand](icommand.md) for C++ or [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true) for C#), adding various UI properties, methods, and events.

The platform provides the following set of commands.

| Command/Label | Description | Icon | Keyboard shortcut |
| ------- | ---- | ----------------- | ----- |
| Cut | Delete the selected content and copy it to the clipboard. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E8C6.png" alt-text="Cut icon." border="false":::<br>E8C6 | Ctrl + X |
| Copy | Copy the selected content to the clipboard. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E8C8.png" alt-text="Copy icon." border="false":::<br>E8C8  |Ctrl + C |
| Paste | Insert the the clipboard content. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E77F.png" alt-text="Paste icon." border="false":::<br>E77F | Ctrl + P |
| Select All | Select all content. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E8B3.png" alt-text="Select all icon." border="false":::<br>E8B3 | Ctrl + A |
| Delete | Delete the selected content. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E74D.png" alt-text="Delete icon." border="false":::<br>E74D | Delete |
| Share | Share the selected content. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E72D.png" alt-text="Share icon." border="false":::<br>E72D | n/a |
| Save | Save changes.  | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E74E.png" alt-text="Save icon." border="false":::<br>E74E | Ctrl + S |
| Open | Open panel. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E8A0.png" alt-text="Open panel icon." border="false":::<br>E8A0 | Ctrl + O |
| Close | Close panel. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E89F.png" alt-text="Close panel icon." border="false":::<br>E89F | Alt + F4 |
| Pause | Pause currently playing media. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E769.png" alt-text="Pause icon." border="false":::<br>E769 | Spacebar |
| Play | Play currently paused media. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E768.png" alt-text="Play icon." border="false":::<br>E768 | Spacebar |
| Stop | Stop media. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E71A.png" alt-text="Stop icon." border="false":::<br>E71A | Escape |
| Forward | Skip forward. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E72A.png" alt-text="Forward icon." border="false":::<br>E72A | Alt + Right arrow |
| Back | Skip back. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E72B.png" alt-text="Back icon." border="false":::<br>E72B | Alt + Left arrow |
| Undo | Revert the most recent action. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E7A7.png" alt-text="Undo icon." border="false":::<br>E7A7 | Ctrl + Z |
| Redo | Repeat the most recently undone action. | :::image type="icon" source="../windows.ui.xaml.controls/images/segoe-fluent-icons/E7A6.png" alt-text="Redo icon." border="false":::<br>E7A6 | Ctrl + Y |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command design basics](/windows/uwp/layout/commanding-basics).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the StandardUICommand in action](winui2gallery:/item/StandardUICommand).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also

[XamlUICommand](xamluicommand.md), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/uwp/design/controls-and-patterns/commanding)
