using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dataacess.Model;


namespace Dataacess.Mappers
{
	internal class StudentMapper
	{
		public static DTO.Model.Student Map(Student student)
		{
			return new DTO.Model.Student(student.Navn, student.StudieStart, student.Alder,student.StudentId,(DTO.Model.Student._StudieType)student.StudieType);

		}

		public static DTO.Model.HoldDetails MapDetail(Hold hold)
		{
			DTO.Model.HoldDetails retur = new DTO.Model.HoldDetails();
			retur.HoldNavn = hold.HoldNavn;
			retur.HoldId = hold.HoldId;
			retur.StudentsIHold = StudentMapper.Map(hold.StudentsIHold);
			return retur;
		}


		public static List<DTO.Model.Student> Map(List<Student> students)
		{
			List<DTO.Model.Student> retur =new List<DTO.Model.Student>();
            foreach (Student student in students )
            {
				retur.Add(StudentMapper.Map(student));
                
            }
			return retur;
        }
		

	}
}
