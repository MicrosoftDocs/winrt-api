---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.RetrieveServiceDocumentAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.AtomPub.ServiceDocument, Windows.Web.Syndication.RetrievalProgress> RetrieveServiceDocumentAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.AtomPub.AtomPubClient.RetrieveServiceDocumentAsync

## -description
Retrieves a service document from the specified Uri.

## -parameters
### -param uri
The specified Uri.

## -returns
The object that is used to retrieve the service document asynchronously and to report the progress and completion status of the operation.

## -remarks

## -examples
The following code demonstrates how to access a service document and retrieve edit URI values. For additional examples of how AtomPub can be used to manage feed content, download the [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample).

```javascript

    function findEditUri(serviceUri) {
        return client.retrieveServiceDocumentAsync(serviceUri).then(function (serviceDocument) {
            for (var i in serviceDocument.workspaces) {
                var workspace = serviceDocument.workspaces[i];
                for (var j in workspace.collections) {
                    var collection = workspace.collections[j];

                    if (collection.accepts.join(";") === "application/atom+xml;type=entry") {
                        return collection.uri;
                    }
                }
            }

            return null;
        });
    }
```



## -see-also
[Quickstart: Managing Feed Entries](/previous-versions/windows/apps/hh700368(v=win.10)), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)
