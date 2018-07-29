using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System;
using Cradle;
using Cradle.StoryFormats.Harlowe;

public class CallackTestRunner: IPrebuildSetup
{
	void IPrebuildSetup.Setup()
	{
	}

	class Test: IDisposable
	{
		public readonly Story Story;

		public Test(string startPassage = null)
		{
			GameObject container = new GameObject();
			container.name = "TestRunner: " + startPassage;
			this.Story = container.AddComponent<Clockwork>();
			if (startPassage != null)
				this.Story.StartPassage = startPassage;
		}

		public void Dispose()
		{
			GameObject.Destroy(this.Story.gameObject);
		}
	}

	[UnityTest]
	public IEnumerator CallbackList()
	{
		using (var test = new Test("Begin"))
		{
			yield return null;
		}
	}
}
