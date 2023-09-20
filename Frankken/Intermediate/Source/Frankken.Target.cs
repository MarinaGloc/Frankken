using UnrealBuildTool;

public class FrankkenTarget : TargetRules
{
	public FrankkenTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Frankken");
	}
}
