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

	}
}
