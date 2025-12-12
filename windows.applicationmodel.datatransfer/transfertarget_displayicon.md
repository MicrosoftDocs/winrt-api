---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTarget.DisplayIcon
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTarget.DisplayIcon

<!--
public Windows.Storage.Streams.IRandomAccessStreamReference DisplayIcon { get; }
-->


## -description

The `DisplayIcon` property gets the icon associated with the transfer target. This icon is typically used to visually represent the target in the user interface.

## -property-value

A `IRandomAccessStreamReference` that represents the icon of the transfer target.

## -remarks

The `DisplayIcon` property provides a way to retrieve the visual representation of a transfer target. Applications can use this property to display the icon in their user interface, making it easier for users to identify the target.

#### Usage Notes:

- The icon can be displayed in lists or dialogs where transfer targets are presented to the user.
- Ensure that the application handles cases where the icon might not be available.

## -see-also

[TransferTarget](transfertarget.md), [IRandomAccessStreamReference](https://learn.microsoft.com/uwp/api/windows.storage.streams.irandomaccessstreamreference)

## -examples

#### Example: Displaying the Icon of a Transfer Target

```csharp
var icon = transferTarget.DisplayIcon;
if (icon != null)
{
    // Use the icon in the UI
    var bitmapImage = new BitmapImage();
    bitmapImage.SetSource(await icon.OpenReadAsync());
    myImageControl.Source = bitmapImage;
}
else
{
    // Handle the case where no icon is available
    myImageControl.Source = null;
}
```
