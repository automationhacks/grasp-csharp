namespace Fundamentals.Tests;
public class LinqTests
{
    [Fact]
    public void BasicLinqQueryTest()
    {
        var student1 = new Student("Rob", 7);
        var student2 = new Student("Smith", 8);
        var student3 = new Student("Chuck", 2);

        List<Student> students = [student1, student2, student3];
        // Linq provides a convenient DSL to query data from different
        // sources using a simple syntax
        // Could be used to read/manipulate data from a list, xml, json or even database
        var sevenAndAbove = from student in students
                                        where student.getGPA() > 7
                                        select student;
        // Method to check collection has only a single item
        Assert.Single(sevenAndAbove);
    }

}

public class Student
{
    private int gpa;
    private string name;

    public Student(string name, int studentGPA)
    {
        this.name = name;
        this.gpa = studentGPA;
    }

    public int getGPA()
    {
        return this.gpa;
    }
}