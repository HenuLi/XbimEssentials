// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelAssociatesLibrary : IIfcRelAssociatesLibrary
	{
		Xbim.Ifc4.ExternalReferenceResource.IfcLibrarySelect IIfcRelAssociatesLibrary.RelatingLibrary 
		{ 
			get
			{
				if (RelatingLibrary == null) return null;
				var ifclibraryreference = RelatingLibrary as Xbim.Ifc2x3.ExternalReferenceResource.IfcLibraryReference;
				if (ifclibraryreference != null) 
					return ifclibraryreference;
				var ifclibraryinformation = RelatingLibrary as Xbim.Ifc2x3.ExternalReferenceResource.IfcLibraryInformation;
				if (ifclibraryinformation != null) 
					return ifclibraryinformation;
				return null;
			} 
		}
	}
}