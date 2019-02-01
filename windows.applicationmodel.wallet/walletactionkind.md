---
-api-id: T:Windows.ApplicationModel.Wallet.WalletActionKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Wallet.WalletActionKind : int
-->

# WalletActionKind

## -description
Represents the action that was taken on the item that caused your app to launch.

## -enum-fields
### -field OpenItem:0
The item was opened.

### -field Transaction:1
A transaction was tapped.

### -field MoreTransactions:2
The UI item "see more transactions" was tapped.

### -field Message:3
A message was tapped.

### -field Verb:4
A verb was tapped.


## -remarks
When your app is launched as a result of an action on an item in Wallet, the **OnActivated** event handler in your app is called. The [Kind](../windows.applicationmodel.activation/activationkind.md) value in the [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md) data is **WalletAction**. To access the information specific to wallet activation, cast the [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md) to [WalletActionActivatedEventArgs](../windows.applicationmodel.activation/walletactionactivatedeventargs.md).

> [!NOTE]
> JavaScript uses [Windows.UI.WebUI.IActivatedEventArgs](../windows.ui.webui/iactivatedeventargsdeferral.md) and [WebUIWalletActionActivatedEventArgs](../windows.ui.webui/webuiwalletactionactivatedeventargs.md).

## -examples

## -see-also
[WalletActionActivatedEventArgs](../windows.applicationmodel.activation/walletactionactivatedeventargs.md), [WebUIWalletActionActivatedEventArgs](../windows.ui.webui/webuiwalletactionactivatedeventargs.md), [Handle app activation](https://msdn.microsoft.com/library/da9a6a43-f09d-4512-a2ab-9b6132431007), [App lifecycle](https://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10)
