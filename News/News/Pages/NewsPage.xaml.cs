namespace News.Pages;

public partial class NewsPage : ContentPage
{
    public List<Article> Articles { get; set; } = new List<Article>();

	public NewsPage()
	{
		InitializeComponent();
	}

	// a default MAUI lifeCycle method.
    protected override async void OnAppearing()
    {
		base.OnAppearing();
        ApiService apiService = new ApiService();
        var newsResult = await apiService.GetNews();

        foreach (var item in newsResult.Articles)
        {
            Articles.Add(item);
        }
        News.ItemsSource = Articles;


        


    }


    // a default MAUI lifeCycle method.
    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //}
}