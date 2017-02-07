//
// Page1.xaml.h
// Declaration of the Page1 class
//

#pragma once

#include "Page1.g.h"
#include "Page2.xaml.h"

namespace AppBarSample
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public ref class Page1 sealed
	{
	public:
		Page1();

	protected:
		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
	private:
		Page^ rootPage;
	};
}
