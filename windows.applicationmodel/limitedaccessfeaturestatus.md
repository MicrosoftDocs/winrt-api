---
-api-id: T:Windows.ApplicationModel.LimitedAccessFeatureStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LimitedAccessFeatureStatus : int 
-->

# Windows.ApplicationModel.LimitedAccessFeatureStatus

## -description

Provides the result of an attempt to authorize the use of a Limited Access Feature with the [LimitedAccessFeatures.TryUnlockFeature](limitedaccessfeatures_tryunlockfeature_180193416.md) API.

## -enum-fields
### -field Unknown:3

Indicates that the feature could not be found. This is likely due to an incorrect or deleted feature ID.

### -field Unavailable:0

Indicates that the user does not have access to the feature.

### -field AvailableWithoutToken:2

Indicates that the feature is no longer in the "limited access" state, and that permission is no longer required for its use.

### -field Available:1

Indicates that the user has permission to use the feature, and that the feature is still in the "limited access" state.

## -remarks

## -see-also

## -examples

