---
-api-id: P:Windows.Services.Store.StoreAppLicense.IsDiscLicense
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsDiscLicense { get; }
-->

# Windows.Services.Store.StoreAppLicense.IsDiscLicense

## -description
Gets a value that indicates whether the current license was acquired from a disc-based installation.

## -property-value
True if the current license was acquired from a disc-based installation; otherwise, false.

## -remarks
This property is useful if you are a game developer who wants to determine whether the current customer acquired your game's license by installing it from a disc (rather than acquiring it from a Store purchase or some other process). You might want to use this information if you are building a differentiated monetization experience where customers who acquire your game in different ways will get access to different sets of features.

## -see-also

## -examples
