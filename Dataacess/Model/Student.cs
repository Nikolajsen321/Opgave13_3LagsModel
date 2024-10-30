using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacess.Model
{
	internal class Student
	{
		private string _navn;
		public string Navn { get { return _navn; } set { _navn = value; } }
		
		private DateTime _studieStart;
		public DateTime StudieStart { get { return _studieStart; } set { _studieStart = value; } }

		private int _alder;
		public int Alder { get { return _alder; } set { _alder = value; } }

		private int _studentId;

		public int StudentId {get{ return _studentId; } set { _studentId = value; } }

		public int? HoldId { get; set; }	

		
		public enum _StudieType
		{
			Bachelor,
			Master,
			Ungdomudannelse 
		}

		public _StudieType StudieType { get; set; }


		public Student() { }

		public Student(string navn, DateTime studieStart, int alder,int studentId,_StudieType studieType)
		{
			_navn = navn;
			_studieStart = studieStart;
			_alder = alder;
			_studentId = studentId;
			StudieType = studieType;
			
		}
	}
}
