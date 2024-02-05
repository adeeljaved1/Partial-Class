namespace WK5A_PartialClass
{
    public partial class MainPage : ContentPage
    {
        Shape shape ;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // reading values of width and height from entry UI component
            var width = int.Parse(WidthValue.Text);
            var height = int.Parse(HeightValue.Text);

            shape = new Shape(width, height);

            string name = ShapeName.Text;

            if (name != "" && name != null)
                shape.Name = name;
            else
                //adding an error message
                DisplayAlert("Error", "Please enter a valid name of the shape", "OK");

            if (width != height)
                if (name.ToLower() != "rectangle")
                    DisplayAlert("Error", "Invalid shape name", "OK");

            ShapeNameLabel.Text = shape.Name;
            RectangleShape.WidthRequest = shape.Width;
            RectangleShape.HeightRequest = shape.Height;  
        }
    }

    //TODO:
    // 1) take input from the user, ShapeName using Entry UI component
    // 2) display the name of shape in a label, ShapeNameLabel
    // 3) Add validation using DisplayAlert() to display error, if ShapeName is empty string
    // 4) Also, DisplayAlert() to display error, if dimentions are different and ShapeNameLabel.Text should be "Rectangle"
}
