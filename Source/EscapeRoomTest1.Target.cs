// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class EscapeRoomTest1Target : TargetRules
{
	public EscapeRoomTest1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "EscapeRoomTest1" } );
	}
}
