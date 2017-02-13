---
-api-id: P:Windows.ApplicationModel.Resources.Core.ResourceQualifier.IsMatch
-api-type: winrt property
---

<!-- Property syntax
public bool IsMatch { get; }
-->

# Windows.ApplicationModel.Resources.Core.ResourceQualifier.IsMatch

## -description
Indicates whether a given qualifier for a given candidate matched the context when a named resource is resolved to a candidate for some given context.

## -property-value
**TRUE** if this qualifier matched the environment against which it was evaluated; otherwise, **FALSE**.

## -remarks
If a [ResourceQualifier](resourcequalifier.md) is obtained in a scenario that does not involve resolving a named resource for some context, the value is **FALSE**. (For example, when all candidates are enumerated for a named resource and their qualifiers are inspected.)

After resolving a named resource for some context, [IsMatch](resourcequalifier_ismatch.md) is **TRUE** if the qualifier matches the context on a non-default basis (that is, the qualifier value is not designated as the default value for that qualifier). The score is non-zero, and [IsDefault](resourcequalifier_isdefault.md) is **FALSE**.

After resolving a named resource for some context, [IsMatch](resourcequalifier_ismatch.md) is **FALSE** if the qualifier does not match the context on a non-default basis. (The qualifier value may or may not be the default value for that qualifier. The score may or may not be zero, according to whether the qualifier is the default value.)

## -examples

## -see-also
