---
-api-id: M:Windows.Networking.BackgroundTransfer.DownloadOperation.GetResponseInformation
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.BackgroundTransfer.ResponseInformation GetResponseInformation()
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.GetResponseInformation

## -description
Gets the response information.

## -returns
Contains the data returned by a server response.

## -remarks
This method returns an object that contains information about the current server response. When calling this method multiple times, the object returned will be the same as long as there is no new server response information available. Sometimes however, one download consists of multiple requests to a server. If a request gets aborted due to some non-fatal error (e.g. machine lost internet connectivity, cost policy required download to pause, application called Pause(), etc.), Download API will invoke a new request and try to resume/restart the download. The response information from the server for this second request may be different than the one returned by the first request.

Returns **null** if any of the following conditions is true.


+ The transfer associated with the DownloadOperation is being made using a protocol other than HTTP (e.g., FTP).
+ The DownloadOperation hasn't yet begun.
+ There was a failure before any response from the server was received (e.g., connection couldn't be established).


## -examples

## -see-also
