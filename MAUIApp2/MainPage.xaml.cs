namespace MAUIApp2;

public partial class MainPage : ContentPage
{
    string real_text = "Reality";
    public MainPage()
	{
		InitializeComponent();
	}
	//set text to another text
	private void OnImageClicked(object sender, EventArgs e)
	{
      
        expectations_pic.Source = "reality.png";
		expect_text.Text = real_text;
	}
	private void OnSecondImageClicked(object sender, EventArgs e)
	{
     
        expectations_pic2.Source = "real_cs.jpg";
        expect_text2.Text = real_text;
    }
}
