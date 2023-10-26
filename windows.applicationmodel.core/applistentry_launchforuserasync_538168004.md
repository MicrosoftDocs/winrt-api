---
-api-id: M:Windows.ApplicationModel.Core.AppListEntry.LaunchForUserAsync(Windows.System.User)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppListEntry.LaunchForUserAsync(User user)
-->

# Windows.ApplicationModel.Core.AppListEntry.LaunchForUserAsync

## -description
Launch the app associated with this [AppListEntry](applistentry.md) within the context of a specified user.

## -parameters
### -param user
The user context that the app should be launched under.

## -returns
Returns **true** if the launch succeeds; otherwise, **false**.

## -remarks
This is a Multi-User-Aware (MUA) API and can only be used by apps that declare themselves to be MUA, and only on devices that support MUA apps.
The app is launched in the same way as if the specified user clicked on the entry in the app list. The user is passed to the launched app via the event args. Passing `null` for `user` will result in an exception.

MUA apps launch with the a default user context. The `user` value, which is passed to the activated application via the event arguments, indicates who the app is activating on behalf of. A Single-User-Aware app will launch in the context of the `user` value that is passed into this API.

## -see-also
[Introduction to multi-user applications](/windows/uwp/xbox-apps/multi-user-applications)

## -examples
```csharp
public async void LaunchButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
{
    // The active User is retrieved from the initial activation args and validated against list of active users
    User user = this.GetAppActiveUser();
    PackageManager pm = new PackageManager();
    // The App Family Name is stored as part of the Product Display Page
    Package p = pm.FindPackage(this.GetFocusedAppFamilyName());
    IReadOnlyList<AppListEntry> entries = await p.GetAppListEntriesAsync();

    //This assumes the first app in the package should be launched, if there is one in the package
    if (entries.Count > 0)
    {
        await entries[0].LaunchForUserAsync(user);
    }
}
```
