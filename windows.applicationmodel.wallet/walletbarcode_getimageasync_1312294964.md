---
-api-id: M:Windows.ApplicationModel.Wallet.WalletBarcode.GetImageAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStreamReference> GetImageAsync()
-->

# Windows.ApplicationModel.Wallet.WalletBarcode.GetImageAsync

## -description
Creates and returns a bitmap image stream for the barcode (or returns the custom image used during instantiation).

## -returns
An asynchronous operation. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type on successful completion is an [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md) instance. This can be assigned as the source for an image (with some additional code).

## -remarks
If the [WalletBarcode](walletbarcode.md) object was instantiated using the [WalletBarcode](walletbarcode_walletbarcode_199548425.md) constructor that takes a custom image as a parameter, that custom image is returned on completion. Otherwise, an image of the system-defined barcode is created and then returned.

This method doesn't literally return an image object that's ready for UI, it returns a stream that defines a bitmap image. To actually set an image in JavaScript, you can use code similar to this:
```javascript
var awns = Windows.ApplicationModel.Wallet;
var wbc = new awns.WalletBarcode(awns.WalletBarcodeSymbology.qr, "123123123123");
wbc.getImageAsync().done(function (img) {
    if (img) {
        var img1 = document.getElementById("img1"); //existing <img> tag in this script's scope
        img.openReadAsync().done(function (blob) {
            var stream = MSApp.createStreamFromInputStream("image/bmp", blob);
            img1.src = URL.createObjectURL(stream);
        })
     }
});
```



## -examples

## -see-also
[IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [Asynchronous programming in JavaScript](https://docs.microsoft.com/previous-versions/windows/apps/hh700330(v=win.10))
