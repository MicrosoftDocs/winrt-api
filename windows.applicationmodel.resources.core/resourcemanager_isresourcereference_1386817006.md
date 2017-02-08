---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceManager.IsResourceReference(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsResourceReference(System.String resourceReference)
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager.IsResourceReference

## -description
Determines whether a supplied string matches the resource reference format (an ms-resource string URI identifier).
<!--Note: MRT acronym removed during edit process. TODO: add more detail to main description and in Remarks section.-->

## -parameters
### -param resourceReference
The string you want to match.

## -returns
**TRUE** if the string matches.

## -remarks
An example of matching an ms-resource string URI identifier format: `isResourceReference('ms-resource:Hello')` returns **true**, but `isResourceReference('Hello')` returns **false**.

## -examples

## -see-also
