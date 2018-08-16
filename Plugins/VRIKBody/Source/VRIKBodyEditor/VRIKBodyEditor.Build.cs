// VR IK Body Component
// (c) Yuri N Kalinin, 2017, ykasczc@gmail.com. All right reserved.

namespace UnrealBuildTool.Rules
{
    public class VRIKBodyEditor : ModuleRules
    {
        public VRIKBodyEditor(ReadOnlyTargetRules Target) : base(Target)
        {
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PublicIncludePaths.AddRange(
                new string[] {
                    "VRIKBodyEditor/Public",
                    "VRIKBodyRuntime/Public"
                }
            );

            PrivateIncludePaths.AddRange(
                new string[] {
                    "VRIKBodyEditor/Private",
                    "VRIKBodyRuntime/Private"
                }
            );

            PrivateDependencyModuleNames.AddRange(
                new string[] {
                    "VRIKBodyRuntime",
                    "Core",
                    "CoreUObject",
                    "Engine",
                    "AnimGraphRuntime",
                    "AnimGraph",
                    "BlueprintGraph",
                    "UnrealEd"
                }
            );
        }
    }
}