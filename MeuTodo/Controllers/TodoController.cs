using MeuTodo.Data;
using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Controllers

{
	[ApiController]
	[Route("v1")]
	public class TodoController : ControllerBase
	{
		[HttpGet]
		[Route("todos")]
		public async Task<IActionResult> Get(
			[FromServices] AppDbContext context)
		{
			var todos = await context //AppDbContext
				.Todos//DbSet<Todos>
				.AsNoTracking()
				.ToListAsync();
			return Ok(todos);
		}
		
	}
}
