namespace CourseRegistration.Domain.Models;

public sealed class Student
{
    private static int _id;
    public int Id { get; } = ++_id;
    public string Fullname { get; private set; }
    public byte Age { get; private set; }
    public float Grade { get; private set; }

    public Student(string fullname, byte age, float grade)
    {
        ArgumentException.ThrowIfNullOrEmpty(fullname, nameof(fullname));

        Fullname = fullname;
        Age = age;
        Grade = grade;
    }
}