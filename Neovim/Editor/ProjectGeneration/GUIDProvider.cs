namespace Packages.Neovim.Editor.ProjectGeneration {
	class GUIDProvider : IGUIDGenerator
	{
		public string ProjectGuid(string name)
		{
			return SolutionGuidGenerator.GuidForProject(name);
		}
	}
}
