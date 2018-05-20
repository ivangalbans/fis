//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Me\Cybernetic\ComputerScience\4Year\2Semestre\SIM\Proyectos\3. Logica Difusa\Code\FuzzySolution\Fuzzy\Parsing\Fuzzy.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class FuzzyLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, NUMBER=20, ID=21, COMMENT=22, WS=23;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "LETTER", "DIGIT", "NUMBER", "ID", "COMMENT", "WS"
	};


	public FuzzyLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public FuzzyLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'['", "'model'", "']'", "'t-norm'", "'t-conorm'", "'defuzzy'", 
		"'then'", "'='", "'is'", "'('", "')'", "'and'", "'or'", "'not'", "'**'", 
		"'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "NUMBER", "ID", "COMMENT", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Fuzzy.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static FuzzyLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x19', '\xAB', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x6', '\x17', '\x81', '\n', '\x17', '\r', 
		'\x17', '\xE', '\x17', '\x82', '\x3', '\x17', '\x3', '\x17', '\x6', '\x17', 
		'\x87', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\x88', '\x5', '\x17', 
		'\x8B', '\n', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\a', '\x18', '\x91', '\n', '\x18', '\f', '\x18', '\xE', '\x18', 
		'\x94', '\v', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\a', '\x19', '\x9B', '\n', '\x19', '\f', '\x19', 
		'\xE', '\x19', '\x9E', '\v', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x6', '\x1A', '\xA6', 
		'\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xA7', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x9C', '\x2', '\x1B', '\x3', '\x3', '\x5', '\x4', '\a', 
		'\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', 
		'\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', 
		'\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', '\x14', 
		'\'', '\x15', ')', '\x2', '+', '\x2', '-', '\x16', '/', '\x17', '\x31', 
		'\x18', '\x33', '\x19', '\x3', '\x2', '\x5', '\x4', '\x2', '\x43', '\\', 
		'\x63', '|', '\x3', '\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', 
		'\xF', '\"', '\"', '\x2', '\xB1', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x3', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x37', '\x3', '\x2', '\x2', '\x2', '\a', '=', '\x3', 
		'\x2', '\x2', '\x2', '\t', '?', '\x3', '\x2', '\x2', '\x2', '\v', '\x46', 
		'\x3', '\x2', '\x2', '\x2', '\r', 'O', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'W', '\x3', '\x2', '\x2', '\x2', '\x11', '\\', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '^', '\x3', '\x2', '\x2', '\x2', '\x15', '\x61', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x63', '\x3', '\x2', '\x2', '\x2', '\x19', '\x65', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', 'i', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'l', '\x3', '\x2', '\x2', '\x2', '\x1F', 'p', '\x3', '\x2', '\x2', '\x2', 
		'!', 's', '\x3', '\x2', '\x2', '\x2', '#', 'u', '\x3', '\x2', '\x2', '\x2', 
		'%', 'w', '\x3', '\x2', '\x2', '\x2', '\'', 'y', '\x3', '\x2', '\x2', 
		'\x2', ')', '{', '\x3', '\x2', '\x2', '\x2', '+', '}', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x80', '\x3', '\x2', '\x2', '\x2', '/', '\x8C', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x95', '\x3', '\x2', '\x2', '\x2', '\x33', '\xA5', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\a', ']', '\x2', '\x2', '\x36', 
		'\x4', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', 'o', '\x2', '\x2', 
		'\x38', '\x39', '\a', 'q', '\x2', '\x2', '\x39', ':', '\a', '\x66', '\x2', 
		'\x2', ':', ';', '\a', 'g', '\x2', '\x2', ';', '<', '\a', 'n', '\x2', 
		'\x2', '<', '\x6', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', '_', '\x2', 
		'\x2', '>', '\b', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', 'v', '\x2', 
		'\x2', '@', '\x41', '\a', '/', '\x2', '\x2', '\x41', '\x42', '\a', 'p', 
		'\x2', '\x2', '\x42', '\x43', '\a', 'q', '\x2', '\x2', '\x43', '\x44', 
		'\a', 't', '\x2', '\x2', '\x44', '\x45', '\a', 'o', '\x2', '\x2', '\x45', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\a', 'v', '\x2', '\x2', 
		'G', 'H', '\a', '/', '\x2', '\x2', 'H', 'I', '\a', '\x65', '\x2', '\x2', 
		'I', 'J', '\a', 'q', '\x2', '\x2', 'J', 'K', '\a', 'p', '\x2', '\x2', 
		'K', 'L', '\a', 'q', '\x2', '\x2', 'L', 'M', '\a', 't', '\x2', '\x2', 
		'M', 'N', '\a', 'o', '\x2', '\x2', 'N', '\f', '\x3', '\x2', '\x2', '\x2', 
		'O', 'P', '\a', '\x66', '\x2', '\x2', 'P', 'Q', '\a', 'g', '\x2', '\x2', 
		'Q', 'R', '\a', 'h', '\x2', '\x2', 'R', 'S', '\a', 'w', '\x2', '\x2', 
		'S', 'T', '\a', '|', '\x2', '\x2', 'T', 'U', '\a', '|', '\x2', '\x2', 
		'U', 'V', '\a', '{', '\x2', '\x2', 'V', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'W', 'X', '\a', 'v', '\x2', '\x2', 'X', 'Y', '\a', 'j', '\x2', '\x2', 
		'Y', 'Z', '\a', 'g', '\x2', '\x2', 'Z', '[', '\a', 'p', '\x2', '\x2', 
		'[', '\x10', '\x3', '\x2', '\x2', '\x2', '\\', ']', '\a', '?', '\x2', 
		'\x2', ']', '\x12', '\x3', '\x2', '\x2', '\x2', '^', '_', '\a', 'k', '\x2', 
		'\x2', '_', '`', '\a', 'u', '\x2', '\x2', '`', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x61', '\x62', '\a', '*', '\x2', '\x2', '\x62', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x63', '\x64', '\a', '+', '\x2', '\x2', '\x64', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', '\x63', '\x2', 
		'\x2', '\x66', 'g', '\a', 'p', '\x2', '\x2', 'g', 'h', '\a', '\x66', '\x2', 
		'\x2', 'h', '\x1A', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\a', 'q', '\x2', 
		'\x2', 'j', 'k', '\a', 't', '\x2', '\x2', 'k', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', 'l', 'm', '\a', 'p', '\x2', '\x2', 'm', 'n', '\a', 'q', '\x2', 
		'\x2', 'n', 'o', '\a', 'v', '\x2', '\x2', 'o', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', 'p', 'q', '\a', ',', '\x2', '\x2', 'q', 'r', '\a', ',', '\x2', 
		'\x2', 'r', ' ', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', ',', '\x2', 
		'\x2', 't', '\"', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\a', '\x31', 
		'\x2', '\x2', 'v', '$', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', '-', 
		'\x2', '\x2', 'x', '&', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', '/', 
		'\x2', '\x2', 'z', '(', '\x3', '\x2', '\x2', '\x2', '{', '|', '\t', '\x2', 
		'\x2', '\x2', '|', '*', '\x3', '\x2', '\x2', '\x2', '}', '~', '\t', '\x3', 
		'\x2', '\x2', '~', ',', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x81', '\x5', 
		'+', '\x16', '\x2', '\x80', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x81', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '\x82', '\x80', '\x3', '\x2', '\x2', 
		'\x2', '\x82', '\x83', '\x3', '\x2', '\x2', '\x2', '\x83', '\x8A', '\x3', 
		'\x2', '\x2', '\x2', '\x84', '\x86', '\a', '\x30', '\x2', '\x2', '\x85', 
		'\x87', '\x5', '+', '\x16', '\x2', '\x86', '\x85', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x88', '\x3', '\x2', '\x2', '\x2', '\x88', '\x86', '\x3', 
		'\x2', '\x2', '\x2', '\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x8B', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x8A', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8B', '.', '\x3', 
		'\x2', '\x2', '\x2', '\x8C', '\x92', '\x5', ')', '\x15', '\x2', '\x8D', 
		'\x91', '\x5', ')', '\x15', '\x2', '\x8E', '\x91', '\x5', '+', '\x16', 
		'\x2', '\x8F', '\x91', '\a', '\x61', '\x2', '\x2', '\x90', '\x8D', '\x3', 
		'\x2', '\x2', '\x2', '\x90', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x90', 
		'\x8F', '\x3', '\x2', '\x2', '\x2', '\x91', '\x94', '\x3', '\x2', '\x2', 
		'\x2', '\x92', '\x90', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\x3', 
		'\x2', '\x2', '\x2', '\x93', '\x30', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\a', '\x31', '\x2', 
		'\x2', '\x96', '\x97', '\a', ',', '\x2', '\x2', '\x97', '\x9C', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x9B', '\x5', '\x31', '\x19', '\x2', '\x99', 
		'\x9B', '\v', '\x2', '\x2', '\x2', '\x9A', '\x98', '\x3', '\x2', '\x2', 
		'\x2', '\x9A', '\x99', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9E', '\x3', 
		'\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9C', 
		'\x9A', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9F', '\x3', '\x2', '\x2', 
		'\x2', '\x9E', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\a', 
		',', '\x2', '\x2', '\xA0', '\xA1', '\a', '\x31', '\x2', '\x2', '\xA1', 
		'\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\b', '\x19', '\x2', 
		'\x2', '\xA3', '\x32', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA6', '\t', 
		'\x4', '\x2', '\x2', '\xA5', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA6', 
		'\xA7', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA5', '\x3', '\x2', '\x2', 
		'\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', 
		'\x2', '\x2', '\x2', '\xA9', '\xAA', '\b', '\x1A', '\x2', '\x2', '\xAA', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\v', '\x2', '\x82', '\x88', '\x8A', 
		'\x90', '\x92', '\x9A', '\x9C', '\xA7', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
