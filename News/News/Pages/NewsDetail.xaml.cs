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
}