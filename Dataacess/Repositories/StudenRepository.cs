using DTO.Model;
using Dataacess.Mappers;
using Dataacess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using System.Diagnostics;


namespace Dataacess.Repositories
{
	public class StudenRepository
	{
		public static Student getStudent(int id)
		{
			using (StudentContext context = new StudentContext())
			{
				return StudentMapper.Map(context.Students.Find(id));

			}


		}

		public static List<Student> GetStudents()
		{
			using (StudentContext context = new StudentContext())
			{

				List<Model.Student> students = context.Students.ToList();
				List<Student> studentsDTO = students.Select(student => StudentMapper.Map(student)).ToList();
				return studentsDTO;


			}
		}


		public static void RemoveStudent(int Id)
		{
			using (StudentContext context = new StudentContext())
			{
				Model.Student studentRemove = context.Students.Find(Id);

				if (studentRemove != null)
				{
					//Remove the student 
					context.Students.Remove(studentRemove);
					// Save changes til database
					context.SaveChanges();
				}
				else
				{
					// Optionally, handle the case where the student doesn't exist
					Debug.WriteLine($"Student with ID {Id} does not exist.");
				}

			}


		}
	}
}
