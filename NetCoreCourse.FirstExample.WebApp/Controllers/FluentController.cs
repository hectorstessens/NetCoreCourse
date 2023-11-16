using Microsoft.AspNetCore.Mvc;

namespace NetCoreCourse.FirstExample.WebApp.Controllers
{
    public class FluentController : Controller
    {
        [Route("api/[controller]")]

        [HttpGet]
        public IActionResult Hey()
        {
            FluentExample person = new FluentExample()
                 .SetFirstName("John")
                 .SetLastName("Doe")
                 .SetAge(25)
                 .SetProgramer("si es progrador c#");

            var name = person.DisplayInfo();
            return Ok(name);
        }
    }

    public class FluentExample
    {
        private string firstName;
        private string lastName;
        private int age;
        private string isProgramer;

        public FluentExample SetFirstName(string name)
        {
            this.firstName = name;
            return this;
        }

        public FluentExample SetLastName(string name)
        {
            this.lastName = name;
            return this;
        }

        public FluentExample SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public FluentExample SetProgramer(string isprogramer)
        {
            this.isProgramer = isprogramer;
            return this;
        }

        public string DisplayInfo()
        {
            return $"Name: {firstName} {lastName}, Age: {age}, es Programador: {isProgramer}";
        }
    }
}
