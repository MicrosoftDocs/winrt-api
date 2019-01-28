---
-api-id: P:Windows.Services.Store.StoreProduct.ProductKind
-api-type: winrt property
---

<!-- Property syntax
public string ProductKind { get; }
-->

# Windows.Services.Store.StoreProduct.ProductKind

## -description
Gets the type of the product. These values are currently supported: **Application**, **Game**, **Consumable**, **UnmanagedConsumable**, and **Durable**.

## -property-value
The type of the product.

## -remarks
The following table provides definitions for the currently supported values. Additional values may be supported in the future.<table>
   <tr><th>String value</th><th>Description</th></tr>
   <tr><td>**Application**</td><td>An app that belongs to any category other than **Games**. For more info, see [Category and subcategory table](https://msdn.microsoft.com/windows/uwp/publish/category-and-subcategory-table).</td></tr>
   <tr><td>**Game**</td><td>An app that belongs to the **Games** category. For more info, see [Category and subcategory table](https://msdn.microsoft.com/windows/uwp/publish/category-and-subcategory-table).</td></tr>
   <tr><td>**Consumable**</td><td>A Store-managed consumable add-on that can be purchased, used, and purchased again. Microsoft keeps track of the user's balance for these types of add-ons.</td></tr>
   <tr><td>**UnmanagedConsumable**</td><td>A developer-managed consumable add-on that can be purchased, used, and purchased again. Microsoft does not keep track of the user's balance for these types of add-ons; the developer is responsible for keeping track of the user's balance.</td></tr>
   <tr><td>**Durable**</td><td>An add-on that persists for the lifetime that you specify in [Partner Center](https://partner.microsoft.com/dashboard). By default, durable add-ons never expire, in which case they can only be purchased once. If you specify a particular duration for the add-on, the user can repurchase the add-on after it expires.<p/><p/>**Note**&nbsp;&nbsp;A **StoreProduct** that represents a [subscription add-on](https://docs.microsoft.com/windows/uwp/monetize/enable-subscription-add-ons-for-your-app) has the type **Durable**.  </td></tr>
</table>

## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)
