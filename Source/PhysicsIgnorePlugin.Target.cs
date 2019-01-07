// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class PhysicsIgnorePluginTarget : TargetRules
{
	public PhysicsIgnorePluginTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "PhysicsIgnorePlugin" } );
	}
}
