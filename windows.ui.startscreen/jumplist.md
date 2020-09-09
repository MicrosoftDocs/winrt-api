---
-api-id: T:Windows.UI.StartScreen.JumpList
-api-type: winrt class
---

<!-- Class syntax.
public class JumpList : Windows.UI.StartScreen.IJumpList
-->

# Windows.UI.StartScreen.JumpList

## -description

Provides functionality for an app's jump list. A jump list is a system-provided menu that appears when the user right-clicks a program in the taskbar or on the Start menu. It is used to provide quick access to recently or frequently-used documents and offer direct links to app functionality. Not all device families support jump lists.

## -remarks

An app's JumpList is retrieved using the [LoadCurrentAsync](jumplist_loadcurrentasync_313230072.md) method. If an application does not customize its jump list, the system provides a default jump list. Currently, the default jump list shows recent items. Make sure your app has registered to become the default file handler for a certain file type that you want to show in the recent items list. For more information, see [Handle file activation](/windows/uwp/launch-resume/handle-file-activation).

## -examples

The following example demonstrates how to remove the jump list for an app, including any custom items that might have been previously added.

```csharp
private async void DisableSystemJumpListAsync()
{
    // Get the app's jump list.
    var jumpList = await Windows.UI.StartScreen.JumpList.LoadCurrentAsync();

    // Disable the system-managed jump list group.
    jumpList.SystemGroupKind = Windows.UI.StartScreen.JumpListSystemGroupKind.None;

    // Remove any previously added custom jump list items.
    jumpList.Items.Clear();

    // Save the changes to the app's jump list.
    await jumpList.SaveAsync();
}

```

The following example demonstrates how to set the type of system-managed group used by an app's jump list, without affecting any existing custom jump list items.

```csharp
private async void SetSystemGroupAsync()
{
    // Get the app's jump list.
    var jumpList = await Windows.UI.StartScreen.JumpList.LoadCurrentAsync();

    // Set the system to autogenerate a Frequent group for the app jump list.
    // Alternatively, this property could be set to JumpListSystemGroupKind.Recent to autogenerate a Recent group.
    jumpList.SystemGroupKind = Windows.UI.StartScreen.JumpListSystemGroupKind.Frequent;

    // No changes were made to the jump list Items property, so any custom tasks and groups remain intact.
    await jumpList.SaveAsync();
}

```

## -see-also

[Jump list customization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/JumpList)
