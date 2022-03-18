---
-api-id: T:Windows.ApplicationModel.Resources.Core.NamedResource
-api-type: winrt class
---

<!-- Class syntax.
public class NamedResource : Windows.ApplicationModel.Resources.Core.INamedResource
-->

# Windows.ApplicationModel.Resources.Core.NamedResource

## -description
Represents a single logical, named resource, such as a string resource named 'Header1'.

## -remarks

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
[Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
