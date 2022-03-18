---
-api-id: T:Windows.ApplicationModel.Wallet.WalletBarcode
-api-type: winrt class
---

<!-- Class syntax.
public class WalletBarcode : Windows.ApplicationModel.Wallet.IWalletBarcode
-->

# Windows.ApplicationModel.Wallet.WalletBarcode

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Represents a bar code assigned to a wallet item.

## -remarks
Use [WalletBarcode(WalletBarcodeSymbology, String)](walletbarcode_walletbarcode_30902746.md) to construct a scheme-generated barcode image (which is realized when you call [GetImageAsync](walletbarcode_getimageasync_1312294964.md)). Use [WalletBarcode(IRandomAccessStreamReference)](walletbarcode_walletbarcode_199548425.md) to construct a barcode that you supply the image for.

The WalletBarcode class provides the value for the [WalletItem.Barcode](walletitem_barcode.md) property.

## -examples

## -see-also
[WalletItem](walletitem.md), [WalletItem.Barcode](walletitem_barcode.md)
