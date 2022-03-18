---
-api-id: P:Windows.ApplicationModel.Store.CurrentAppSimulator.AppId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid AppId { get; }
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.AppId

## -description
Gets a simulated app ID. Since [CurrentAppSimulator](currentappsimulator.md) is intended only for testing during app development, the returned CurrentAppSimulator.AppId will contain only 0's.

Once your app is listed on the Windows Store, [CurrentApp.AppId](currentapp_appid.md) will get the [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) generated during app on-boarding and used to list your app within the Windows Store catalog.

> [!NOTE]
> App updates or changes to the app description will not result in a change to the [CurrentApp.AppId](currentapp_appid.md).

## -property-value
The [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) that identifies the app in the Windows Store.

## -remarks
Uses the **AppId** element in the WindowsStoreProxy.xml file as the data source for the members of the returned object. For more information, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace).

## -examples

## -see-also
