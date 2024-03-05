using System;

namespace ClassRoom
{
	public class Student : IEquatable<Student>
	{
		private Student()
		{
			this._evaluationNotes = new List<double>();
			this._name = "";
		}

		string _name { get; }
		List<double> _evaluationNotes;

		public string Name { get { return _name; } }
		public double Note { set { this._evaluationNotes.Add(value); } }

		public Student(string name)
		{
			this._evaluationNotes = new List<double>();
			this._name = name;
		}

		public double GetAverage() 
		{
			int i = 0;
			double totalNotes = 0.0;

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
			return this.Name == student.Name;
		}

	}
}