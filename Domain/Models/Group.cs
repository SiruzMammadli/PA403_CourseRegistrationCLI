
namespace CourseRegistration.Domain.Models
{
    public class Group
    {
        private static int _idcounter = 0;

        public int Id { get; private set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Group(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            Id = ++_idcounter;
            
        }




    }
}
