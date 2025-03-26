using UnrealBuildTool;

public class RogueDanceTarget : TargetRules
{
	public RogueDanceTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("RogueDance");
	}
}
