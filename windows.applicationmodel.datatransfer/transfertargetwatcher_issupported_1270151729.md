---
-api-id: M:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.IsSupported(Windows.ApplicationModel.DataTransfer.DataPackageView)
-api-type: winrt method
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.IsSupported(Windows.ApplicationModel.DataTransfer.DataPackageView)

<!--
public static bool IsSupported (Windows.ApplicationModel.DataTransfer.DataPackageView dataPackage);
-->


## -description

The `IsSupported` method determines whether the specified data package is supported by any transfer targets. This method helps applications verify compatibility before initiating a sharing operation.

## -parameters

#### -param dataPackage

A `DataPackageView` object that represents the data package to check for compatibility. This parameter specifies the content to be shared.

## -returns

A `bool` value that is `true` if the data package is supported by at least one transfer target; otherwise, `false`.

## -remarks

The `IsSupported` method is a static method that allows applications to check whether the specified data package can be handled by any available transfer targets. This is useful for ensuring that sharing operations are only attempted with compatible data.

#### Usage Notes:

- Use this method to validate the data package before calling methods like `TransferToAsync`.
- If the method returns `false`, consider providing feedback to the user about the unsupported data.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [DataPackageView](datapackageview.md)

## -examples

#### Example: Checking if a Data Package is Supported

```csharp
var isSupported = TransferTargetWatcher.IsSupported(dataPackage);
if (isSupported)
{
    Console.WriteLine("The data package is supported.");
}
else
{
    Console.WriteLine("The data package is not supported.");
}
```
