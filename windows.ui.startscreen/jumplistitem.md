---
-api-id: T:Windows.UI.StartScreen.JumpListItem
-api-type: winrt class
---

<!-- Class syntax.
public class JumpListItem : Windows.UI.StartScreen.IJumpListItem
-->

# Windows.UI.StartScreen.JumpListItem

## -description
Provides functionality for creating and defining jump list items for an app's jump list.

## -remarks
[JumpListItem](jumplistitem.md) 's are created using the [CreateWithArguments](jumplistitem_createwitharguments.md) and [CreateSeparator](jumplistitem_createseparator.md) methods. After creation, they can be added to the app's jump list using the jump list's [Items](jumplist_items.md) property and the [SaveAsync](jumplist_saveasync.md) method. Be aware that in the user interface, a user can right-click a jump list item that is in a custom group and select “Remove from this list”. When this action occurs, the system marks the item as removed by user and suppresses it from the UI. The next time an app loads the jump list, it should check the items to see if the item's [RemovedByUser](jumplistitem_removedbyuser.md) property is set to True. If [RemovedByUser](jumplistitem_removedbyuser.md) is True, then the app should update its internal state to be in sync with the user initiated change. It is the apps responsibility to make sure that a removed item is not added back to the jump list until such time as the conditions for its addition are again met, for example, by the user opening the associated document again.

When an app saves the [JumpList](jumplist.md) using [SaveAsync](jumplist_saveasync.md), the operating system organizes the items as follows. 
+ Any items with RemovedByUser equal to True are removed.
+ Items with the same GroupName property are placed together, preserving their relative order.
+ Groups are ordered by the original position of the first item in the group, with the exception that system-managed groups are always at the top and the Tasks group is always at the bottom if they are present.
 That means that when an app loads it's [JumpList](jumplist.md) using the [LoadCurrentAsync](jumplist_loadcurrentasync.md) method, the items are retrieved in their organized order, which might not agree with the order of the items in the jump list when it was originally saved.

## -examples
The following example demonstrates how to create a task for a [JumpList](jumplist.md) that launches the app with command line parameters and takes a desired action. Localization is not shown, but is possible for the [DisplayName](jumplistitem_displayname.md), [description](jumplistitem_description.md), and [logo](jumplistitem_logo.md) through the use of the *ms-resource:* and *ms-appx:* URI schemes.

```csharp
private Windows.UI.StartScreen.JumpListItem CreateJumpListItemTask()
{
    var taskItem = JumpListItem.CreateWithArguments(
                            "/Argument", "DisplayName");

    // Set the description. (Optional.)
    taskItem.Description = "Compose a new message to " + friendName;

    // Set the logo for this jump list item. Must be ms-appx: or ms-appdata:.
    taskItem.Logo = new Uri("ms-appdata:///local/downloads/taskImage.png");

    // If the GroupName is left blank, then the item goes into the Tasks group by default.

    return taskItem;
}

partial class App
{
    protected override void OnLaunched(LaunchActivatedEventArgs e)
    {
        if (e.Kind == ActivationKind.Launch && e.Arguments == "/Argument")
        {
            // Run code relevant to the task that was selected.
        }
    }
}


```



## -see-also
