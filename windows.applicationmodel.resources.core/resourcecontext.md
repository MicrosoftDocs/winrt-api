---
-api-id: T:Windows.ApplicationModel.Resources.Core.ResourceContext
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class ResourceContext : Windows.ApplicationModel.Resources.Core.IResourceContext
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext

## -description
Encapsulates all of the factors ([ResourceQualifier](resourcequalifier.md)s) that might affect resource selection.

## -remarks
Resources can be sensitive to scale, and different views owned by an app are able to display simultaneously on different display devices, which might use different scales. For that reason, a ResourceContext is generally associated with a specific view, and should be obtained using [GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md). (A view-independent **ResourceContext** can be obtained using [GetForViewIndependentUse](resourcecontext_getforviewindependentuse_386169056.md), but note that scale-dependent functionality will fail if invoked on a **ResourceContext** that is not associated with a view.)

Do not create an instance of ResourceContext using the constructor, as it is deprecated and subject to removal in a future release.

Except where otherwise noted, methods of this class can be called on any thread.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | GetForUIContext |

## -examples

This example is based on scenario 10 of the [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources). See the sample for the complete solution.

```csharp
private void Scenario10Button_Show_Click(object sender, RoutedEventArgs e)
{
    Button b = sender as Button;
    if (b != null)
    {
        // Use a cloned context for this scenario so that qualifier values set
        // in this scenario don't impact behavior in other scenarios that
        // use a default context for the view (crossover effects between
        // the scenarios will not be expected).
        var context = ResourceContext.GetForCurrentView().Clone();

        var selectedLanguage = Scenario10ComboBox_Language.SelectedValue;
        var selectedScale = Scenario10ComboBox_Scale.SelectedValue;
        var selectedContrast = Scenario10ComboBox_Contrast.SelectedValue;
        var selectedHomeRegion = Scenario10ComboBox_HomeRegion.SelectedValue;

        if (selectedLanguage != null)
        {
            context.QualifierValues["language"] = selectedLanguage.ToString();
        }
        if (selectedScale != null)
        {
            context.QualifierValues["scale"] = selectedScale.ToString();
        }
        if (selectedContrast != null)
        {
            context.QualifierValues["contrast"] = selectedContrast.ToString();
        }
        if (selectedHomeRegion != null)
        {
            context.QualifierValues["homeregion"] = selectedHomeRegion.ToString();
        }
        Scenario10_SearchMultipleResourceIds(context, new string[] { "LanguageOnly", "ScaleOnly", "ContrastOnly", "HomeRegionOnly", "MultiDimensional" });
    }
}

void Scenario10_SearchMultipleResourceIds(ResourceContext context, string[] resourceIds)
{
    this.Scenario10TextBlock.Text = "";
    var dimensionMap = ResourceManager.Current.MainResourceMap.GetSubtree("dimensions");

    foreach (var id in resourceIds)
    {
        NamedResource namedResource;
        if (dimensionMap.TryGetValue(id, out namedResource))
        {
            var resourceCandidates = namedResource.ResolveAll(context);
            Scenario10_ShowCandidates(id, resourceCandidates);
        }
    }
}

void Scenario10_ShowCandidates(string resourceId, IReadOnlyList<ResourceCandidate> resourceCandidates)
{
    // Print 'resourceId', 'found value', 'qualifer info', 'matching condition'
    string outText = "resourceId: dimensions\\" + resourceId + "\r\n";
    int i = 0;
    foreach (var candidate in resourceCandidates)
    {
        var value = candidate.ValueAsString;
        outText += "    Candidate " + i.ToString() + ":" + value + "\r\n";
        int j = 0;
        foreach (var qualifier in candidate.Qualifiers)
        {
            var qualifierName = qualifier.QualifierName;
            var qualifierValue = qualifier.QualifierValue;
            outText += "        Qualifer: " + qualifierName + ": " + qualifierValue + "\r\n";
            outText += "        Matching: IsMatch (" + qualifier.IsMatch.ToString() + ")  " + "IsDefault (" + qualifier.IsDefault.ToString() + ")" + "\r\n";
            j++;
        }
        i++;
    }

    this.Scenario10TextBlock.Text += outText + "\r\n";
}
```

## -see-also
[ResourceQualifier](resourcequalifier.md), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
