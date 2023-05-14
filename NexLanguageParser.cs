//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\ixlle\source\repos\NexLanguage\NexLanguage.g4 by ANTLR 4.9.2

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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class NexLanguageParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, ID=7, WS=8;
	public const int
		RULE_program = 0, RULE_declaration = 1, RULE_assignment = 2, RULE_datatype = 3;
	public static readonly string[] ruleNames = {
		"program", "declaration", "assignment", "datatype"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "'='", "'('", "')'", "'int'", "'Int32'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "ID", "WS"
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

	public override string GrammarFileName { get { return "NexLanguage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static NexLanguageParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public NexLanguageParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public NexLanguageParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext[] declaration() {
			return GetRuleContexts<DeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration(int i) {
			return GetRuleContext<DeclarationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext[] assignment() {
			return GetRuleContexts<AssignmentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment(int i) {
			return GetRuleContext<AssignmentContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			INexLanguageVisitor<TResult> typedVisitor = visitor as INexLanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 10;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case T__4:
				case T__5:
					{
					State = 8;
					declaration();
					}
					break;
				case ID:
					{
					State = 9;
					assignment();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 12;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__4) | (1L << T__5) | (1L << ID))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DatatypeContext datatype() {
			return GetRuleContext<DatatypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(NexLanguageParser.ID, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			INexLanguageVisitor<TResult> typedVisitor = visitor as INexLanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 2, RULE_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			datatype();
			State = 15;
			Match(ID);
			State = 16;
			Match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(NexLanguageParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DatatypeContext datatype() {
			return GetRuleContext<DatatypeContext>(0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			INexLanguageVisitor<TResult> typedVisitor = visitor as INexLanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignment(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 4, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 18;
			Match(ID);
			State = 19;
			Match(T__1);
			State = 20;
			datatype();
			State = 21;
			Match(T__2);
			State = 22;
			Match(T__3);
			State = 23;
			Match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DatatypeContext : ParserRuleContext {
		public DatatypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_datatype; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			INexLanguageVisitor<TResult> typedVisitor = visitor as INexLanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDatatype(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DatatypeContext datatype() {
		DatatypeContext _localctx = new DatatypeContext(Context, State);
		EnterRule(_localctx, 6, RULE_datatype);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			_la = TokenStream.LA(1);
			if ( !(_la==T__4 || _la==T__5) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\n', '\x1E', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\x3', '\x2', '\x6', '\x2', '\r', '\n', '\x2', '\r', '\x2', '\xE', 
		'\x2', '\xE', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x2', '\x2', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x3', '\x3', '\x2', 
		'\a', '\b', '\x2', '\x1B', '\x2', '\f', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '\x6', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\b', '\x1B', '\x3', '\x2', '\x2', '\x2', '\n', '\r', '\x5', '\x4', 
		'\x3', '\x2', '\v', '\r', '\x5', '\x6', '\x4', '\x2', '\f', '\n', '\x3', 
		'\x2', '\x2', '\x2', '\f', '\v', '\x3', '\x2', '\x2', '\x2', '\r', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\xF', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x10', '\x11', '\x5', '\b', '\x5', '\x2', '\x11', '\x12', '\a', 
		'\t', '\x2', '\x2', '\x12', '\x13', '\a', '\x3', '\x2', '\x2', '\x13', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\a', '\t', '\x2', 
		'\x2', '\x15', '\x16', '\a', '\x4', '\x2', '\x2', '\x16', '\x17', '\x5', 
		'\b', '\x5', '\x2', '\x17', '\x18', '\a', '\x5', '\x2', '\x2', '\x18', 
		'\x19', '\a', '\x6', '\x2', '\x2', '\x19', '\x1A', '\a', '\x3', '\x2', 
		'\x2', '\x1A', '\a', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', '\t', 
		'\x2', '\x2', '\x2', '\x1C', '\t', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\f', '\xE',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
