---
-api-id: T:Windows.Storage.Provider.IStorageProviderStatusUISourceFactory
-api-type: winrt interface
---

# Windows.Storage.Provider.IStorageProviderStatusUISourceFactory

<!--
public interface IStorageProviderStatusUISourceFactory
-->

## -description

Returns an instance of IStorageProviderStatusUISource.

## -remarks

Cloud providers must implement this interface and register the implementation class in the app manifest or registry. Refer to the [sample app](https://github.com/microsoft/Windows-classic-samples/blob/7cbd99ac1d2b4a0beffbaba29ea63d024ceff700/Samples/CloudMirror/CloudMirror/MyStatusUISourceFactory.h) for an example.

## -see-also

[IStorageProviderStatusUISource](istorageproviderstatusuisource.md)
