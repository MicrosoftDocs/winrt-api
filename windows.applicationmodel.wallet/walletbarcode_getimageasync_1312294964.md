---
-api-id: M:Windows.ApplicationModel.Wallet.WalletBarcode.GetImageAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStreamReference> GetImageAsync()
-->

# Windows.ApplicationModel.Wallet.WalletBarcode.GetImageAsync

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Creates and returns a bitmap image stream for the barcode (or returns the custom image used during instantiation).

## -returns
An asynchronous operation. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type on successful completion is an [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md) instance. This can be assigned as the source for an image (with some additional code).
## -remarks
If the [WalletBarcode](walletbarcode.md) object was instantiated using the [WalletBarcode](walletbarcode_walletbarcode_199548425.md) constructor that takes a custom image as a parameter, that custom image is returned on completion. Otherwise, an image of the system-defined barcode is created and then returned.

This method doesn't literally return an image object that's ready for UI, it returns a stream that defines a bitmap image. To actually set an image, you can use code similar to this:

```xaml
<Button Content="Generate barcode" Click="Button_Click"/>
<Image x:Name="barcodeImage"/>
```

```csharp
private async void Button_Click(object sender, RoutedEventArgs e)
{
    var walletBarcode = new WalletBarcode(WalletBarcodeSymbology.Qr, "123123123123");

    IRandomAccessStreamReference streamRef = await walletBarcode.GetImageAsync();
    IRandomAccessStream stream = await streamRef.OpenReadAsync();

    var bitmapImage = new BitmapImage();
    await bitmapImage.SetSourceAsync(stream);
    barcodeImage.Source = bitmapImage;
}
```

## -examples

## -see-also
[IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)