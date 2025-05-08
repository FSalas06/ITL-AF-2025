using System;
namespace ITL_AF_2025.Models
{
	public class TodoDataModel
	{
		public required string Task { get; set; }
		public string? Subtask { get; set; }
		public bool IsChecked { get; set; } = false;
	}
}

