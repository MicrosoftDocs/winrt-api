---
-api-id: T:Windows.ApplicationModel.Store.CurrentApp
-api-type: winrt class
---

<!-- Class syntax.
public class CurrentApp
-->

# Windows.ApplicationModel.Store.CurrentApp

## -description
Defines methods and properties you can use to get license and listing info about the current app and perform in-app product purchases.

> [!NOTE]
> The **CurrentApp** class and the other types in the [Windows.ApplicationModel.Store](windows_applicationmodel_store.md) namespace are no longer being updated with new features. If your project targets **Windows 10 Anniversary Edition (10.0; Build 14393)** or a later release in Visual Studio (that is, you are targeting Windows 10, version 1607, or later), we recommend that you use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace instead. For more information, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials). The **CurrentApp** class is not supported in Windows desktop applications that use the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop) or in apps or games that use a development sandbox in [Partner Center](https://partner.microsoft.com/dashboard) (for example, this is the case for any game that integrates with Xbox Live). These products must use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace to implement in-app purchases and trials. 

## -remarks
This object obtains its data from the Microsoft Store, so you must have a developer account and the app must be published in the Microsoft Store. Before submitting to the Microsoft Store, you can test your code with a simulated version of this class (whose state is initialized from an XML file). See [CurrentAppSimulator](currentappsimulator.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | GetCustomerCollectionsIdAsync |
| 1511 | 10586 | GetCustomerPurchaseIdAsync |

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample)
