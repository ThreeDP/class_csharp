using System;

namespace ClassRoom
{
	public class Student : IEquatable<Student>
	{
		private Student(){}

		string _name { get };
		List<int> _evaluationNotes;

		public string Name { get { return _name; } }

		public Student(string name)
		{
			this._evaluationNotes = new List<int>();
			this._name = name;
		}

		public double getAverage() 
		{
			int i = 0;
			double totalNotes = 0.0.;

			foreach (var n in this._evaluationNotes)
			{
				totalNotes += n;
				i++;
			}
			return totalNotes / Convert.ToDouble(i);
		}

		public bool Equals(Student student)
		{
			if (student == null) return false;
			return this.Name == student.Name
		}

		public static bool operator ==(Student a, Student b) {  return a.Equals(b); }
		public static bool operator !=(Student a, Student b) { return !(a.Equals(b)); }
	}
}