---
-api-id: T:Windows.Foundation.Collections.IPropertySet
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IPropertySet : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMap<System.String, System.Object>, Windows.Foundation.Collections.IObservableMap<System.String, System.Object>
-->

# Windows.Foundation.Collections.IPropertySet

## -description
Represents a collection of key-value pairs, correlating several other collection interfaces.

## -remarks
This interface is unusual in that it doesn't define any new members. Instead, it correlates three other collection interfaces such that they share the same type parameter constraints:
+ [IIterable](iiterable_1.md) (constraint [IKeyValuePair](ikeyvaluepair_2.md), with inner constraint of **String**, **Object**)
+ [IMap](imap_2.md) (constraint **String**, **Object**)
+ [IObservableMap](iobservablemap_2.md) (constraint **String**, **Object**)

If you cast an object to IPropertySet (which isn't a generic) you can then use the combined methods of these three interfaces based on using **String** for key, **Object** for value. For a practical implementation, Windows Runtime uses the [PropertySet](propertyset.md) class. See the documentation for various members of [PropertySet](propertyset.md) to learn how to use those methods once you cast as IPropertySet.

In many cases where a Windows Runtime API uses a [PropertySet](propertyset.md) as a value, it's actually shown as IPropertySet in the signatures. [PropertySet](propertyset.md) can be considered the practical implementation of IPropertySet that's ready for use by app code. JavaScript code can treat any IPropertySet value as if it implemented the [PropertySet](propertyset.md) prototypes. Usage by type is the main scenario for IPropertySet; actually implementing the interface in your app code is less common.

IPropertySet is also implemented by the [ValueSet](valueset.md) class. [ValueSet](valueset.md) is the value type of several **ContinuationData** properties, which enable restoring state when apps resume after calling an **AndContinue** method that might deactivate the app. [ValueSet](valueset.md) and all the **ContinuationData** properties and **AndContinue** methods are Windows Phone only APIs because it's only Windows Phone that has this behavior. For more info, see [How to continue your Windows Phone Store app after calling an AndContinue method](/previous-versions/windows/apps/dn631755(v=win.10)). The difference between [ValueSet](valueset.md) and [PropertySet](propertyset.md) is that the [ValueSet](valueset.md) implementation of methods like [Insert](valueset_insert_2123640444.md) enforces that its property values are value types.

## -examples
This example shows how to check for an item within the IPropertySet object returned by a Windows Runtime property. Specifically, this is from the [CoreApplication.Properties](../windows.applicationmodel.core/coreapplication_properties.md) property. This code snippet comes from the [ControlChannelT​rigger HTTP client sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20HTTP%20client%20sample). Note how the C# version casts to [IDictionary<string,object>](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) so that it can use the indexer, whereas the Visual C++ component extensions (C++/CX) version uses [HasKey](propertyset_haskey_425964900.md) and [Lookup](propertyset_lookup_711408188.md). Typically this is all you do with an IPropertySet object that you get from the various Windows Runtime properties that return the type: look for specific keys in the property set, and then set some app property to the corresponding value if it exists.

```csharp
// In this example, the channel name has been hardcoded to lookup the property bag 
// for any previous contexts. The channel name may be used in more sophisticated ways 
// in case an app has multiple ControlChannelTrigger objects. 
string channelId = "channelOne";
if (((IDictionary<string, object>)CoreApplication.Properties).ContainsKey(channelId))
{
    try
    {
        AppContext appContext = null;
        lock(CoreApplication.Properties)
        {
            appContext = ((IDictionary<string, object>)CoreApplication.Properties)[channelId] as AppContext;
        }
        if (appContext != null && appContext.CommunicationInstance != null)
        {
            CommunicationModule communicationInstance = appContext.CommunicationInstance;

            // Clear any existing channels, sockets etc. 
            communicationInstance.Reset();

            // Create CCT enabled transport. 
            communicationInstance.SetUpTransport(communicationInstance.serverUri, GetType().Name);
        }
    }
    catch (Exception ex)
    {
        Diag.DebugPrint("Registering with CCT failed with: " + ex.ToString());
    }
}
else
{
    Diag.DebugPrint("Cannot find AppContext key channelOne");
}
```

```cppwinrt
// In this example, the channel name has been hardcoded to look up the property bag
// for any previous contexts. The channel name may be used in more sophisticated ways
// in case an app has multiple ControlChannelTrigger objects.
std::wstring channelId{ L"channelOne" };
if (CoreApplication::Properties().HasKey(channelId))
{
    try
    {
        auto appContext{ CoreApplication::Properties().Lookup(channelId).as<AppContext>() };
        if (appContext && appContext->CommunicationInstance())
        {
            CommunicationModule communicationInstance{ appContext->CommunicationInstance() };

            // Clear any existing channels, sockets etc.
            communicationInstance.Reset();

            // Create CCT enabled transport.
            communicationInstance.SetUpTransport(L"NetworkChangeTask");
        }
    }
    catch (winrt::hresult_error const& ex)
    {
        Diag::DebugPrint(L"Registering with CCT failed with: " + ex.message());
    }
}
else
{
    Diag::DebugPrint(L"Cannot find AppContext key channelOne");
}
```

```cppcx
// In this example, the channel name has been hardcoded to look up the property bag
// for any previous contexts. The channel name may be used in more sophisticated ways
// in case an app has multiple ControlChannelTrigger objects.
String^ channelId = "channelOne";
if (CoreApplication::Properties->HasKey(channelId))
{
    try
    {
        auto appContext = dynamic_cast<AppContext^>(CoreApplication::Properties->Lookup(channelId));
        if (appContext != nullptr && appContext->CommunicationInstance != nullptr)
        {
            CommunicationModule^ communicationInstance = appContext->CommunicationInstance;

            // Clear any existing channels, sockets etc. 
            communicationInstance->Reset();

            // Create CCT enabled transport 
            communicationInstance->SetUpTransport("NetworkChangeTask");
        }
    }
    catch (Exception^ ex)
    {
        Diag::DebugPrint("Registering with CCT failed with: " + ex->Message);
    }
}
else
{
    Diag::DebugPrint("Cannot find AppContext key channelOne");
}
```

## -see-also
[PropertySet](propertyset.md)
