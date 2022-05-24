---
-api-id: T:Windows.System.UserAgeConsentResult
-api-type: winrt enum
---

# Windows.System.UserAgeConsentResult

<!--
public enum UserAgeConsentResult
-->


## -description

Specifies the result of a call to [CheckUserAgeConsentGroupAsync](user_checkuserageconsentgroupasync_43625918.md), querying for a user's membership in a specified [UserAgeConsentGroup](userageconsentgroup.md).

## -enum-fields

### -field NotEnforced: 0

The user's region does not use age consent enforcement groups. 

### -field Included: 1

The user is a member of the specified group, or a group that includes the specified group. For example, checking for **Minor** will return **Included** if the user is an **Adult**, because **Adult** is a superset of **Minor**.

### -field NotIncluded: 2

The user is not a member of the specified group.

### -field Unknown: 3

The system cannot determine which enforcement group the user belongs to. 

### -field Ambiguous: 4

The specified enforcement group is obsolete, and the user belongs to an enforcement group that partially overlaps it. 

## -remarks

## -see-also

## -examples


