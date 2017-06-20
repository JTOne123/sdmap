﻿using Antlr4.Runtime;
using Microsoft.VisualStudio.Text;
using sdmap.Vstool.Tagger.Antlr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdmap.Vstool.Tagger
{
    interface ISdmapLexerHelper
    {
        IEnumerable<SpannedToken> GetTokens(IEnumerable<string> segments, int offset);
    }
}
