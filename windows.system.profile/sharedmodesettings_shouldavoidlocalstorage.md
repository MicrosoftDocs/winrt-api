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
If true, then your app should not show local storage locations in its UI.

## -see-also

## -examples
``` xml
<StackPanel>
  <ListView x:Name="ThisPC" Header="This PC" .../>
  <ListView x:Name="OneDrive" Header="OneDrive" .../>
</StackPanel>
```
    
``` cs
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    if (Windows.System.Profile.SharedModeSettings.ShouldAvoidLocalStorage)
    {
        ThisPC.Visibility = Visibility.Collapsed;
    }
}
```
