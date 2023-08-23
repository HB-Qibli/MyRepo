using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using Microsoft.CodeAnalysis;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: TargetFramework(".NETCoreApp,Version=v6.0", FrameworkDisplayName = "")]
[assembly: AssemblyCompany("MyNotes")]
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")]
[assembly: AssemblyProduct("MyNotes")]
[assembly: AssemblyTitle("MyNotes")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
	}
}
namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		public readonly byte[] NullableFlags;

		public NullableAttribute(byte P_0)
		{
			NullableFlags = new byte[1] { P_0 };
		}

		public NullableAttribute(byte[] P_0)
		{
			NullableFlags = P_0;
		}
	}
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		public readonly byte Flag;

		public NullableContextAttribute(byte P_0)
		{
			Flag = P_0;
		}
	}
}
public class Chapter
{
	public string Title { get; set; }

	public List<Page> Pages { get; set; } = new List<Page>();


	public Chapter(string title, Page page)
	{
		Title = title;
		Pages.Add(page);
	}

	public Chapter(string title, List<Page> pages)
	{
		Title = title;
		Pages = pages;
	}

	public void Read()
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(Title);
		Console.ResetColor();
		Console.WriteLine("\nChapter contents:");
		foreach (Page page in Pages)
		{
			page.Read();
			Console.WriteLine("\nPress any key to continue...");
			Console.ReadKey();
		}
		Console.Clear();
	}
}
public class FancyWriter
{
	public static void WriteLine(string text, int speed = 1)
	{
		int num = 0;
		while (num < text.Length)
		{
			if (text[num] == '{')
			{
				int num2 = text.IndexOf('}', num);
				int millisecondsTimeout = int.Parse(text.Substring(num + 1, num2 - num - 1));
				Thread.Sleep(millisecondsTimeout);
				num = num2 + 1;
			}
			else
			{
				Console.Write(text[num]);
				Thread.Sleep(speed);
				num++;
			}
		}
	}
}
public class FibonacciPage : Page
{
	public FibonacciPage(string content)
		: base(content)
	{
	}

	public override void Read()
	{
		Console.Clear();
		Console.WriteLine("\nPage contents:");
		FancyWriter.WriteLine(base.Content);
		Console.WriteLine("\nPress any key to continue...");
		Console.ReadKey();
		Console.WriteLine(coolFibonacciSymbolPrint(10));
	}

	private string coolFibonacciSymbolPrint(int v, char symbol = '*')
	{
		string text = "";
		int[] array = new int[v];
		array[0] = 1;
		array[1] = 1;
		for (int i = 2; i < v; i++)
		{
			array[i] = array[i - 1] + array[i - 2];
		}
		int[] array2 = array;
		foreach (int num in array2)
		{
			for (int k = 0; k < num; k++)
			{
				text += symbol;
			}
			text += "\n";
		}
		return text;
	}
}
public static class MyNotes
{
	public static string VariablesPageOne = ".{500}.{500}.{500}\r\nIn the vast savannah of computer memory, a remarkable phenomenon occurs. \r\n{1000}Behold, the magnificent 'variables' – they are the vessels of information, the heart of computation. \r\n{1000}They bear names, bestowed upon them with care, starting only with letters or the humble underscore. \r\n{1000}But tread with caution, for certain names are forbidden, like 'int', 'string', and 'bool'. \r\n{1000}With the gentle touch of the '=' operator, values are imbued unto these variables. \r\n{1000}And lo, their types can be declared, like incantations, as in 'type variableName = value;'. \r\n{1000}Observe: \r\n{1000} int age = 32;\r\n{1000} string name = \"Jesper\";\r\n{1000} float awesomeLevel = 99.9f;\r\n{1000} bool TooCoolForSchool = false;\r\n";

