﻿/*
------------------------------------------------
Generated by Cradle 2.0.2.0
https://github.com/daterre/Cradle

Original file: FWUnityDemoBU.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @FWUnityDemoBU: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("watched", () => this.@watched, val => this.@watched = val);
			VarDef("calledSimone", () => this.@calledSimone, val => this.@calledSimone = val);
			VarDef("health", () => this.@health, val => this.@health = val);
		}

		public StoryVar @watched;
		public StoryVar @calledSimone;
		public StoryVar @health;
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

	@FWUnityDemoBU()
	{
		this.StartPassage = "You";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new UnityTwineTestMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: StartUpVariables

	void passage1_Init()
	{
		this.Passages[@"StartUpVariables"] = new StoryPassage(@"StartUpVariables", new string[]{ "startup", }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		Vars.watched = 0;
		yield return lineBreak();
		Vars.calledSimone = false;
		yield return lineBreak();
		Vars.health = 10;
		yield return lineBreak();
		yield break;
	}


	// .............
	// #2: You

	void passage2_Init()
	{
		this.Passages[@"You"] = new StoryPassage(@"You", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("This trip will take you to a nature reserve in a green, forested place off limits to normal city people. Invitations are extended by the Corp - who own it - infrequently. ");
		yield return lineBreak();
		yield return lineBreak();
		using (styleScope("hook", "h00001"))
			yield return link("First", null, () => enchantHook("h00001", HarloweEnchantCommand.Replace, passage2_Fragment_2));
		yield return lineBreak();
		yield return lineBreak();
		yield return text("At twenty-three, this is your first time first time on a plane.");
		yield return lineBreak();
		yield return text("You are not exactly a first timer in any other ");
		using (styleScope("hook", "s1")) {
			yield return text("things.");
		}
		yield return enchantIntoLink(hookRef("s1"), passage2_Fragment_3);
		yield return enchantIntoLink(hookRef("s2"), passage2_Fragment_4);
		yield return enchantIntoLink(hookRef("s3"), passage2_Fragment_5);
		yield return enchantIntoLink(hookRef("s4"), passage2_Fragment_6);
		yield return enchantIntoLink(hookRef("s5"), passage2_Fragment_7);
		yield return enchantIntoLink(hookRef("s6"), passage2_Fragment_8);
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return passage("StartUpVariables");
		yield break;
	}

	IStoryThread passage2_Fragment_0()
	{
		yield return lineBreak();
		yield return text("         Last");
		yield return lineBreak();
		yield return text("      ");
		yield break;
	}

	IStoryThread passage2_Fragment_1()
	{
		yield return lineBreak();
		yield return text("      ");
		using (styleScope("hook", "h00003"))
			yield return link("Third", null, () => enchantHook("h00003", HarloweEnchantCommand.Replace, passage2_Fragment_0));
		yield return lineBreak();
		yield return text("   ");
		yield break;
	}

	IStoryThread passage2_Fragment_2()
	{
		yield return lineBreak();
		yield return text("   ");
		using (styleScope("hook", "h00002"))
			yield return link("Second", null, () => enchantHook("h00002", HarloweEnchantCommand.Replace, passage2_Fragment_1));
		yield return lineBreak();
		yield break;
	}

	IStoryThread passage2_Fragment_3()
	{
		using (styleScope("hook", "s2")) {
			yield return text(" Sex.");
		}
		yield break;
	}

	IStoryThread passage2_Fragment_4()
	{
		using (styleScope("hook", "s3")) {
			yield return text(" Pony riding.");
		}
		yield break;
	}

	IStoryThread passage2_Fragment_5()
	{
		using (styleScope("hook", "s4")) {
			yield return text(" Recreational drugs.");
		}
		yield break;
	}

	IStoryThread passage2_Fragment_6()
	{
		using (styleScope("hook", "s5")) {
			yield return text(" Therapy.");
		}
		yield break;
	}

	IStoryThread passage2_Fragment_7()
	{
		using (styleScope("hook", "s6")) {
			yield return text(" More sex.");
		}
		yield break;
	}

	IStoryThread passage2_Fragment_8()
	{
		using (styleScope("hook", null)) {
			yield return text("  Fraud.");
			yield return lineBreak();
			yield return lineBreak();
			yield return lineBreak();
			yield return text("Just a little ");
		yield return link("fraud.", "Beginning", null);
		}
		yield break;
	}

	// .............
	// #3: Promotion

	void passage3_Init()
	{
		this.Passages[@"Promotion"] = new StoryPassage(@"Promotion", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("[");
		yield return text("The flight was chartered by your boss: a private jet with room for just two passengers and a pilot. The seat creaked with luxury as you slept , the leather soft on the thighs. As you dreamt of the last conversation you had with your lover, you forgot temporarily that you were ");
		using (styleScope("hook", "Alone")) {
			yield return text("alone.");
		}
		yield return lineBreak();
		yield return enchantIntoLink(hookRef("Alone"), passage3_Fragment_0);
		yield break;
	}

	IStoryThread passage3_Fragment_0()
	{
		using (styleScope("hook", null)) {
			yield return text("Simone was supposed to come. As it is, the other seat remained empty and there has been no word from ");
		yield return link("her", "Simone", null);
			yield return text(" for two days. Absence is becoming her thing.");
		}
		yield break;
	}

	// .............
	// #4: Simone

	void passage4_Init()
	{
		this.Passages[@"Simone"] = new StoryPassage(@"Simone", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Simone is the director of the city's media studio. She edits all the natural history footage sent in from outside.");
		yield return lineBreak();
		yield return text("She is a family friend. So what if she is twenty years your ");
		using (styleScope("hook", "Senior")) {
			yield return text("senior?");
		}
		yield return lineBreak();
		yield return enchantIntoLink(hookRef("Senior"), passage4_Fragment_0);
		yield break;
	}

	IStoryThread passage4_Fragment_0()
	{
		using (styleScope("hook", null)) {
			yield return text(" You love her. But worrying about her not turning up could ruin this retreat, and she would say you shouldn't let it. She is a big girl and she can look after herself.");
			yield return lineBreak();
		yield return link("Don" + "'" + "t worry about Simone.", "FreshAir", null);
			yield return lineBreak();
		yield return link("Call Simone", "CallSimone", null);
		}
		yield break;
	}

	// .............
	// #5: Beginning

	void passage5_Init()
	{
		this.Passages[@"Beginning"] = new StoryPassage(@"Beginning", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("The retreat has been afforded to you for ");
		using (styleScope("hook", "h00004"))
			yield return link("going the extra mile to help the Corp.", null, () => enchantHook("h00004", HarloweEnchantCommand.Replace, passage5_Fragment_0));
		yield break;
	}

	IStoryThread passage5_Fragment_0()
	{
		yield return text("sex with your boss.");
		yield return lineBreak();
		yield return text("You are not proud: you have always done what your boss asks you to do. Even when she wants you to lie. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("It is right, given the risks taken, that you be rewarded ");
		yield return link("in this way.", "Promotion", null);
		yield break;
	}

	// .............
	// #6: CallSimone

	void passage6_Init()
	{
		this.Passages[@"CallSimone"] = new StoryPassage(@"CallSimone", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("That's Strange");
		yield return lineBreak();
		Vars.calledSimone = true;
		yield return lineBreak();
		yield return link("Hang Up", "FreshAir", null);
		yield break;
	}


	// .............
	// #7: FreshAir

	void passage7_Init()
	{
		this.Passages[@"FreshAir"] = new StoryPassage(@"FreshAir", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("As you turn your face up to the sun, a warm, damp breeze brushes your face.");
		yield return lineBreak();
		yield return text("It is nice to be off the plane but the holiday has not started yet, more is the pity.");
		yield return lineBreak();
		yield return text("A high stone wall surrounds the security forecourt, but you can see tree canopies sprawled over the skyline beyond. ");
		yield return lineBreak();
		yield return text("There's a door to arrivals ");
		yield return link("ahead.", "Arrivals", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #8: AsYouWait

	void passage8_Init()
	{
		this.Passages[@"AsYouWait"] = new StoryPassage(@"AsYouWait", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("Arrivals is a sparse space designed not for comfort but for scrutiny: polished floor, dull walls. No seats, only places to stand and wait for papers to be checked. ");
		yield return lineBreak();
		yield return text("The only other people here are a security guard and a woman in a glass booth waiting to look at your papers.");
		yield return lineBreak();
		yield return text("\"Paradise attracts trouble.\" Simone had said, inhaling on a cigarette as she described the reserve. \"The place is beautiful and the nature there is precious. We have to stop certain people ... breaching the border.\"");
		yield return lineBreak();
		yield return text("\"What people?\"");
		yield return lineBreak();
		yield return text("\"Jealous people.\" She had stubbed out her cigarette and pulled out a ");
		yield return link("brochure", "Brochure", null);
		yield return text(" from her desk to give to you.");
		yield break;
	}


	// .............
	// #9: ConveyerBelt

	void passage9_Init()
	{
		this.Passages[@"ConveyerBelt"] = new StoryPassage(@"ConveyerBelt", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text(" The bag is leather and expensive and the size of a medium dog. It is also heavy and stuffed with ");
		using (styleScope("hook", null)) {
			yield return text("essential items");
		}
		yield return text(".");
		yield return enchantIntoLink("essential items", passage9_Fragment_1);
		yield break;
	}

	IStoryThread passage9_Fragment_0()
	{
		yield return text("illegal items.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The things you considered vital for the trip might not be what everybody would pack. But you are a City girl on the up. So whatever.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The bag wobbles off, through the plastic flaps and into the belly of the machine, where it will be ");
		yield return link("photographed", "AsYouWait", null);
		yield break;
	}

	IStoryThread passage9_Fragment_1()
	{
		yield return enchant("essential items", HarloweEnchantCommand.Replace, passage9_Fragment_0);
		yield break;
	}

	// .............
	// #10: Arrivals

	void passage10_Init()
	{
		this.Passages[@"Arrivals"] = new StoryPassage(@"Arrivals", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("The wide doors sweep closed behind you and you are enveloped in blissful, cool air. To your right, is an X-ray machine. Its ");
		yield return link("conveyer belt", "ConveyerBelt", null);
		yield return text(" is waiting for your bag. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You curse Simone: without her to ease the passage, going through security could get awkward, given what you have in your bag.");
		yield return lineBreak();
		yield break;
	}


	// .............
	// #11: Grim

	void passage11_Init()
	{
		this.Passages[@"Grim"] = new StoryPassage(@"Grim", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("You have tried telling yourself that the toilets are NOT SO BAD. Enduring the discomfort of outdoor retreats is one of those things that is really character-building.");
		yield return enchantIntoLink("character-building.", passage11_Fragment_1);
		yield return lineBreak();
		yield break;
	}

	IStoryThread passage11_Fragment_0()
	{
		yield return text("  terrifying");
		yield return lineBreak();
		yield return text("Best to focus on the ");
		yield return link("here and now.", "Terror", null);
		yield break;
	}

	IStoryThread passage11_Fragment_1()
	{
		yield return enchant("character-building.", HarloweEnchantCommand.Replace, passage11_Fragment_0);
		yield break;
	}

	// .............
	// #12: Terror

	void passage12_Init()
	{
		this.Passages[@"Terror"] = new StoryPassage(@"Terror", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("Stop thinking about creepy crawlies: You've got more immediate ");
		yield return link("problems.", "BagReclaim", null);
		yield break;
	}


	// .............
	// #13: BagReclaim

	void passage13_Init()
	{
		this.Passages[@"BagReclaim"] = new StoryPassage(@"BagReclaim", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("Your bag emerges through the vinyl flaps and nobody has arrested you yet. ");
		yield return lineBreak();
		yield return text("\"madam. \" ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You hear a voice. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Step over here please.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Do as they ask.", "End", null);
		yield return lineBreak();
		yield return link("Bluster through.", "End", null);
		yield break;
	}


	// .............
	// #14: End

	void passage14_Init()
	{
		this.Passages[@"End"] = new StoryPassage(@"End", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("End of demo");
		yield break;
	}


	// .............
	// #15: Brochure

	void passage15_Init()
	{
		this.Passages[@"Brochure"] = new StoryPassage(@"Brochure", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"It is a haven. I want you to escape here for a while.\" She had said. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("It didn't look like a haveb when you looked at the toilets. It looked ");
		yield return link("grim.", "Grim", null);
		yield break;
	}


}