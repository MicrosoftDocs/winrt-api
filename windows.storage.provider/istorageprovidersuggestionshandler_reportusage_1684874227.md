---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.ReportUsage(Windows.Storage.Provider.StorageProviderResultUsageKind,System.String,System.String,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.ReportUsage(Windows.Storage.Provider.StorageProviderResultUsageKind,System.String,System.String,Windows.Foundation.TimeSpan)

<!--
public void ReportUsage (Windows.Storage.Provider.StorageProviderResultUsageKind resultUsageKind, string remoteFileId, string resultId, System.TimeSpan latency);
-->

## -description

Sends feedback on usage of a file or folder to the system.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandler** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param resultUsageKind

The kind of usage to report.

### -param remoteFileId

The remote ID of the file or folder.

### -param resultId

The ID of the usage to report.

### -param latency

The time taken to perform the operation.

## -remarks

This is expected to be a blocking call and should not be called on a UI thread.

## -see-also

## -examples
