namespace MauiWebShell;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBackClicked(object sender, EventArgs e)
	{
		if (WebViewControl.CanGoBack)
		{
			WebViewControl.GoBack();
		}
	}

	private void OnForwardClicked(object sender, EventArgs e)
	{
		if (WebViewControl.CanGoForward)
		{
			WebViewControl.GoForward();
		}
	}

	private void OnRefreshClicked(object sender, EventArgs e)
	{
		WebViewControl.Reload();
	}

	private void OnGoClicked(object sender, EventArgs e)
	{
		NavigateToUrl();
	}

	private void OnUrlCompleted(object sender, EventArgs e)
	{
		NavigateToUrl();
	}

	private void NavigateToUrl()
	{
		string url = UrlEntry.Text?.Trim() ?? string.Empty;
		
		if (string.IsNullOrWhiteSpace(url))
		{
			return;
		}

		// Add https:// if no protocol is specified
		if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
		    !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
		{
			url = "https://" + url;
		}

		try
		{
			WebViewControl.Source = url;
		}
		catch (Exception ex)
		{
			DisplayAlert("Error", $"Failed to navigate: {ex.Message}", "OK");
		}
	}

	private void OnNavigating(object sender, WebNavigatingEventArgs e)
	{
		// Update URL entry when navigation starts
		UrlEntry.Text = e.Url;
	}

	private void OnNavigated(object sender, WebNavigatedEventArgs e)
	{
		// Could add error handling here if needed
		if (e.Result != WebNavigationResult.Success)
		{
			DisplayAlert("Navigation Error", $"Failed to load {e.Url}", "OK");
		}
	}
}
