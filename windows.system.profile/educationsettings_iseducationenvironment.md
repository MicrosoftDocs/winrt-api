---
-api-id: P:Windows.System.Profile.EducationSettings.IsEducationEnvironment
-api-type: winrt property
---

<!-- Property syntax.
public bool IsEducationEnvironment { get; }
-->

# Windows.System.Profile.EducationSettings.IsEducationEnvironment

## -description
Gets a Boolean value indicating if the app is running in an education environment.

## -property-value
A Boolean value indicating if the app is running in an education environment.

## -remarks
Returns **true** when running an Education SKU (Pro Education or Education).  

Returns **true** when the [SetEduPolicies](/windows/client-management/mdm/sharedpc-csp) policy is set.   

Always returns **false** on the Home SKU.  

A **true** value means the PC is running in an education environment (set either by the SKU or by the IT admin) and sets policies and behaviors to make Windows education ready.

## -see-also

## -examples
```csharp
if (Windows.System.Profile.EducationSettings.IsEducationEnvironment)
{
    SetHomePage("about:EDU");
}
else
{
    SetHomePage("about:start");
}
```
