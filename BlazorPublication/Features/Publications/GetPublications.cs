using BlazorPublication.Data;
using BlazorPublication.Entities;

using Mapster;

using Microsoft.EntityFrameworkCore;

namespace BlazorPublication.Features.Publications;

public static class GetPublications
{

	public class Handler(ApplicationDbContext context)
	{

		public async Task<List<Response>> HandleAsync()
		{

			List<Publication> publications = await context.Publications.ToListAsync();

			return publications.Adapt<List<Response>>();

		}

	}

	public record Response(
		Guid Id,
		string Name,
		string SubstackUrl,
		string NotesUrl,
		int Subscribers,
		string Category1,
		string Category2,
		string AboutPublication,
		string AboutWriter
		);

}
