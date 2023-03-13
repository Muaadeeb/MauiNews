namespace News.Pages;

public partial class NewsDetail : ContentPage
{
    private string uri;

    public NewsDetail(Article article)
    {
        InitializeComponent();
        ImgNews.Source = article.Image;
        Title.Text = article.Title;
        Content.Text = article.Content;
        uri = article.Url;
    }

    private async void TbShare_Clicked(object sender, EventArgs e)
    {
        // To share on social media - use the MAUI plugin.   Microsoft.Maui.Essentials.
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = uri,
            Title = "Share Web Link"
        });
    }
}