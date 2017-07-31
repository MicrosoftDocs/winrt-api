---
-api-id: P:Windows.Networking.BackgroundTransfer.DownloadOperation.IsRandomAccessRequired
-api-type: winrt property
---

<!-- Property syntax.
public bool IsRandomAccessRequired { get;  set; }
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.IsRandomAccessRequired

## -description
A boolean property to enable random access. The property must be set to TRUE before calling StartAsync() on a [DownloadOperation](downloadoperation.md) object to use the random access feature. After calling StartAsync(), call [GetResultRandomAccessStreamReference](downloadoperation_getresultrandomaccessstreamreference_1794718843.md) to get a reference to the random access stream and read from it.  

## -property-value
TRUE to use the random access feature. The default value is FALSE. 
## -remarks
The IsRandomAccessRequired setter will fail with E_ILLEGAL_METHOD_CALL and a custom error message if StartAsync() has already been called on the [DownloadOperation](downloadoperation.md).  

## -see-also
[DownloadOperation](downloadoperation.md), [GetResultRandomAccessStreamReference](downloadoperation_getresultrandomaccessstreamreference_1794718843.md)
## -examples

