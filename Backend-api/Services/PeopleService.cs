using Backend_api.Controllers;

namespace Backend_api.Services
{
    public class PeopleService: IPeopleService
    {
        public bool Validate(People people)
        {
            if (string.IsNullOrEmpty(people.Name)|| people.Name.Length >100) 
            {
                return false;
            }
            return true;
        }
    }
}
