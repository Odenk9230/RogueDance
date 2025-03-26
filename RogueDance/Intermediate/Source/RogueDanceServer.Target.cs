using UnrealBuildTool;

public class RogueDanceServerTarget : TargetRules
{
	public RogueDanceServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("RogueDance");
	}
}
