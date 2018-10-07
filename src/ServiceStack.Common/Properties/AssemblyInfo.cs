using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3871f659-64fb-4dfb-a49f-17dc2f8a47e2")]

// CCB Custom
[assembly: ContractNamespace("http://schemas.servicestack.net/types",
 ClrNamespace = "ServiceStack.Common.ServiceClient.Web")]

[assembly: ContractNamespace("http://schemas.servicestack.net/types",
 ClrNamespace = "ServiceStack.Common.ServiceModel")]

[assembly: InternalsVisibleTo("ServiceStack.Common.Tests")]
