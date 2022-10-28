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
private void SearchMultipleResourceIds(string language, string scale, string contrast, string homeRegion)
{
    // use a cloned context for this scenario so that qualifier values set
    // in this scenario don't impact behavior in other scenarios that
    // use a default context for the view (crossover effects between
    // the scenarios will not be expected)
    ResourceContext context = ResourceContext.GetForCurrentView().Clone();
    context.QualifierValues["language"] = language;
    context.QualifierValues["scale"] = scale;
    context.QualifierValues["contrast"] = contrast;
    context.QualifierValues["homeregion"] = homeRegion;
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

```cpp
void SDKTemplate::Scenario10::Scenario10Button_Show_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    Button^ b = safe_cast<Button^>(sender);
    if (b != nullptr)
    {
        // use a cloned context for this scenario so that qualifier values set
        // in this scenario don't impact behavior in other scenarios that
        // use a default context for the view (crossover effects between
        // the scenarios will not be expected)
        auto context = ResourceContext::GetForCurrentView()->Clone();

        auto selectedLanguage = Scenario10ComboBox_Language->SelectedValue;
        auto selectedScale = Scenario10ComboBox_Scale->SelectedValue;
        auto selectedContrast = Scenario10ComboBox_Contrast->SelectedValue;
        auto selectedHomeRegion = Scenario10ComboBox_HomeRegion->SelectedValue;

        if (selectedLanguage != nullptr)
        {
            context->QualifierValues->Insert("language", selectedLanguage->ToString());
        }
        if (selectedScale != nullptr)
        {
            context->QualifierValues->Insert("scale", selectedScale->ToString());
        }
        if (selectedContrast != nullptr)
        {
            context->QualifierValues->Insert("contrast", selectedContrast->ToString());
        }
        if (selectedHomeRegion != nullptr)
        {
            context->QualifierValues->Insert("homeregion", selectedHomeRegion->ToString());
        }

        Platform::Collections::Vector<String^>^ resourceIds = ref new Platform::Collections::Vector<String^>();
        resourceIds->Append("LanguageOnly");
        resourceIds->Append("ScaleOnly");
        resourceIds->Append("ContrastOnly");
        resourceIds->Append("HomeRegionOnly");
        resourceIds->Append("MultiDimensional");
        Scenario10_SearchMultipleResourceIds(context, resourceIds);
    }
}

void SDKTemplate::Scenario10::Scenario10_SearchMultipleResourceIds(ResourceContext^ context, Platform::Collections::Vector<String^>^ resourceIds)
{
    Scenario10TextBlock->Text = "";
    auto dimensionMap = ResourceManager::Current->MainResourceMap->GetSubtree("dimensions");

    for (unsigned int it = 0; it < resourceIds->Size; it++)
    {
        String^ id = resourceIds->GetAt(it);
        NamedResource^ namedResource = dimensionMap->Lookup(id);
        if (namedResource)
        {
            auto resourceCandidates = namedResource->ResolveAll(context);
            Scenario10_ShowCandidates(resourceIds->GetAt(it), resourceCandidates);
        }
    }
}

void SDKTemplate::Scenario10::Scenario10_ShowCandidates(String^ resourceId, Windows::Foundation::Collections::IVectorView<ResourceCandidate^>^ resourceCandidates)
{
    // print 'resourceId', 'found value', 'qualifier info', 'matching condition'
    String^ outText = "resourceId: dimensions\\" + resourceId + "\r\n";

    for(unsigned int i =0; i < resourceCandidates->Size; i++)
    {
        ResourceCandidate^ candidate = resourceCandidates->GetAt(i);
        auto value = candidate->ValueAsString;

        outText += "    Candidate " + i.ToString() + ":" + value + "\r\n";
        for (unsigned int j = 0; j < candidate->Qualifiers->Size; j++)
        {
            auto qualifier = candidate->Qualifiers->GetAt(j);
            auto qualifierName = qualifier->QualifierName;
            auto qualifierValue = qualifier->QualifierValue;
            outText += "        Qualifier: " + qualifierName + ": " + qualifierValue + "\r\n";
            outText += "        Matching: IsMatch (" + qualifier->IsMatch.ToString() + ")  " + "IsDefault (" + qualifier->IsDefault.ToString() + ")" + "\r\n";
        }
    }

    this->Scenario10TextBlock->Text += outText + "\r\n";

}
```

## -see-also

[App resources and the Resource Management System](/windows/uwp/app-resources/), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
