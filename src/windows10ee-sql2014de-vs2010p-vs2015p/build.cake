#load ../../lib/cake/build.cake

name = Argument("name", "windows10ee-sql2014de-vs2010p-vs2015p");
description = Argument("description", "Windows 10 Enterprise Evaluation with SQL Server 2014 Developer, Visual Studio 2010 Professional amd Visual Studio 2015 Professional");

components = new List<string> { "windows10ee", "sql2014de", "vs2010p", "vs2015p" };
parent = "windows10ee-sql2014de-vs2010p";

RunTarget(target);
