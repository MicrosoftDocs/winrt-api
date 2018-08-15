---
-api-id: T:Windows.ApplicationModel.Wallet.System.WalletItemAppAssociation
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Wallet.System.WalletItemAppAssociation : int
-->

# WalletItemAppAssociation

## -description
Defines values used by the [GetAppStatusForItem](walletitemsystemstore_getappstatusforitem_1214253302.md) method indicating if an app is installed for the specified [WalletItem](../windows.applicationmodel.wallet/walletitem.md).

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -enum-fields
### -field None:0
There is no app associated with the wallet item.

### -field AppInstalled:1
The app for the wallet item is installed on this device.

### -field AppNotInstalled:2
An app exists for the wallet item, but it is not installed on the device.


## -remarks

## -examples

## -see-also


## -capabilities
walletSystem
