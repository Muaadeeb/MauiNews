namespace News.Pages;

public partial class NewsPage : ContentPage
{
    public List<Article> Articles { get; set; } = new List<Article>();
    public List<Category> NewsCategories { get; set; } = new List<Category>()
    {
        new Category(){Name= "Breaking-News"},
        new Category(){Name= "World"},
        new Category(){Name= "Nation"},
        new Category(){Name= "Business"},
        new Category(){Name= "Technology"},
        new Category(){Name= "Entertainment"},
        new Category(){Name= "Sports"},
        new Category(){Name= "Science"},
        new Category(){Name= "Health"},
    };

    private bool IsNextPage = false;

    public NewsPage()
	{
		InitializeComponent();
        //Articles = new List<Article>();
        Categories.ItemsSource = NewsCategories;
    }

	// a default MAUI lifeCycle method.
    protected override async void OnAppearing()
    {
		base.OnAppearing();

        if (IsNextPage is false)
        {
            await PassCategory("breaking-news");
        }
    }

    private async void Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Category;
        await PassCategory(selectedItem!.Name);
    }

    public async Task PassCategory(string categoryName)
    {
        News.ItemsSource = null;
        Articles.Clear();

        ApiService apiService = new ApiService();
        var newsResult = await apiService.GetNews(categoryName);

        foreach (var item in newsResult.Articles)
        {
            Articles.Add(item);
        }

        News.ItemsSource = Articles;
    }

    private void News_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Article;
        IsNextPage = true;
        Navigation.PushAsync(new NewsDetail(selectedItem));
    }

    // a default MAUI lifeCycle method.
    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //}
}