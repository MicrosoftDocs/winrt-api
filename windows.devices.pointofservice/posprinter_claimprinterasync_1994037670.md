---
-api-id: M:Windows.Devices.PointOfService.PosPrinter.ClaimPrinterAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.ClaimedPosPrinter> ClaimPrinterAsync()
-->

# Windows.Devices.PointOfService.PosPrinter.ClaimPrinterAsync

## -description
Claims the point-of-service printer for use, and gets an instance of the [ClaimedPosPrinter](claimedposprinter.md) class for the point-of-service printer.

## -returns
The claimed point-of-service printer.

## -remarks
The claim is cooperatively managed, so multiple concurrent apps can negotiate which app owns the claim.

## -examples

## -see-also
