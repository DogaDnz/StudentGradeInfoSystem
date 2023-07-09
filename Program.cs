namespace koddenemeleri2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student Doga = new Student();
			Student Enes = new Student();
			Student Emir = new Student();

			Doga.setStudentInfo("Doga", "Deniz",70);
			Enes.setStudentInfo("Enes", "Güneş",20);
			Emir.setStudentInfo("Emir", "Yıldız",68);

			Console.WriteLine(Doga.getStudentInfo());
			Console.WriteLine(Enes.getStudentInfo());
			Console.WriteLine(Emir.getStudentInfo());
			
		}
	}
}