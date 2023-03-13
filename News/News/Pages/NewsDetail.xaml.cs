namespace News.Pages;

public partial class NewsDetail : ContentPage
{
    public NewsDetail(Article article)
    {
        InitializeComponent();
        ImgNews.Source = article.Image;
        Title.Text = article.Title;
        Content.Text = article.Content;
    }

    private void Share_Clicked(object sender, EventArgs e)
    {
        // To share on social media - use the MAUI plugin.   Microsoft.Maui.Essentials.

    }
}