---
-api-id: M:Windows.ApplicationModel.Core.AppListEntry.LaunchForUserAsync(Windows.System.User)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppListEntry.LaunchForUserAsync(User user)
-->

# Windows.ApplicationModel.Core.AppListEntry.LaunchForUserAsync

## -description
Launch the app associated with this [AppListEntry](applistentry.md) with the context of a specified user.

## -parameters
### -param user
The user context that the app should be launched under.

## -returns
Returns **true** if the launch succeeds; otherwise, **false**.

## -remarks
The user is passed to the launched app via the activated event args.
The app is launched without passing additional parameters. It is launched in the same way as if the specified user clicked on the entry in the app list.
Passing `null` for `user` will result in an exception.

## -see-also

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
