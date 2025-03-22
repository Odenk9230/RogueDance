using UnrealBuildTool;

public class RogueDanceEditorTarget : TargetRules
{
	public RogueDanceEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("RogueDance");
	}
}
