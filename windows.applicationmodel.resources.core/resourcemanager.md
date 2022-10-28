---
-api-id: T:Windows.ApplicationModel.Resources.Core.ResourceManager
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceManager : Windows.ApplicationModel.Resources.Core.IResourceManager, Windows.ApplicationModel.Resources.Core.IResourceManager2
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager

## -description

Provides access to application resource maps and more advanced resource functionality.

## -remarks

## -examples

This example is based on scenario 10 of the [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources). See the sample for the more complete solution.

```csharp
private void SearchMultipleResourceIds()
{
    // use a cloned context for this scenario so that qualifier values set
    // in this scenario don't impact behavior in other scenarios that
    // use a default context for the view (crossover effects between
    // the scenarios will not be expected)
    ResourceContext context = ResourceContext.GetForCurrentView().Clone();
    var resourceIds = new string[] { "LanguageOnly", "ScaleOnly", "ContrastOnly", "HomeRegionOnly", "MultiDimensional" }
    var dimensionMap = ResourceManager.Current.MainResourceMap.GetSubtree("dimensions");

    foreach (var id in resourceIds)
    {
        NamedResource namedResource;
        if (dimensionMap.TryGetValue(id, out namedResource))
        {
            var resourceCandidates = namedResource.ResolveAll(context);
            string candidateInfo = ShowCandidates(id, resourceCandidates);
        }
    }
    Console.WriteLine(candidateInfo);
}

private string ShowCandidates(string resourceId, IReadOnlyList<ResourceCandidate> resourceCandidates)
{
    // print 'resourceId', 'found value', 'qualifier info', 'matching condition'
    string outText = "resourceId: dimensions\\" + resourceId + "\r\n";
    int i = 0;

    foreach (var candidate in resourceCandidates)
    {
        var value = candidate.ValueAsString;
        outText += "    Candidate " + i.ToString() + ":" + value + "\r\n";

        foreach (var qualifier in candidate.Qualifiers)
        {
            var qualifierName = qualifier.QualifierName;
            var qualifierValue = qualifier.QualifierValue;
            outText += "        Qualifier: " + qualifierName + ": " + qualifierValue + "\r\n";
            outText += "        Matching: IsMatch (" + qualifier.IsMatch.ToString() + ")  " + "IsDefault (" + qualifier.IsDefault.ToString() + ")" + "\r\n";
        }
        i++;
    }

    return outText + "\r\n";
}
```

## -see-also

[App resources and the Resource Management System](/windows/uwp/app-resources/), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
