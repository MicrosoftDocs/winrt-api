---
-api-id: M:Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.#ctor(Windows.ApplicationModel.DataTransfer.DataPackageView)
-api-type: winrt constructor
---

# Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.#ctor(Windows.ApplicationModel.DataTransfer.DataPackageView)

<!--
public TransferTargetDiscoveryOptions (Windows.ApplicationModel.DataTransfer.DataPackageView dataPackage);
-->


## -description

Initializes a new instance of the `TransferTargetDiscoveryOptions` class with the specified data package. This constructor allows applications to configure discovery options based on the content being shared.

## -parameters

#### -param dataPackage

A `DataPackageView` object that specifies the content to be shared. This parameter is used to filter relevant transfer targets.

## -remarks

The constructor sets the `DataPackage` property and initializes the discovery options. Applications can use this constructor to ensure that only transfer targets compatible with the specified data package are discovered.

#### Usage Notes:

- Ensure that the `dataPackage` parameter is not null when calling this constructor.
- Additional properties, such as `AllowedTargetAppIds` and `MaxAppTargets`, can be set after initialization.

## -see-also

[TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md), [DataPackageView](datapackageview.md)

## -examples

#### Example: Creating TransferTargetDiscoveryOptions with a DataPackage

```csharp
var dataPackage = new DataPackageView();
var options = new TransferTargetDiscoveryOptions(dataPackage);
options.MaxAppTargets = 5;
```
