---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.DataPackage
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.DataPackage

<!--
public Windows.ApplicationModel.DataTransfer.DataPackageView DataPackage { get; }
-->


## -description

The `DataPackage` property gets the data package used to filter relevant transfer targets. This property specifies the content that is being shared.

## -property-value

A `DataPackageView` object that represents the data package used for filtering.

## -remarks

The `DataPackage` property allows applications to specify the content being shared, which helps in discovering transfer targets that can handle the specified data.

#### Usage Notes:

- This property is read-only and must be set during the initialization of the `TransferTargetDiscoveryOptions`.
- Use this property to ensure that only compatible transfer targets are discovered.

## -see-also

[TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md), [DataPackageView](https://learn.microsoft.com/uwp/api/windows.applicationmodel.datatransfer.datapackageview)

## -examples

#### Example: Accessing the DataPackage Property

```csharp
var dataPackage = options.DataPackage;
if (dataPackage != null)
{
    Console.WriteLine("DataPackage is set.");
}
```
