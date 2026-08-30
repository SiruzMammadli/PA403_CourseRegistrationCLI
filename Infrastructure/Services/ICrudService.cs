namespace CourseRegistration.Infrastructure.Services;

public interface ICrudService<Type>
{
    Type GetById(int id);
    List<Type> GetAll();
}