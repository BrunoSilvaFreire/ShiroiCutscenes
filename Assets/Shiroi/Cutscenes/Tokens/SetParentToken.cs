﻿using System.Collections;
using JetBrains.Annotations;

namespace Shiroi.Cutscenes.Tokens {
    [UsedImplicitly]
    public class SetParentToken : IToken {
        public IEnumerator Execute(CutscenePlayer player) {
            yield break;
        }
    }
}