namespace News;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Pages.News();
        //MainPage = new AppShell();
    }
}
