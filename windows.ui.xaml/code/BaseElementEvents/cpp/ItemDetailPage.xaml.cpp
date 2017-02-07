//
// ItemDetailPage.xaml.cpp
// Implementation of the ItemDetailPage class
//

#include "pch.h"
#include "DataModel\SampleDataSource.h"
#include "ItemDetailPage.xaml.h"

using namespace BaseElementEvents;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Graphics::Display;
using namespace Windows::UI::ViewManagement;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Item Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234232

ItemDetailPage::ItemDetailPage()
{
	InitializeComponent();
}

/// <summary>
/// Populates the page with content passed during navigation.  Any saved state is also
/// provided when recreating a page from a prior session.
/// </summary>
/// <param name="navigationParameter">The parameter value passed to
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially requested.
/// </param>
/// <param name="pageState">A map of state preserved by this page during an earlier
/// session.  This will be null the first time a page is visited.</param>
void ItemDetailPage::LoadState(Object^ navigationParameter, IMap<String^, Object^>^ pageState)
{
	// Allow saved page state to override the initial item to display
	if (pageState != nullptr && pageState->HasKey("SelectedItem"))
	{
		navigationParameter = pageState->Lookup("SelectedItem");
	}

	// TODO: Create an appropriate data model for your problem domain to replace the sample data
	auto item = Data::SampleDataSource::GetItem(safe_cast<String^>(navigationParameter));
	DefaultViewModel->Insert("Group", item->Group);
	DefaultViewModel->Insert("Items", item->Group->Items);
	flipView->SelectedItem = item;
}

/// <summary>
/// Preserves state associated with this page in case the application is suspended or the
/// page is discarded from the navigation cache.  Values must conform to the serialization
/// requirements of <see cref="SuspensionManager::SessionState"/>.
/// </summary>
/// <param name="pageState">An empty map to be populated with serializable state.</param>
void ItemDetailPage::SaveState(IMap<String^, Object^>^ pageState)
{
	auto selectedItem = safe_cast<Data::SampleDataItem^>(flipView->SelectedItem);
	pageState->Insert("SelectedItem", selectedItem->UniqueId);
}
