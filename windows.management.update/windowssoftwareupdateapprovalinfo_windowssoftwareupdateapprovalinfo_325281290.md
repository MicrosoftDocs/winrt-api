---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateApprovalInfo.#ctor(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsSoftwareUpdateApprovalInfo.#ctor(System.Boolean,System.Boolean,System.Boolean,System.Boolean)

<!--
public WindowsSoftwareUpdateApprovalInfo (bool userInitiated, bool appClosure, bool meteredNetwork, bool seeker);
-->


## -description

Creates a new [WindowsSoftwareUpdateApprovalInfo](./windowssoftwareupdateapprovalinfo.md) with the specified approval conditions.

## -parameters

### -param userInitiated

`true` if the update was approved as a result of a user-initiated request; otherwise, `false`.

### -param appClosure

`true` to allow the update to close the target application if doing so is required to complete an action; otherwise, `false`.

### -param meteredNetwork

`true` to allow the update to download over a metered network; otherwise, `false`.

### -param seeker

`true` if the update is approved as a seeker update (one that a user explicitly sought out); otherwise, `false`.

## -remarks


## -see-also

[WindowsSoftwareUpdateApprovalInfo](./windowssoftwareupdateapprovalinfo.md)

## -examples

