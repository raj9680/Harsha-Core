/* Importing namespace (using directive): using Namespacename; help reducing the repeated namespace like

example:-
using System;

now we can use Console.WriteLine(""); instead of System.Console.WriteLine("");
*/

/* Importing namespace (using alias): The "using alias" directive allowsyou to create "alias name" for the namespace.
 example:

using AliasName = Namespacename;

AliasName.ClassName c1 = new AliasName.ClassName();

*/
/* Importing namespace (using static): Importing static classes. The "using static" directive allows you to import a static class directly from a namespace; so that you can directly access any of its methods anywhere in the current file.
 
Example:

using static Namespacename.StaticClassName;

*/