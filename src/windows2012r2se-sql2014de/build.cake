#load ../../lib/cake/build.cake

name = Argument("name", "windows2012r2se-sql2014de");
description = Argument("description", "indows Server 2012 R2 Standard Evaluation with SQL Server 2014 Developer");

components = new List<string> { "windows2012r2se", "sql2014de" };
parent = "windows2012r2se";

RunTarget(target);