	public static string VariablesPageTwo = ".{500}.{500}.{500}\r\nSo often used without consideration for its magnificence, the humble 'variable' is the heart of computation. \r\n{100}It can be used to store and manipulate data, and is the backbone of all computer programs. \r\n{100}The 'variable' is a named container for a value, and can be of different types. \r\n{100}The type of a variable determines what kind of value it can hold, and what kind of operations can be performed on it. \r\n{100}There are many different types of variables, but the most common ones are 'int', 'string', 'float', and 'bool'. \r\n{100}An 'int' is a whole number, like 1, 2, 3, 4, 5, 6, 7, 8, 9, 0. \r\n{100}A 'string' is a sequence of characters, like \"Hello World\", \"I am a string\", and \"C# is awesome\". \r\n{100}A 'float' is a decimal number, like 1.234, 5.678, and 9.101112. \r\n{100}A 'bool' is a true or false value, like true and false. ";

	public static string FancyIntro = "The fancy stuff is a collection of show off, over-engineered, functionality, for the challengers.\r\nCheck out fibonacci :o";

	public static string FibonacciContinued = "It's a resurive function that prints * based on the fibonacci sequence.";
}
public class Page
{
	public string Content { get; set; }

	public Page(string content)
	{
		Content = content;
	}

	public virtual void Read()
	{
		Console.Clear();
		Console.WriteLine("\nPage contents:");
		FancyWriter.WriteLine(Content);
	}
}
[CompilerGenerated]
internal class Program
{
	private static void Main(string[] args)
	{
		Console.BackgroundColor = ConsoleColor.Black;
		ProgrammingNotes programmingNotes = new ProgrammingNotes();
		while (true)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(programmingNotes.Title);
			Console.ResetColor();
			programmingNotes.WriteLine("\nWelcome to your programming notes. This program will help you keep track of your notes for your programming projects.\n");
			programmingNotes.PrintChapters();
			Console.WriteLine("\nEnter a chapter title (or 'quit/q/exit' to exit):");
			string text = Console.ReadLine();
			if (text.ToLower() == "quit" || text.ToLower() == "q" || text.ToLower() == "exit")
			{
				break;
			}
			Chapter chapter = programmingNotes.GetChapter(text);
			if (chapter == null)
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Chapter not found.\n");
				Console.ResetColor();
			}
			else
			{
				chapter.Read();
			}
		}
	}
}
public class ProgrammingNotes
{
	public string Title { get; set; }

	public List<Chapter> Chapters { get; set; }

	public ProgrammingNotes()
	{
		Title = "Programming notes";
		Chapters = new List<Chapter>();
		List<Page> list = new List<Page>();
		List<Page> list2 = new List<Page>();
		Page item = new Page(MyNotes.VariablesPageOne);
		Page item2 = new Page(MyNotes.VariablesPageTwo);
		Page item3 = new FibonacciPage(MyNotes.FancyIntro);
		Page item4 = new Page(MyNotes.FibonacciContinued);
		list.Add(item);
		list.Add(item2);
		list2.Add(item3);
		list2.Add(item4);
		Chapter item5 = new Chapter("Vars", list);
		Chapter item6 = new Chapter("Fancy", list2);
		Chapters.Add(item5);
		Chapters.Add(item6);
	}

	public void PrintChapters()
	{
		Console.WriteLine("\nChapter titles:");
		Console.ForegroundColor = ConsoleColor.Yellow;
		foreach (Chapter chapter in Chapters)
		{
			Console.WriteLine(chapter.Title);
		}
		Console.ResetColor();
	}

	public Chapter GetChapter(string title)
	{
		foreach (Chapter chapter in Chapters)
		{
			if (chapter.Title == title)
			{
				return chapter;
			}
		}
		return null;
	}

	public string RecursiveWriteLine(string text)
	{
		if (text.Length == 0)
		{
			return "";
		}
		Console.Write(text[0]);
		Thread.Sleep(1);
		return RecursiveWriteLine(text.Substring(1));
	}

	public void WriteLine(string text)
	{
		foreach (char value in text)
		{
			Console.Write(value);
			Thread.Sleep(1);
		}
	}
}
