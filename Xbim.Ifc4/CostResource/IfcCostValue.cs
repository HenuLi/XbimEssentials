// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.CostResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCostValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCostValue : IIfcAppliedValue
	{
		
	}
}

namespace Xbim.Ifc4.CostResource
{
	[ExpressType("IFCCOSTVALUE", 540)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostValue : IfcAppliedValue, IInstantiableEntity, IIfcCostValue, IEqualityComparer<@IfcCostValue>, IEquatable<@IfcCostValue>
	{
		#region IIfcCostValue explicit implementation
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostValue(IModel model) : base(model) 		{ 
			Model = model; 
		}





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCostValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCostValue
            var root = (@IfcCostValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCostValue left, @IfcCostValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCostValue left, @IfcCostValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCostValue x, @IfcCostValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCostValue obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}