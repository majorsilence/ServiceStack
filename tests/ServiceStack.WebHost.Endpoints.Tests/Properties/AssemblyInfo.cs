using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a10fdf44-0168-49d4-9f25-0dfac96998ea")]

//Default DataContract namespace instead of tempuri.org
//Note: doesn't work for ilmerged assemblies
[assembly: ContractNamespace("http://schemas.servicestack.net/types", ClrNamespace = "ServiceStack.ServiceInterface.ServiceModel")]
[assembly: ContractNamespace("http://schemas.servicestack.net/types", ClrNamespace = "ServiceStack.WebHost.Endpoints.Tests.Support.Operations")]
[assembly: ContractNamespace("http://schemas.servicestack.net/types", ClrNamespace = "ServiceStack.WebHost.Endpoints.Tests.IntegrationTests")]
[assembly: ContractNamespace("http://schemas.servicestack.net/types", ClrNamespace = "ServiceStack.WebHost.Endpoints.Tests.Support.Host")]
[assembly: ContractNamespace("http://schemas.servicestack.net/types", ClrNamespace = "ServiceStack.WebHost.Endpoints.Tests")]

