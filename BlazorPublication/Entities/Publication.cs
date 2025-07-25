namespace BlazorPublication.Entities;

public class Publication
{

	public Guid Id { get; set; }

	public string Name { get; set; } = string.Empty;

	public string SubstackUrl { get; set; } = string.Empty;

	public string NotesUrl { get; set; } = string.Empty;

	public int Subscribers { get; set; }

	public string Category1 { get; set; } = string.Empty;

	public string Category2 { get; set; } = string.Empty;

	public string About { get; set; } = string.Empty;

	public string AboutPublication { get; set; } = string.Empty;

	public string AboutWriter { get; set; } = string.Empty;

}
