---
-api-id: T:Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource
-api-type: winrt interface
---

# Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource

<!--
public interface IStorageProviderKnownFolderSyncInfoSource
-->

## -description

The interface that a cloud provider implements to provide information about the sync status of known folders.

## -remarks

File Explorer obtains an instance of **IStorageProviderKnownFolderSyncInfoSource** for a given provider by calling [GetKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosourcefactory_getknownfoldersyncinfosource_1598084472.md).

This interface provides a [KnownFolderSyncInfoChanged](istorageproviderknownfoldersyncinfosource_knownfoldersyncinfochanged.md) event, which the app raises when any property or folder status changes, including the display name. The cloud provider should not expect **GetKnownFolderSyncInfoSource** to be called immediately after raising the event. File Explorer will only request a new object as it's needed.

## -see-also

[GetKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosourcefactory_getknownfoldersyncinfosource_1598084472.md), [KnownFolderSyncInfoChanged](istorageproviderknownfoldersyncinfosource_knownfoldersyncinfochanged.md)

## -examples

The following example shows a storage provider's implementation of **IStorageProviderKnownFolderSyncInfoSource**:

```cppwinrt
namespace winrt::CloudMirror::implementation
{
    struct MyKnownFolderInfoSource : implements<MyKnownFolderInfoSource,
            winrt::CloudMirror::IStorageProviderKnownFolderSyncInfoSource>
    {
        MyKnownFolderInfoSource();

        StorageProviderKnownFolderSyncInfo GetKnownFolderSyncInfo();

        winrt::event_token KnownFolderSyncInfoChanged(
            winrt::Windows::Foundation::TypedEventHandler<IStorageProviderKnownFolderSyncInfoSource,
            winrt::Windows::Foundation::IInspectable> const& handler);
        void KnownFolderSyncInfoChanged(winrt::event_token const& token) noexcept;

    private:
        winrt::hstring GetProviderDisplayName();
        winrt::Uri GetAvailableIcon();
        winrt::Uri GetEnrollingIcon();
        void NotifyStateChanged();

    winrt::event<winrt::TypedEventHandler<IStorageProviderKnownFolderSyncInfoSource, IInspectable>> m_changedEvent;
        std::vector<StorageProviderKnownFolderEntry> m_knownFolderEntries;
    };
}

...

using namespace winrt::Windows::Storage::Provider;

namespace winrt::CloudMirror::implementation
{
    MyKnownFolderInfoSource::MyKnownFolderInfoSource()
    {
        // The cloud provider would assess its current state and use it to
        // inform File Explorer. In this example, Documents is available for
        // backup, Pictures is currently enrolling, and Downloads is already
        // backed up (enrolled).
        winrt::StorageProviderKnownFolderEntry documents{};
        documents.KnownFolderId(FOLDERID_Documents);
        documents.Status(StorageProviderKnownFolderSyncStatus::Available);
        m_knownFolderState.push_back(documents);

        winrt::StorageProviderKnownFolderEntry pictures{};
        pictures.KnownFolderId(FOLDERID_Pictures);
        pictures.Status(StorageProviderKnownFolderSyncStatus::Enrolling);
        m_knownFolderState.push_back(pictures);

        winrt::StorageProviderKnownFolderEntry downloads{};
        downloads.KnownFolderId(FOLDERID_Downloads);
        downloads.Status(StorageProviderKnownFolderSyncStatus::Enrolled);
        m_knownFolderState.push_back(downloads);
    }
    
    // GetKnownFolderSyncInfo is called by File Explorer whenever it needs to get the
    // latest known folder sync status from the cloud provider. Once returned, the
    // StorageProviderKnownFolderSyncInfo is considered immutable.
    //
    // A SyncRequested handler must be set on the returned object to be considered valid
    // and to be displayed in File Explorer.
    StorageProviderKnownFolderSyncInfo MyKnownFolderInfoSource::GetKnownFolderSyncInfo()
    {
        winrt::StorageProviderKnownFolderSyncInfo info{};
        info.ProviderDisplayName(GetProviderDisplayName());
        // Setting a SyncRequested handler to respond to user action.
        auto syncRequestHandler = [](
            winrt::CloudMirror::StorageProviderKnownFolderSyncRequestArgs const& args)
        {
            // The user wants to sync some known folders with our cloud provider.
            // We can show some UI to sign in, confirm their choice, etc.
            MyStorageProviderSyncManager::ShowFolderEnrollmentUI(args.KnownFolders(), args.Source());

            // Or we can immediately start syncing the requested folders.
            MyStorageProviderSyncManager::StartSyncingFolders(args.KnownFolders(), args.Source());
        };

        info.SyncRequested(syncRequestHandler);
        info.KnownFolderEntries().ReplaceAll(m_knownFolderEntries);
        return info;
    }
}
```
