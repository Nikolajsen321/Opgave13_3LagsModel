namespace StudentGUI
{
	public partial class MainPage : ContentPage
	{
	

		Buisness.BLL.StudentBLL studentBLL = new Buisness.BLL.StudentBLL();
		public MainPage()
		{
			InitializeComponent();

			CollectionViewStudent.ItemsSource = studentBLL.getStudents();


		}


	



	}

}
