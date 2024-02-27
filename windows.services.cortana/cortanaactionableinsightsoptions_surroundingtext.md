---
-api-id: P:Windows.Services.Cortana.CortanaActionableInsightsOptions.SurroundingText
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string SurroundingText { get;  set; }
-->

# Windows.Services.Cortana.CortanaActionableInsightsOptions.SurroundingText

## -description

Text from the surrounding context of the content supplied to [CortanaActionableInsights](cortanaactionableinsights.md) for showing insights.



## -property-value

The textual context surrounding the content (maximum length of 3000 characters). This value can be null.

## -capabilities

cortanaSurface

## -remarks

If the setter is called with a string exceeding the maximum length, an exception is thrown.

The [CortanaActionableInsights](cortanaactionableinsights.md) class requires the following be added to the Package.appxmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaSurface"/>`

## -see-also

## -examples
