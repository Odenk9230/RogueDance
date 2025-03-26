using UnrealBuildTool;

public class RogueDanceClientTarget : TargetRules
{
	public RogueDanceClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("RogueDance");
	}
}
