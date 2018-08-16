// VR IK Body Component
// (c) Yuri N Kalinin, 2017, ykasczc@gmail.com. All right reserved.

using UnrealBuildTool;

public class VRIKBodyRuntime : ModuleRules
{
    public VRIKBodyRuntime(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[] { "VRIKBodyRuntime/Public" });
		PrivateIncludePaths.AddRange(new string[] { "VRIKBodyRuntime/Private" });

		PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore",
				"HeadMountedDisplay",
				"AnimGraphRuntime"
			}
		);

	    PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
