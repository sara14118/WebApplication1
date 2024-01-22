using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<ToDo> GetAll()
		{
			var todos = new List<ToDo>() {
			new ToDo { Id = 1, Name = "API", Description = "you should study api" },
			new ToDo { Id = 2, Name = "PL", Description = "you should study PL" },
			new ToDo { Id = 3, Name = "BLL", Description = "you should study BLL"}

		};
			return todos;

		}
	}
	}

