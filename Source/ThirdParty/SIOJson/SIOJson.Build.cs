// Copyright 2014 Vladimir Alyamkin. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class SIOJson : ModuleRules
	{
		//public SIOJson(TargetInfo Target)
    public SIOJson(ReadOnlyTargetRules Target) : base(Target)
		{
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PrivateIncludePaths.AddRange(
				new string[] {
					"ThirdParty/SIOJson/Private",
					// ... add other private include paths required here ...
				});

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine",
                    "HTTP",
                    "Json",
                    "JsonUtilities"
					// ... add other public dependencies that you statically link with here ...
				});
		}
	}
}
