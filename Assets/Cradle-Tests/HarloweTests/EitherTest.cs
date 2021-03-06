﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: EitherTest.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @EitherTest: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;
	public readonly UnityTwineTestMacros macros2;

	@EitherTest()
	{
		this.StartPassage = "Untitled Passage 1";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new UnityTwineTestMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Untitled Passage 1

	void passage1_Init()
	{
		this.Passages[@"Untitled Passage 1"] = new StoryPassage(@"Untitled Passage 1", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return link("Hi $name! It is going great, and you?", "Intro02Response02", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("...to the (either:\"left\",\"right\") for the (either:\"fish\",\"drinks\").", "Intro01Response03", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("...to the " + macros1.either("left","right") + " for the " + macros1.either("fish","drinks") + ".", "Intro01Response03", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #2: Intro01Response03

	void passage2_Init()
	{
		this.Passages[@"Intro01Response03"] = new StoryPassage(@"Intro01Response03", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


}