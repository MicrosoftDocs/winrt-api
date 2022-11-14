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

This example is based on scenario 12 of the [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources). See the sample for the complete solution.

```csharp
private async void Scenario12Button_Show_Click(object sender, RoutedEventArgs e)
{
    // Two coding patterns will be used:
    //   1. Get a ResourceContext on the UI thread using GetForCurrentView and pass 
    //      to the non-UI thread
    //   2. Get a ResourceContext on the non-UI thread using GetForViewIndependentUse
    //
    // Two analogous patterns could be used for ResourceLoader instead of ResourceContext.

    // pattern 1: get a ResourceContext for the UI thread
    ResourceContext defaultContextForUiThread = ResourceContext.GetForCurrentView();

    // pattern 2: we'll create a view-independent context in the non-UI worker thread

    // We need some things in order to display results in the UI (doing that
    // for purposes of this sample, to show that work was actually done in the
    // worker thread):
    List<string> uiDependentResourceList = new List<string>();
    List<string> uiIndependentResourceList = new List<string>();

    // use a worker thread for the heavy lifting so the UI isn't blocked
    await Windows.System.Threading.ThreadPool.RunAsync(
        (source) =>
        {
            ResourceMap stringResourceMap = ResourceManager.Current.MainResourceMap.GetSubtree("Resources");

            // pattern 1: the defaultContextForUiThread variable was created above and is visible here

            // pattern 2: get a view-independent ResourceContext
            ResourceContext defaultViewIndependentResourceContext = ResourceContext.GetForViewIndependentUse();

            // NOTE: The ResourceContext obtained using GetForViewIndependentUse() has no scale qualifier
            // value set. If this ResourceContext is used in its default state to retrieve a resource, that 
            // will work provided that the resource does not have any scale-qualified variants. But if the
            // resource has any scale-qualified variants, then that will fail at runtime.
            //
            // A scale qualifier value on this ResourceContext can be set programmatically. If that is done,
            // then the ResourceContext can be used to retrieve a resource that has scale-qualified variants.
            // But if the scale qualifier is reset (e.g., using the ResourceContext.Reset() method), then
            // it will return to the default state with no scale qualifier value set, and cannot be used
            // to retrieve any resource that has scale-qualified variants.

            // simulate processing a number of items
            // just using a single string resource: that's sufficient to demonstrate 
            for (var i = 0; i < 4; i++)
            {
                // pattern 1: use the ResourceContext from the UI thread
                string listItem1 = stringResourceMap.GetValue("string1", defaultContextForUiThread).ValueAsString;
                uiDependentResourceList.Add(listItem1);

                // pattern 2: use the view-independent ResourceContext
                string listItem2 = stringResourceMap.GetValue("string1", defaultViewIndependentResourceContext).ValueAsString;
                uiIndependentResourceList.Add(listItem2);
            }
        });

    // Display the results in one go. (A more finessed design might add results
    // in the UI asynchronously, but that goes beyond what this sample is 
    // demonstrating.)
    ViewDependentResourcesList.ItemsSource = uiDependentResourceList;
    ViewIndependentResourcesList.ItemsSource = uiIndependentResourceList;
}
```

```cpp
void Scenario12::Scenario12Button_Show_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    // Two coding patterns will be used:
    //   1. Get a ResourceContext on the UI thread using GetForCurrentView and pass 
    //      to the non-UI thread
    //   2. Get a ResourceContext on the non-UI thread using GetForViewIndependentUse
    //
    // Two analogous patterns could be used for ResourceLoader instead of ResourceContext.

    // pattern 1: get a ResourceContext for the UI thread
    ResourceContext^ defaultContextForUiThread = ResourceContext::GetForCurrentView();

    // pattern 2: we'll create a view-independent context in the non-UI worker thread

    // We need some things in order to display results in the UI (doing that
    // for purposes of this sample, to show that work was actually done in the
    // worker thread): a pair of vectors to capture data, and a pair of variable 
    // references to the controls where the results will be displayed (needed to
    // pass to the .then lambda).
    Platform::Collections::Vector<Platform::String^>^ uiDependentResourceItems = ref new Platform::Collections::Vector<Platform::String^>();
    Platform::Collections::Vector<Platform::String^>^ uiIndependentResourceItems = ref new Platform::Collections::Vector<Platform::String^>();
    ItemsControl^ viewDependentListControl = ViewDependentResourcesList;
    ItemsControl^ viewIndependentListControl = ViewIndependentResourcesList;


    // use a worker thread for the heavy lifting so the UI isn't blocked
    concurrency::create_task(
        Windows::System::Threading::ThreadPool::RunAsync(
            ref new Windows::System::Threading::WorkItemHandler(
            [defaultContextForUiThread, uiDependentResourceItems, uiIndependentResourceItems](Windows::Foundation::IAsyncAction^ /*action*/)
        {
            // This is happening asynchronously on a background worker thread,
            // not on the UI thread.
            ResourceMap^ stringResourceMap = ResourceManager::Current->MainResourceMap->GetSubtree("Resources");

            // coding pattern 1: the defaultContextForUiThread variable was created above and has been captured to use here

            // coding pattern 2: get a view-independent ResourceContext
            ResourceContext^ defaultViewIndependentResourceContext = ResourceContext::GetForViewIndependentUse();

            // NOTE: The ResourceContext obtained using GetForViewIndependentUse() has no scale qualifier
            // value set. If this ResourceContext is used in its default state to retrieve a resource, that 
            // will work provided that the resource does not have any scale-qualified variants. But if the
            // resource has any scale-qualified variants, then that will fail at runtime.
            //
            // A scale qualifier value on this ResourceContext can be set programmatically. If that is done,
            // then the ResourceContext can be used to retrieve a resource that has scale-qualified variants.
            // But if the scale qualifier is reset (e.g., using the ResourceContext::Reset() method), then
            // it will return to the default state with no scale qualifier value set, and cannot be used
            // to retrieve any resource that has scale-qualified variants.

            // simulate processing a number of items
            // just using a single string resource: that's sufficient to demonstrate 
            for (auto i = 0; i < 4; i++)
            {
                // pattern 1: use the ResourceContext from the UI thread
                Platform::String^ item1 = stringResourceMap->GetValue("string1", defaultContextForUiThread)->ValueAsString;
                uiDependentResourceItems->Append(item1);

                // pattern 2: use the view-independent ResourceContext
                Platform::String^ item2 = stringResourceMap->GetValue("string1", defaultViewIndependentResourceContext)->ValueAsString;
                uiIndependentResourceItems->Append(item2);
            }
        }))
    ).then([uiDependentResourceItems, uiIndependentResourceItems, viewDependentListControl, viewIndependentListControl]
    {
        // After the async work is complete, this will execute on the UI thread.

        // Display the results in one go. (A more finessed design might add results
        // in the UI asynchronously, but that goes beyond what this sample is 
        // demonstrating.)
        viewDependentListControl->ItemsSource = uiDependentResourceItems;
        viewIndependentListControl->ItemsSource = uiIndependentResourceItems;
    });
}
```

## -see-also

[ResourceQualifier](resourcequalifier.md), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
