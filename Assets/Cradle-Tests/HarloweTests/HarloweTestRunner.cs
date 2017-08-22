using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System;
using Cradle;
using Cradle.StoryFormats.Harlowe;

public class HarloweTestRunner: IPrebuildSetup
{
	void IPrebuildSetup.Setup()
	{
	}

	class TestRunner: IDisposable
	{
		public readonly HarloweTests Story;

		public TestRunner(string startPassage = null)
		{
			GameObject container = new GameObject();
			container.name = "TestRunner: " + startPassage;
			this.Story = container.AddComponent<HarloweTests>();
			if (startPassage != null)
				this.Story.StartPassage = startPassage;
		}

		public void Dispose()
		{
			GameObject.Destroy(this.Story.gameObject);
		}
	}

	IEnumerator DoTest(string startPassage, Action<HarloweTests> test = null)
	{
		using (var testRunner = new TestRunner(startPassage))
		{
			yield return null;
			if (test != null)
				test(testRunner.Story);
		}
	}

	[UnityTest]
	public IEnumerator Markup_Links()
	{
		return DoTest("Markup_Links");
	}

	[UnityTest]
	public IEnumerator Markup_Unsupported()
	{
		return DoTest("Markup_Unsupported");
	}

	[UnityTest]
	public IEnumerator Markup_Verbatim()
	{
		return DoTest("Markup_Verbatim");
	}

	[UnityTest]
	public IEnumerator Markup_LineBreaks()
	{
		return DoTest("Markup_LineBreaks");
	}

	[UnityTest]
	public IEnumerator Markup_HTML()
	{
		return DoTest("Markup_HTML");
	}

	[UnityTest]
	public IEnumerator Markup_Scope_Styles()
	{
		return DoTest("Markup_Scope_Styles");
	}

	[UnityTest]
	public IEnumerator Markup_Scope_Hooks()
	{
		return DoTest("Markup_Scope_Hooks");
	}

	[UnityTest]
	public IEnumerator Markup_NakedVar()
	{
		return DoTest("Markup_NakedVar");
	}

	[UnityTest]
	public IEnumerator Vars_It()
	{
		return DoTest("Vars_It");
	}

	[UnityTest]
	public IEnumerator Vars_Type_String()
	{
		return DoTest("Vars_Type_String");
	}

	[UnityTest]
	public IEnumerator Vars_Type_Number()
	{
		return DoTest("Vars_Type_Number");
	}

	[UnityTest]
	public IEnumerator Vars_Type_Bool()
	{
		return DoTest("Vars_Type_Bool");
	}

	[UnityTest]
	public IEnumerator Vars_Type_Array()
	{
		return DoTest("Vars_Type_Array");
	}

	[UnityTest]
	public IEnumerator Vars_Type_Dataset()
	{
		return DoTest("Vars_Type_Dataset");
	}

	[UnityTest]
	public IEnumerator Vars_Type_Datamap()
	{
		return DoTest("Vars_Type_Datamap");
	}
}
