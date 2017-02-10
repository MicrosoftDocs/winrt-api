---
-api-id: T:Windows.Security.Authentication.Web.Provider.WebAccountProviderAddAccountOperation
-api-type: winrt class
---

<!-- Class syntax.
public class WebAccountProviderAddAccountOperation : Windows.Security.Authentication.Web.Provider.IWebAccountProviderAddAccountOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation
-->

# Windows.Security.Authentication.Web.Provider.WebAccountProviderAddAccountOperation

## -description
Represents an add account operation.

## -remarks

## -examples
The following demonstrates how to handle an add web account operation:

```csharp

WebAccountProviderAddAccountOperation operation;
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    operation = (WebAccountProviderAddAccountOperation)e.Parameter;
    base.OnNavigatedTo(e);
}

private async void DoneAddAccountButton_Click(object sender, RoutedEventArgs e)
{
    Dictionary<string, string> properties = new Dictionary<string, string>();
    properties.Add(this.PropKeyTextBox.Text, this.PropValueTextBox.Text);
    WebAccount newAccount = await WebAccountManager.AddWebAccountAsync(this.AccountIdTextBox.Text, 
                                this.UserNameTextBox.Text, properties);
}
```



## -see-also
[IWebAccountProviderOperation](iwebaccountprovideroperation.md)