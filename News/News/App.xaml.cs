namespace News;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Pages.NewsPage();
        //MainPage = new AppShell();
    }
}
