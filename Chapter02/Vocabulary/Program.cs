﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // #error version
// WriteLine($"Computer named {Env.MachineName} says \"No.\"");

using System.Linq;
using System.Reflection;

System.Data.DataSet ds = new();
HttpClient client = new();

Assembly? myApp = Assembly.GetEntryAssembly();

if(myApp is null) return;

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;
    }

    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: name.Name);
}