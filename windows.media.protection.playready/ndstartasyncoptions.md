---
-api-id: T:Windows.Media.Protection.PlayReady.NDStartAsyncOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.PlayReady.NDStartAsyncOptions : int
-->

# NDStartAsyncOptions

## -description
Indicates the asynchronous start options. This enumeration is a bitwise OR and is used by the [StartAsync](ndclient_startasync.md) method.

## -enum-fields
### -field MutualAuthentication:1
If set, the transmitter's certificate will be presented to the caller through a [RegistrationCompleted](ndclient_registrationcompleted.md) event for verification. The caller should set a flag to accept or reject it. If not set, **RegistrationCompleted** will not contain the certificate.

### -field WaitForLicenseDescriptor:2
If set and the *LicenseFetchDescriptor* parameter is **null** for [StartAsync](ndclient_startasync.md), then **StartAsync** will wait for **OnContentIDReceived** from either [NDDownloadEngineNotifier](nddownloadenginenotifier.md) or [NDStreamParserNotifier](ndstreamparsernotifier.md). After **OnContententIDReceived**, the received *LicenseFetchDescriptor* is used to perform the license fetch. If not set and the *LicenseFetchDescriptor* parameter is **null** for **StartAsync**, then **StartAsync** assumes you already acquired the license beforehand and will not do a license fetch. Note that if *LicenseFetchDescriptor* is not **null**, this flag is ignored and a license fetch will be performed.


## -remarks

## -examples

## -see-also