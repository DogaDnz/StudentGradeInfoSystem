using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace koddenemeleri2
{
	internal class Student
	{
		string name, surname = null;
		int grades = 0;
		int level;
		string ayrac = new string('-', 20);


		public void setStudentInfo(string name, string surname, int grades)
		{
			if
				(name != null && surname != null)
			{
				if (grades >= 85)
				{
					this.name = name;
					this.surname = surname;
					this.level = 5;
					this.grades = grades;
					
					
				}

				else if (grades >= 70 && grades < 85)
				{
					this.name = name;
					this.surname = surname;
					this.level = 4;
					this.grades = grades;
				}
				else if (grades >= 50 && grades < 70)
				{
					this.name = name;
					this.surname = surname;
					this.level = 3;
					this.grades = grades;
				}
				else if (grades >= 20 && grades < 50)
				{
					this.name = name;
					this.surname = surname;
					this.level = 2;
					this.grades = grades;
				}
				else if (grades >= 0 && grades < 20)
				{
					this.name = name;
					this.surname = surname;
					this.level = 1;
					this.grades = grades;
				}

			}
		}
			public string getStudentInfo()
		{
				
					if (name != null)
						return ayrac + "\n<Student Informations>\n" + ayrac + "\n-> Student Name: " + name + "\n-> Student Surname: " + surname + "\n-> Student Grade: " + grades + " \n-> Student Level: " + level  + ayrac;
					else
						return ayrac + "\n<Needing Student Informations >\n" + ayrac + "\n-> Could not reached Student's Informations.\n" + ayrac;
				
			}
		}

	}

