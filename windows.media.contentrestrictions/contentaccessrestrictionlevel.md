---
-api-id: T:Windows.Media.ContentRestrictions.ContentAccessRestrictionLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.ContentRestrictions.ContentAccessRestrictionLevel : int
-->

# ContentAccessRestrictionLevel

## -description
Specifies how the content is treated, based on the user's content settings.

## -enum-fields
### -field Allow:0
Can be shown in the content catalog and consumed.

### -field Warn:1
(Xbox only) If multiple users are logged in and the content is blocked for at least one user, content is allowed with a warning displayed.

### -field Block:2
Can be shown in the content catalog, but will be blocked by [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync_637668410.md).

### -field Hide:3
Can't be shown in the content catalog. It's rating is higher than the user's settings, determined by [MaxBrowsableAgeRating](contentrestrictionsbrowsepolicy_maxbrowsableagerating.md).


## -remarks

## -examples

## -see-also