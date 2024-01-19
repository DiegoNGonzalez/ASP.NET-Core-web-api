using Backend_api.Controllers;

namespace Backend_api.Services
{
    public class People2Service: IPeopleService
    {
        public bool Validate(People people)
        {
            if (string.IsNullOrEmpty(people.Name)|| people.Name.Length >100 || people.Name.Length<3) 
            {
                return false;
            }
            return true;
        }
    }
}
