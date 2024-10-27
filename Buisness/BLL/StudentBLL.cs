using DTO.Model;
using Dataacess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.BLL
{
	public class StudentBLL
	{
		public Student getStudent(int id)
		{
			return StudenRepository.getStudent(id);
		}

		public List<Student> getStudents()
		{
			return StudenRepository.GetStudents();
		}
	}
}
