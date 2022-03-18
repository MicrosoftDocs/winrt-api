---
-api-id: P:Windows.System.Profile.SharedModeSettings.ShouldAvoidLocalStorage
-api-type: winrt property
---

<!-- Property syntax.
public bool ShouldAvoidLocalStorage { get; }
-->

# Windows.System.Profile.SharedModeSettings.ShouldAvoidLocalStorage

## -description
Gets a Boolean value indicating that your app should not store files on the local hard drive.

## -property-value
A Boolean value indicating that apps should not store files on the local hard drive. Instead, files should be saved to cloud storage.

## -remarks
If **true**, then your app should not show local storage locations in its UI.  

Returns **true** when the [RestrictLocalStorage](/windows/client-management/mdm/sharedpc-csp) policy is set.  
	
A **true** value means the PC is running in a scenario where apps should hide all entry and save points to the local disk. Windows File Explorer is disabled so customers won’t be able to navigate to any local storage (except downloads, removable drives, and mapped network drives) to access those files.


## -see-also

## -examples
```xaml
<StackPanel>
  <ListView x:Name="ThisPC" Header="This PC" .../>
  <ListView x:Name="OneDrive" Header="OneDrive" .../>
</StackPanel>
```

```csharp
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    if (Windows.System.Profile.SharedModeSettings.ShouldAvoidLocalStorage)
    {
        ThisPC.Visibility = Visibility.Collapsed;
    }
}
```
