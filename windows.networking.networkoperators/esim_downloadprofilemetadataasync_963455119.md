---
-api-id: M:Windows.Networking.NetworkOperators.ESim.DownloadProfileMetadataAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimDownloadProfileMetadataResult> ESim.DownloadProfileMetadataAsync(String activationCode)
-->

# Windows.Networking.NetworkOperators.ESim.DownloadProfileMetadataAsync

## -description
Asynchronously downloads installation metadata for the eSIM profile that corresponds to the specified activation code.

> [!NOTE]
> To use this API you will need to contact Microsoft to request the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live).

## -parameters
### -param activationCode
The activation code for the eSIM profile installation metadata to download.

## -returns
An asynchronous download operation. On successful completion, contains an [ESimDownloadProfileMetadataResult](esimdownloadprofilemetadataresult.md) object representing the result of the download operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe