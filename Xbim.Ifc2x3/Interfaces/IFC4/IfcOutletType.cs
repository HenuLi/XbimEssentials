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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcOutletType : IIfcOutletType
	{
		Xbim.Ifc4.ElectricalDomain.IfcOutletTypeEnum IIfcOutletType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.ElectricalDomain.IfcOutletTypeEnum.AUDIOVISUALOUTLET:
						return Xbim.Ifc4.ElectricalDomain.IfcOutletTypeEnum.AUDIOVISUALOUTLET;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcOutletTypeEnum.COMMUNICATIONSOUTLET:
						return Xbim.Ifc4.ElectricalDomain.IfcOutletTypeEnum.COMMUNICATIONSOUTLET;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcOutletTypeEnum.POWEROUTLET:
						return Xbim.Ifc4.ElectricalDomain.IfcOutletTypeEnum.POWEROUTLET;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcOutletTypeEnum.USERDEFINED:
						return Xbim.Ifc4.ElectricalDomain.IfcOutletTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcOutletTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.ElectricalDomain.IfcOutletTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}