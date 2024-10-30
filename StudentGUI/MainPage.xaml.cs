namespace StudentGUI
{
	public partial class MainPage : ContentPage
	{
	
		private List<DTO.Model.Student> selectedStudent = new List<DTO.Model.Student>();

		Buisness.BLL.StudentBLL studentBLL = new Buisness.BLL.StudentBLL();

		public MainPage()
		{
			InitializeComponent();
			DTO.Model.HoldDetails holdDetails = studentBLL.getHoldDetails(1);
			Console.WriteLine($"HoldId: {holdDetails.HoldId}");

			Hold.BindingContext = holdDetails;
			HoldId.BindingContext = holdDetails;
			

			CollectionViewStudent.ItemsSource = studentBLL.getStudents();


		}

		private void OnStudentSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			selectedStudent = e.CurrentSelection.Cast<DTO.Model.Student>().ToList();
		}


		private void AddStudentToHold(object sender, EventArgs e)
		{
			var holdId = ((DTO.Model.HoldDetails)HoldId.BindingContext).HoldId;
			foreach (var student in selectedStudent) 
			{
				studentBLL.AddStudentToHold(student.StudentId,holdId);
				
			}


		}


	



	}

}
