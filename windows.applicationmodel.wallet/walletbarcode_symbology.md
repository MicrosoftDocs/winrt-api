---
-api-id: P:Windows.ApplicationModel.Wallet.WalletBarcode.Symbology
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Wallet.WalletBarcodeSymbology Symbology { get; }
-->

# Windows.ApplicationModel.Wallet.WalletBarcode.Symbology

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Gets the [symbology](walletbarcodesymbology.md) used by the bar code.

## -property-value
The bar code's symbology.
## -remarks
A *symbology* is the convention that defines the mapping between barcodes and the messages they represent. Barcodes for wallet items support several of the most common barcode symbologies, as defined by the values in [WalletBarcodeSymbology](walletbarcodesymbology.md). For other symbologies, you can provide your own barcode image (construct using [WalletBarcode(IRandomAccessStreamReference)](walletbarcode_walletbarcode_199548425.md)).
<!--in that case, is value Custom? Or Invalid? -->

## -examples

## -see-also
[WalletItem.Barcode](walletitem_barcode.md), [WalletBarcodeSymbology](walletbarcodesymbology.md)