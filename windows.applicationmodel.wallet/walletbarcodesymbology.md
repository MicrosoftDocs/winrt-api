---
-api-id: T:Windows.ApplicationModel.Wallet.WalletBarcodeSymbology
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Wallet.WalletBarcodeSymbology : int
-->

# WalletBarcodeSymbology

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Represents the barcode symbology types that are supported for a [WalletItem](walletitem.md).

## -enum-fields
### -field Invalid:0
Invalid barcode type.

### -field Upca:1
Uses the **UPC-A** barcode symbology.

### -field Upce:2
Uses the **UPC-E** barcode symbology.

### -field Ean13:3
Uses the **EAN-13** barcode symbology.

### -field Ean8:4
Uses the **EAN-8** barcode symbology.

### -field Itf:5
Uses the **ITF** barcode symbology.

### -field Code39:6
Uses the **Code 39** barcode symbology.

### -field Code128:7
Uses the **Code 128** barcode symbology.

### -field Qr:8
Uses the **QR Code** barcode symbology.

### -field Pdf417:9
Uses the **PDF417** barcode symbology.

### -field Aztec:10
Uses the **Aztec** barcode symbology.

### -field Custom:100000
Uses a custom bar code symbology.


## -remarks
Each value other than **Invalid** and **Custom** enables creation of the barcode image by the system, when you call [GetImageAsync](walletbarcode_getimageasync_1312294964.md). For symbologies that aren't in this enumeration, use the [WalletBarcode(IRandomAccessStreamReference)](walletbarcode_walletbarcode_199548425.md) constructor and provide your own image.

## -examples

## -see-also
[WalletBarcode class](walletbarcode.md), [WalletBarcode(WalletBarcodeSymbology, String) constructor](walletbarcode_walletbarcode_30902746.md), [Symbology property](walletbarcode_symbology.md)