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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcBoilerType : IIfcBoilerType
	{
		Xbim.Ifc4.HvacDomain.IfcBoilerTypeEnum IIfcBoilerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcBoilerTypeEnum.WATER:
						return Xbim.Ifc4.HvacDomain.IfcBoilerTypeEnum.WATER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcBoilerTypeEnum.STEAM:
						return Xbim.Ifc4.HvacDomain.IfcBoilerTypeEnum.STEAM;
					
					case Xbim.Ifc2x3.HVACDomain.IfcBoilerTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcBoilerTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcBoilerTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcBoilerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}