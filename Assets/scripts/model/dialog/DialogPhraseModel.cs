using System;
using System.Collections.Generic;

namespace bloodhunt {
	public class DialogPhraseModel
	{
		public DialogPhraseModel() {
		}

		public string Phrase { get; set; }

		public DialogPhraseModel Next { get; set; }

	}
}