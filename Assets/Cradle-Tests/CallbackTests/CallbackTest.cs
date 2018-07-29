using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System;
using Cradle;
using Cradle.StoryFormats.Harlowe;

public class CallbackTest: MonoBehaviour
{
	Story story;
	private void Awake()
	{
		story = GetComponent<Story>();
		story.OnPassageEnter += Story_OnPassageEnter;
		story.OnPassageExit += Story_OnPassageExit;
		story.OnLinkBegin += Story_OnLinkBegin;
		story.OnLinkDone += Story_OnLinkDone;
		story.OnOutput += Story_OnOutput;
	}

	IEnumerator Timer(string title, string objectName, float duration = 0.1f, bool log = true)
	{
		if (log)
			Debug.LogFormat("{0:0.0} - {1} - {2}{3}", Time.time, objectName, title, story.CanBePaused ? " IN" : null);

		if (!story.CanBePaused)
			yield break;
		
		story.Pause();
		yield return new WaitForSeconds(duration);
		if (log)
			Debug.LogFormat("{0:0.0} - {1} - {2} OUT", Time.time, objectName, title);
		story.Resume();
	}
	
	private void Story_OnOutput(StoryOutput output)
	{
		StartCoroutine(Timer("EVENT: Output", story.CurrentPassage.Name, 0.1f, false));
	}

	private void Story_OnPassageEnter(StoryPassage passage)
	{
		StartCoroutine(Timer("EVENT: PassageEnter", passage.Name));
	}

	private void Story_OnPassageExit(StoryPassage passage)
	{
		StartCoroutine(Timer("EVENT: PassageExit", passage.Name));
	}

	private void Story_OnLinkBegin(StoryPassage passage, StoryLink link)
	{
		StartCoroutine(Timer("EVENT: LinkBegin", link.ToString()));
	}

	private void Story_OnLinkDone(StoryPassage passage, StoryLink link)
	{
		StartCoroutine(Timer("EVENT: LinkDone", link.ToString()));
	}

	[Cue(CueType.PassageEnter)]
	IEnumerator OnStoryPassageEnter(StoryPassage passage)
	{
		return Timer("GENERAL: PassageEnter", passage.Name);
	}

	[Cue(CueType.PassageExit)]
	IEnumerator OnStoryPassageExit(StoryPassage passage)
	{
		return Timer("GENERAL: PassageExit", passage.Name);
	}

	[Cue(CueType.LinkBegin)]
	IEnumerator OnStoryLinkBegin()
	{
		return Timer("GENERAL: LinkBegin", story.CurrentLinkInAction.ToString());
	}

	[Cue(CueType.LinkDone)]
	IEnumerator OnStoryLinkDone()
	{
		return Timer("GENERAL: LinkDone", story.CurrentLinkInAction.ToString());
	}

	[Cue(CueType.LinkBegin, Tag = "tag-test")]
	IEnumerator TagLinkBegin()
	{
		return Timer(string.Format("TAG ({0}): LinkBegin", story.CurrentPassage.Tags[0]), story.CurrentLinkInAction.ToString());
	}

	[Cue(CueType.LinkDone, Tag = "tag-test")]
	IEnumerator TagLinkDone()
	{
		return Timer(string.Format("TAG ({0}): LinkDone", story.CurrentPassage.Tags[0]), story.CurrentLinkInAction.ToString());
	}

	IEnumerator Begin_Enter()
	{
		return Timer("PASSAGE (named): PassageEnter", story.CurrentPassage.Name);
	}

	IEnumerator Begin_Exit()
	{
		return Timer("PASSAGE (named): PassageExit", story.CurrentPassage.Name);
	}

	[Cue(CueType.PassageEnter, Tag = "tag-test")]
	IEnumerator Tag_Enter(StoryPassage passage)
	{
		return Timer(string.Format("TAG ({0}): PassageEnter", story.CurrentPassage.Tags[0]), passage.Name);
	}


	[StoryCue("Begin", CueType.Enter)]
	IEnumerator EnterObsolete()
	{
		return Timer("OBSOLETE: Enter", story.CurrentPassage.Name);
	}

	[StoryCue("Begin", CueType.Exit)]
	IEnumerator ExitObsolete()
	{
		return Timer("OBSOLETE: Exit", story.CurrentPassage.Name);
	}
}
